using ErpDashboard.Application.Enums;
using ErpDashboard.Application.Interfaces.Services;
using ErpDashboard.Application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ErpDashboard.Infrastructure.Contexts
{
    public class Logger : DbContext
    {
        private protected ICurrentUserService _currentUser;
        public Logger(DbContextOptions<ERBSYSTEMContext> options, ICurrentUserService currentUser)
            : base(options)
        {
            _currentUser = currentUser;
        }
        public virtual DbSet<TbSystemLogger> TbSystemLoggers { get; set; }
        public List<AuditEntryy> OnBeforeSaveChanges(int? userid,int? comId)
        {

            ChangeTracker.DetectChanges();
            var auditEntries = new List<AuditEntryy>();
            var ChangedData = ChangeTracker.Entries();
            foreach (var entry in ChangedData)
            {
                if (entry.Entity is TbSystemLogger || entry.State == EntityState.Detached || entry.State == EntityState.Unchanged)
                    continue;
                var auditEntry = new AuditEntryy(entry);
                auditEntry.TableName = entry.Entity.GetType().Name;
                auditEntry.UserId = userid?? 0;
                auditEntry.CompanyID = comId?? 0;

                auditEntries.Add(auditEntry);

                var EntityProperties = entry.Entity.GetType().GetProperties();


                foreach (var property in entry.Properties)
                {

                    if (property.IsTemporary)
                    {
                        auditEntry.TemporaryProperties.Add(property);
                        continue;
                    }

                    string propertyName = property.Metadata.Name;
                    if (property.Metadata.IsPrimaryKey())
                    {
                        auditEntry.KeyValues[propertyName] = property.CurrentValue;
                        continue;
                    }
                        switch (entry.State)
                        {
                            case EntityState.Added:
                                auditEntry.AuditType = AuditType.Create;
                                auditEntry.NewValues[propertyName] = property.CurrentValue;
                                break;

                            case EntityState.Deleted:
                                auditEntry.AuditType = AuditType.Delete;
                                auditEntry.OldValues[propertyName] = property.OriginalValue;
                                break;

                            case EntityState.Modified:
                                if (property.IsModified && property.OriginalValue?.Equals(property.CurrentValue) == false)
                                {
                                    auditEntry.ChangedColumns.Add(propertyName);
                                    auditEntry.AuditType = AuditType.Update;
                                    auditEntry.OldValues[propertyName] = property.OriginalValue;
                                    auditEntry.NewValues[propertyName] = property.CurrentValue;
                                }
                                break;
                        }
                }
            }

            foreach (var auditEntry in auditEntries.Where(_ => !_.HasTemporaryProperties))
            {
                TbSystemLoggers.Add(auditEntry.ToLog());
            }
            return auditEntries.Where(_ => _.HasTemporaryProperties).ToList();
        }

        public virtual async Task<int> SaveChangesAsync(int? userId = null,int? commId = null, CancellationToken cancellationToken = new())
        {
            var auditEntries = OnBeforeSaveChanges(_currentUser.SystemUserId,_currentUser.CompanyID);
            var result = await base.SaveChangesAsync(cancellationToken);
            await OnAfterSaveChanges(auditEntries, cancellationToken);
            return result;
        }

        private Task OnAfterSaveChanges(List<AuditEntryy> auditEntries, CancellationToken cancellationToken = new CancellationToken())
        {
           

            if (auditEntries == null || auditEntries.Count == 0)
                return Task.CompletedTask;

            foreach (var auditEntry in auditEntries)
            {

                foreach (var prop in auditEntry.TemporaryProperties)
                {

                    if (prop.Metadata.IsPrimaryKey())
                    {
                        auditEntry.KeyValues[prop.Metadata.Name] = prop.CurrentValue;
                    }
                    else
                    {
                        auditEntry.NewValues[prop.Metadata.Name] = prop.CurrentValue;
                    }

                }
                TbSystemLoggers.Add(auditEntry.ToLog());
            }
            return SaveChangesAsync(cancellationToken);
        }
    }
    public class AuditEntryy
    {
        public AuditEntryy(EntityEntry entry)
        {
            Entry = entry;
        }

        public EntityEntry Entry { get; }
        public int UserId { get; set; }
        public int CompanyID { get; set; }
        public string TableName { get; set; }
        public Dictionary<string, object> KeyValues { get; } = new Dictionary<string, object>();
        public Dictionary<string, object> OldValues { get; } = new Dictionary<string, object>();
        public Dictionary<string, object> NewValues { get; } = new Dictionary<string, object>();
        public List<PropertyEntry> TemporaryProperties { get; } = new List<PropertyEntry>();
        public AuditType AuditType { get; set; }
        public List<string> ChangedColumns { get; } = new List<string>();
        public bool HasTemporaryProperties => TemporaryProperties.Any();

        public TbSystemLogger ToLog()
        {
            var audit = new TbSystemLogger();
            audit.UserId = UserId;
            audit.CompanyId = CompanyID;
            audit.Action = AuditType.ToString();
            audit.TableName = TableName;
            audit.CreatedOn = DateTime.Now;
            audit.ActionDate = DateTime.Now;
            audit.PrimaryKey = JsonConvert.SerializeObject(KeyValues);
            audit.OldValue = OldValues.Count == 0 ? null : JsonConvert.SerializeObject(OldValues);
            audit.NewValue = NewValues.Count == 0 ? null : JsonConvert.SerializeObject(NewValues);
            audit.PropertyName = ChangedColumns.Count == 0 ? null : JsonConvert.SerializeObject(ChangedColumns);
            return audit;
        }
    }
}
