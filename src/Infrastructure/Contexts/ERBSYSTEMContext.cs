using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ErpDashboard.Application.Models;
using ErpDashboard.Application.Interfaces.Services;

#nullable disable

namespace ErpDashboard.Infrastructure.Contexts
{
    public partial class ERBSYSTEMContext : DbContext
    {
        private protected ICurrentUserService _currentUser;

        public ERBSYSTEMContext(ICurrentUserService currentUser)
        {
         _currentUser = currentUser;
        }
        public ERBSYSTEMContext(DbContextOptions<ERBSYSTEMContext> options, ICurrentUserService currentUser)
            : base(options)
        {
            _currentUser = currentUser;
        }

        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<TbAccount> TbAccounts { get; set; }
        public virtual DbSet<TbAlarmMessage> TbAlarmMessages { get; set; }
        public virtual DbSet<TbArea> TbAreas { get; set; }
        public virtual DbSet<TbBankTransHdr> TbBankTransHdrs { get; set; }
        public virtual DbSet<TbBankTransLine> TbBankTransLines { get; set; }
        public virtual DbSet<TbBanksInfo> TbBanksInfos { get; set; }
        public virtual DbSet<TbBranch> TbBranches { get; set; }
        public virtual DbSet<TbCategory> TbCategories { get; set; }
        public virtual DbSet<TbCheckBook> TbCheckBooks { get; set; }
        public virtual DbSet<TbCity> TbCities { get; set; }
        public virtual DbSet<TbCompany> TbCompanies { get; set; }
        public virtual DbSet<TbCompanyControlPanel> TbCompanyControlPanels { get; set; }
        public virtual DbSet<TbCostaccount> TbCostaccounts { get; set; }
        public virtual DbSet<TbCosttreestructure> TbCosttreestructures { get; set; }
        public virtual DbSet<TbCurrency> TbCurrencies { get; set; }
        public virtual DbSet<TbCurrencyPrice> TbCurrencyPrices { get; set; }
        public virtual DbSet<TbCustCardBalance> TbCustCardBalances { get; set; }
        public virtual DbSet<TbCustomPrice> TbCustomPrices { get; set; }
        public virtual DbSet<TbCustomer> TbCustomers { get; set; }
        public virtual DbSet<TbCustomerAdress> TbCustomerAdresses { get; set; }
        public virtual DbSet<TbCustomerCategory> TbCustomerCategories { get; set; }
        public virtual DbSet<TbCustomerLog> TbCustomerLogs { get; set; }
        public virtual DbSet<TbCustomersPhone> TbCustomersPhones { get; set; }
        public virtual DbSet<TbCustomersVendor> TbCustomersVendors { get; set; }
        public virtual DbSet<TbDepartment> TbDepartments { get; set; }
        public virtual DbSet<TbDiscountOption> TbDiscountOptions { get; set; }
        public virtual DbSet<TbDislikeCategory> TbDislikeCategories { get; set; }
        public virtual DbSet<TbDislikeCategorytbSubscrbtionHeader> TbDislikeCategorytbSubscrbtionHeaders { get; set; }
        public virtual DbSet<TbDislikeItem> TbDislikeItems { get; set; }
        public virtual DbSet<TbDriver> TbDrivers { get; set; }
        public virtual DbSet<TbEntryAttatchment> TbEntryAttatchments { get; set; }
        public virtual DbSet<TbErbMainBranch> TbErbMainBranches { get; set; }
        public virtual DbSet<TbExpense> TbExpenses { get; set; }
        public virtual DbSet<TbExpensesDatum> TbExpensesData { get; set; }
        public virtual DbSet<TbFinancialPeriod> TbFinancialPeriods { get; set; }
        public virtual DbSet<TbFranchise> TbFranchises { get; set; }
        public virtual DbSet<TbGeneralDiscount> TbGeneralDiscounts { get; set; }
        public virtual DbSet<TbGovernorate> TbGovernorates { get; set; }
        public virtual DbSet<TbInventoryDetail> TbInventoryDetails { get; set; }
        public virtual DbSet<TbInventoryHeader> TbInventoryHeaders { get; set; }
        public virtual DbSet<TbInvoicePaymentsHdr> TbInvoicePaymentsHdrs { get; set; }
        public virtual DbSet<TbItem> TbItems { get; set; }
        public virtual DbSet<TbItemComponentsHdr> TbItemComponentsHdrs { get; set; }
        public virtual DbSet<TbItemComponentsLine> TbItemComponentsLines { get; set; }
        public virtual DbSet<TbItemNutiration> TbItemNutirations { get; set; }
        public virtual DbSet<TbItemPrice> TbItemPrices { get; set; }
        public virtual DbSet<TbItemsDepartment> TbItemsDepartments { get; set; }
        public virtual DbSet<TbItemsSection> TbItemsSections { get; set; }
        public virtual DbSet<TbLogUserScr> TbLogUserScrs { get; set; }
        public virtual DbSet<TbLoyaltyPoint> TbLoyaltyPoints { get; set; }
        public virtual DbSet<TbMainBranch> TbMainBranches { get; set; }
        public virtual DbSet<TbManyCatMeal> TbManyCatMeals { get; set; }
        public virtual DbSet<TbManyTypeMeal> TbManyTypeMeals { get; set; }
        public virtual DbSet<TbMeal> TbMeals { get; set; }
        public virtual DbSet<TbMealTag> TbMealTags { get; set; }
        public virtual DbSet<TbMealsCategory> TbMealsCategories { get; set; }
        public virtual DbSet<TbMealsLine> TbMealsLines { get; set; }
        public virtual DbSet<TbMealsNutiration> TbMealsNutirations { get; set; }
        public virtual DbSet<TbMealsType> TbMealsTypes { get; set; }
        public virtual DbSet<TbMenuSection> TbMenuSections { get; set; }
        public virtual DbSet<TbMonth> TbMonths { get; set; }
        public virtual DbSet<TbMovie> TbMovies { get; set; }
        public virtual DbSet<TbNfcOperation> TbNfcOperations { get; set; }
        public virtual DbSet<TbNfcType> TbNfcTypes { get; set; }
        public virtual DbSet<TbNutMaster> TbNutMasters { get; set; }
        public virtual DbSet<TbOpeningEntryDetail> TbOpeningEntryDetails { get; set; }
        public virtual DbSet<TbOpeningEntryHeader> TbOpeningEntryHeaders { get; set; }
        public virtual DbSet<TbPayTypeHeader> TbPayTypeHeaders { get; set; }
        public virtual DbSet<TbPayTypeHeaderTbErbMainBranch> TbPayTypeHeaderTbErbMainBranches { get; set; }
        public virtual DbSet<TbPayTypeLine> TbPayTypeLines { get; set; }
        public virtual DbSet<TbPaymentDiscountDetail> TbPaymentDiscountDetails { get; set; }
        public virtual DbSet<TbPaymentMethodDetail> TbPaymentMethodDetails { get; set; }
        public virtual DbSet<TbPaymentVoucherHdr> TbPaymentVoucherHdrs { get; set; }
        public virtual DbSet<TbPaymentVoucherLine> TbPaymentVoucherLines { get; set; }
        public virtual DbSet<TbPeriodCloseHr> TbPeriodCloseHrs { get; set; }
        public virtual DbSet<TbPeriodclodeDt> TbPeriodclodeDts { get; set; }
        public virtual DbSet<TbPivotetable> TbPivotetables { get; set; }
        public virtual DbSet<TbPlanCatTip> TbPlanCatTips { get; set; }
        public virtual DbSet<TbPlanCategory> TbPlanCategories { get; set; }
        public virtual DbSet<TbPlanDay> TbPlanDays { get; set; }
        public virtual DbSet<TbPlanHdrType> TbPlanHdrTypes { get; set; }
        public virtual DbSet<TbPlanMasterHdr> TbPlanMasterHdrs { get; set; }
        public virtual DbSet<TbPlanMasterLine> TbPlanMasterLines { get; set; }
        public virtual DbSet<TbPlanPrice> TbPlanPrices { get; set; }
        public virtual DbSet<TbPriceType> TbPriceTypes { get; set; }
        public virtual DbSet<TbReportdetail> TbReportdetails { get; set; }
        public virtual DbSet<TbReportsheader> TbReportsheaders { get; set; }
        public virtual DbSet<TbRestrictionHdr> TbRestrictionHdrs { get; set; }
        public virtual DbSet<TbRestrictionLine> TbRestrictionLines { get; set; }
        public virtual DbSet<TbRestrictionsType> TbRestrictionsTypes { get; set; }
        public virtual DbSet<TbRole> TbRoles { get; set; }
        public virtual DbSet<TbRolesPermission> TbRolesPermissions { get; set; }
        public virtual DbSet<TbScreen> TbScreens { get; set; }
        public virtual DbSet<TbSponserDiscount> TbSponserDiscounts { get; set; }
        public virtual DbSet<TbSubscrbtionDetail> TbSubscrbtionDetails { get; set; }
        public virtual DbSet<TbSubscrbtionHeader> TbSubscrbtionHeaders { get; set; }
        public virtual DbSet<TbSubscribtionOpertaion> TbSubscribtionOpertaions { get; set; }
        public virtual DbSet<TbSystemLogger> TbSystemLoggers { get; set; }
        public virtual DbSet<TbThirdpart> TbThirdparts { get; set; }
        public virtual DbSet<TbTransactionDetail> TbTransactionDetails { get; set; }
        public virtual DbSet<TbTransactionHeader> TbTransactionHeaders { get; set; }
        public virtual DbSet<TbTransactionProp> TbTransactionProps { get; set; }
        public virtual DbSet<TbTransctionsOtherAdd> TbTransctionsOtherAdds { get; set; }
        public virtual DbSet<TbTreestructure> TbTreestructures { get; set; }
        public virtual DbSet<TbUnit> TbUnits { get; set; }
        public virtual DbSet<TbUser> TbUsers { get; set; }
        public virtual DbSet<TbUserBranche> TbUserBranches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=ErpConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId)
                    .HasMaxLength(150)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ContextKey)
                    .HasMaxLength(300)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbAccount>(entity =>
            {
                entity.ToTable("Tb_accounts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccAcType)
                    .HasMaxLength(50)
                    .HasColumnName("acc_AcType")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccAccept).HasColumnName("acc_Accept");

                entity.Property(e => e.AccArName)
                    .HasColumnName("acc_arName")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccEnName)
                    .HasColumnName("acc_EnName")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccLevelNo).HasColumnName("acc_level_no");

                entity.Property(e => e.AccNumber)
                    .HasColumnName("acc_number")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccParentid)
                    .HasColumnName("acc_parentid")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccountBalance).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.AccountBalanceCredit).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.Credit).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Debit).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.HasCost).HasColumnName("Has_cost");

                entity.Property(e => e.LastCredit).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.LastDebit).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.RelatedScreen)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SortId).HasColumnName("sortID");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<TbAlarmMessage>(entity =>
            {
                entity.HasKey(e => e.MsgId)
                    .HasName("PK_dbo.TB_Alarm_message");

                entity.ToTable("TB_Alarm_message");

                entity.Property(e => e.MsgId).HasColumnName("msg_id");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.MsgActive).HasColumnName("msg_active");

                entity.Property(e => e.MsgDateFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("msg_date_from");

                entity.Property(e => e.MsgDateTo)
                    .HasColumnType("datetime")
                    .HasColumnName("msg_date_to");

                entity.Property(e => e.MsgText)
                    .HasMaxLength(200)
                    .HasColumnName("msg_text")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
                entity.HasQueryFilter(x => _currentUser.CompanyID.HasValue ? x.ComId == _currentUser.CompanyID : true);
            });

            modelBuilder.Entity<TbArea>(entity =>
            {
                entity.ToTable("TB_areas");

                entity.HasIndex(e => e.BranchId, "IX_BranchID");

                entity.HasIndex(e => e.CityId, "IX_City_id");

                entity.HasIndex(e => e.CityGovernId, "IX_city_govern_id");

                entity.HasIndex(e => e.DriverId, "IX_driverID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.CityGovernId).HasColumnName("city_govern_id");

                entity.Property(e => e.CityId).HasColumnName("City_id");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.DriverId).HasColumnName("driverID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TbAreas)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.TB_areas_dbo.Tb_ErbMainBranches_BranchID");

                entity.HasOne(d => d.CityGovern)
                    .WithMany(p => p.TbAreas)
                    .HasForeignKey(d => d.CityGovernId)
                    .HasConstraintName("FK_dbo.TB_areas_dbo.TB_Governorates_city_govern_id");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TbAreas)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_dbo.TB_areas_dbo.TB_Cities_City_id");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.TbAreas)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("FK_dbo.TB_areas_dbo.tb_Drivers_driverID");
                entity.HasQueryFilter(x=> _currentUser.CompanyID.HasValue? x.ComId == _currentUser.CompanyID : true);
            });

            modelBuilder.Entity<TbBankTransHdr>(entity =>
            {
                entity.HasKey(e => e.RestId)
                    .HasName("PK_dbo.TB_Bank_trans_hdr");

                entity.ToTable("TB_Bank_trans_hdr");

                entity.HasIndex(e => e.BankId, "IX_Bank_id");

                entity.HasIndex(e => e.CheckBookId, "IX_check_book_id");

                entity.HasIndex(e => e.RestType, "IX_rest_type");

                entity.Property(e => e.RestId).HasColumnName("rest_id");

                entity.Property(e => e.BankAccNum)
                    .HasMaxLength(50)
                    .HasColumnName("Bank_acc_num")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BankId).HasColumnName("Bank_id");

                entity.Property(e => e.CheckBookId).HasColumnName("check_book_id");

                entity.Property(e => e.CheckCase)
                    .HasMaxLength(50)
                    .HasColumnName("check_case")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CheckId).HasColumnName("check_id");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.FinPeriod).HasColumnName("fin_period");

                entity.Property(e => e.ResFinCode).HasColumnName("res_fin_code");

                entity.Property(e => e.RestCase)
                    .HasMaxLength(50)
                    .HasColumnName("rest_case")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestCode).HasColumnName("rest_code");

                entity.Property(e => e.RestCurId).HasColumnName("rest_cur_id");

                entity.Property(e => e.RestCurRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rest_cur_rate");

                entity.Property(e => e.RestDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("rest_datetime");

                entity.Property(e => e.RestFlag)
                    .HasMaxLength(50)
                    .HasColumnName("rest_flag")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestId1).HasColumnName("restID");

                entity.Property(e => e.RestMonthId).HasColumnName("rest_month_id");

                entity.Property(e => e.RestNote)
                    .HasColumnName("rest_note")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestType).HasColumnName("rest_type");

                entity.Property(e => e.RestUser)
                    .HasMaxLength(50)
                    .HasColumnName("rest_user")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rest_value");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.TbBankTransHdrs)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_dbo.TB_Bank_trans_hdr_dbo.TB_Banks_Info_Bank_id");

                entity.HasOne(d => d.CheckBook)
                    .WithMany(p => p.TbBankTransHdrs)
                    .HasForeignKey(d => d.CheckBookId)
                    .HasConstraintName("FK_dbo.TB_Bank_trans_hdr_dbo.TB_CheckBooks_check_book_id");

                entity.HasOne(d => d.RestTypeNavigation)
                    .WithMany(p => p.TbBankTransHdrs)
                    .HasForeignKey(d => d.RestType)
                    .HasConstraintName("FK_dbo.TB_Bank_trans_hdr_dbo.TB_Restrictions_type_rest_type");
                entity.HasQueryFilter(x => _currentUser.CompanyID.HasValue ? x.ComId == _currentUser.CompanyID : true);
            });

            modelBuilder.Entity<TbBankTransLine>(entity =>
            {
                entity.HasKey(e => e.RestLineId)
                    .HasName("PK_dbo.TB_Bank_trans_lines");

                entity.ToTable("TB_Bank_trans_lines");

                entity.HasIndex(e => e.RestHdrId, "IX_rest_hdr_id");

                entity.Property(e => e.RestLineId).HasColumnName("rest_line_id");

                entity.Property(e => e.CostChild).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CostFlag).HasColumnName("Cost_flag");

                entity.Property(e => e.CostParient).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CostValue).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.MainCost).HasColumnName("mainCost");

                entity.Property(e => e.RestAccName)
                    .HasMaxLength(50)
                    .HasColumnName("rest_acc_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestAccNum)
                    .HasMaxLength(50)
                    .HasColumnName("rest_acc_num")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestCreditor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rest_creditor");

                entity.Property(e => e.RestDebtor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rest_debtor");

                entity.Property(e => e.RestHdrId).HasColumnName("rest_hdr_id");

                entity.Property(e => e.RestNote)
                    .HasColumnName("rest_note")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.RestHdr)
                    .WithMany(p => p.TbBankTransLines)
                    .HasForeignKey(d => d.RestHdrId)
                    .HasConstraintName("FK_dbo.TB_Bank_trans_lines_dbo.TB_Bank_trans_hdr_rest_hdr_id");
            });

            modelBuilder.Entity<TbBanksInfo>(entity =>
            {
                entity.ToTable("TB_Banks_Info");

                entity.HasIndex(e => e.ComId, "IX_com_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Account_Number")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccountTreeNum)
                    .HasMaxLength(50)
                    .HasColumnName("account_tree_num")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.BankAccountNum)
                    .HasMaxLength(50)
                    .HasColumnName("bank_account_num")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BankId).HasColumnName("bank_id");

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .HasColumnName("bank_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BankNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("bank_name_en")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.CommissionAcc)
                    .HasMaxLength(50)
                    .HasColumnName("commission_acc")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CommissionAccName)
                    .HasMaxLength(50)
                    .HasColumnName("commission_acc_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CommissionRate)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("commission_Rate");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.TbBanksInfos)
                    .HasForeignKey(d => d.ComId)
                    .HasConstraintName("FK_dbo.TB_Banks_Info_dbo.TB_Company_com_id");
                entity.HasQueryFilter(x => _currentUser.CompanyID.HasValue ? x.ComId == _currentUser.CompanyID : true);
            });

            modelBuilder.Entity<TbBranch>(entity =>
            {
                entity.ToTable("tb_branches");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BankAccounts)
                    .HasColumnName("bank_accounts")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CashNumber).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.CostOfSoldGoodsAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Costnumber).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FirstGoodsAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MainAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OtherAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreAddValue).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDamageGoods).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreInventoryAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StorePurchaseDiscount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreSells).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreSellsDiscount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreStockAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreTax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UserId).HasColumnName("UserID");
                entity.HasQueryFilter(x => _currentUser.CompanyID.HasValue ? x.ComId == _currentUser.CompanyID : true);
            });

            modelBuilder.Entity<TbCategory>(entity =>
            {
                entity.ToTable("tb_Category");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.EnName)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UserId).HasColumnName("UserID");
                entity.HasQueryFilter(x => _currentUser.CompanyID.HasValue ? x.ComId == _currentUser.CompanyID : true);
            });

            modelBuilder.Entity<TbCheckBook>(entity =>
            {
                entity.HasKey(e => e.ChBookId)
                    .HasName("PK_dbo.TB_CheckBooks");

                entity.ToTable("TB_CheckBooks");

                entity.HasIndex(e => e.BankId, "IX_bank_id");

                entity.Property(e => e.ChBookId).HasColumnName("ch_book_id");

                entity.Property(e => e.BankId).HasColumnName("bank_id");

                entity.Property(e => e.ChBookCode).HasColumnName("ch_book_code");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.CurrentCheckId).HasColumnName("current_check_id");

                entity.Property(e => e.EndWith).HasColumnName("end_with");

                entity.Property(e => e.StartWith).HasColumnName("start_with");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.TbCheckBooks)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_dbo.TB_CheckBooks_dbo.TB_Banks_Info_bank_id");
                entity.HasQueryFilter(x => _currentUser.CompanyID.HasValue ? x.ComId == _currentUser.CompanyID : true);
            });

            modelBuilder.Entity<TbCity>(entity =>
            {
                entity.ToTable("TB_Cities");

                entity.HasIndex(e => e.GovernId, "IX_govern_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.GovernId).HasColumnName("govern_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Govern)
                    .WithMany(p => p.TbCities)
                    .HasForeignKey(d => d.GovernId)
                    .HasConstraintName("FK_dbo.TB_Cities_dbo.TB_Governorates_govern_id");
                entity.HasQueryFilter(x => _currentUser.CompanyID.HasValue ? x.ComId == _currentUser.CompanyID : true);
            });

            modelBuilder.Entity<TbCompany>(entity =>
            {
                entity.HasKey(e => e.ComId)
                    .HasName("PK_dbo.TB_Company");

                entity.ToTable("TB_Company");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.ComActive).HasColumnName("com_active");

                entity.Property(e => e.ComAddress)
                    .HasMaxLength(50)
                    .HasColumnName("com_address")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComCommercialRecord)
                    .HasMaxLength(50)
                    .HasColumnName("com_commercial_record")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComMailBox)
                    .HasMaxLength(50)
                    .HasColumnName("com_mail_box")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComMobile1)
                    .HasMaxLength(50)
                    .HasColumnName("com_mobile1")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComMobile2)
                    .HasMaxLength(50)
                    .HasColumnName("com_mobile2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComName)
                    .HasMaxLength(50)
                    .HasColumnName("com_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("com_name_en")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComNameEnRpt)
                    .HasMaxLength(50)
                    .HasColumnName("com_name_en_rpt")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComNameRpt)
                    .HasMaxLength(50)
                    .HasColumnName("com_name_rpt")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComTaxCard)
                    .HasMaxLength(50)
                    .HasColumnName("com_tax_card")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComTelephone1)
                    .HasMaxLength(50)
                    .HasColumnName("com_telephone1")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComTelephone2)
                    .HasMaxLength(50)
                    .HasColumnName("com_telephone2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbCompanyControlPanel>(entity =>
            {
                entity.ToTable("tb_CompanyControlPanel");

                entity.HasIndex(e => e.CompanyId, "IX_company_id");

                entity.HasIndex(e => e.PeriodId, "IX_period_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountLenth)
                    .HasMaxLength(50)
                    .HasColumnName("account_lenth")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BankAccount).HasColumnName("bank_account");

                entity.Property(e => e.BankCommission).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchAddValue).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchCostAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchCostOfGoodsSold).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchDamageGoods).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchPurchaseDiscount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchSAccount)
                    .HasColumnName("BranchS_Account")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchSellsDiscount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchStock).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchTax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchesSells).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Cash)
                    .HasColumnName("cash")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CashAccount)
                    .HasColumnName("cashAccount")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CostOfGoodsSold).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCredit).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Customers)
                    .HasColumnName("customers")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DaysItemExpire).HasColumnName("days_item_expire");

                entity.Property(e => e.DriverAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DublicateNumber)
                    .HasMaxLength(50)
                    .HasColumnName("dublicate_number")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ExpensesNo)
                    .HasColumnName("Expenses_no")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FirstGoods).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FranciseAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.GoodsStock).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IntermediateAccount)
                    .HasColumnName("Intermediate_account")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LastPeriod).HasColumnName("last_period");

                entity.Property(e => e.MyProperty).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NextPeriod).HasColumnName("next_period");

                entity.Property(e => e.NfcLossProfit).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Nfcsells)
                    .HasColumnName("NFCSells")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NotifyItemExpire).HasColumnName("notify_item_expire");

                entity.Property(e => e.OpeningEntry).HasColumnName("opening_entry");

                entity.Property(e => e.PeriodId).HasColumnName("period_id");

                entity.Property(e => e.RevenueNo)
                    .HasColumnName("Revenue_no")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ShowControlpanel).HasColumnName("show_controlpanel");

                entity.Property(e => e.ShowCurrencyscreen).HasColumnName("show_Currencyscreen");

                entity.Property(e => e.StoreAddValue).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCash).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCostAccount)
                    .HasColumnName("storeCostAccount")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDamageGoods).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreInventory).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StorePurchaseDiscount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreSells).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreSellsDiscount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreTax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SubscriptionDiscount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SubscriptionRevenue).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SubscriptionTax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Suppliers)
                    .HasColumnName("suppliers")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TaxPercnt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ThirdPartAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UndeliveryDay).HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TbCompanyControlPanels)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tb_CompanyControlPanel_dbo.TB_Company_company_id");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.TbCompanyControlPanels)
                    .HasForeignKey(d => d.PeriodId)
                    .HasConstraintName("FK_dbo.tb_CompanyControlPanel_dbo.TB_Financial_Periods_period_id");
                entity.HasQueryFilter(x => _currentUser.CompanyID.HasValue ? x.CompanyId == _currentUser.CompanyID : true);
            });

            modelBuilder.Entity<TbCostaccount>(entity =>
            {
                entity.ToTable("tb_Costaccounts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccAcType)
                    .HasMaxLength(50)
                    .HasColumnName("acc_AcType")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccAccept).HasColumnName("acc_Accept");

                entity.Property(e => e.AccArName)
                    .HasColumnName("acc_arName")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccEnName)
                    .HasColumnName("acc_EnName")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccLevelNo).HasColumnName("acc_level_no");

                entity.Property(e => e.AccNumber)
                    .HasColumnName("acc_number")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccParentid)
                    .HasColumnName("acc_parentid")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.Related).HasColumnName("related");

                entity.Property(e => e.UserId).HasColumnName("user_id");
                entity.HasQueryFilter(x => _currentUser.CompanyID.HasValue ? x.ComId == _currentUser.CompanyID : true);
            });

            modelBuilder.Entity<TbCosttreestructure>(entity =>
            {
                entity.ToTable("TB_Costtreestructure");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.StArName)
                    .HasColumnName("st_ArName")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StComId).HasColumnName("st_ComID");

                entity.Property(e => e.StCount)
                    .HasColumnName("st_count")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StEnName)
                    .HasColumnName("st_EnName")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StId).HasColumnName("st_id");

                entity.Property(e => e.StLength).HasColumnName("st_length");

                entity.Property(e => e.StStartwith)
                    .HasMaxLength(50)
                    .HasColumnName("st_startwith")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UserId).HasColumnName("user_id");
                
            });

            modelBuilder.Entity<TbCurrency>(entity =>
            {
                entity.HasKey(e => e.CurId)
                    .HasName("PK_dbo.TB_Currency");

                entity.ToTable("TB_Currency");

                entity.Property(e => e.CurId).HasColumnName("cur_id");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.CurActive).HasColumnName("cur_active");

                entity.Property(e => e.CurDefRate).HasColumnName("cur_def_rate");

                entity.Property(e => e.CurName)
                    .HasMaxLength(50)
                    .HasColumnName("cur_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("cur_name_en")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurSmall)
                    .HasMaxLength(50)
                    .HasColumnName("cur_small")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurSmallEn)
                    .HasMaxLength(50)
                    .HasColumnName("cur_small_en")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurSymbol)
                    .HasMaxLength(50)
                    .HasColumnName("cur_symbol")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
                entity.HasQueryFilter(x => _currentUser.CompanyID.HasValue ? x.ComId == _currentUser.CompanyID : true);
            });

            modelBuilder.Entity<TbCurrencyPrice>(entity =>
            {
                entity.HasKey(e => e.CurPrId)
                    .HasName("PK_dbo.TB_Currency_prices");

                entity.ToTable("TB_Currency_prices");

                entity.HasIndex(e => e.ComId, "IX_com_id");

                entity.HasIndex(e => e.CurId, "IX_cur_id");

                entity.Property(e => e.CurPrId).HasColumnName("cur_pr_id");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.CurDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("cur_datetime");

                entity.Property(e => e.CurId).HasColumnName("cur_id");

                entity.Property(e => e.PurPrice)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pur_price");

                entity.Property(e => e.Rate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.SalesPrice)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("sales_price");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.TbCurrencyPrices)
                    .HasForeignKey(d => d.ComId)
                    .HasConstraintName("FK_dbo.TB_Currency_prices_dbo.TB_Company_com_id");

                entity.HasOne(d => d.Cur)
                    .WithMany(p => p.TbCurrencyPrices)
                    .HasForeignKey(d => d.CurId)
                    .HasConstraintName("FK_dbo.TB_Currency_prices_dbo.TB_Currency_cur_id");
                entity.HasQueryFilter(x => _currentUser.CompanyID.HasValue ? x.ComId == _currentUser.CompanyID : true);
            });

            modelBuilder.Entity<TbCustCardBalance>(entity =>
            {
                entity.ToTable("Tb_Cust_card_balance");

                entity.HasIndex(e => e.CustId, "IX_cust_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardId).HasColumnName("card_id");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.InOut)
                    .HasColumnName("in_out")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MoneyAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("money_amount");

                entity.Property(e => e.OpDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("op_datetime");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.TbCustCardBalances)
                    .HasForeignKey(d => d.CustId)
                    .HasConstraintName("FK_dbo.Tb_Cust_card_balance_dbo.tb_Customers_cust_id");
                
            });

            modelBuilder.Entity<TbCustomPrice>(entity =>
            {
                entity.ToTable("tb_CustomPrice");

                entity.HasIndex(e => e.MainCategoryId, "IX_MainCategoryId");

                entity.HasIndex(e => e.SupCategoryId, "IX_SupCategoryID");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.MaxQtyGm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Max_qty_gm");

                entity.Property(e => e.MaxQtyPc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Max_qty_pc");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupCategoryId).HasColumnName("SupCategoryID");

                entity.HasOne(d => d.MainCategory)
                    .WithMany(p => p.TbCustomPrices)
                    .HasForeignKey(d => d.MainCategoryId)
                    .HasConstraintName("FK_dbo.tb_CustomPrice_dbo.tb_PlanCategory_MainCategoryId");

                entity.HasOne(d => d.SupCategory)
                    .WithMany(p => p.TbCustomPrices)
                    .HasForeignKey(d => d.SupCategoryId)
                    .HasConstraintName("FK_dbo.tb_CustomPrice_dbo.Tb_MealsCategory_SupCategoryID");
                entity.HasQueryFilter(x => _currentUser.CompanyID.HasValue ? x.CommId == _currentUser.CompanyID : true);
            });

            modelBuilder.Entity<TbCustomer>(entity =>
            {
                entity.ToTable("tb_Customers");

                entity.HasIndex(e => e.CategoryId, "IX_CategoryID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.CustCoupon)
                    .HasColumnName("cust_coupon")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Height).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .HasColumnName("notes")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.RegType).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RelatedId).HasColumnName("related_Id");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Weight).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TbCustomers)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.tb_Customers_dbo.tb_CustomerCategory_CategoryID");
            });

            modelBuilder.Entity<TbCustomerAdress>(entity =>
            {
                entity.ToTable("tb_CustomerAdress");

                entity.HasIndex(e => e.AreaId, "IX_AreaID");

                entity.HasIndex(e => e.CustomerId, "IX_CustomerID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adress)
                    .HasMaxLength(200)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.TbCustomerAdresses)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tb_CustomerAdress_dbo.TB_areas_AreaID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TbCustomerAdresses)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.tb_CustomerAdress_dbo.tb_Customers_CustomerID");
            });

            modelBuilder.Entity<TbCustomerCategory>(entity =>
            {
                entity.ToTable("tb_CustomerCategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TbCustomerLog>(entity =>
            {
                entity.ToTable("tb_customerLog");

                entity.HasIndex(e => e.Cid, "IX_CID");

                entity.HasIndex(e => e.CustomerId, "IX_CustomerID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Action).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Notes).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.CidNavigation)
                    .WithMany(p => p.TbCustomerLogs)
                    .HasForeignKey(d => d.Cid)
                    .HasConstraintName("FK_dbo.tb_customerLog_dbo.tb_SubscrbtionHeader_CID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TbCustomerLogs)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.tb_customerLog_dbo.tb_Customers_CustomerID");
            });

            modelBuilder.Entity<TbCustomersPhone>(entity =>
            {
                entity.ToTable("tb_CustomersPhones");

                entity.HasIndex(e => e.CustomerId, "IX_CustomerID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Phone).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PhoneType).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TbCustomersPhones)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.tb_CustomersPhones_dbo.tb_Customers_CustomerID");
            });

            modelBuilder.Entity<TbCustomersVendor>(entity =>
            {
                entity.ToTable("tb_CustomersVendors");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Adress).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CommercialRecord)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Limeit).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Mandop)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PersonName)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Status).HasColumnName("Status_");

                entity.Property(e => e.TaxCard)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TaxFile)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TaxesOffice)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TaxesPositions)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbDepartment>(entity =>
            {
                entity.ToTable("Tb_Departments");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.Name).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbDiscountOption>(entity =>
            {
                entity.ToTable("Tb_Discount_Options");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApplyNewCust).HasColumnName("apply_new_cust");

                entity.Property(e => e.Customers)
                    .HasColumnName("customers")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DiscId).HasColumnName("disc_id");

                entity.Property(e => e.DiscOnCust).HasColumnName("disc_on_cust");

                entity.Property(e => e.DiscOnPlans).HasColumnName("disc_on_plans");

                entity.Property(e => e.MaxBenefitVal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("max_benefit_val");

                entity.Property(e => e.MaxCustBenefits).HasColumnName("max_cust_benefits");

                entity.Property(e => e.MaxCustVal).HasColumnName("max_cust_val");

                entity.Property(e => e.MaxLimitPercValue).HasColumnName("max_limit_perc_value");

                entity.Property(e => e.MaxPercValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("max_perc_value");

                entity.Property(e => e.MaxToBenefit).HasColumnName("max_to_benefit");

                entity.Property(e => e.MiniBenefitVal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("mini_benefit_val");

                entity.Property(e => e.MiniToBenefit).HasColumnName("mini_to_benefit");

                entity.Property(e => e.MoreCustBenefit).HasColumnName("more_cust_benefit");

                entity.Property(e => e.OtherDiscBenefit).HasColumnName("other_disc_benefit");

                entity.Property(e => e.Plans).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RelatedToSponser).HasColumnName("related_to_sponser");

                entity.Property(e => e.Sponsers)
                    .HasColumnName("sponsers")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ValueOrPerc).HasColumnName("value_or_perc");
            });

            modelBuilder.Entity<TbDislikeCategory>(entity =>
            {
                entity.ToTable("tb_DislikeCategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("ComID");
            });

            modelBuilder.Entity<TbDislikeCategorytbSubscrbtionHeader>(entity =>
            {
                entity.HasKey(e => new { e.TbDislikeCategoryId, e.TbSubscrbtionHeaderId })
                    .HasName("PK_dbo.tb_DislikeCategorytb_SubscrbtionHeader");

                entity.ToTable("tb_DislikeCategorytb_SubscrbtionHeader");

                entity.HasIndex(e => e.TbDislikeCategoryId, "IX_tb_DislikeCategory_ID");

                entity.HasIndex(e => e.TbSubscrbtionHeaderId, "IX_tb_SubscrbtionHeader_ID");

                entity.Property(e => e.TbDislikeCategoryId).HasColumnName("tb_DislikeCategory_ID");

                entity.Property(e => e.TbSubscrbtionHeaderId).HasColumnName("tb_SubscrbtionHeader_ID");

                entity.HasOne(d => d.TbDislikeCategory)
                    .WithMany(p => p.TbDislikeCategorytbSubscrbtionHeaders)
                    .HasForeignKey(d => d.TbDislikeCategoryId)
                    .HasConstraintName("FK_dbo.tb_DislikeCategorytb_SubscrbtionHeader_dbo.tb_DislikeCategory_tb_DislikeCategory_ID");

                entity.HasOne(d => d.TbSubscrbtionHeader)
                    .WithMany(p => p.TbDislikeCategorytbSubscrbtionHeaders)
                    .HasForeignKey(d => d.TbSubscrbtionHeaderId)
                    .HasConstraintName("FK_dbo.tb_DislikeCategorytb_SubscrbtionHeader_dbo.tb_SubscrbtionHeader_tb_SubscrbtionHeader_ID");
            });

            modelBuilder.Entity<TbDislikeItem>(entity =>
            {
                entity.ToTable("tb_DislikeItems");

                entity.HasIndex(e => e.DislikeCategoryId, "IX_DislikeCategoryID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.DislikeCategoryId).HasColumnName("DislikeCategoryID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.OppositeItemId).HasColumnName("OppositeItemID");

                entity.HasOne(d => d.DislikeCategory)
                    .WithMany(p => p.TbDislikeItems)
                    .HasForeignKey(d => d.DislikeCategoryId)
                    .HasConstraintName("FK_dbo.tb_DislikeItems_dbo.tb_DislikeCategory_DislikeCategoryID");
            });

            modelBuilder.Entity<TbDriver>(entity =>
            {
                entity.ToTable("tb_Drivers");

                entity.HasIndex(e => e.BranchId, "IX_BranchID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Adress)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.DriverName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Phone1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Phone2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Phone3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TbDrivers)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tb_Drivers_dbo.Tb_ErbMainBranches_BranchID");
            });

            modelBuilder.Entity<TbEntryAttatchment>(entity =>
            {
                entity.ToTable("tb_EntryAttatchments");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttatchId).HasColumnName("AttatchID");

                entity.Property(e => e.AttatchName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AttatchPath).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.EntryType)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Extentions)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RememberData).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<TbErbMainBranch>(entity =>
            {
                entity.ToTable("Tb_ErbMainBranches");

                entity.HasIndex(e => e.ComId, "IX_ComID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchAddValue).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchCostOfGoodsSold).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchDamageGoods).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchPurchaseDiscount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchSells).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchSellsDiscount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchStock).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchTax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CashNumber).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.CommisionAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Commission).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Costnumber).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FranchiseAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Isfranchise).HasColumnName("ISFranchise");

                entity.Property(e => e.MainAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OtherAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.TbErbMainBranches)
                    .HasForeignKey(d => d.ComId)
                    .HasConstraintName("FK_dbo.Tb_ErbMainBranches_dbo.TB_Company_ComID");
            });

            modelBuilder.Entity<TbExpense>(entity =>
            {
                entity.ToTable("Tb_Expenses");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .HasColumnName("AccountNO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.ExpensesId).HasColumnName("ExpensesID");

                entity.Property(e => e.ExpensesName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ExpensesNameEn).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MainAccount)
                    .HasColumnName("mainAccount")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Notes).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TbExpensesDatum>(entity =>
            {
                entity.ToTable("tb_ExpensesData");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankId)
                    .HasColumnName("BankID")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.CurRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Cur_Rate");

                entity.Property(e => e.CurrancyId).HasColumnName("CurrancyID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_");

                entity.Property(e => e.ExpenseAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ExpensesId).HasColumnName("ExpensesID");

                entity.Property(e => e.LoadType).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ManualId).HasColumnName("ManualID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PayType).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ResetId).HasColumnName("ResetID");

                entity.Property(e => e.Response)
                    .HasColumnName("Response_")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TbFinancialPeriod>(entity =>
            {
                entity.HasKey(e => e.FinancialId)
                    .HasName("PK_dbo.TB_Financial_Periods");

                entity.ToTable("TB_Financial_Periods");

                entity.Property(e => e.FinancialId).HasColumnName("financial_id");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.FinancialCase).HasColumnName("financial_case");

                entity.Property(e => e.FinancialEndIn)
                    .HasColumnType("datetime")
                    .HasColumnName("financial_end_in");

                entity.Property(e => e.FinancialName)
                    .HasMaxLength(50)
                    .HasColumnName("financial_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FinancialNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("financial_name_en")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FinancialStartIn)
                    .HasColumnType("datetime")
                    .HasColumnName("financial_start_in");
            });

            modelBuilder.Entity<TbFranchise>(entity =>
            {
                entity.ToTable("tb_franchise");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Adress).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CommercialRecord)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Mandop)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PersonName)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Status).HasColumnName("Status_");

                entity.Property(e => e.TaxCard)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TaxFile)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TaxesOffice)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TaxesPositions)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbGeneralDiscount>(entity =>
            {
                entity.ToTable("Tb_GeneralDiscount");

                entity.HasIndex(e => e.DiscId, "IX_disc_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("datetime")
                    .HasColumnName("date_to");

                entity.Property(e => e.DiscCoupon)
                    .HasColumnName("disc_coupon")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DiscId).HasColumnName("disc_id");

                entity.Property(e => e.DiscName)
                    .HasColumnName("disc_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DiscPerc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("disc_perc");

                entity.Property(e => e.DiscVal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("disc_val");

                entity.Property(e => e.State).HasColumnName("state");

                entity.HasOne(d => d.Disc)
                    .WithMany(p => p.TbGeneralDiscounts)
                    .HasForeignKey(d => d.DiscId)
                    .HasConstraintName("FK_dbo.Tb_GeneralDiscount_dbo.Tb_Discount_Options_disc_id");
            });

            modelBuilder.Entity<TbGovernorate>(entity =>
            {
                entity.ToTable("TB_Governorates");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.GovernId).HasColumnName("govern_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbInventoryDetail>(entity =>
            {
                entity.ToTable("tb_InventoryDetails");

                entity.HasIndex(e => e.InventoryDetailsId, "IX_InventoryDetailsID");

                entity.Property(e => e.Id).HasColumnName("ID_");

                entity.Property(e => e.ActualQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BookQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InventoryDetailsId).HasColumnName("InventoryDetailsID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.InventoryDetails)
                    .WithMany(p => p.TbInventoryDetails)
                    .HasForeignKey(d => d.InventoryDetailsId)
                    .HasConstraintName("FK_dbo.tb_InventoryDetails_dbo.tb_InventoryHeader_InventoryDetailsID");
            });

            modelBuilder.Entity<TbInventoryHeader>(entity =>
            {
                entity.ToTable("tb_InventoryHeader");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.InventoryDate).HasColumnType("datetime");

                entity.Property(e => e.InventoryId).HasColumnName("InventoryID");

                entity.Property(e => e.InventoryNotes)
                    .HasMaxLength(200)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TbInvoicePaymentsHdr>(entity =>
            {
                entity.ToTable("tb_Invoice_Payments_hdr");

                entity.HasIndex(e => e.CurrancyId, "IX_CurrancyID");

                entity.HasIndex(e => e.SubscrbtionId, "IX_SubscrbtionID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.CurrancyId).HasColumnName("CurrancyID");

                entity.Property(e => e.CurrancyRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("currancyRate");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.FinId).HasColumnName("fin_id");

                entity.Property(e => e.InvoiceState).HasColumnName("invoiceState");

                entity.Property(e => e.InvoiceType).HasColumnName("invoiceType");

                entity.Property(e => e.ManualDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Net).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Notes).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.SubscrbtionId).HasColumnName("SubscrbtionID");

                entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Currancy)
                    .WithMany(p => p.TbInvoicePaymentsHdrs)
                    .HasForeignKey(d => d.CurrancyId)
                    .HasConstraintName("FK_dbo.tb_Invoice_Payments_hdr_dbo.TB_Currency_CurrancyID");

                entity.HasOne(d => d.Subscrbtion)
                    .WithMany(p => p.TbInvoicePaymentsHdrs)
                    .HasForeignKey(d => d.SubscrbtionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tb_Invoice_Payments_hdr_dbo.tb_SubscrbtionHeader_SubscrbtionID");
            });

            modelBuilder.Entity<TbItem>(entity =>
            {
                entity.ToTable("TB_Items");

                entity.HasIndex(e => e.CategoryId, "IX_Category_id");

                entity.HasIndex(e => e.ItemUnit1, "IX_Item_unit1");

                entity.HasIndex(e => e.ItemPricesId, "IX_item_prices_id");

                entity.HasIndex(e => e.MenueSectionId, "IX_menue_section_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("Category_id");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.CostPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cost_price");

                entity.Property(e => e.ExpireFlag).HasColumnName("Expire_flag");

                entity.Property(e => e.ItemActive).HasColumnName("Item_active");

                entity.Property(e => e.ItemCase)
                    .HasColumnName("Item_case")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ItemEnName)
                    .HasMaxLength(100)
                    .HasColumnName("Item_En_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ItemId2)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ItemPricesId).HasColumnName("item_prices_id");

                entity.Property(e => e.ItemType).HasColumnName("Item_type");

                entity.Property(e => e.ItemUnit1).HasColumnName("Item_unit1");

                entity.Property(e => e.ItemUnit2).HasColumnName("Item_unit2");

                entity.Property(e => e.ItemUnit3).HasColumnName("Item_unit3");

                entity.Property(e => e.MainUnit).HasColumnName("Main_unit");

                entity.Property(e => e.MainUnitId).HasColumnName("Main_unit_id");

                entity.Property(e => e.MaxRequestUnit1)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("max_request_unit1");

                entity.Property(e => e.MaxRequestUnit2)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("max_request_unit2");

                entity.Property(e => e.MaxRequestUnit3)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("max_request_unit3");

                entity.Property(e => e.MenueSectionId).HasColumnName("menue_section_id");

                entity.Property(e => e.MinRequestUnit1)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("min_request_unit1");

                entity.Property(e => e.MinRequestUnit2)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("min_request_unit2");

                entity.Property(e => e.MinRequestUnit3)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("min_request_unit3");

                entity.Property(e => e.RequestUnit1)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("request_unit1");

                entity.Property(e => e.RequestUnit2)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("request_unit2");

                entity.Property(e => e.RequestUnit3)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("request_unit3");

                entity.Property(e => e.UnitRate1)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("Unit_rate1");

                entity.Property(e => e.UnitRate2)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("Unit_rate2");

                entity.Property(e => e.UnitRate3)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("Unit_rate3");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TbItems)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.TB_Items_dbo.tb_Category_Category_id");

                entity.HasOne(d => d.ItemPrices)
                    .WithMany(p => p.TbItems)
                    .HasForeignKey(d => d.ItemPricesId)
                    .HasConstraintName("FK_dbo.TB_Items_dbo.TB_Item_prices_item_prices_id");

                entity.HasOne(d => d.ItemUnit1Navigation)
                    .WithMany(p => p.TbItems)
                    .HasForeignKey(d => d.ItemUnit1)
                    .HasConstraintName("FK_dbo.TB_Items_dbo.tb_Units_Item_unit1");

                entity.HasOne(d => d.MenueSection)
                    .WithMany(p => p.TbItems)
                    .HasForeignKey(d => d.MenueSectionId)
                    .HasConstraintName("FK_dbo.TB_Items_dbo.Tb_Menu_section_menue_section_id");
            });

            modelBuilder.Entity<TbItemComponentsHdr>(entity =>
            {
                entity.ToTable("TB_ItemComponents_hdr");

                entity.HasIndex(e => e.ComplexItem, "IX_Complex_Item");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.CompHdrType).HasColumnName("comp_hdr_type");

                entity.Property(e => e.ComplexItem).HasColumnName("Complex_Item");

                entity.Property(e => e.CostPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Cost_Price");

                entity.Property(e => e.MainUnit)
                    .HasColumnName("main_unit")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ManualEnterPrice).HasColumnName("Manual_Enter_Price");

                entity.Property(e => e.PriceType).HasColumnName("Price_type");

                entity.Property(e => e.QtyNeeded)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Qty_needed");

                entity.HasOne(d => d.ComplexItemNavigation)
                    .WithMany(p => p.TbItemComponentsHdrs)
                    .HasForeignKey(d => d.ComplexItem)
                    .HasConstraintName("FK_dbo.TB_ItemComponents_hdr_dbo.TB_Items_Complex_Item");
            });

            modelBuilder.Entity<TbItemComponentsLine>(entity =>
            {
                entity.ToTable("TB_ItemComponents_lines");

                entity.HasIndex(e => e.ItemComHdr, "IX_item_com_hdr");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CostPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Cost_Price");

                entity.Property(e => e.IsUnit123).HasColumnName("Is_Unit_1_2_3");

                entity.Property(e => e.ItemComHdr).HasColumnName("item_com_hdr");

                entity.Property(e => e.ItemName)
                    .HasColumnName("Item_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.PriceEntered).HasColumnName("Price_entered");

                entity.Property(e => e.PriceType)
                    .HasColumnName("Price_type")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.ItemComHdrNavigation)
                    .WithMany(p => p.TbItemComponentsLines)
                    .HasForeignKey(d => d.ItemComHdr)
                    .HasConstraintName("FK_dbo.TB_ItemComponents_lines_dbo.TB_ItemComponents_hdr_item_com_hdr");
            });

            modelBuilder.Entity<TbItemNutiration>(entity =>
            {
                entity.ToTable("TB_ItemNutiration");

                entity.HasIndex(e => e.ItemId, "IX_ItemId");

                entity.HasIndex(e => e.NutMasterid, "IX_NutMasterid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CalcRow).HasColumnName("calc_row");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.ItemNutQty).HasColumnName("item_nut_qty");

                entity.Property(e => e.ItemNutUnit)
                    .HasColumnName("item_nut_unit")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NutMasterEquation).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NutMasterName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NutMasterPercEquation).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NutPerc).HasColumnName("nut_perc");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TbItemNutirations)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_dbo.TB_ItemNutiration_dbo.TB_Items_ItemId");

                entity.HasOne(d => d.NutMaster)
                    .WithMany(p => p.TbItemNutirations)
                    .HasForeignKey(d => d.NutMasterid)
                    .HasConstraintName("FK_dbo.TB_ItemNutiration_dbo.TB_NutMaster_NutMasterid");
            });

            modelBuilder.Entity<TbItemPrice>(entity =>
            {
                entity.ToTable("TB_Item_prices");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AvgPurPrice)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("avg_pur_price");

                entity.Property(e => e.AvgPurPrice2)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("avg_pur_price2");

                entity.Property(e => e.AvgPurPrice3)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("avg_pur_price3");

                entity.Property(e => e.AvgSalePrice)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("avg_sale_price");

                entity.Property(e => e.AvgSalePrice2)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("avg_sale_price2");

                entity.Property(e => e.AvgSalePrice3)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("avg_sale_price3");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LastPurPrice)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("last_pur_price");

                entity.Property(e => e.LastPurPrice2)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("last_pur_price2");

                entity.Property(e => e.LastPurPrice3)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("last_pur_price3");

                entity.Property(e => e.LastSalePrice)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("last_sale_price");

                entity.Property(e => e.LastSalePrice2)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("last_sale_price2");

                entity.Property(e => e.LastSalePrice3)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("last_sale_price3");

                entity.Property(e => e.PurPrice1Unt1)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pur_price1_unt1");

                entity.Property(e => e.PurPrice1Unt2)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pur_price1_unt2");

                entity.Property(e => e.PurPrice1Unt3)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pur_price1_unt3");

                entity.Property(e => e.PurPrice2Unt1)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pur_price2_unt1");

                entity.Property(e => e.PurPrice2Unt2)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pur_price2_unt2");

                entity.Property(e => e.PurPrice2Unt3)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pur_price2_unt3");

                entity.Property(e => e.PurPrice3Unt1)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pur_price3_unt1");

                entity.Property(e => e.PurPrice3Unt2)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pur_price3_unt2");

                entity.Property(e => e.PurPrice3Unt3)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pur_price3_unt3");

                entity.Property(e => e.PurPrice4Unt1)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pur_price4_unt1");

                entity.Property(e => e.PurPrice4Unt2)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pur_price4_unt2");

                entity.Property(e => e.PurPrice4Unt3)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pur_price4_unt3");

                entity.Property(e => e.PurPrice5Unt1)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pur_price5_unt1");

                entity.Property(e => e.PurPrice5Unt2)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pur_price5_unt2");

                entity.Property(e => e.PurPrice5Unt3)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pur_price5_unt3");

                entity.Property(e => e.SalePrice1Unt1)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("sale_price1_unt1");

                entity.Property(e => e.SalePrice1Unt2)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("sale_price1_unt2");

                entity.Property(e => e.SalePrice1Unt3)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("sale_price1_unt3");

                entity.Property(e => e.SalePrice2Unt1)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("sale_price2_unt1");

                entity.Property(e => e.SalePrice2Unt2)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("sale_price2_unt2");

                entity.Property(e => e.SalePrice2Unt3)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("sale_price2_unt3");

                entity.Property(e => e.SalePrice3Unt1)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("sale_price3_unt1");

                entity.Property(e => e.SalePrice3Unt2)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("sale_price3_unt2");

                entity.Property(e => e.SalePrice3Unt3)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("sale_price3_unt3");

                entity.Property(e => e.SalePrice4Unt1)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("sale_price4_unt1");

                entity.Property(e => e.SalePrice4Unt2)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("sale_price4_unt2");

                entity.Property(e => e.SalePrice4Unt3)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("sale_price4_unt3");

                entity.Property(e => e.SalePrice5Unt1)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("sale_price5_unt1");

                entity.Property(e => e.SalePrice5Unt2)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("sale_price5_unt2");

                entity.Property(e => e.SalePrice5Unt3)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("sale_price5_unt3");
            });

            modelBuilder.Entity<TbItemsDepartment>(entity =>
            {
                entity.ToTable("Tb_Items_Departments");

                entity.HasIndex(e => e.DeptId, "IX_DeptId");

                entity.HasIndex(e => e.ItemId, "IX_ItemId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.TbItemsDepartments)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK_dbo.Tb_Items_Departments_dbo.Tb_Departments_DeptId");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TbItemsDepartments)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_dbo.Tb_Items_Departments_dbo.TB_Items_ItemId");
            });

            modelBuilder.Entity<TbItemsSection>(entity =>
            {
                entity.ToTable("Tb_Items_Sections");

                entity.HasIndex(e => e.MealId, "IX_MealId");

                entity.HasIndex(e => e.ItemId, "IX_itemID");

                entity.HasIndex(e => e.SectionId, "IX_sectionID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemId).HasColumnName("itemID");

                entity.Property(e => e.SectionId).HasColumnName("sectionID");

                entity.Property(e => e.SectionName)
                    .HasColumnName("sectionName")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Selected).HasColumnName("selected");

                entity.Property(e => e.SelectedName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TbItemsSections)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_dbo.Tb_Items_Sections_dbo.TB_Items_itemID");

                entity.HasOne(d => d.Meal)
                    .WithMany(p => p.TbItemsSections)
                    .HasForeignKey(d => d.MealId)
                    .HasConstraintName("FK_dbo.Tb_Items_Sections_dbo.TB_Meals_MealId");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.TbItemsSections)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_dbo.Tb_Items_Sections_dbo.Tb_Menu_section_sectionID");
            });

            modelBuilder.Entity<TbLogUserScr>(entity =>
            {
                entity.ToTable("TB_Log_user_scr");

                entity.HasIndex(e => e.ScrId, "IX_scr_id");

                entity.HasIndex(e => e.UserId, "IX_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime");

                entity.Property(e => e.MasterId).HasColumnName("master_id");

                entity.Property(e => e.ScrId).HasColumnName("scr_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Scr)
                    .WithMany(p => p.TbLogUserScrs)
                    .HasForeignKey(d => d.ScrId)
                    .HasConstraintName("FK_dbo.TB_Log_user_scr_dbo.TB_Screens_scr_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TbLogUserScrs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.TB_Log_user_scr_dbo.TB_Users_user_id");
            });

            modelBuilder.Entity<TbLoyaltyPoint>(entity =>
            {
                entity.ToTable("Tb_loyalty_points");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AmountFrom)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount_from");

                entity.Property(e => e.AmountTo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount_to");

                entity.Property(e => e.ExpireCriteria)
                    .HasColumnName("expire_criteria")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ExpireRate).HasColumnName("expire_rate");

                entity.Property(e => e.Points).HasColumnName("points");

                entity.Property(e => e.PointsId).HasColumnName("points_id");

                entity.Property(e => e.RelatedMoney)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("related_money");
            });

            modelBuilder.Entity<TbMainBranch>(entity =>
            {
                entity.ToTable("Tb_MainBranches");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CashNumber).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.Costnumber).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MainAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OtherAccount).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TbManyCatMeal>(entity =>
            {
                entity.ToTable("Tb_many_cat_meal");

                entity.HasIndex(e => e.MealId, "IX_meal_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CatId).HasColumnName("cat_id");

                entity.Property(e => e.MealId).HasColumnName("meal_id");

                entity.HasOne(d => d.Meal)
                    .WithMany(p => p.TbManyCatMeals)
                    .HasForeignKey(d => d.MealId)
                    .HasConstraintName("FK_dbo.Tb_many_cat_meal_dbo.TB_Meals_meal_id");
            });

            modelBuilder.Entity<TbManyTypeMeal>(entity =>
            {
                entity.ToTable("Tb_many_type_meal");

                entity.HasIndex(e => e.MealId, "IX_meal_id");

                entity.HasIndex(e => e.TypeId, "IX_type_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MealId).HasColumnName("meal_id");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.Meal)
                    .WithMany(p => p.TbManyTypeMeals)
                    .HasForeignKey(d => d.MealId)
                    .HasConstraintName("FK_dbo.Tb_many_type_meal_dbo.TB_Meals_meal_id");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TbManyTypeMeals)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_dbo.Tb_many_type_meal_dbo.Tb_Meals_Types_type_id");
            });

            modelBuilder.Entity<TbMeal>(entity =>
            {
                entity.ToTable("TB_Meals");

                entity.HasIndex(e => e.PlanCategoryId, "IX_PlanCategoryID");

                entity.HasIndex(e => e.TbMenuSectionId, "IX_Tb_Menu_Section_ID");

                entity.HasIndex(e => e.TbUnitsId, "IX_tb_Units_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.CostPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cost_price");

                entity.Property(e => e.Iscustom).HasColumnName("ISCustom");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(50)
                    .HasColumnName("Item_type")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MainUnit).HasColumnName("Main_unit");

                entity.Property(e => e.MealCase).HasColumnName("Meal_case");

                entity.Property(e => e.MealCoArDesc)
                    .HasColumnName("Meal_co_Ar_Desc")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MealCoArName)
                    .HasMaxLength(100)
                    .HasColumnName("Meal_co_Ar_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MealCoEnDesc)
                    .HasColumnName("Meal_co_En_Desc")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MealCoEnName)
                    .HasColumnName("Meal_co_En_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MealImg).HasColumnName("Meal_img");

                entity.Property(e => e.MealName)
                    .HasColumnName("Meal_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MealUnit1).HasColumnName("Meal_unit1");

                entity.Property(e => e.PlanCategoryId).HasColumnName("PlanCategoryID");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sale_price");

                entity.Property(e => e.Tag).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TbMenuSectionId).HasColumnName("Tb_Menu_Section_ID");

                entity.Property(e => e.TbUnitsId).HasColumnName("tb_Units_ID");

                entity.HasOne(d => d.PlanCategory)
                    .WithMany(p => p.TbMeals)
                    .HasForeignKey(d => d.PlanCategoryId)
                    .HasConstraintName("FK_dbo.TB_Meals_dbo.tb_PlanCategory_PlanCategoryID");

                entity.HasOne(d => d.TbMenuSection)
                    .WithMany(p => p.TbMeals)
                    .HasForeignKey(d => d.TbMenuSectionId)
                    .HasConstraintName("FK_dbo.TB_Meals_dbo.Tb_Menu_section_Tb_Menu_Section_ID");

                entity.HasOne(d => d.TbUnits)
                    .WithMany(p => p.TbMeals)
                    .HasForeignKey(d => d.TbUnitsId)
                    .HasConstraintName("FK_dbo.TB_Meals_dbo.tb_Units_tb_Units_ID");
            });

            modelBuilder.Entity<TbMealTag>(entity =>
            {
                entity.ToTable("Tb_MealTags");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaxQtyGm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Max_qty_gm");

                entity.Property(e => e.MaxQtyPc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Max_qty_pc");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbMealsCategory>(entity =>
            {
                entity.ToTable("Tb_MealsCategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.EnName)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Issnack).HasColumnName("ISsnack");

                entity.Property(e => e.MealCategoryId).HasColumnName("MealCategoryID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TbMealsLine>(entity =>
            {
                entity.ToTable("Tb_Meals_Lines");

                entity.HasIndex(e => e.ItemId, "IX_ItemId");

                entity.HasIndex(e => e.MealId, "IX_Meal_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CostPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Cost_Price");

                entity.Property(e => e.ItemName)
                    .HasColumnName("Item_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ItemType).HasColumnName("Item_type");

                entity.Property(e => e.MealId).HasColumnName("Meal_id");

                entity.Property(e => e.PriceEntered).HasColumnName("Price_entered");

                entity.Property(e => e.PriceType)
                    .HasColumnName("Price_type")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TbMealsLines)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_dbo.Tb_Meals_Lines_dbo.TB_Items_ItemId");

                entity.HasOne(d => d.Meal)
                    .WithMany(p => p.TbMealsLines)
                    .HasForeignKey(d => d.MealId)
                    .HasConstraintName("FK_dbo.Tb_Meals_Lines_dbo.TB_Meals_Meal_id");
            });

            modelBuilder.Entity<TbMealsNutiration>(entity =>
            {
                entity.ToTable("Tb_MealsNutiration");

                entity.HasIndex(e => e.MealId, "IX_Meal_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CalcRow).HasColumnName("calc_row");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.Equation).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MealId).HasColumnName("Meal_id");

                entity.Property(e => e.NutMasterName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NutPerc).HasColumnName("nut_perc");

                entity.Property(e => e.PercEquation).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Meal)
                    .WithMany(p => p.TbMealsNutirations)
                    .HasForeignKey(d => d.MealId)
                    .HasConstraintName("FK_dbo.Tb_MealsNutiration_dbo.TB_Meals_Meal_id");
            });

            modelBuilder.Entity<TbMealsType>(entity =>
            {
                entity.ToTable("Tb_Meals_Types");

                entity.HasIndex(e => e.CategoryId, "IX_CategoryID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.MTypeId).HasColumnName("M_Type_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TbMealsTypes)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.Tb_Meals_Types_dbo.Tb_MealsCategory_CategoryID");
            });

            modelBuilder.Entity<TbMenuSection>(entity =>
            {
                entity.ToTable("Tb_Menu_section");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.EnName)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SectionId).HasColumnName("sectionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TbMonth>(entity =>
            {
                entity.ToTable("tb_month");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.أبريل).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.أغسطس).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.أكتوبر).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.ديسمبر).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.سبتمبر).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.فبراير).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.مارس).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.مايو).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.نوفمبر).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.يناير).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.يوليو).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.يونيو).HasColumnType("numeric(18, 3)");
            });

            modelBuilder.Entity<TbMovie>(entity =>
            {
                entity.HasKey(e => e.MoveId)
                    .HasName("PK_dbo.tb_movies");

                entity.ToTable("tb_movies");

                entity.Property(e => e.MoveId).HasColumnName("Move_id");

                entity.Property(e => e.Cheked).HasColumnName("cheked");

                entity.Property(e => e.MoveName)
                    .HasMaxLength(50)
                    .HasColumnName("Move_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbNfcOperation>(entity =>
            {
                entity.ToTable("Tb_NFC_operation");

                entity.HasIndex(e => e.CurrancyId, "IX_CurrancyID");

                entity.HasIndex(e => e.TransactionType, "IX_TransactionType");

                entity.HasIndex(e => e.CardType, "IX_card_type");

                entity.HasIndex(e => e.CustId, "IX_cust_id");

                entity.HasIndex(e => e.ExportBranch, "IX_export_branch");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankId).HasColumnName("bank_id");

                entity.Property(e => e.CardAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("card_amount");

                entity.Property(e => e.CardSerial).HasColumnName("card_serial");

                entity.Property(e => e.CardType).HasColumnName("card_type");

                entity.Property(e => e.CardValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("card_value");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.CurrancyId).HasColumnName("CurrancyID");

                entity.Property(e => e.CurrancyRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("currancyRate");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.ExportBranch).HasColumnName("export_branch");

                entity.Property(e => e.ExportDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Export_date");

                entity.Property(e => e.FinId).HasColumnName("fin_id");

                entity.Property(e => e.NfcOpType).HasColumnName("nfc_op_type");

                entity.Property(e => e.PayType)
                    .HasColumnName("pay_type")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestId).HasColumnName("restID");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.CardTypeNavigation)
                    .WithMany(p => p.TbNfcOperations)
                    .HasForeignKey(d => d.CardType)
                    .HasConstraintName("FK_dbo.Tb_NFC_operation_dbo.Tb_NFC_types_card_type");

                entity.HasOne(d => d.Currancy)
                    .WithMany(p => p.TbNfcOperations)
                    .HasForeignKey(d => d.CurrancyId)
                    .HasConstraintName("FK_dbo.Tb_NFC_operation_dbo.TB_Currency_CurrancyID");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.TbNfcOperations)
                    .HasForeignKey(d => d.CustId)
                    .HasConstraintName("FK_dbo.Tb_NFC_operation_dbo.tb_Customers_cust_id");

                entity.HasOne(d => d.ExportBranchNavigation)
                    .WithMany(p => p.TbNfcOperations)
                    .HasForeignKey(d => d.ExportBranch)
                    .HasConstraintName("FK_dbo.Tb_NFC_operation_dbo.tb_branches_export_branch");

                entity.HasOne(d => d.TransactionTypeNavigation)
                    .WithMany(p => p.TbNfcOperations)
                    .HasForeignKey(d => d.TransactionType)
                    .HasConstraintName("FK_dbo.Tb_NFC_operation_dbo.TB_Restrictions_type_TransactionType");
            });

            modelBuilder.Entity<TbNfcType>(entity =>
            {
                entity.ToTable("Tb_NFC_types");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BancAccounts)
                    .HasColumnName("banc_accounts")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.IncrPerc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("incr_perc");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<TbNutMaster>(entity =>
            {
                entity.ToTable("TB_NutMaster");

                entity.Property(e => e.ComId).HasColumnName("Com_Id");

                entity.Property(e => e.Equation).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NutName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Perc).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbOpeningEntryDetail>(entity =>
            {
                entity.ToTable("tb_OpeningEntryDetails");

                entity.HasIndex(e => e.DetialsId, "IX_DetialsID");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccountNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ColRel).HasColumnName("col_rel");

                entity.Property(e => e.Credit).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Debit).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.DetialsId).HasColumnName("DetialsID");

                entity.Property(e => e.DetialsNotes).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Detials)
                    .WithMany(p => p.TbOpeningEntryDetails)
                    .HasForeignKey(d => d.DetialsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.tb_OpeningEntryDetails_dbo.tb_OpeningEntryHeader_DetialsID");
            });

            modelBuilder.Entity<TbOpeningEntryHeader>(entity =>
            {
                entity.ToTable("tb_OpeningEntryHeader");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.CurrancyPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EntryNo).HasColumnName("EntryNO");

                entity.Property(e => e.EntryNotes).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EntryType)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Entrydate).HasColumnType("date");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.RestId).HasColumnName("restID");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<TbPayTypeHeader>(entity =>
            {
                entity.ToTable("tb_payTypeHeader");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNumber).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CardId).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Commation).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefranceId).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbPayTypeHeaderTbErbMainBranch>(entity =>
            {
                entity.HasKey(e => new { e.TbPayTypeHeaderId, e.TbErbMainBranchesId })
                    .HasName("PK_dbo.tb_payTypeHeaderTb_ErbMainBranches");

                entity.ToTable("tb_payTypeHeaderTb_ErbMainBranches");

                entity.HasIndex(e => e.TbErbMainBranchesId, "IX_Tb_ErbMainBranches_ID");

                entity.HasIndex(e => e.TbPayTypeHeaderId, "IX_tb_payTypeHeader_ID");

                entity.Property(e => e.TbPayTypeHeaderId).HasColumnName("tb_payTypeHeader_ID");

                entity.Property(e => e.TbErbMainBranchesId).HasColumnName("Tb_ErbMainBranches_ID");

                entity.HasOne(d => d.TbErbMainBranches)
                    .WithMany(p => p.TbPayTypeHeaderTbErbMainBranches)
                    .HasForeignKey(d => d.TbErbMainBranchesId)
                    .HasConstraintName("FK_dbo.tb_payTypeHeaderTb_ErbMainBranches_dbo.Tb_ErbMainBranches_Tb_ErbMainBranches_ID");

                entity.HasOne(d => d.TbPayTypeHeader)
                    .WithMany(p => p.TbPayTypeHeaderTbErbMainBranches)
                    .HasForeignKey(d => d.TbPayTypeHeaderId)
                    .HasConstraintName("FK_dbo.tb_payTypeHeaderTb_ErbMainBranches_dbo.tb_payTypeHeader_tb_payTypeHeader_ID");
            });

            modelBuilder.Entity<TbPayTypeLine>(entity =>
            {
                entity.ToTable("tb_payTypeLines");

                entity.HasIndex(e => e.PaymethodId, "IX_PaymethodID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.PaymethodId).HasColumnName("PaymethodID");

                entity.HasOne(d => d.Paymethod)
                    .WithMany(p => p.TbPayTypeLines)
                    .HasForeignKey(d => d.PaymethodId)
                    .HasConstraintName("FK_dbo.tb_payTypeLines_dbo.tb_payTypeHeader_PaymethodID");
            });

            modelBuilder.Entity<TbPaymentDiscountDetail>(entity =>
            {
                entity.ToTable("tb_PaymentDiscountDetails");

                entity.HasIndex(e => e.CustomerId, "IX_CustomerId");

                entity.HasIndex(e => e.PaymentDetailsId, "IX_PaymentDetailsID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CouponCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DiscountId).HasColumnName("DiscountID");

                entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentDetailsId).HasColumnName("PaymentDetailsID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TbPaymentDiscountDetails)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.tb_PaymentDiscountDetails_dbo.tb_Customers_CustomerId");

                entity.HasOne(d => d.PaymentDetails)
                    .WithMany(p => p.TbPaymentDiscountDetails)
                    .HasForeignKey(d => d.PaymentDetailsId)
                    .HasConstraintName("FK_dbo.tb_PaymentDiscountDetails_dbo.tb_Invoice_Payments_hdr_PaymentDetailsID");
            });

            modelBuilder.Entity<TbPaymentMethodDetail>(entity =>
            {
                entity.ToTable("tb_PaymentMethodDetails");

                entity.HasIndex(e => e.MethodId, "IX_MethodID");

                entity.HasIndex(e => e.PaymentsDetailsId, "IX_PaymentsDetailsID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MethodId).HasColumnName("MethodID");

                entity.Property(e => e.PaymentsDetailsId).HasColumnName("PaymentsDetailsID");

                entity.Property(e => e.RefrenceId)
                    .HasColumnName("RefrenceID")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Method)
                    .WithMany(p => p.TbPaymentMethodDetails)
                    .HasForeignKey(d => d.MethodId)
                    .HasConstraintName("FK_dbo.tb_PaymentMethodDetails_dbo.tb_payTypeHeader_MethodID");

                entity.HasOne(d => d.PaymentsDetails)
                    .WithMany(p => p.TbPaymentMethodDetails)
                    .HasForeignKey(d => d.PaymentsDetailsId)
                    .HasConstraintName("FK_dbo.tb_PaymentMethodDetails_dbo.tb_Invoice_Payments_hdr_PaymentsDetailsID");
            });

            modelBuilder.Entity<TbPaymentVoucherHdr>(entity =>
            {
                entity.HasKey(e => e.RestId)
                    .HasName("PK_dbo.TB_PaymentVoucherHdr");

                entity.ToTable("TB_PaymentVoucherHdr");

                entity.HasIndex(e => e.RestCurId, "IX_rest_cur_id");

                entity.HasIndex(e => e.RestType, "IX_rest_type");

                entity.Property(e => e.RestId).HasColumnName("rest_id");

                entity.Property(e => e.AccountA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccountB).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AmountA).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.AmountB).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.FinPeriod).HasColumnName("fin_period");

                entity.Property(e => e.MoveType)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ResFinCode).HasColumnName("res_fin_code");

                entity.Property(e => e.RestCase)
                    .HasMaxLength(50)
                    .HasColumnName("rest_case")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestCode).HasColumnName("rest_code");

                entity.Property(e => e.RestCurId).HasColumnName("rest_cur_id");

                entity.Property(e => e.RestCurRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rest_cur_rate");

                entity.Property(e => e.RestDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("rest_datetime");

                entity.Property(e => e.RestId1).HasColumnName("restID");

                entity.Property(e => e.RestMonthId).HasColumnName("rest_month_id");

                entity.Property(e => e.RestNote)
                    .HasColumnName("rest_note")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestType).HasColumnName("rest_type");

                entity.Property(e => e.RestValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rest_value");

                entity.HasOne(d => d.RestCur)
                    .WithMany(p => p.TbPaymentVoucherHdrs)
                    .HasForeignKey(d => d.RestCurId)
                    .HasConstraintName("FK_dbo.TB_PaymentVoucherHdr_dbo.TB_Currency_rest_cur_id");

                entity.HasOne(d => d.RestTypeNavigation)
                    .WithMany(p => p.TbPaymentVoucherHdrs)
                    .HasForeignKey(d => d.RestType)
                    .HasConstraintName("FK_dbo.TB_PaymentVoucherHdr_dbo.TB_Restrictions_type_rest_type");
            });

            modelBuilder.Entity<TbPaymentVoucherLine>(entity =>
            {
                entity.HasKey(e => e.RestLineId)
                    .HasName("PK_dbo.TB_PaymentVoucher_lines");

                entity.ToTable("TB_PaymentVoucher_lines");

                entity.HasIndex(e => e.RestHdrId, "IX_rest_hdr_id");

                entity.Property(e => e.RestLineId).HasColumnName("rest_line_id");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostChild).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CostFlag).HasColumnName("Cost_flag");

                entity.Property(e => e.CostParient).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CostValue).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.MainCost).HasColumnName("mainCost");

                entity.Property(e => e.RestAccName)
                    .HasMaxLength(50)
                    .HasColumnName("rest_acc_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestAccNum)
                    .HasMaxLength(50)
                    .HasColumnName("rest_acc_num")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestCreditor)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("rest_creditor");

                entity.Property(e => e.RestDebtor)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("rest_debtor");

                entity.Property(e => e.RestHdrId).HasColumnName("rest_hdr_id");

                entity.Property(e => e.RestNote)
                    .HasColumnName("rest_note")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.RestHdr)
                    .WithMany(p => p.TbPaymentVoucherLines)
                    .HasForeignKey(d => d.RestHdrId)
                    .HasConstraintName("FK_dbo.TB_PaymentVoucher_lines_dbo.TB_PaymentVoucherHdr_rest_hdr_id");
            });

            modelBuilder.Entity<TbPeriodCloseHr>(entity =>
            {
                entity.ToTable("tb_PeriodCloseHR");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CloseFrom).HasColumnType("date");

                entity.Property(e => e.CloseId).HasColumnName("CloseID");

                entity.Property(e => e.CloseName)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CloseNotes).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CloseTo).HasColumnType("date");

                entity.Property(e => e.ComId).HasColumnName("ComID");
            });

            modelBuilder.Entity<TbPeriodclodeDt>(entity =>
            {
                entity.ToTable("tb_periodclodeDT");

                entity.HasIndex(e => e.CloseIdhr, "IX_CloseIDHR");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CloseIdhr).HasColumnName("CloseIDHR");

                entity.HasOne(d => d.CloseIdhrNavigation)
                    .WithMany(p => p.TbPeriodclodeDts)
                    .HasForeignKey(d => d.CloseIdhr)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.tb_periodclodeDT_dbo.tb_PeriodCloseHR_CloseIDHR");
            });

            modelBuilder.Entity<TbPivotetable>(entity =>
            {
                entity.ToTable("tb_pivotetable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccountNo)
                    .HasColumnName("account_no")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Month)
                    .HasMaxLength(50)
                    .HasColumnName("Month_")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MonthNumber).HasColumnName("month_number");

                entity.Property(e => e.Total)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<TbPlanCatTip>(entity =>
            {
                entity.ToTable("tb_Plan_cat_tips");

                entity.HasIndex(e => e.PlanCatId, "IX_Plan_cat_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PlanCatId).HasColumnName("Plan_cat_id");

                entity.Property(e => e.Pointer).HasColumnName("pointer");

                entity.Property(e => e.TipText)
                    .HasColumnName("Tip_text")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.PlanCat)
                    .WithMany(p => p.TbPlanCatTips)
                    .HasForeignKey(d => d.PlanCatId)
                    .HasConstraintName("FK_dbo.tb_Plan_cat_tips_dbo.tb_PlanCategory_Plan_cat_id");
            });

            modelBuilder.Entity<TbPlanCategory>(entity =>
            {
                entity.ToTable("tb_PlanCategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TbPlanDay>(entity =>
            {
                entity.ToTable("Tb_Plan_days");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DayCount).HasColumnName("day_count");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbPlanHdrType>(entity =>
            {
                entity.ToTable("Tb_Plan_hdr_type");

                entity.HasIndex(e => e.PlanHdrId, "IX_plan_hdr_id");

                entity.HasIndex(e => e.TypeId, "IX_type_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.PlanHdrId).HasColumnName("plan_hdr_id");

                entity.Property(e => e.Sticker).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.PlanHdr)
                    .WithMany(p => p.TbPlanHdrTypes)
                    .HasForeignKey(d => d.PlanHdrId)
                    .HasConstraintName("FK_dbo.Tb_Plan_hdr_type_dbo.Tb_PlanMaster_hdr_plan_hdr_id");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TbPlanHdrTypes)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_dbo.Tb_Plan_hdr_type_dbo.Tb_Meals_Types_type_id");
            });

            modelBuilder.Entity<TbPlanMasterHdr>(entity =>
            {
                entity.ToTable("Tb_PlanMaster_hdr");

                entity.HasIndex(e => e.PlanCategory, "IX_PlanCategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.DaysCount).HasColumnName("days_count");

                entity.Property(e => e.DefaultSticker)
                    .HasColumnName("default_sticker")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.PlanExprission)
                    .HasColumnName("plan_exprission")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.PlanName)
                    .HasColumnName("plan_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PointerDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Pointer_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.StartDay).HasColumnName("start_day");

                entity.HasOne(d => d.PlanCategoryNavigation)
                    .WithMany(p => p.TbPlanMasterHdrs)
                    .HasForeignKey(d => d.PlanCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Tb_PlanMaster_hdr_dbo.tb_PlanCategory_PlanCategory");
            });

            modelBuilder.Entity<TbPlanMasterLine>(entity =>
            {
                entity.ToTable("Tb_PlanMaster_Lines");

                entity.HasIndex(e => e.HdrId, "IX_hdr_id");

                entity.HasIndex(e => e.MealId, "IX_meal_id");

                entity.HasIndex(e => e.TypeId, "IX_type_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Days).HasColumnName("days");

                entity.Property(e => e.DaysNames)
                    .HasColumnName("days_names")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.HdrId).HasColumnName("hdr_id");

                entity.Property(e => e.MealCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("meal_cost");

                entity.Property(e => e.MealId).HasColumnName("meal_id");

                entity.Property(e => e.MealName)
                    .HasColumnName("meal_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MealPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.TypeName)
                    .HasColumnName("type_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Hdr)
                    .WithMany(p => p.TbPlanMasterLines)
                    .HasForeignKey(d => d.HdrId)
                    .HasConstraintName("FK_dbo.Tb_PlanMaster_Lines_dbo.Tb_PlanMaster_hdr_hdr_id");

                entity.HasOne(d => d.Meal)
                    .WithMany(p => p.TbPlanMasterLines)
                    .HasForeignKey(d => d.MealId)
                    .HasConstraintName("FK_dbo.Tb_PlanMaster_Lines_dbo.TB_Meals_meal_id");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TbPlanMasterLines)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_dbo.Tb_PlanMaster_Lines_dbo.Tb_Meals_Types_type_id");
            });

            modelBuilder.Entity<TbPlanPrice>(entity =>
            {
                entity.ToTable("tb_PlanPrice");

                entity.HasIndex(e => e.CategeoryTypeId, "IX_CategeoryTypeID");

                entity.HasIndex(e => e.PlanDayId, "IX_PlanDayID");

                entity.HasIndex(e => e.PlanId, "IX_PlanID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CategeoryTypeId).HasColumnName("CategeoryTypeID");

                entity.Property(e => e.MealTypeId).HasColumnName("MealTypeID");

                entity.Property(e => e.PlanDayId).HasColumnName("PlanDayID");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.HasOne(d => d.CategeoryType)
                    .WithMany(p => p.TbPlanPrices)
                    .HasForeignKey(d => d.CategeoryTypeId)
                    .HasConstraintName("FK_dbo.tb_PlanPrice_dbo.Tb_MealsCategory_CategeoryTypeID");

                entity.HasOne(d => d.PlanDay)
                    .WithMany(p => p.TbPlanPrices)
                    .HasForeignKey(d => d.PlanDayId)
                    .HasConstraintName("FK_dbo.tb_PlanPrice_dbo.Tb_Plan_days_PlanDayID");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.TbPlanPrices)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK_dbo.tb_PlanPrice_dbo.Tb_PlanMaster_hdr_PlanID");
            });

            modelBuilder.Entity<TbPriceType>(entity =>
            {
                entity.ToTable("Tb_price_types");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbReportdetail>(entity =>
            {
                entity.ToTable("tb_reportdetails");

                entity.HasIndex(e => e.RepordId, "IX_RepordID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountBalance).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(200)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccountNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Formula).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RepordId).HasColumnName("RepordID");

                entity.HasOne(d => d.Repord)
                    .WithMany(p => p.TbReportdetails)
                    .HasForeignKey(d => d.RepordId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.tb_reportdetails_dbo.tb_reportsheader_RepordID");
            });

            modelBuilder.Entity<TbReportsheader>(entity =>
            {
                entity.ToTable("tb_reportsheader");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.CurrancyId).HasColumnName("CurrancyID");

                entity.Property(e => e.EntryType)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.From)
                    .HasColumnType("date")
                    .HasColumnName("From_");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.To).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TbRestrictionHdr>(entity =>
            {
                entity.HasKey(e => e.RestId)
                    .HasName("PK_dbo.TB_Restriction_hdr");

                entity.ToTable("TB_Restriction_hdr");

                entity.HasIndex(e => e.AttatchedId, "IX_attatched_id");

                entity.HasIndex(e => e.ComId, "IX_com_id");

                entity.HasIndex(e => e.RestCurId, "IX_rest_cur_id");

                entity.HasIndex(e => e.RestType, "IX_rest_type");

                entity.Property(e => e.RestId).HasColumnName("rest_id");

                entity.Property(e => e.AttatchedId).HasColumnName("attatched_id");

                entity.Property(e => e.CheckCase)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.FinPeriod).HasColumnName("fin_period");

                entity.Property(e => e.RelatedFincialId).HasColumnName("RelatedFincialID");

                entity.Property(e => e.RelatedId).HasColumnName("RelatedID");

                entity.Property(e => e.ResFinCode).HasColumnName("res_fin_code");

                entity.Property(e => e.RestCase)
                    .HasMaxLength(50)
                    .HasColumnName("rest_case")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestCode).HasColumnName("rest_code");

                entity.Property(e => e.RestCurId).HasColumnName("rest_cur_id");

                entity.Property(e => e.RestCurRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rest_cur_rate");

                entity.Property(e => e.RestDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("rest_datetime");

                entity.Property(e => e.RestFlag)
                    .HasMaxLength(50)
                    .HasColumnName("rest_flag")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestId1).HasColumnName("restID");

                entity.Property(e => e.RestMonthId).HasColumnName("rest_month_id");

                entity.Property(e => e.RestNote)
                    .HasColumnName("rest_note")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestType).HasColumnName("rest_type");

                entity.Property(e => e.RestValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rest_value");

                entity.HasOne(d => d.Attatched)
                    .WithMany(p => p.TbRestrictionHdrs)
                    .HasForeignKey(d => d.AttatchedId)
                    .HasConstraintName("FK_dbo.TB_Restriction_hdr_dbo.tb_EntryAttatchments_attatched_id");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.TbRestrictionHdrs)
                    .HasForeignKey(d => d.ComId)
                    .HasConstraintName("FK_dbo.TB_Restriction_hdr_dbo.TB_Company_com_id");

                entity.HasOne(d => d.RestCur)
                    .WithMany(p => p.TbRestrictionHdrs)
                    .HasForeignKey(d => d.RestCurId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.TB_Restriction_hdr_dbo.TB_Currency_rest_cur_id");

                entity.HasOne(d => d.RestTypeNavigation)
                    .WithMany(p => p.TbRestrictionHdrs)
                    .HasForeignKey(d => d.RestType)
                    .HasConstraintName("FK_dbo.TB_Restriction_hdr_dbo.TB_Restrictions_type_rest_type");
            });

            modelBuilder.Entity<TbRestrictionLine>(entity =>
            {
                entity.HasKey(e => e.RestLineId)
                    .HasName("PK_dbo.TB_Restriction_lines");

                entity.ToTable("TB_Restriction_lines");

                entity.HasIndex(e => e.RestHdrId, "IX_rest_hdr_id");

                entity.Property(e => e.RestLineId).HasColumnName("rest_line_id");

                entity.Property(e => e.CostChild).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CostFlag).HasColumnName("Cost_flag");

                entity.Property(e => e.CostParient).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CostValue).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.MainCost).HasColumnName("mainCost");

                entity.Property(e => e.RestAccName)
                    .HasMaxLength(50)
                    .HasColumnName("rest_acc_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestAccNum)
                    .HasMaxLength(50)
                    .HasColumnName("rest_acc_num")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestCreditor)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("rest_creditor");

                entity.Property(e => e.RestDebtor)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("rest_debtor");

                entity.Property(e => e.RestHdrId).HasColumnName("rest_hdr_id");

                entity.Property(e => e.RestNote)
                    .HasColumnName("rest_note")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.RestHdr)
                    .WithMany(p => p.TbRestrictionLines)
                    .HasForeignKey(d => d.RestHdrId)
                    .HasConstraintName("FK_dbo.TB_Restriction_lines_dbo.TB_Restriction_hdr_rest_hdr_id");
            });

            modelBuilder.Entity<TbRestrictionsType>(entity =>
            {
                entity.ToTable("TB_Restrictions_type");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.QtyIn).HasColumnName("qty_in");

                entity.Property(e => e.RestModual)
                    .HasColumnName("Rest__Modual")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestTypeEnglis)
                    .HasColumnName("Rest__typeEnglis")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestTypeId).HasColumnName("Rest_Type_id");

                entity.Property(e => e.RestTypeName)
                    .HasMaxLength(50)
                    .HasColumnName("Rest__type_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbRole>(entity =>
            {
                entity.ToTable("tb_Roles");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RoleName).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbRolesPermission>(entity =>
            {
                entity.ToTable("tb_RolesPermissions");

                entity.HasIndex(e => e.RoleId, "IX_RoleID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleValue).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TbRolesPermissions)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.tb_RolesPermissions_dbo.tb_Roles_RoleID");
            });

            modelBuilder.Entity<TbScreen>(entity =>
            {
                entity.ToTable("TB_Screens");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ScrName)
                    .HasMaxLength(50)
                    .HasColumnName("scr_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ScrNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("scr_name_en")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbSponserDiscount>(entity =>
            {
                entity.ToTable("Tb_SponserDiscount");

                entity.HasIndex(e => e.DiscId, "IX_disc_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustCount).HasColumnName("cust_count");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("datetime")
                    .HasColumnName("date_to");

                entity.Property(e => e.DiscId).HasColumnName("disc_id");

                entity.Property(e => e.DiscName)
                    .HasColumnName("disc_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DiscPerc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("disc_perc");

                entity.Property(e => e.DiscType).HasColumnName("disc_type");

                entity.Property(e => e.DiscVal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("disc_val");

                entity.Property(e => e.PointCount).HasColumnName("point_count");

                entity.Property(e => e.State).HasColumnName("state");

                entity.HasOne(d => d.Disc)
                    .WithMany(p => p.TbSponserDiscounts)
                    .HasForeignKey(d => d.DiscId)
                    .HasConstraintName("FK_dbo.Tb_SponserDiscount_dbo.Tb_Discount_Options_disc_id");
            });

            modelBuilder.Entity<TbSubscrbtionDetail>(entity =>
            {
                entity.ToTable("tb_SubscrbtionDetails");

                entity.HasIndex(e => e.DeliveryAdress, "IX_DeliveryAdress");

                entity.HasIndex(e => e.DriverId, "IX_DriverID");

                entity.HasIndex(e => e.MealId, "IX_MealID");

                entity.HasIndex(e => e.MealTypeId, "IX_MealTypeID");

                entity.HasIndex(e => e.PaymentsDetailsId, "IX_PaymentsDetailsID");

                entity.HasIndex(e => e.SubscrbtionId, "IX_SubscrbtionID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.DayName)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.MealId).HasColumnName("MealID");

                entity.Property(e => e.MealTypeId).HasColumnName("MealTypeID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PaymentsDetailsId).HasColumnName("PaymentsDetailsID");

                entity.Property(e => e.Sticker).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SubscrbtionId).HasColumnName("SubscrbtionID");

                entity.HasOne(d => d.DeliveryAdressNavigation)
                    .WithMany(p => p.TbSubscrbtionDetails)
                    .HasForeignKey(d => d.DeliveryAdress)
                    .HasConstraintName("FK_dbo.tb_SubscrbtionDetails_dbo.tb_CustomerAdress_DeliveryAdress");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.TbSubscrbtionDetails)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("FK_dbo.tb_SubscrbtionDetails_dbo.tb_Drivers_DriverID");

                entity.HasOne(d => d.Meal)
                    .WithMany(p => p.TbSubscrbtionDetails)
                    .HasForeignKey(d => d.MealId)
                    .HasConstraintName("FK_dbo.tb_SubscrbtionDetails_dbo.TB_Meals_MealID");

                entity.HasOne(d => d.MealType)
                    .WithMany(p => p.TbSubscrbtionDetails)
                    .HasForeignKey(d => d.MealTypeId)
                    .HasConstraintName("FK_dbo.tb_SubscrbtionDetails_dbo.Tb_Meals_Types_MealTypeID");

                entity.HasOne(d => d.PaymentsDetails)
                    .WithMany(p => p.TbSubscrbtionDetails)
                    .HasForeignKey(d => d.PaymentsDetailsId)
                    .HasConstraintName("FK_dbo.tb_SubscrbtionDetails_dbo.tb_Invoice_Payments_hdr_PaymentsDetailsID");

                entity.HasOne(d => d.Subscrbtion)
                    .WithMany(p => p.TbSubscrbtionDetails)
                    .HasForeignKey(d => d.SubscrbtionId)
                    .HasConstraintName("FK_dbo.tb_SubscrbtionDetails_dbo.tb_SubscrbtionHeader_SubscrbtionID");
            });

            modelBuilder.Entity<TbSubscrbtionHeader>(entity =>
            {
                entity.ToTable("tb_SubscrbtionHeader");

                entity.HasIndex(e => e.BranchId, "IX_BranchID");

                entity.HasIndex(e => e.ComId, "IX_ComID");

                entity.HasIndex(e => e.CreatedBy, "IX_CreatedBy");

                entity.HasIndex(e => e.CustomerId, "IX_CustomerID");

                entity.HasIndex(e => e.DriverId, "IX_DriverID");

                entity.HasIndex(e => e.PlanId, "IX_PlanID");

                entity.HasIndex(e => e.TransactionType, "IX_TransactionType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdressId).HasColumnName("AdressID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.LastPaymentId).HasColumnName("LastPaymentID");

                entity.Property(e => e.Notes).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PlanDays).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.PlanMeals)
                    .HasColumnName("planMeals")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestId).HasColumnName("restID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SubscriptionExepression)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TbSubscrbtionHeaders)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.tb_SubscrbtionHeader_dbo.Tb_ErbMainBranches_BranchID");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.TbSubscrbtionHeaders)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tb_SubscrbtionHeader_dbo.TB_Company_ComID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TbSubscrbtionHeaders)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.tb_SubscrbtionHeader_dbo.TB_Users_CreatedBy");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TbSubscrbtionHeaders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tb_SubscrbtionHeader_dbo.tb_Customers_CustomerID");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.TbSubscrbtionHeaders)
                    .HasForeignKey(d => d.DriverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tb_SubscrbtionHeader_dbo.tb_Drivers_DriverID");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.TbSubscrbtionHeaders)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK_dbo.tb_SubscrbtionHeader_dbo.Tb_PlanMaster_hdr_PlanID");

                entity.HasOne(d => d.TransactionTypeNavigation)
                    .WithMany(p => p.TbSubscrbtionHeaders)
                    .HasForeignKey(d => d.TransactionType)
                    .HasConstraintName("FK_dbo.tb_SubscrbtionHeader_dbo.TB_Restrictions_type_TransactionType");
            });

            modelBuilder.Entity<TbSubscribtionOpertaion>(entity =>
            {
                entity.ToTable("tb_Subscribtion_Opertaion");

                entity.HasIndex(e => e.MealId, "IX_MealID");

                entity.HasIndex(e => e.SubscrbtionId, "IX_SubscrbtionID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerBranchId).HasColumnName("CustomerBranchID");

                entity.Property(e => e.CustomerBranchName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerNote)
                    .HasMaxLength(200)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.DayName)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DayNotes)
                    .HasMaxLength(200)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeliverBranchId).HasColumnName("DeliverBranchID");

                entity.Property(e => e.DeliverBranchName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryNote)
                    .HasMaxLength(200)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.DriverName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MealId).HasColumnName("MealID");

                entity.Property(e => e.PlanExpression).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.SubscrbtionId).HasColumnName("SubscrbtionID");

                entity.HasOne(d => d.Meal)
                    .WithMany(p => p.TbSubscribtionOpertaions)
                    .HasForeignKey(d => d.MealId)
                    .HasConstraintName("FK_dbo.tb_Subscribtion_Opertaion_dbo.TB_Meals_MealID");

                entity.HasOne(d => d.Subscrbtion)
                    .WithMany(p => p.TbSubscribtionOpertaions)
                    .HasForeignKey(d => d.SubscrbtionId)
                    .HasConstraintName("FK_dbo.tb_Subscribtion_Opertaion_dbo.tb_SubscrbtionHeader_SubscrbtionID");
            });

            modelBuilder.Entity<TbSystemLogger>(entity =>
            {
                entity.ToTable("tb_SystemLogger");

                entity.Property(e => e.Action).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifaiedOn).HasColumnType("datetime");

                entity.Property(e => e.NewValue).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OldValue).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PrimaryKey).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PropertyName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TableName).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbThirdpart>(entity =>
            {
                entity.ToTable("tb_thirdpart");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TbTransactionDetail>(entity =>
            {
                entity.ToTable("tb_TransactionDetails");

                entity.HasIndex(e => e.ItemId, "IX_ItemID");

                entity.HasIndex(e => e.TransDetailId, "IX_TransDetailID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddValuePercent).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.AddValueValue).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.DiscountPercent).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.DiscountValue).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.ExpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Expire_date");

                entity.Property(e => e.IsUnit123).HasColumnName("Is_Unit_1_2_3");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .HasColumnName("Notes_")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Price).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Qty).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.QtyIn)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("qty_in");

                entity.Property(e => e.QtyOut)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("qty_out");

                entity.Property(e => e.Show).HasColumnName("Show_");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.TotalAfterDiscount).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.TransDetailId).HasColumnName("TransDetailID");

                entity.Property(e => e.Unit1)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Unit2).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Unit3).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UnitRate).HasColumnType("numeric(18, 3)");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TbTransactionDetails)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_dbo.tb_TransactionDetails_dbo.TB_Items_ItemID");

                entity.HasOne(d => d.TransDetail)
                    .WithMany(p => p.TbTransactionDetails)
                    .HasForeignKey(d => d.TransDetailId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.tb_TransactionDetails_dbo.tb_TransactionHeader_TransDetailID");
            });

            modelBuilder.Entity<TbTransactionHeader>(entity =>
            {
                entity.ToTable("tb_TransactionHeader");

                entity.HasIndex(e => e.AccountId, "IX_AccountID");

                entity.HasIndex(e => e.StoreId, "IX_StoreID");

                entity.HasIndex(e => e.TransactionType, "IX_TransactionType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AddTaxPercent).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.AddValue).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CurrancyId).HasColumnName("CurrancyID");

                entity.Property(e => e.CurrancyRate)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("currancyRate");

                entity.Property(e => e.FinId).HasColumnName("fin_id");

                entity.Property(e => e.ItemDicountPercent).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.ItemsDiscount).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.NetVal)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("net_val");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PayType)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.QtyTot)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("Qty_tot");

                entity.Property(e => e.RelatedId).HasColumnName("RelatedID");

                entity.Property(e => e.RelatedScreen)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RestId).HasColumnName("restID");

                entity.Property(e => e.SalesTax).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.SalesTaxPercent).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.StoreTo).HasColumnName("StoreTO");

                entity.Property(e => e.TotalAfterDiscount).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.TransActionDiscountercent).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionDiscount).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.TransactionExpense).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.TransactionNo)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TransactionTotal).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VisaBank)
                    .HasMaxLength(50)
                    .HasColumnName("visa_bank")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.TbTransactionHeaders)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_dbo.tb_TransactionHeader_dbo.tb_CustomersVendors_AccountID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.TbTransactionHeaders)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_dbo.tb_TransactionHeader_dbo.tb_branches_StoreID");

                entity.HasOne(d => d.TransactionTypeNavigation)
                    .WithMany(p => p.TbTransactionHeaders)
                    .HasForeignKey(d => d.TransactionType)
                    .HasConstraintName("FK_dbo.tb_TransactionHeader_dbo.TB_Restrictions_type_TransactionType");
            });

            modelBuilder.Entity<TbTransactionProp>(entity =>
            {
                entity.ToTable("Tb_Transaction_Prop");

                entity.HasIndex(e => e.Store, "IX_Store");

                entity.HasIndex(e => e.PriceType, "IX_price_type");

                entity.Property(e => e.CashAccount)
                    .HasMaxLength(50)
                    .HasColumnName("Cash_Account")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.CostOfGoods)
                    .HasMaxLength(50)
                    .HasColumnName("Cost_of_goods")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreateEntry).HasColumnName("create_entry");

                entity.Property(e => e.DiscVal)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("disc_val");

                entity.Property(e => e.DiscountAccount)
                    .HasMaxLength(50)
                    .HasColumnName("Discount_Account")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EffectOnAvg).HasColumnName("effect_on_avg");

                entity.Property(e => e.EntryType)
                    .HasMaxLength(50)
                    .HasColumnName("Entry_type")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ExpireItemOption)
                    .HasMaxLength(50)
                    .HasColumnName("expire_item_option")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.GoadsOnWay)
                    .HasMaxLength(50)
                    .HasColumnName("Goads_On_Way")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvVendorDisc).HasColumnName("inv_vendor_disc");

                entity.Property(e => e.ManualCodeOption)
                    .HasMaxLength(50)
                    .HasColumnName("manual_code_option")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MaterialAccount)
                    .HasMaxLength(50)
                    .HasColumnName("Material_Account")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .HasColumnName("notes")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NoyifyExpire).HasColumnName("noyify_expire");

                entity.Property(e => e.PayType)
                    .HasMaxLength(50)
                    .HasColumnName("pay_type")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PriceType).HasColumnName("price_type");

                entity.Property(e => e.PurchaseAccount)
                    .HasMaxLength(50)
                    .HasColumnName("Purchase_Account")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ReManualCode).HasColumnName("re_manual_code");

                entity.Property(e => e.SalesTax)
                    .HasMaxLength(50)
                    .HasColumnName("sales_tax")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ScreenName).HasColumnName("screen_name");

                entity.Property(e => e.UseExpireItem).HasColumnName("use_expire_item");

                entity.Property(e => e.ValueAdded)
                    .HasMaxLength(50)
                    .HasColumnName("Value_Added")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VisaAccount)
                    .HasMaxLength(50)
                    .HasColumnName("Visa_Account")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Voucher)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.PriceTypeNavigation)
                    .WithMany(p => p.TbTransactionProps)
                    .HasForeignKey(d => d.PriceType)
                    .HasConstraintName("FK_dbo.Tb_Transaction_Prop_dbo.Tb_price_types_price_type");

                entity.HasOne(d => d.StoreNavigation)
                    .WithMany(p => p.TbTransactionProps)
                    .HasForeignKey(d => d.Store)
                    .HasConstraintName("FK_dbo.Tb_Transaction_Prop_dbo.tb_branches_Store");
            });

            modelBuilder.Entity<TbTransctionsOtherAdd>(entity =>
            {
                entity.ToTable("tb_TransctionsOtherAdds");

                entity.HasIndex(e => e.TransctionId, "IX_TransctionID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccountNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AddPercent).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.AddValue).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.DiscountPercent).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.DiscountValue).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TransctionId).HasColumnName("TransctionID");

                entity.HasOne(d => d.Transction)
                    .WithMany(p => p.TbTransctionsOtherAdds)
                    .HasForeignKey(d => d.TransctionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.tb_TransctionsOtherAdds_dbo.tb_TransactionHeader_TransctionID");
            });

            modelBuilder.Entity<TbTreestructure>(entity =>
            {
                entity.ToTable("TB_treestructure");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.StArName)
                    .HasColumnName("st_ArName")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StComId).HasColumnName("st_ComID");

                entity.Property(e => e.StCount)
                    .HasColumnName("st_count")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StEnName)
                    .HasColumnName("st_EnName")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StId).HasColumnName("st_id");

                entity.Property(e => e.StLength).HasColumnName("st_length");

                entity.Property(e => e.StStartwith)
                    .HasMaxLength(50)
                    .HasColumnName("st_startwith")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<TbUnit>(entity =>
            {
                entity.ToTable("tb_Units");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.DefQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("def_Qty");

                entity.Property(e => e.EnName)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Notes)
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TbUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_dbo.TB_Users");

                entity.ToTable("TB_Users");

                entity.HasIndex(e => e.UserRole, "IX_UserRole");

                entity.HasIndex(e => e.ComId, "IX_com_id");

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.UserActive).HasColumnName("user_active");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("user_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UserPass)
                    .HasMaxLength(50)
                    .HasColumnName("user_pass")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.TbUsers)
                    .HasForeignKey(d => d.ComId)
                    .HasConstraintName("FK_dbo.TB_Users_dbo.TB_Company_com_id");

                entity.HasOne(d => d.UserRoleNavigation)
                    .WithMany(p => p.TbUsers)
                    .HasForeignKey(d => d.UserRole)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.TB_Users_dbo.tb_Roles_UserRole");
            });

            modelBuilder.Entity<TbUserBranche>(entity =>
            {
                entity.ToTable("tb_UserBranche");

                entity.HasIndex(e => e.UserId, "IX_UserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TbUserBranches)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.tb_UserBranche_dbo.TB_Users_UserID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
