using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbSubscrbtionHeader
    {
        public TbSubscrbtionHeader()
        {
            TbCustomerLogs = new HashSet<TbCustomerLog>();
            TbDislikeCategorytbSubscrbtionHeaders = new HashSet<TbDislikeCategorytbSubscrbtionHeader>();
            TbInvoicePaymentsHdrs = new HashSet<TbInvoicePaymentsHdr>();
            TbSubscrbtionDetails = new HashSet<TbSubscrbtionDetail>();
            TbSubscribtionOpertaions = new HashSet<TbSubscribtionOpertaion>();
        }

        public int Id { get; set; }
        public int ComId { get; set; }
        public int CustomerId { get; set; }
        public int AdressId { get; set; }
        public int? PlanId { get; set; }
        public DateTime StartDate { get; set; }
        public string SubscriptionExepression { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public int LastPaymentId { get; set; }
        public int DriverId { get; set; }
        public int BranchId { get; set; }
        public string Notes { get; set; }
        public int OldCid { get; set; }
        public int RestId { get; set; }
        public int? TransactionType { get; set; }
        public string PlanDays { get; set; }
        public string PlanMeals { get; set; }
        public int SubscriptionStatus { get; set; }
        public int PlanCategory { get; set; }
        public int Durations { get; set; }
        public int RemainDays { get; set; }

        public virtual TbErbMainBranch Branch { get; set; }
        public virtual TbCompany Com { get; set; }
        public virtual TbUser CreatedByNavigation { get; set; }
        public virtual TbCustomer Customer { get; set; }
        public virtual TbDriver Driver { get; set; }
        public virtual TbPlanMasterHdr Plan { get; set; }
        public virtual TbRestrictionsType TransactionTypeNavigation { get; set; }
        public virtual ICollection<TbCustomerLog> TbCustomerLogs { get; set; }
        public virtual ICollection<TbDislikeCategorytbSubscrbtionHeader> TbDislikeCategorytbSubscrbtionHeaders { get; set; }
        public virtual ICollection<TbInvoicePaymentsHdr> TbInvoicePaymentsHdrs { get; set; }
        public virtual ICollection<TbSubscrbtionDetail> TbSubscrbtionDetails { get; set; }
        public virtual ICollection<TbSubscribtionOpertaion> TbSubscribtionOpertaions { get; set; }
    }
}
