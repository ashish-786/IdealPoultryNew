using System;
using System.Data.SqlClient;
using IdealPoultryApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class IdealPoultryContext : DbContext
    {
        public IdealPoultryContext()
        {
        }

        public IdealPoultryContext(DbContextOptions<IdealPoultryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<ActivityDtl> ActivityDtl { get; set; }
        public virtual DbSet<ActivitySession> ActivitySession { get; set; }
        public virtual DbSet<ActivityType> ActivityType { get; set; }
        public virtual DbSet<AttribDtl> AttribDtl { get; set; }
        public virtual DbSet<AttribGroupDtl> AttribGroupDtl { get; set; }
        public virtual DbSet<AttribGroupHdr> AttribGroupHdr { get; set; }
        public virtual DbSet<AttribHdr> AttribHdr { get; set; }
        public virtual DbSet<Availability> Availability { get; set; }
        public virtual DbSet<AvailabilityOutsource> AvailabilityOutsource { get; set; }
        public virtual DbSet<BoxDtl> BoxDtl { get; set; }
        public virtual DbSet<BoxHdr> BoxHdr { get; set; }
        public virtual DbSet<Breed> Breed { get; set; }
        public virtual DbSet<BreedAttribute> BreedAttribute { get; set; }
        public virtual DbSet<BreedAttributeDtl> BreedAttributeDtl { get; set; }
        public virtual DbSet<BreedAttributeType> BreedAttributeType { get; set; }
        public virtual DbSet<BreedAvailability> BreedAvailability { get; set; }
        public virtual DbSet<BreedDescription> BreedDescription { get; set; }
        public virtual DbSet<BreedGroupHdr> BreedGroupHdr { get; set; }
        public virtual DbSet<BreedMakeup> BreedMakeup { get; set; }
        public virtual DbSet<BreedMaster> BreedMaster { get; set; }
        public virtual DbSet<BreedOutsource> BreedOutsource { get; set; }
        public virtual DbSet<BreedTray> BreedTray { get; set; }
        public virtual DbSet<BreedType> BreedType { get; set; }
        public virtual DbSet<BreedsearchDetail> BreedsearchDetail { get; set; }
        public virtual DbSet<BreedsearchMaster> BreedsearchMaster { get; set; }
        public virtual DbSet<CalllistCode> CalllistCode { get; set; }
        public virtual DbSet<CartDtl> CartDtl { get; set; }
        public virtual DbSet<CartDtlAttrib> CartDtlAttrib { get; set; }
        public virtual DbSet<CartHdr> CartHdr { get; set; }
        public virtual DbSet<CodCard> CodCard { get; set; }
        public virtual DbSet<Creditcard> Creditcard { get; set; }
        public virtual DbSet<CreditcardTransaction> CreditcardTransaction { get; set; }
        public virtual DbSet<CreditcardTransactionType> CreditcardTransactionType { get; set; }
        public virtual DbSet<CustomAvailDetail> CustomAvailDetail { get; set; }
        public virtual DbSet<CustomAvailMaster> CustomAvailMaster { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerCallcode> CustomerCallcode { get; set; }
        public virtual DbSet<CustomerCalllist> CustomerCalllist { get; set; }
        public virtual DbSet<CustomerCreditcard> CustomerCreditcard { get; set; }
        public virtual DbSet<CustomerEastercall> CustomerEastercall { get; set; }
        public virtual DbSet<CustomerNote> CustomerNote { get; set; }
        public virtual DbSet<CustomerRoute> CustomerRoute { get; set; }
        public virtual DbSet<Customertype> Customertype { get; set; }
        public virtual DbSet<DrXtxt1webSearchK> DrXtxt1webSearchK { get; set; }
        public virtual DbSet<DrXtxt1webSearchN> DrXtxt1webSearchN { get; set; }
        public virtual DbSet<DropshipDtl> DropshipDtl { get; set; }
        public virtual DbSet<DropshipHdr> DropshipHdr { get; set; }
        public virtual DbSet<EasterDates> EasterDates { get; set; }
        public virtual DbSet<Eastercode> Eastercode { get; set; }
        public virtual DbSet<EdiDocument> EdiDocument { get; set; }
        public virtual DbSet<EdiInvoiceHdr> EdiInvoiceHdr { get; set; }
        public virtual DbSet<EdiPartner> EdiPartner { get; set; }
        public virtual DbSet<EdiPoDtl> EdiPoDtl { get; set; }
        public virtual DbSet<EdiPoHdr> EdiPoHdr { get; set; }
        public virtual DbSet<EdiTranslation> EdiTranslation { get; set; }
        public virtual DbSet<EmailQueue> EmailQueue { get; set; }
        public virtual DbSet<EmailQueueVars> EmailQueueVars { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplate { get; set; }
        public virtual DbSet<EmailTemplateArg> EmailTemplateArg { get; set; }
        public virtual DbSet<ErrorMessages> ErrorMessages { get; set; }
        public virtual DbSet<Hatchery> Hatchery { get; set; }
        public virtual DbSet<Hatchsessions> Hatchsessions { get; set; }
        public virtual DbSet<HundredPricing> HundredPricing { get; set; }
        public virtual DbSet<ItemGroup> ItemGroup { get; set; }
        public virtual DbSet<ItemGroupProductClass> ItemGroupProductClass { get; set; }
        public virtual DbSet<MemoDtl> MemoDtl { get; set; }
        public virtual DbSet<MemoHdr> MemoHdr { get; set; }
        public virtual DbSet<MemoReason> MemoReason { get; set; }
        public virtual DbSet<MemoStatus> MemoStatus { get; set; }
        public virtual DbSet<Offset> Offset { get; set; }
        public virtual DbSet<Offsetcode> Offsetcode { get; set; }
        public virtual DbSet<OrderHdr> OrderHdr { get; set; }
        public virtual DbSet<OrderType> OrderType { get; set; }
        public virtual DbSet<PaymentDtl> PaymentDtl { get; set; }
        public virtual DbSet<PaymentHdr> PaymentHdr { get; set; }
        public virtual DbSet<PaymentSession> PaymentSession { get; set; }
        public virtual DbSet<Paymentterm> Paymentterm { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PostalWeight> PostalWeight { get; set; }
        public virtual DbSet<Postalcode> Postalcode { get; set; }
        public virtual DbSet<PostalcodeCharge> PostalcodeCharge { get; set; }
        public virtual DbSet<Pricesheet> Pricesheet { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductBreakpoint> ProductBreakpoint { get; set; }
        public virtual DbSet<ProductBreed> ProductBreed { get; set; }
        public virtual DbSet<ProductBreedProduct> ProductBreedProduct { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<ProductClass> ProductClass { get; set; }
        public virtual DbSet<ProductClassCategory> ProductClassCategory { get; set; }
        public virtual DbSet<ProductClassMember> ProductClassMember { get; set; }
        public virtual DbSet<ProductPricedate> ProductPricedate { get; set; }
        public virtual DbSet<ProductPricing> ProductPricing { get; set; }
        public virtual DbSet<ProductSoldout> ProductSoldout { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<Productcolor> Productcolor { get; set; }
        public virtual DbSet<QEmail> QEmail { get; set; }
        public virtual DbSet<Rolodex> Rolodex { get; set; }
        public virtual DbSet<RolodexType> RolodexType { get; set; }
        public virtual DbSet<Route> Route { get; set; }
        public virtual DbSet<Sessions> Sessions { get; set; }
        public virtual DbSet<ShipdayCode> ShipdayCode { get; set; }
        public virtual DbSet<ShipdayDtl> ShipdayDtl { get; set; }
        public virtual DbSet<ShipdayHdr> ShipdayHdr { get; set; }
        public virtual DbSet<ShipdayRoute> ShipdayRoute { get; set; }
        public virtual DbSet<ShippingLocation> ShippingLocation { get; set; }
        public virtual DbSet<ShippingTruck> ShippingTruck { get; set; }
        public virtual DbSet<ShippingZone> ShippingZone { get; set; }
        public virtual DbSet<SoldOut> SoldOut { get; set; }
        public virtual DbSet<SpecialInstruction> SpecialInstruction { get; set; }
        public virtual DbSet<SpecialService> SpecialService { get; set; }
        public virtual DbSet<Specials> Specials { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Suborder> Suborder { get; set; }
        public virtual DbSet<SuborderDtl> SuborderDtl { get; set; }
        public virtual DbSet<SuggestiveSell> SuggestiveSell { get; set; }
        public virtual DbSet<TempBreedAvailability> TempBreedAvailability { get; set; }
        public virtual DbSet<TempLob> TempLob { get; set; }
        public virtual DbSet<Waitlist> Waitlist { get; set; }
        public virtual DbSet<WebAccount> WebAccount { get; set; }
        public virtual DbSet<WebAccountAddress> WebAccountAddress { get; set; }
        public virtual DbSet<WebAddress> WebAddress { get; set; }
        public virtual DbSet<WebAttr> WebAttr { get; set; }
        public virtual DbSet<WebAttrDtl> WebAttrDtl { get; set; }
        public virtual DbSet<WebAttrGroup> WebAttrGroup { get; set; }
        public virtual DbSet<WebAttrGroupDtl> WebAttrGroupDtl { get; set; }
        public virtual DbSet<WebAvailability> WebAvailability { get; set; }
        public virtual DbSet<WebBlackout> WebBlackout { get; set; }
        public virtual DbSet<WebBreed> WebBreed { get; set; }
        public virtual DbSet<WebBreedItem> WebBreedItem { get; set; }
        public virtual DbSet<WebCart> WebCart { get; set; }
        public virtual DbSet<WebCartDtl> WebCartDtl { get; set; }
        public virtual DbSet<WebCartDtlAttr> WebCartDtlAttr { get; set; }
        public virtual DbSet<WebCategory> WebCategory { get; set; }
        public virtual DbSet<WebCategoryBreed> WebCategoryBreed { get; set; }
        public virtual DbSet<WebDescriptionFlag> WebDescriptionFlag { get; set; }
        public virtual DbSet<WebFaq> WebFaq { get; set; }
        public virtual DbSet<WebImage> WebImage { get; set; }
        public virtual DbSet<WebItem> WebItem { get; set; }
        public virtual DbSet<WebItemDescription> WebItemDescription { get; set; }
        public virtual DbSet<WebItemProduct> WebItemProduct { get; set; }
        public virtual DbSet<WebOrderDtl> WebOrderDtl { get; set; }
        public virtual DbSet<WebOrderDtlAttr> WebOrderDtlAttr { get; set; }
        public virtual DbSet<WebOrderHdr> WebOrderHdr { get; set; }
        public virtual DbSet<WebOrderMaster> WebOrderMaster { get; set; }
        public virtual DbSet<WebPreview> WebPreview { get; set; }
        public virtual DbSet<WebPreviewDtl> WebPreviewDtl { get; set; }
        public virtual DbSet<WebSearch> WebSearch { get; set; }
        public virtual DbSet<WebSeason> WebSeason { get; set; }
        public virtual DbSet<WebSession> WebSession { get; set; }
        public virtual DbSet<WebShippingInfo> WebShippingInfo { get; set; }
        public virtual DbSet<WebSoldout> WebSoldout { get; set; }
        public virtual DbSet<WebSpecial> WebSpecial { get; set; }
        public virtual DbSet<WebSpecialService> WebSpecialService { get; set; }
        public virtual DbSet<WebSpecials> WebSpecials { get; set; }
        public virtual DbSet<WebSuggestiveSell> WebSuggestiveSell { get; set; }
        public virtual DbSet<WebToken> WebToken { get; set; }
        public virtual DbSet<WebWaitlist> WebWaitlist { get; set; }
        public virtual DbSet<ZipImport> ZipImport { get; set; }
        public virtual DbSet<Zipcode> Zipcode { get; set; }

        // Unable to generate entity type for table 'IDEALADM.PLAN_TABLE'. Please see the warning messages.
        // Unable to generate entity type for table 'IDEALADM.SHIPPING_CHARGE'. Please see the warning messages.
        // Unable to generate entity type for table 'IDEALADM.SUBORDER_INSTRUCTION'. Please see the warning messages.
        // Unable to generate entity type for table 'IDEALADM.SUBORDER_SERVICE'. Please see the warning messages.
        // Unable to generate entity type for table 'IDEALADM.HATCHERY_SETTINGS'. Please see the warning messages.
        // Unable to generate entity type for table 'IDEALADM.PRODUCT_CATEGORY_BREED'. Please see the warning messages.
        // Unable to generate entity type for table 'IDEALADM.AUDIT_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'IDEALADM.BREED_GROUP_DTL'. Please see the warning messages.
        // Unable to generate entity type for table 'IDEALADM.JSON_TEST'. Please see the warning messages.
        // Unable to generate entity type for table 'IDEALADM.COD_CHARGE'. Please see the warning messages.
        // Unable to generate entity type for table 'IDEALADM.EXTERNAL_CHAT'. Please see the warning messages.
        // Unable to generate entity type for table 'IDEALADM.INSURANCE_CHARGE'. Please see the warning messages.
        // Unable to generate entity type for table 'IDEALADM.TEMP_REPORT'. Please see the warning messages.
        // Unable to generate entity type for table 'IDEALADM.TEMP_VALUE'. Please see the warning messages.
        // Unable to generate entity type for table 'IDEALADM.TEMP_DROPSHIP'. Please see the warning messages.
        // Unable to generate entity type for table 'IDEALADM.TEMP_AVAILABILITY'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:DefaultSchema", "IDEALADM");

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.ToTable("ACTIVITY");

                entity.HasIndex(e => e.ActivityId)
                    .HasName("PK_ACTIVITY_HDR")
                    .IsUnique();

                entity.HasIndex(e => e.ActivitySessionId)
                    .HasName("NDX_ACTIVITY_4");

                entity.HasIndex(e => e.ActivityTypeId)
                    .HasName("NDX_ACTIVITY_ACTTYPE");

                entity.HasIndex(e => e.BillingId)
                    .HasName("NDX_ACTIVITY_BILLING");

                entity.HasIndex(e => e.OrderId)
                    .HasName("NDX_ACTIVITY_ORDERHDR")
                    .IsUnique();

                entity.Property(e => e.ActivityId)
                    .HasColumnName("ACTIVITY_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActivityDate)
                    .HasColumnName("ACTIVITY_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActivitySessionId)
                    .HasColumnName("ACTIVITY_SESSION_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActivityTypeId)
                    .HasColumnName("ACTIVITY_TYPE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("NUMBER(38,2)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BillingId)
                    .HasColumnName("BILLING_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CheckNumber)
                    .HasColumnName("CHECK_NUMBER")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EntryType)
                    .IsRequired()
                    .HasColumnName("ENTRY_TYPE")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("INVOICE_NUMBER")
                    .HasColumnType("VARCHAR2(10)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsPosted)
                    .IsRequired()
                    .HasColumnName("IS_POSTED")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrderId)
                    .HasColumnName("ORDER_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PoNumber)
                    .HasColumnName("PO_NUMBER")
                    .HasColumnType("VARCHAR2(15)")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.ActivitySession)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.ActivitySessionId)
                    .HasConstraintName("FK_ACTIVITY_4");

                entity.HasOne(d => d.ActivityType)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.ActivityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACTIVITY2ACTTYPE");

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.BillingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACTIVITY2CUSTOMER");

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.Activity)
                    .HasForeignKey<Activity>(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ACTIVITY2ORDERHDR");
            });

            modelBuilder.Entity<ActivityDtl>(entity =>
            {
                entity.ToTable("ACTIVITY_DTL");

                entity.HasIndex(e => e.ActivityDtlId)
                    .HasName("PK_ACTIVITY_DTL")
                    .IsUnique();

                entity.HasIndex(e => e.ActivityId)
                    .HasName("NDX_ACTIVITYDTL2ACTIVITY");

                entity.HasIndex(e => e.OrderId)
                    .HasName("NDX_ACTIVITYDTL2ORDER");

                entity.HasIndex(e => new { e.ActivityId, e.OrderId })
                    .HasName("NDX_ACTIVITYDTL1")
                    .IsUnique();

                entity.Property(e => e.ActivityDtlId)
                    .HasColumnName("ACTIVITY_DTL_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActivityId)
                    .HasColumnName("ACTIVITY_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("NUMBER(38,2)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrderId)
                    .HasColumnName("ORDER_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityDtl)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_ACTIVITYDTL2ACTIVITY");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ActivityDtl)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_ACTIVITYDTL2ORDER");
            });

            modelBuilder.Entity<ActivitySession>(entity =>
            {
                entity.ToTable("ACTIVITY_SESSION");

                entity.HasIndex(e => e.ActivitySessionId)
                    .HasName("PK_ACTIVITY_SESSION")
                    .IsUnique();

                entity.HasIndex(e => e.PersonId)
                    .HasName("NDX_ACTIVITY_SESSION_1");

                entity.Property(e => e.ActivitySessionId)
                    .HasColumnName("ACTIVITY_SESSION_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CREATION_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PersonId)
                    .HasColumnName("PERSON_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PostDate)
                    .HasColumnName("POST_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SessionType)
                    .IsRequired()
                    .HasColumnName("SESSION_TYPE")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.ActivitySession)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACTIVITY_SESSION_1");
            });

            modelBuilder.Entity<ActivityType>(entity =>
            {
                entity.ToTable("ACTIVITY_TYPE");

                entity.HasIndex(e => e.ActivityTypeId)
                    .HasName("PK_ACTIVITY_TYPE")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_ACTIVITYTYPE_DESC");

                entity.Property(e => e.ActivityTypeId)
                    .HasColumnName("ACTIVITY_TYPE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EntryType)
                    .IsRequired()
                    .HasColumnName("ENTRY_TYPE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("IS_ACTIVE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.IsCodInvoice)
                    .IsRequired()
                    .HasColumnName("IS_COD_INVOICE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IsCreditCardAuthorization)
                    .IsRequired()
                    .HasColumnName("IS_CREDIT_CARD_AUTHORIZATION")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.IsCreditCardInvoice)
                    .IsRequired()
                    .HasColumnName("IS_CREDIT_CARD_INVOICE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IsCreditCardPayment)
                    .IsRequired()
                    .HasColumnName("IS_CREDIT_CARD_PAYMENT")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.IsCreditCardRefund)
                    .IsRequired()
                    .HasColumnName("IS_CREDIT_CARD_REFUND")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.IsFinanceCharge)
                    .IsRequired()
                    .HasColumnName("IS_FINANCE_CHARGE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IsInvoice)
                    .IsRequired()
                    .HasColumnName("IS_INVOICE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IsMemo)
                    .IsRequired()
                    .HasColumnName("IS_MEMO")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IsStandardInvoice)
                    .IsRequired()
                    .HasColumnName("IS_STANDARD_INVOICE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.MenuOrder)
                    .HasColumnName("MENU_ORDER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.MenuPrompt)
                    .HasColumnName("MENU_PROMPT")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.PostToCurrentActivity)
                    .IsRequired()
                    .HasColumnName("POST_TO_CURRENT_ACTIVITY")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.PrintReceipt)
                    .IsRequired()
                    .HasColumnName("PRINT_RECEIPT")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");
            });

            modelBuilder.Entity<AttribDtl>(entity =>
            {
                entity.ToTable("ATTRIB_DTL");

                entity.HasIndex(e => e.AttribDtlId)
                    .HasName("PK_ATTRIB_DTL")
                    .IsUnique();

                entity.HasIndex(e => e.AttribHdrId)
                    .HasName("NDX_ATTRIB_DTL_01");

                entity.HasIndex(e => e.SpecialServiceId)
                    .HasName("NDX_ATTRIB_DTL_02");

                entity.HasIndex(e => new { e.AttribHdrId, e.Code })
                    .HasName("UK_ATTRIB_DTL_02")
                    .IsUnique();

                entity.HasIndex(e => new { e.AttribHdrId, e.SortOrder })
                    .HasName("UK_ATTRIB_DTL_01")
                    .IsUnique();

                entity.Property(e => e.AttribDtlId)
                    .HasColumnName("ATTRIB_DTL_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AttribHdrId)
                    .HasColumnName("ATTRIB_HDR_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.PriceModifier)
                    .HasColumnName("PRICE_MODIFIER")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SpecialServiceId)
                    .HasColumnName("SPECIAL_SERVICE_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.SpecialService)
                    .WithMany(p => p.AttribDtl)
                    .HasForeignKey(d => d.SpecialServiceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ATTRIB_DTL_02");
            });

            modelBuilder.Entity<AttribGroupDtl>(entity =>
            {
                entity.ToTable("ATTRIB_GROUP_DTL");

                entity.HasIndex(e => e.AttribGroupDtlId)
                    .HasName("PK_ATTRIB_GROUP_DTL")
                    .IsUnique();

                entity.HasIndex(e => e.AttribGroupHdrId)
                    .HasName("NDX_ATTRIB_GROUP_DTL_01");

                entity.HasIndex(e => e.AttribHdrId)
                    .HasName("NDX_ATTRIB_GROUP_DTL_02");

                entity.Property(e => e.AttribGroupDtlId)
                    .HasColumnName("ATTRIB_GROUP_DTL_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AllowMultipleEntires)
                    .IsRequired()
                    .HasColumnName("ALLOW_MULTIPLE_ENTIRES")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.AttribGroupHdrId)
                    .HasColumnName("ATTRIB_GROUP_HDR_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.AttribHdrId)
                    .HasColumnName("ATTRIB_HDR_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.IsRequired)
                    .IsRequired()
                    .HasColumnName("IS_REQUIRED")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.Orientation)
                    .IsRequired()
                    .HasColumnName("ORIENTATION")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'V' ");

                entity.Property(e => e.PresentationType)
                    .IsRequired()
                    .HasColumnName("PRESENTATION_TYPE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'D' ");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.AttribGroupHdr)
                    .WithMany(p => p.AttribGroupDtl)
                    .HasForeignKey(d => d.AttribGroupHdrId)
                    .HasConstraintName("FK_ATTRIB_GROUP_DTL_01");

                entity.HasOne(d => d.AttribHdr)
                    .WithMany(p => p.AttribGroupDtl)
                    .HasForeignKey(d => d.AttribHdrId)
                    .HasConstraintName("FK_ATTRIB_GROUP_DTL_02");
            });

            modelBuilder.Entity<AttribGroupHdr>(entity =>
            {
                entity.ToTable("ATTRIB_GROUP_HDR");

                entity.HasIndex(e => e.AttribGroupHdrId)
                    .HasName("PK_ATTRIB_GOUP_HDR")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_ATTRIB_GROUP_HDR_01")
                    .IsUnique();

                entity.Property(e => e.AttribGroupHdrId)
                    .HasColumnName("ATTRIB_GROUP_HDR_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)");
            });

            modelBuilder.Entity<AttribHdr>(entity =>
            {
                entity.ToTable("ATTRIB_HDR");

                entity.HasIndex(e => e.AttribHdrId)
                    .HasName("PK_ATTRIB")
                    .IsUnique();

                entity.HasIndex(e => e.Code)
                    .HasName("UK_ATTRIB_01")
                    .IsUnique();

                entity.Property(e => e.AttribHdrId)
                    .HasColumnName("ATTRIB_HDR_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(10)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(80)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasColumnName("DISPLAY_NAME")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.EditPrompt)
                    .HasColumnName("EDIT_PROMPT")
                    .HasColumnType("VARCHAR2(200)");
            });

            modelBuilder.Entity<Availability>(entity =>
            {
                entity.ToTable("AVAILABILITY");

                entity.HasIndex(e => e.AvailabilityId)
                    .HasName("PK_AVAILABILITY_ID")
                    .IsUnique();

                entity.HasIndex(e => e.ProductId)
                    .HasName("NDX_AVAILABILITY_PRODUCTID");

                entity.HasIndex(e => new { e.ShipDate, e.ProductId })
                    .HasName("NDX_AVAIL_DATE_PRODUCT")
                    .IsUnique();

                entity.Property(e => e.AvailabilityId)
                    .HasColumnName("AVAILABILITY_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BalutChicks)
                    .HasColumnName("BALUT_CHICKS")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.BalutTrays)
                    .HasColumnName("BALUT_TRAYS")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Chicks)
                    .HasColumnName("CHICKS")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Eggs)
                    .HasColumnName("EGGS")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.EggsInTray1)
                    .HasColumnName("EGGS_IN_TRAY1")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.EggsInTray2)
                    .HasColumnName("EGGS_IN_TRAY2")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.EggsYield)
                    .HasColumnName("EGGS_YIELD")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.NumberOfTray1)
                    .HasColumnName("NUMBER_OF_TRAY1")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.NumberOfTray2)
                    .HasColumnName("NUMBER_OF_TRAY2")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ShipDate)
                    .HasColumnName("SHIP_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.YieldTray1)
                    .HasColumnName("YIELD_TRAY1")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.YieldTray2)
                    .HasColumnName("YIELD_TRAY2")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Availability)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AVAILABILITY2PRODUCT");
            });

            modelBuilder.Entity<AvailabilityOutsource>(entity =>
            {
                entity.HasKey(e => new { e.AvailabilityId, e.Source })
                    .HasName("PK_AVAIL_OUTSOURCE");

                entity.ToTable("AVAILABILITY_OUTSOURCE");

                entity.HasIndex(e => e.AvailabilityId)
                    .HasName("NDX_OUTSRC_AVAILABILITY");

                entity.HasIndex(e => new { e.AvailabilityId, e.Source })
                    .HasName("PK_AVAIL_OUTSOURCE")
                    .IsUnique();

                entity.Property(e => e.AvailabilityId)
                    .HasColumnName("AVAILABILITY_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Source)
                    .HasColumnName("SOURCE")
                    .HasColumnType("VARCHAR2(2)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Quantity)
                    .HasColumnName("QUANTITY")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Availability)
                    .WithMany(p => p.AvailabilityOutsource)
                    .HasForeignKey(d => d.AvailabilityId)
                    .HasConstraintName("FK_AVLOUTSRC2AVAIL");
            });

            modelBuilder.Entity<BoxDtl>(entity =>
            {
                entity.ToTable("BOX_DTL");

                entity.HasIndex(e => e.BoxDtlId)
                    .HasName("PK_BOX_DTL")
                    .IsUnique();

                entity.HasIndex(e => e.BoxId)
                    .HasName("NDX_BOXDTL_BOXID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("NDX_BOXDTL_PRODUCT");

                entity.Property(e => e.BoxDtlId)
                    .HasColumnName("BOX_DTL_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BoxId)
                    .HasColumnName("BOX_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Quantity)
                    .HasColumnName("QUANTITY")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SpecialServicesString)
                    .HasColumnName("SPECIAL_SERVICES_STRING")
                    .HasColumnType("VARCHAR2(30)");

                entity.HasOne(d => d.Box)
                    .WithMany(p => p.BoxDtl)
                    .HasForeignKey(d => d.BoxId)
                    .HasConstraintName("FK_BOXDTL2BOX");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BoxDtl)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BOXDTL2PRODUCT");
            });

            modelBuilder.Entity<BoxHdr>(entity =>
            {
                entity.HasKey(e => e.BoxId)
                    .HasName("XPKBOX");

                entity.ToTable("BOX_HDR");

                entity.HasIndex(e => e.BoxId)
                    .HasName("XPKBOX")
                    .IsUnique();

                entity.HasIndex(e => e.OutsourceId)
                    .HasName("NDX_BOXHDR2");

                entity.HasIndex(e => e.SuborderId)
                    .HasName("NDX_BOXHDR_SUBORDER");

                entity.HasIndex(e => new { e.BoxId, e.SuborderId })
                    .HasName("NDX_BOXHDR_IF1");

                entity.HasIndex(e => new { e.SuborderId, e.Sequence })
                    .HasName("XIF1BOX")
                    .IsUnique();

                entity.Property(e => e.BoxId)
                    .HasColumnName("BOX_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BoxWeight)
                    .HasColumnName("BOX_WEIGHT")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.BundleId)
                    .HasColumnName("BUNDLE_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.OutsourceId)
                    .HasColumnName("OUTSOURCE_ID")
                    .HasColumnType("VARCHAR2(2)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PrintShippingLabel)
                    .IsRequired()
                    .HasColumnName("PRINT_SHIPPING_LABEL")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("null ");

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SuborderId)
                    .HasColumnName("SUBORDER_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TrackingInfo)
                    .HasColumnName("TRACKING_INFO")
                    .HasColumnType("VARCHAR2(30)");

                entity.HasOne(d => d.Suborder)
                    .WithMany(p => p.BoxHdr)
                    .HasForeignKey(d => d.SuborderId)
                    .HasConstraintName("XIE1BOX");
            });

            modelBuilder.Entity<Breed>(entity =>
            {
                entity.ToTable("BREED");

                entity.HasIndex(e => e.AttribGroupHdrId)
                    .HasName("NDX_BREED_04");

                entity.HasIndex(e => e.BreedId)
                    .HasName("PK_BREED")
                    .IsUnique();

                entity.HasIndex(e => e.BreedTypeId)
                    .HasName("NDX_BREED_05");

                entity.HasIndex(e => e.Code)
                    .HasName("UK_BREED_01")
                    .IsUnique();

                entity.HasIndex(e => e.OffsetId)
                    .HasName("NDX_BREED_03");

                entity.HasIndex(e => e.PostalcodeId)
                    .HasName("NDX_BREED_02");

                entity.HasIndex(e => e.ShipdayCodeId)
                    .HasName("NDX_BREED_01");

                entity.Property(e => e.BreedId)
                    .HasColumnName("BREED_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AttribGroupHdrId)
                    .HasColumnName("ATTRIB_GROUP_HDR_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.AvailMaleFactor)
                    .HasColumnName("AVAIL_MALE_FACTOR")
                    .HasColumnType("NUMBER(2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AvailPulletFactor)
                    .HasColumnName("AVAIL_PULLET_FACTOR")
                    .HasColumnType("NUMBER(2)")
                    .HasDefaultValueSql("2 ");

                entity.Property(e => e.AvailStraightRunFactor)
                    .HasColumnName("AVAIL_STRAIGHT_RUN_FACTOR")
                    .HasColumnType("NUMBER(2)")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.BreedTypeId)
                    .HasColumnName("BREED_TYPE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.CheckAvailability)
                    .IsRequired()
                    .HasColumnName("CHECK_AVAILABILITY")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(5)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.DropShipOnly)
                    .IsRequired()
                    .HasColumnName("DROP_SHIP_ONLY")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.HighlightOnReport)
                    .IsRequired()
                    .HasColumnName("HIGHLIGHT_ON_REPORT")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.Inactive)
                    .IsRequired()
                    .HasColumnName("INACTIVE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.IsTotalOnly)
                    .IsRequired()
                    .HasColumnName("IS_TOTAL_ONLY")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.MinimumOrderQuantity)
                    .HasColumnName("MINIMUM_ORDER_QUANTITY")
                    .HasColumnType("NUMBER(4)")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.OffsetId)
                    .HasColumnName("OFFSET_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PostalcodeId)
                    .HasColumnName("POSTALCODE_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ShipdayCodeId)
                    .HasColumnName("SHIPDAY_CODE_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ShowInAvailability)
                    .IsRequired()
                    .HasColumnName("SHOW_IN_AVAILABILITY")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.ShowOnWeb)
                    .IsRequired()
                    .HasColumnName("SHOW_ON_WEB")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER(4)")
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.AttribGroupHdr)
                    .WithMany(p => p.Breed)
                    .HasForeignKey(d => d.AttribGroupHdrId)
                    .HasConstraintName("FK_BREED_04");

                entity.HasOne(d => d.BreedType)
                    .WithMany(p => p.Breed)
                    .HasForeignKey(d => d.BreedTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BREED_05");

                entity.HasOne(d => d.Offset)
                    .WithMany(p => p.Breed)
                    .HasForeignKey(d => d.OffsetId)
                    .HasConstraintName("FK_BREED_03");

                entity.HasOne(d => d.Postalcode)
                    .WithMany(p => p.Breed)
                    .HasForeignKey(d => d.PostalcodeId)
                    .HasConstraintName("FK_BREED_02");

                entity.HasOne(d => d.ShipdayCode)
                    .WithMany(p => p.Breed)
                    .HasForeignKey(d => d.ShipdayCodeId)
                    .HasConstraintName("FK_BREED_01");
            });

            modelBuilder.Entity<BreedAttribute>(entity =>
            {
                entity.ToTable("BREED_ATTRIBUTE");

                entity.HasIndex(e => e.BreedAttributeId)
                    .HasName("PK_BREED_ATTRIBUTE")
                    .IsUnique();

                entity.HasIndex(e => e.BreedAttributeTypeId)
                    .HasName("NDX_BREED_ATTRIBUTE_01");

                entity.HasIndex(e => new { e.BreedAttributeTypeId, e.Value })
                    .HasName("UK_BREED_ATTRIBUTE_01")
                    .IsUnique();

                entity.Property(e => e.BreedAttributeId)
                    .HasColumnName("BREED_ATTRIBUTE_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BreedAttributeTypeId)
                    .HasColumnName("BREED_ATTRIBUTE_TYPE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER(2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("VALUE")
                    .HasColumnType("VARCHAR2(255)");

                entity.HasOne(d => d.BreedAttributeType)
                    .WithMany(p => p.BreedAttribute)
                    .HasForeignKey(d => d.BreedAttributeTypeId)
                    .HasConstraintName("FK_BREED_ATTRIBUTE_01");
            });

            modelBuilder.Entity<BreedAttributeDtl>(entity =>
            {
                entity.HasKey(e => new { e.BreedId, e.BreedAttributeId });

                entity.ToTable("BREED_ATTRIBUTE_DTL");

                entity.HasIndex(e => e.BreedAttributeId)
                    .HasName("NDX_BREED_ATTRIBUTE_DTL_02");

                entity.HasIndex(e => e.BreedId)
                    .HasName("NDX_BREED_ATTRIBUTE_DTL_01");

                entity.HasIndex(e => new { e.BreedId, e.BreedAttributeId })
                    .HasName("PK_BREED_ATTRIBUTE_DTL")
                    .IsUnique();

                entity.Property(e => e.BreedId)
                    .HasColumnName("BREED_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.BreedAttributeId)
                    .HasColumnName("BREED_ATTRIBUTE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.HasOne(d => d.BreedAttribute)
                    .WithMany(p => p.BreedAttributeDtl)
                    .HasForeignKey(d => d.BreedAttributeId)
                    .HasConstraintName("FK_BREED_ATTRIBUTE_DTL_02");

                entity.HasOne(d => d.Breed)
                    .WithMany(p => p.BreedAttributeDtl)
                    .HasForeignKey(d => d.BreedId)
                    .HasConstraintName("FK_BREED_ATTRIBUTE_DTL_01");
            });

            modelBuilder.Entity<BreedAttributeType>(entity =>
            {
                entity.ToTable("BREED_ATTRIBUTE_TYPE");

                entity.HasIndex(e => e.BreedAttributeTypeId)
                    .HasName("PK_BREED_ATTRIBUTE_TYPE")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_BREED_ATTRIBUTE_TYPE_01");

                entity.Property(e => e.BreedAttributeTypeId)
                    .HasColumnName("BREED_ATTRIBUTE_TYPE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.ShowAsAttribute)
                    .IsRequired()
                    .HasColumnName("SHOW_AS_ATTRIBUTE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.ShowAttributeName)
                    .IsRequired()
                    .HasColumnName("SHOW_ATTRIBUTE_NAME")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER(2)")
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<BreedAvailability>(entity =>
            {
                entity.ToTable("BREED_AVAILABILITY");

                entity.HasIndex(e => e.BreedAvailabilityId)
                    .HasName("PK_BREED_AVAILABILITY")
                    .IsUnique();

                entity.HasIndex(e => e.BreedId)
                    .HasName("NDX_BREED_AVAILABILITY_01");

                entity.HasIndex(e => new { e.ShipDate, e.BreedId })
                    .HasName("UK_BREED_AVAILABILITY_01")
                    .IsUnique();

                entity.Property(e => e.BreedAvailabilityId)
                    .HasColumnName("BREED_AVAILABILITY_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BalutChickCount)
                    .HasColumnName("BALUT_CHICK_COUNT")
                    .HasColumnType("NUMBER(6)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedId)
                    .HasColumnName("BREED_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.NonsexableChickCount)
                    .HasColumnName("NONSEXABLE_CHICK_COUNT")
                    .HasColumnType("NUMBER(6)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.NonsexableEggCount)
                    .HasColumnName("NONSEXABLE_EGG_COUNT")
                    .HasColumnType("NUMBER(6)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.NonsexableEggYield)
                    .HasColumnName("NONSEXABLE_EGG_YIELD")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.SexableChickCount)
                    .HasColumnName("SEXABLE_CHICK_COUNT")
                    .HasColumnType("NUMBER(6)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.SexableEggCount)
                    .HasColumnName("SEXABLE_EGG_COUNT")
                    .HasColumnType("NUMBER(6)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.SexableEggYield)
                    .HasColumnName("SEXABLE_EGG_YIELD")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ShipDate)
                    .HasColumnName("SHIP_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<BreedDescription>(entity =>
            {
                entity.ToTable("BREED_DESCRIPTION");

                entity.HasIndex(e => e.BreedDescriptionId)
                    .HasName("PK_BREED_DESCRIPTION")
                    .IsUnique();

                entity.HasIndex(e => e.BreedId)
                    .HasName("NDX_BREED_DESCRIPTION_1");

                entity.HasIndex(e => new { e.DescriptionType, e.BreedId, e.Sequence })
                    .HasName("UK_BREED_DESCRIPTION_1")
                    .IsUnique();

                entity.HasIndex(e => new { e.Sequence, e.BreedId, e.DescriptionType })
                    .HasName("UK_BREED_DESCRIPTION_1")
                    .IsUnique();

                entity.Property(e => e.BreedDescriptionId)
                    .HasColumnName("BREED_DESCRIPTION_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BreedId)
                    .HasColumnName("BREED_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.DescriptionType)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION_TYPE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Flags)
                    .HasColumnName("FLAGS")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("TEXT")
                    .HasColumnType("CLOB");

                entity.HasOne(d => d.Breed)
                    .WithMany(p => p.BreedDescription)
                    .HasForeignKey(d => d.BreedId)
                    .HasConstraintName("FK_BREED_DESCRIPTION_1");
            });

            modelBuilder.Entity<BreedGroupHdr>(entity =>
            {
                entity.HasKey(e => e.BreedGroupId);

                entity.ToTable("BREED_GROUP_HDR");

                entity.HasIndex(e => e.BreedGroupId)
                    .HasName("PK_BREED_GROUP_HDR")
                    .IsUnique();

                entity.Property(e => e.BreedGroupId)
                    .HasColumnName("BREED_GROUP_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(40)");
            });

            modelBuilder.Entity<BreedMakeup>(entity =>
            {
                entity.HasKey(e => new { e.BreedId, e.MemberBreedId });

                entity.ToTable("BREED_MAKEUP");

                entity.HasIndex(e => e.BreedId)
                    .HasName("NDX_BREED_MAKEUP_02");

                entity.HasIndex(e => e.MemberBreedId)
                    .HasName("NDX_BREED_MAKEUP_01");

                entity.HasIndex(e => new { e.BreedId, e.MemberBreedId })
                    .HasName("PK_BREED_MAKEUP")
                    .IsUnique();

                entity.Property(e => e.BreedId)
                    .HasColumnName("BREED_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.MemberBreedId)
                    .HasColumnName("MEMBER_BREED_ID")
                    .HasColumnType("NUMBER(38)");

                entity.HasOne(d => d.Breed)
                    .WithMany(p => p.BreedMakeupBreed)
                    .HasForeignKey(d => d.BreedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BREED_MAKEUP_01");

                entity.HasOne(d => d.MemberBreed)
                    .WithMany(p => p.BreedMakeupMemberBreed)
                    .HasForeignKey(d => d.MemberBreedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BREED_MAKEUP_02");
            });

            modelBuilder.Entity<BreedMaster>(entity =>
            {
                entity.HasKey(e => new { e.BreedId, e.MasterBreedId });

                entity.ToTable("BREED_MASTER");

                entity.HasIndex(e => e.BreedId)
                    .HasName("NDX_BREED_MASTER_01");

                entity.HasIndex(e => e.MasterBreedId)
                    .HasName("NDX_BREED_MASTER_02");

                entity.HasIndex(e => new { e.BreedId, e.MasterBreedId })
                    .HasName("PK_BREED_MASTER")
                    .IsUnique();

                entity.Property(e => e.BreedId)
                    .HasColumnName("BREED_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.MasterBreedId)
                    .HasColumnName("MASTER_BREED_ID")
                    .HasColumnType("NUMBER(38)");

                entity.HasOne(d => d.Breed)
                    .WithMany(p => p.BreedMasterBreed)
                    .HasForeignKey(d => d.BreedId)
                    .HasConstraintName("FK_BREED_MASTER_01");

                entity.HasOne(d => d.MasterBreed)
                    .WithMany(p => p.BreedMasterMasterBreed)
                    .HasForeignKey(d => d.MasterBreedId)
                    .HasConstraintName("FK_BREED_MASTER_02");
            });

            modelBuilder.Entity<BreedOutsource>(entity =>
            {
                entity.HasKey(e => new { e.BreedAvailabilityId, e.Source, e.Sexable });

                entity.ToTable("BREED_OUTSOURCE");

                entity.HasIndex(e => e.BreedAvailabilityId)
                    .HasName("NDX_BREED_OUTSOURCE");

                entity.HasIndex(e => new { e.Sexable, e.BreedAvailabilityId, e.Source })
                    .HasName("PK_BREED_OUTSOURCE")
                    .IsUnique();

                entity.Property(e => e.BreedAvailabilityId)
                    .HasColumnName("BREED_AVAILABILITY_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Source)
                    .HasColumnName("SOURCE")
                    .HasColumnType("VARCHAR2(2)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Sexable)
                    .HasColumnName("SEXABLE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("QUANTITY")
                    .HasColumnType("NUMBER(6)");
            });

            modelBuilder.Entity<BreedTray>(entity =>
            {
                entity.ToTable("BREED_TRAY");

                entity.HasIndex(e => e.BreedAvailabilityId)
                    .HasName("NDX_BREED_TRAY");

                entity.HasIndex(e => e.BreedTrayId)
                    .HasName("PK_BREED_TRAY")
                    .IsUnique();

                entity.Property(e => e.BreedTrayId)
                    .HasColumnName("BREED_TRAY_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BreedAvailabilityId)
                    .HasColumnName("BREED_AVAILABILITY_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.EggsInTray)
                    .HasColumnName("EGGS_IN_TRAY")
                    .HasColumnType("NUMBER(4)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.NumberOfTrays)
                    .HasColumnName("NUMBER_OF_TRAYS")
                    .HasColumnType("NUMBER(6,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Sexable)
                    .IsRequired()
                    .HasColumnName("SEXABLE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Yield)
                    .HasColumnName("YIELD")
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.BreedAvailability)
                    .WithMany(p => p.BreedTray)
                    .HasForeignKey(d => d.BreedAvailabilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BREED_TRAY_01");
            });

            modelBuilder.Entity<BreedType>(entity =>
            {
                entity.ToTable("BREED_TYPE");

                entity.HasIndex(e => e.BreedTypeId)
                    .HasName("PK_BREED_TYPE")
                    .IsUnique();

                entity.Property(e => e.BreedTypeId)
                    .HasColumnName("BREED_TYPE_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AllowWebSearch)
                    .IsRequired()
                    .HasColumnName("ALLOW_WEB_SEARCH")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.ErrorPrompt)
                    .IsRequired()
                    .HasColumnName("ERROR_PROMPT")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.IsPoultryItem)
                    .IsRequired()
                    .HasColumnName("IS_POULTRY_ITEM")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.MinimumOrderQuantity)
                    .HasColumnName("MINIMUM_ORDER_QUANTITY")
                    .HasColumnType("NUMBER(4)")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER(2)")
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<BreedsearchDetail>(entity =>
            {
                entity.ToTable("BREEDSEARCH_DETAIL");

                entity.HasIndex(e => e.BreedsearchDetailId)
                    .HasName("PK_BREEDSRCH_DTL_ID")
                    .IsUnique();

                entity.HasIndex(e => e.BreedsearchId)
                    .HasName("NDX_BREEDSRCH_ID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("NDX_BREEDSRCH_PRODUCT");

                entity.Property(e => e.BreedsearchDetailId)
                    .HasColumnName("BREEDSEARCH_DETAIL_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BreedsearchId)
                    .HasColumnName("BREEDSEARCH_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Breedsearch)
                    .WithMany(p => p.BreedsearchDetail)
                    .HasForeignKey(d => d.BreedsearchId)
                    .HasConstraintName("FK_BREEDSRCH_DTL_ID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BreedsearchDetail)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BREEDSRCH_DTL_PRODUCT");
            });

            modelBuilder.Entity<BreedsearchMaster>(entity =>
            {
                entity.HasKey(e => e.BreedsearchId)
                    .HasName("PK_BREEDSEARCH");

                entity.ToTable("BREEDSEARCH_MASTER");

                entity.HasIndex(e => e.BreedsearchId)
                    .HasName("PK_BREEDSEARCH")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_BREEDSEARCH_DESCRIPTION");

                entity.Property(e => e.BreedsearchId)
                    .HasColumnName("BREEDSEARCH_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)");
            });

            modelBuilder.Entity<CalllistCode>(entity =>
            {
                entity.ToTable("CALLLIST_CODE");

                entity.HasIndex(e => e.CalllistCodeId)
                    .HasName("PK_CUSTCODE")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_CUSTCODE_DESCRIPTION");

                entity.Property(e => e.CalllistCodeId)
                    .HasColumnName("CALLLIST_CODE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(2)");

                entity.Property(e => e.CustomercodeType)
                    .IsRequired()
                    .HasColumnName("CUSTOMERCODE_TYPE")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CartDtl>(entity =>
            {
                entity.ToTable("CART_DTL");

                entity.HasIndex(e => e.CartDtlId)
                    .HasName("PK_CART_DTL")
                    .IsUnique();

                entity.HasIndex(e => e.CartId)
                    .HasName("NDX_CART_DTL_01");

                entity.HasIndex(e => e.ProductId)
                    .HasName("NDX_CART_DTL_02");

                entity.Property(e => e.CartDtlId)
                    .HasColumnName("CART_DTL_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Available)
                    .IsRequired()
                    .HasColumnName("AVAILABLE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.CartId)
                    .HasColumnName("CART_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("NUMBER(38,2)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("QUANTITY")
                    .HasColumnType("NUMBER(38,2)");

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.CartDtl)
                    .HasForeignKey(d => d.CartId)
                    .HasConstraintName("FK_CART_DTL_01");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CartDtl)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CART_DTL_02");
            });

            modelBuilder.Entity<CartDtlAttrib>(entity =>
            {
                entity.ToTable("CART_DTL_ATTRIB");

                entity.HasIndex(e => e.AttribDtlId)
                    .HasName("NDX_CART_DTL_ATTRIB_02");

                entity.HasIndex(e => e.CartDtlAttribId)
                    .HasName("PK_CART_DTL_ATTRIB")
                    .IsUnique();

                entity.HasIndex(e => e.CartDtlId)
                    .HasName("NDX_CART_DTL_ATTRIB_01");

                entity.HasIndex(e => new { e.CartDtlId, e.AttribDtlId })
                    .HasName("UK_CART_DTL_ATTRIB_01")
                    .IsUnique();

                entity.Property(e => e.CartDtlAttribId)
                    .HasColumnName("CART_DTL_ATTRIB_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AttribDtlId)
                    .HasColumnName("ATTRIB_DTL_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.CartDtlId)
                    .HasColumnName("CART_DTL_ID")
                    .HasColumnType("NUMBER(38)");

                entity.HasOne(d => d.AttribDtl)
                    .WithMany(p => p.CartDtlAttrib)
                    .HasForeignKey(d => d.AttribDtlId)
                    .HasConstraintName("FK_CART_DTL_ATTRIB_02");

                entity.HasOne(d => d.CartDtl)
                    .WithMany(p => p.CartDtlAttrib)
                    .HasForeignKey(d => d.CartDtlId)
                    .HasConstraintName("FK_CART_DTL_ATTRIB_01");
            });

            modelBuilder.Entity<CartHdr>(entity =>
            {
                entity.HasKey(e => e.CartId);

                entity.ToTable("CART_HDR");

                entity.HasIndex(e => e.BillingId)
                    .HasName("NDX_CART_HDR_02");

                entity.HasIndex(e => e.CartId)
                    .HasName("PK_CART_HDR")
                    .IsUnique();

                entity.HasIndex(e => e.ShipdayId)
                    .HasName("NDX_CART_HDR_01");

                entity.HasIndex(e => e.ShippingId)
                    .HasName("NDX_CART_HDR_03");

                entity.Property(e => e.CartId)
                    .HasColumnName("CART_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActualShipdate)
                    .HasColumnName("ACTUAL_SHIPDATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.AirmailCharge)
                    .HasColumnName("AIRMAIL_CHARGE")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BillingId)
                    .HasColumnName("BILLING_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BoxingCharge)
                    .HasColumnName("BOXING_CHARGE")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CcCvv)
                    .HasColumnName("CC_CVV")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.CcExpMonth)
                    .HasColumnName("CC_EXP_MONTH")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.CcExpYear)
                    .HasColumnName("CC_EXP_YEAR")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.CcNumber)
                    .HasColumnName("CC_NUMBER")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Comments)
                    .HasColumnName("COMMENTS")
                    .HasColumnType("VARCHAR2(2000)");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IpAddress)
                    .HasColumnName("IP_ADDRESS")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("ORDER_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.OrderSubtotal)
                    .HasColumnName("ORDER_SUBTOTAL")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.OrderTotal)
                    .HasColumnName("ORDER_TOTAL")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasColumnName("PAYMENT_METHOD")
                    .HasColumnType("VARCHAR2(2)")
                    .HasDefaultValueSql("'CC' ");

                entity.Property(e => e.PostageCharge)
                    .HasColumnName("POSTAGE_CHARGE")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.PpPaidAmount)
                    .HasColumnName("PP_PAID_AMOUNT")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.PpReference)
                    .HasColumnName("PP_REFERENCE")
                    .HasColumnType("VARCHAR2(255)");

                entity.Property(e => e.QuarterboxCharge)
                    .HasColumnName("QUARTERBOX_CHARGE")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.RequestContactEmail)
                    .IsRequired()
                    .HasColumnName("REQUEST_CONTACT_EMAIL")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.RequestContactPhone)
                    .IsRequired()
                    .HasColumnName("REQUEST_CONTACT_PHONE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.RequestPickup)
                    .IsRequired()
                    .HasColumnName("REQUEST_PICKUP")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.RequestShipEarly)
                    .IsRequired()
                    .HasColumnName("REQUEST_SHIP_EARLY")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.RequestedShipdate)
                    .HasColumnName("REQUESTED_SHIPDATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.ServicesCharge)
                    .HasColumnName("SERVICES_CHARGE")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ShipdayId)
                    .HasColumnName("SHIPDAY_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ShippingCharge)
                    .HasColumnName("SHIPPING_CHARGE")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ShippingId)
                    .HasColumnName("SHIPPING_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SmallOrderCharge)
                    .HasColumnName("SMALL_ORDER_CHARGE")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.CartHdrBilling)
                    .HasForeignKey(d => d.BillingId)
                    .HasConstraintName("FK_CART_HDR_02");

                entity.HasOne(d => d.Shipday)
                    .WithMany(p => p.CartHdr)
                    .HasForeignKey(d => d.ShipdayId)
                    .HasConstraintName("FK_CART_HDR_01");

                entity.HasOne(d => d.Shipping)
                    .WithMany(p => p.CartHdrShipping)
                    .HasForeignKey(d => d.ShippingId)
                    .HasConstraintName("FK_CART_HDR_03");
            });

            modelBuilder.Entity<CodCard>(entity =>
            {
                entity.ToTable("COD_CARD");

                entity.HasIndex(e => e.CodCardId)
                    .HasName("PK_CODCARD")
                    .IsUnique();

                entity.HasIndex(e => e.OrderId)
                    .HasName("NDX_CODCARD_ORDERID");

                entity.Property(e => e.CodCardId)
                    .HasColumnName("COD_CARD_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.CodNumber)
                    .HasColumnName("COD_NUMBER")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("ORDER_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.CodCard)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_CODCARD_ORDERID");
            });

            modelBuilder.Entity<Creditcard>(entity =>
            {
                entity.HasKey(e => e.CreditcardType);

                entity.ToTable("CREDITCARD");

                entity.HasIndex(e => e.CreditcardType)
                    .HasName("PK_CREDITCARD")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_CREDITCARD_NAME");

                entity.Property(e => e.CreditcardType)
                    .HasColumnName("CREDITCARD_TYPE")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.DisplayMask)
                    .IsRequired()
                    .HasColumnName("DISPLAY_MASK")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.NumberFormat)
                    .IsRequired()
                    .HasColumnName("NUMBER_FORMAT")
                    .HasColumnType("VARCHAR2(30)");
            });

            modelBuilder.Entity<CreditcardTransaction>(entity =>
            {
                entity.ToTable("CREDITCARD_TRANSACTION");

                entity.HasIndex(e => e.ActivityId)
                    .HasName("NDX_CC_TRANS_ACTIVITYID");

                entity.HasIndex(e => e.BillingId)
                    .HasName("NDX_CC_TRANS_BILLINGID");

                entity.HasIndex(e => e.CreditcardTransactionId)
                    .HasName("PK_CREDITCARD_TRANSACTION_ID")
                    .IsUnique();

                entity.HasIndex(e => e.CustomerCreditcardId)
                    .HasName("NDX_CC_CUSTOMER_ID");

                entity.HasIndex(e => e.OrderId)
                    .HasName("NDX_CC_TRANS_ORDERID");

                entity.HasIndex(e => e.TransactionType)
                    .HasName("NDX_CC_TRANS_TYPE");

                entity.Property(e => e.CreditcardTransactionId)
                    .HasColumnName("CREDITCARD_TRANSACTION_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActivityId)
                    .HasColumnName("ACTIVITY_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Approved)
                    .IsRequired()
                    .HasColumnName("APPROVED")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.BillingId)
                    .HasColumnName("BILLING_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.CustomerCreditcardId)
                    .HasColumnName("CUSTOMER_CREDITCARD_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Last4)
                    .HasColumnName("LAST_4")
                    .HasColumnType("VARCHAR2(4)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrderId)
                    .HasColumnName("ORDER_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ReferenceTransactionId)
                    .HasColumnName("REFERENCE_TRANSACTION_ID")
                    .HasColumnType("VARCHAR2(25)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ResponseText)
                    .HasColumnName("RESPONSE_TEXT")
                    .HasColumnType("VARCHAR2(255)");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransactionAmount)
                    .HasColumnName("TRANSACTION_AMOUNT")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TRANSACTION_ID")
                    .HasColumnType("VARCHAR2(25)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransactionType)
                    .HasColumnName("TRANSACTION_TYPE")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.CreditcardTransaction)
                    .HasForeignKey(d => d.BillingId)
                    .HasConstraintName("FK_CREDITCARD_TRANS_01");

                entity.HasOne(d => d.CustomerCreditcard)
                    .WithMany(p => p.CreditcardTransaction)
                    .HasForeignKey(d => d.CustomerCreditcardId)
                    .HasConstraintName("FK_CREDITCARD_TRANS_CUSTOMER");

                entity.HasOne(d => d.TransactionTypeNavigation)
                    .WithMany(p => p.CreditcardTransaction)
                    .HasForeignKey(d => d.TransactionType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CREDITCARD_TRANS_TYPE");
            });

            modelBuilder.Entity<CreditcardTransactionType>(entity =>
            {
                entity.HasKey(e => e.TransactionType)
                    .HasName("PK_CC_TRANSTYPE");

                entity.ToTable("CREDITCARD_TRANSACTION_TYPE");

                entity.HasIndex(e => e.TransactionType)
                    .HasName("PK_CC_TRANSTYPE")
                    .IsUnique();

                entity.Property(e => e.TransactionType)
                    .HasColumnName("TRANSACTION_TYPE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)");
            });

            modelBuilder.Entity<CustomAvailDetail>(entity =>
            {
                entity.ToTable("CUSTOM_AVAIL_DETAIL");

                entity.HasIndex(e => e.BreedId)
                    .HasName("NDX_CUSTOM_AVAIL_DETAIL_01");

                entity.HasIndex(e => e.CustomAvailDetailId)
                    .HasName("PK_CUSTOM_AVAIL_DETAIL")
                    .IsUnique();

                entity.HasIndex(e => e.CustomAvailId)
                    .HasName("NDX_CUSTOM_AVAIL_DTL_ID");

                entity.HasIndex(e => new { e.CustomAvailId, e.BreedId })
                    .HasName("UK_CUSTOM_AVAIL_DETAIL_01")
                    .IsUnique();

                entity.Property(e => e.CustomAvailDetailId)
                    .HasColumnName("CUSTOM_AVAIL_DETAIL_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BreedId)
                    .HasColumnName("BREED_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.CustomAvailId)
                    .HasColumnName("CUSTOM_AVAIL_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Breed)
                    .WithMany(p => p.CustomAvailDetail)
                    .HasForeignKey(d => d.BreedId)
                    .HasConstraintName("FK_CUSTOM_AVAIL_BREED_ID");

                entity.HasOne(d => d.CustomAvail)
                    .WithMany(p => p.CustomAvailDetail)
                    .HasForeignKey(d => d.CustomAvailId)
                    .HasConstraintName("FK_CUSTOM_AVAIL_DETAIL_ID");
            });

            modelBuilder.Entity<CustomAvailMaster>(entity =>
            {
                entity.HasKey(e => e.CustomAvailId);

                entity.ToTable("CUSTOM_AVAIL_MASTER");

                entity.HasIndex(e => e.CustomAvailId)
                    .HasName("PK_CUSTOM_AVAIL_MASTER")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_CUSTOM_AVAIL_M_DESCRIPTION");

                entity.Property(e => e.CustomAvailId)
                    .HasColumnName("CUSTOM_AVAIL_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.ReportType)
                    .HasColumnName("REPORT_TYPE")
                    .HasColumnType("NUMBER(2)")
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("CUSTOMER");

                entity.HasIndex(e => e.AlphaSearch)
                    .HasName("NDX_CUSTOMER_12");

                entity.HasIndex(e => e.BillingId)
                    .HasName("NDX_CUSTOMER_03");

                entity.HasIndex(e => e.Code)
                    .HasName("NDX_CUSTOMER_02")
                    .IsUnique();

                entity.HasIndex(e => e.CustomerId)
                    .HasName("PK_CUSTOMER")
                    .IsUnique();

                entity.HasIndex(e => e.CustomertypeId)
                    .HasName("NDX_CUSTOMER_04");

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_CUSTOMER_11");

                entity.HasIndex(e => e.PaymenttermId)
                    .HasName("NDX_CUSTOMER_07");

                entity.HasIndex(e => e.Phone1)
                    .HasName("NDX_CUSTOMER_09");

                entity.HasIndex(e => e.PricesheetId)
                    .HasName("NDX_CUSTOMER_06");

                entity.HasIndex(e => e.ShippingHatcheryId)
                    .HasName("NDX_CUSTOMER_08");

                entity.HasIndex(e => e.WebLogin)
                    .HasName("UK_CUSTOMER_01")
                    .IsUnique();

                entity.HasIndex(e => e.ZipcodeId)
                    .HasName("NDX_CUSTOMER_05");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CUSTOMER_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS1")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS2")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AddressLastValidated)
                    .HasColumnName("ADDRESS_LAST_VALIDATED")
                    .HasColumnType("DATE");

                entity.Property(e => e.AlphaSearch)
                    .IsRequired()
                    .HasColumnName("ALPHA_SEARCH")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BillingId)
                    .HasColumnName("BILLING_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BookkeeperName)
                    .HasColumnName("BOOKKEEPER_NAME")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BookkeeperNotes)
                    .HasColumnName("BOOKKEEPER_NOTES")
                    .HasColumnType("VARCHAR2(60)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BookkeeperPhone)
                    .HasColumnName("BOOKKEEPER_PHONE")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ChargeAirmail)
                    .HasColumnName("CHARGE_AIRMAIL")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ChargePostage)
                    .HasColumnName("CHARGE_POSTAGE")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ChargeQbc)
                    .HasColumnName("CHARGE_QBC")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ChargeSoc)
                    .HasColumnName("CHARGE_SOC")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodAdderAmount)
                    .HasColumnName("COD_ADDER_AMOUNT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomertypeId)
                    .HasColumnName("CUSTOMERTYPE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateAdded)
                    .HasColumnName("DATE_ADDED")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("EMAIL_ADDRESS")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasColumnType("VARCHAR2(10)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Inactive)
                    .IsRequired()
                    .HasColumnName("INACTIVE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.InsureShipment)
                    .HasColumnName("INSURE_SHIPMENT")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Mobile)
                    .HasColumnName("MOBILE")
                    .HasColumnType("VARCHAR2(10)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrderingNotes)
                    .HasColumnName("ORDERING_NOTES")
                    .HasColumnType("VARCHAR2(60)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrderingWarning)
                    .HasColumnName("ORDERING_WARNING")
                    .HasColumnType("VARCHAR2(60)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PaymenttermId)
                    .HasColumnName("PAYMENTTERM_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Phone1)
                    .HasColumnName("PHONE1")
                    .HasColumnType("VARCHAR2(10)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Phone2)
                    .HasColumnName("PHONE2")
                    .HasColumnType("VARCHAR2(10)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PlacedbyFirstName)
                    .HasColumnName("PLACEDBY_FIRST_NAME")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PlacedbyLastName)
                    .HasColumnName("PLACEDBY_LAST_NAME")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Preferred)
                    .IsRequired()
                    .HasColumnName("PREFERRED")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.PricesheetId)
                    .HasColumnName("PRICESHEET_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PrintPhoneNumber)
                    .IsRequired()
                    .HasColumnName("PRINT_PHONE_NUMBER")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.PrintShippingLabel)
                    .IsRequired()
                    .HasColumnName("PRINT_SHIPPING_LABEL")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.QuickDialNumber)
                    .HasColumnName("QUICK_DIAL_NUMBER")
                    .HasColumnType("VARCHAR2(4)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rejected)
                    .IsRequired()
                    .HasColumnName("REJECTED")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.ShipViaAirmail)
                    .IsRequired()
                    .HasColumnName("SHIP_VIA_AIRMAIL")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.ShippingHatcheryId)
                    .HasColumnName("SHIPPING_HATCHERY_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StandardDiscount)
                    .HasColumnName("STANDARD_DISCOUNT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WebLogin)
                    .HasColumnName("WEB_LOGIN")
                    .HasColumnType("VARCHAR2(255)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.WebPassword)
                    .HasColumnName("WEB_PASSWORD")
                    .HasColumnType("VARCHAR2(255)");

                entity.Property(e => e.ZipcodeId)
                    .HasColumnName("ZIPCODE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.InverseBilling)
                    .HasForeignKey(d => d.BillingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CUSTOMER2BILLING");

                entity.HasOne(d => d.Customertype)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.CustomertypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CUSTOMER2CUSTTYPE");

                entity.HasOne(d => d.Paymentterm)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.PaymenttermId)
                    .HasConstraintName("FK_CUSTOMER2PAYTERM");

                entity.HasOne(d => d.Pricesheet)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.PricesheetId)
                    .HasConstraintName("FK_CUSTOMER2PRICESHEET");

                entity.HasOne(d => d.ShippingHatchery)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.ShippingHatcheryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CUSTOMER2HATCHERY");

                entity.HasOne(d => d.Zipcode)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.ZipcodeId)
                    .HasConstraintName("FK_CUSTOMER2ZIPCODE");
            });

            modelBuilder.Entity<CustomerCallcode>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("CUSTOMER_CALLCODE");

                entity.HasIndex(e => e.ContactPics)
                    .HasName("NDX_CUSTOMER_CALLCODE06");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("PK_CUSTOMER_CALLCODE")
                    .IsUnique();

                entity.HasIndex(e => e.CustomerType)
                    .HasName("NDX_CUSTOMER_CALLCODE02");

                entity.HasIndex(e => e.Feeddealer1)
                    .HasName("NDX_CUSTOMER_CALLCODE07");

                entity.HasIndex(e => e.Feeddealer2)
                    .HasName("NDX_CUSTOMER_CALLCODE08");

                entity.HasIndex(e => e.PrimarySupplier)
                    .HasName("NDX_CUSTOMER_CALLCODE04");

                entity.HasIndex(e => e.PurchaseVolume)
                    .HasName("NDX_CUSTOMER_CALLCODE01");

                entity.HasIndex(e => e.SeasonsOfPurchase)
                    .HasName("NDX_CUSTOMER_CALLCODE03");

                entity.HasIndex(e => e.SecondarySupplier)
                    .HasName("NDX_CUSTOMER_CALLCODE05");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CUSTOMER_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Banner)
                    .HasColumnName("BANNER")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.BantamNotebook)
                    .HasColumnName("BANTAM_NOTEBOOK")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Bantams)
                    .HasColumnName("BANTAMS")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Book)
                    .HasColumnName("BOOK")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.BusinessPics)
                    .HasColumnName("BUSINESS_PICS")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.CallListCode)
                    .HasColumnName("CALL_LIST_CODE")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContactPics)
                    .HasColumnName("CONTACT_PICS")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cornish)
                    .HasColumnName("CORNISH")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Crested)
                    .HasColumnName("CRESTED")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.CustomerType)
                    .HasColumnName("CUSTOMER_TYPE")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DuckNotebook)
                    .HasColumnName("DUCK_NOTEBOOK")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Ducks)
                    .HasColumnName("DUCKS")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Feeddealer1)
                    .HasColumnName("FEEDDEALER_1")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Feeddealer2)
                    .HasColumnName("FEEDDEALER_2")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Geese)
                    .HasColumnName("GEESE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Guineas)
                    .HasColumnName("GUINEAS")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Mallards)
                    .HasColumnName("MALLARDS")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Page)
                    .HasColumnName("PAGE")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PrimarySupplier)
                    .HasColumnName("PRIMARY_SUPPLIER")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PurchaseVolume)
                    .HasColumnName("PURCHASE_VOLUME")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RbMeat)
                    .HasColumnName("RB_MEAT")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.SeasonsOfPurchase)
                    .HasColumnName("SEASONS_OF_PURCHASE")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SecondarySupplier)
                    .HasColumnName("SECONDARY_SUPPLIER")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Sign)
                    .HasColumnName("SIGN")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Silkies)
                    .HasColumnName("SILKIES")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.StandardNotebook)
                    .HasColumnName("STANDARD_NOTEBOOK")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.Turkeys)
                    .HasColumnName("TURKEYS")
                    .HasColumnType("CHAR(1)");

                entity.HasOne(d => d.ContactPicsNavigation)
                    .WithMany(p => p.CustomerCallcodeContactPicsNavigation)
                    .HasForeignKey(d => d.ContactPics)
                    .HasConstraintName("FK_CUSTOMER_CALLCODE6");

                entity.HasOne(d => d.CustomerTypeNavigation)
                    .WithMany(p => p.CustomerCallcodeCustomerTypeNavigation)
                    .HasForeignKey(d => d.CustomerType)
                    .HasConstraintName("FK_CUSTOMER_CALLCODE2");

                entity.HasOne(d => d.PrimarySupplierNavigation)
                    .WithMany(p => p.CustomerCallcodePrimarySupplierNavigation)
                    .HasForeignKey(d => d.PrimarySupplier)
                    .HasConstraintName("FK_CUSTOMER_CALLCODE4");

                entity.HasOne(d => d.PurchaseVolumeNavigation)
                    .WithMany(p => p.CustomerCallcodePurchaseVolumeNavigation)
                    .HasForeignKey(d => d.PurchaseVolume)
                    .HasConstraintName("FK_CUSTOMER_CALLCODE1");

                entity.HasOne(d => d.SeasonsOfPurchaseNavigation)
                    .WithMany(p => p.CustomerCallcodeSeasonsOfPurchaseNavigation)
                    .HasForeignKey(d => d.SeasonsOfPurchase)
                    .HasConstraintName("FK_CUSTOMER_CALLCODE3");

                entity.HasOne(d => d.SecondarySupplierNavigation)
                    .WithMany(p => p.CustomerCallcodeSecondarySupplierNavigation)
                    .HasForeignKey(d => d.SecondarySupplier)
                    .HasConstraintName("FK_CUSTOMER_CALLCODE5");
            });

            modelBuilder.Entity<CustomerCalllist>(entity =>
            {
                entity.ToTable("CUSTOMER_CALLLIST");

                entity.HasIndex(e => e.CustomerCalllistId)
                    .HasName("PK_CUSTOMERCALLLIST")
                    .IsUnique();

                entity.HasIndex(e => e.CustomerId)
                    .HasName("NDX_CUSTCALL_CUSTOMER");

                entity.HasIndex(e => e.ShipdayId)
                    .HasName("NDX_CUSTCALL_SHIPDAY_HDR");

                entity.Property(e => e.CustomerCalllistId)
                    .HasColumnName("CUSTOMER_CALLLIST_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CUSTOMER_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.CustomerPurchase)
                    .HasColumnName("CUSTOMER_PURCHASE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasColumnType("VARCHAR2(5)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ShipdayId)
                    .HasColumnName("SHIPDAY_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerCalllist)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CUSTCALLLIST2CUSTOMER");

                entity.HasOne(d => d.Shipday)
                    .WithMany(p => p.CustomerCalllist)
                    .HasForeignKey(d => d.ShipdayId)
                    .HasConstraintName("FK_CUSTCALLLIST2SHIPDAY");
            });

            modelBuilder.Entity<CustomerCreditcard>(entity =>
            {
                entity.ToTable("CUSTOMER_CREDITCARD");

                entity.HasIndex(e => e.BillingZipcodeId)
                    .HasName("NDX_CUSTOMER_CREDITCARD_02");

                entity.HasIndex(e => e.CcCvv)
                    .HasName("NDX_CUSTOMER_CREDITCARD_07");

                entity.HasIndex(e => e.CcExpirationMonth)
                    .HasName("NDX_CUSTOMER_CREDITCARD_05");

                entity.HasIndex(e => e.CcExpirationYear)
                    .HasName("NDX_CUSTOMER_CREDITCARD_06");

                entity.HasIndex(e => e.CcNumber)
                    .HasName("NDX_CUSTOMER_CREDITCARD_04");

                entity.HasIndex(e => e.CustomerCreditcardId)
                    .HasName("PK_CUSTOMER_CREDITCARD")
                    .IsUnique();

                entity.HasIndex(e => e.CustomerId)
                    .HasName("NDX_CUSTOMER_CREDITCARD_01");

                entity.HasIndex(e => new { e.CcNumber, e.CcExpirationMonth, e.CcExpirationYear, e.CcCvv })
                    .HasName("NDX_CUSTOMER_CREDITCARD_03");

                entity.Property(e => e.CustomerCreditcardId)
                    .HasColumnName("CUSTOMER_CREDITCARD_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BillingAddress)
                    .HasColumnName("BILLING_ADDRESS")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BillingZipcodeId)
                    .HasColumnName("BILLING_ZIPCODE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CcCvv)
                    .IsRequired()
                    .HasColumnName("CC_CVV")
                    .HasMaxLength(100)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CcExpirationMonth)
                    .IsRequired()
                    .HasColumnName("CC_EXPIRATION_MONTH")
                    .HasMaxLength(100)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CcExpirationYear)
                    .IsRequired()
                    .HasColumnName("CC_EXPIRATION_YEAR")
                    .HasMaxLength(100)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CcNumber)
                    .IsRequired()
                    .HasColumnName("CC_NUMBER")
                    .HasMaxLength(100)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CUSTOMER_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Inactive)
                    .IsRequired()
                    .HasColumnName("INACTIVE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.NameOnCard)
                    .HasColumnName("NAME_ON_CARD")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.WasLastUsed)
                    .IsRequired()
                    .HasColumnName("WAS_LAST_USED")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.HasOne(d => d.BillingZipcode)
                    .WithMany(p => p.CustomerCreditcard)
                    .HasForeignKey(d => d.BillingZipcodeId)
                    .HasConstraintName("FK_CUSTOMER_CREDITCARD2");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerCreditcard)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CUSTOMER_CREDITCARD1");
            });

            modelBuilder.Entity<CustomerEastercall>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.Year })
                    .HasName("PK_CUSTEASTCALL");

                entity.ToTable("CUSTOMER_EASTERCALL");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("NDX_CUST_EASTERCALL_CUSTID");

                entity.HasIndex(e => new { e.CustomerId, e.Year })
                    .HasName("PK_CUSTEASTCALL")
                    .IsUnique();

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CUSTOMER_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.PurchaseMade)
                    .HasColumnName("PURCHASE_MADE")
                    .HasColumnType("CHAR(1)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerEastercall)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CUSTEAST2CUST");
            });

            modelBuilder.Entity<CustomerNote>(entity =>
            {
                entity.ToTable("CUSTOMER_NOTE");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("NDX_CUSTOMER_NOTE_1");

                entity.HasIndex(e => e.CustomerNoteId)
                    .HasName("PK_CUSTOMER_NOTE")
                    .IsUnique();

                entity.HasIndex(e => e.PersonId)
                    .HasName("NDX_CUSTOMER_NOTE_2");

                entity.Property(e => e.CustomerNoteId)
                    .HasColumnName("CUSTOMER_NOTE_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CUSTOMER_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.DatetimeStamp)
                    .HasColumnName("DATETIME_STAMP")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("NOTE")
                    .HasColumnType("VARCHAR2(4000)");

                entity.Property(e => e.NoteTypeId)
                    .HasColumnName("NOTE_TYPE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PersonId)
                    .HasColumnName("PERSON_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerNote)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CUSTOMER_NOTE_1");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.CustomerNote)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CUSTOMER_NOTE_2");
            });

            modelBuilder.Entity<CustomerRoute>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.RouteId });

                entity.ToTable("CUSTOMER_ROUTE");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("NDX_CUSTOMER_ROUTE1");

                entity.HasIndex(e => e.RouteId)
                    .HasName("NDX_CUSTOMER_ROUTE2");

                entity.HasIndex(e => new { e.CustomerId, e.RouteId })
                    .HasName("PK_CUSTOMER_ROUTE")
                    .IsUnique();

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CUSTOMER_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.RouteId)
                    .HasColumnName("ROUTE_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerRoute)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CUSTOMER_ROUTE1");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.CustomerRoute)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CUSTOMER_ROUTE2");
            });

            modelBuilder.Entity<Customertype>(entity =>
            {
                entity.ToTable("CUSTOMERTYPE");

                entity.HasIndex(e => e.Code)
                    .HasName("AK1_CUSTOMERTYPE")
                    .IsUnique();

                entity.HasIndex(e => e.CustomertypeId)
                    .HasName("PK_CUSTOMERTYPE")
                    .IsUnique();

                entity.HasIndex(e => e.PricesheetId)
                    .HasName("NDX_CUSTTYPE_PRICESHEET");

                entity.HasIndex(e => e.ShippingHatcheryId)
                    .HasName("NDX_CUSTTYPE_HATCHERY");

                entity.Property(e => e.CustomertypeId)
                    .HasColumnName("CUSTOMERTYPE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ChargeAirmail)
                    .IsRequired()
                    .HasColumnName("CHARGE_AIRMAIL")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.ChargePostage)
                    .IsRequired()
                    .HasColumnName("CHARGE_POSTAGE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.ChargeQbc)
                    .IsRequired()
                    .HasColumnName("CHARGE_QBC")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.ChargeSoc)
                    .IsRequired()
                    .HasColumnName("CHARGE_SOC")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(2)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Inactive)
                    .IsRequired()
                    .HasColumnName("INACTIVE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.InsureShipment)
                    .IsRequired()
                    .HasColumnName("INSURE_SHIPMENT")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.InvoicePrintCount)
                    .HasColumnName("INVOICE_PRINT_COUNT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IsCreditcardCustomer)
                    .IsRequired()
                    .HasColumnName("IS_CREDITCARD_CUSTOMER")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.IsPaypalCustomer)
                    .IsRequired()
                    .HasColumnName("IS_PAYPAL_CUSTOMER")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.IsRetailCustomer)
                    .IsRequired()
                    .HasColumnName("IS_RETAIL_CUSTOMER")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.IsWholesaleCustomer)
                    .IsRequired()
                    .HasColumnName("IS_WHOLESALE_CUSTOMER")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.PackingListPrintCount)
                    .HasColumnName("PACKING_LIST_PRINT_COUNT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.PricesheetId)
                    .HasColumnName("PRICESHEET_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.PrintConfirmation)
                    .IsRequired()
                    .HasColumnName("PRINT_CONFIRMATION")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.PrintLabelDetail)
                    .IsRequired()
                    .HasColumnName("PRINT_LABEL_DETAIL")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.PrintShippingLabel)
                    .IsRequired()
                    .HasColumnName("PRINT_SHIPPING_LABEL")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.ShippingHatcheryId)
                    .HasColumnName("SHIPPING_HATCHERY_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Pricesheet)
                    .WithMany(p => p.Customertype)
                    .HasForeignKey(d => d.PricesheetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2_CUSTTYPE2PRICESHEET");

                entity.HasOne(d => d.ShippingHatchery)
                    .WithMany(p => p.Customertype)
                    .HasForeignKey(d => d.ShippingHatcheryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_CUSTTYPE2HATCHERY");
            });

            modelBuilder.Entity<DrXtxt1webSearchK>(entity =>
            {
                entity.HasKey(e => e.Textkey)
                    .HasName("SYS_IOT_TOP_108831");

                entity.ToTable("DR$XTXT1WEB_SEARCH$K");

                entity.HasIndex(e => e.Textkey)
                    .HasName("SYS_IOT_TOP_108831")
                    .IsUnique();

                entity.Property(e => e.Textkey)
                    .HasColumnName("TEXTKEY")
                    .HasColumnType("ROWID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Docid)
                    .HasColumnName("DOCID")
                    .HasColumnType("NUMBER(38)");
            });

            modelBuilder.Entity<DrXtxt1webSearchN>(entity =>
            {
                entity.HasKey(e => e.NltDocid)
                    .HasName("SYS_IOT_TOP_108837");

                entity.ToTable("DR$XTXT1WEB_SEARCH$N");

                entity.HasIndex(e => e.NltDocid)
                    .HasName("SYS_IOT_TOP_108837")
                    .IsUnique();

                entity.Property(e => e.NltDocid)
                    .HasColumnName("NLT_DOCID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.NltMark)
                    .IsRequired()
                    .HasColumnName("NLT_MARK")
                    .HasColumnType("CHAR(1)");
            });

            modelBuilder.Entity<DropshipDtl>(entity =>
            {
                entity.ToTable("DROPSHIP_DTL");

                entity.HasIndex(e => e.DropshipDtlId)
                    .HasName("PK_DROPSHIP_DTL")
                    .IsUnique();

                entity.HasIndex(e => e.DropshipId)
                    .HasName("NDX_DROPSHIP_DTL1");

                entity.HasIndex(e => e.ProductId)
                    .HasName("NDX2_DROPSHIP_DTL");

                entity.HasIndex(e => new { e.ShipdayId, e.SuborderDtlId, e.OutsourceId })
                    .HasName("UK1_DROPSHIP_DTL")
                    .IsUnique();

                entity.Property(e => e.DropshipDtlId)
                    .HasColumnName("DROPSHIP_DTL_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DropshipId)
                    .HasColumnName("DROPSHIP_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.OutsourceId)
                    .IsRequired()
                    .HasColumnName("OUTSOURCE_ID")
                    .HasColumnType("VARCHAR2(2)");

                entity.Property(e => e.PoNumber)
                    .HasColumnName("PO_NUMBER")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Reported)
                    .HasColumnName("REPORTED")
                    .HasColumnType("NUMBER(10,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ShipdayId)
                    .HasColumnName("SHIPDAY_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SuborderDtlId)
                    .HasColumnName("SUBORDER_DTL_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SuborderId)
                    .HasColumnName("SUBORDER_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Dropship)
                    .WithMany(p => p.DropshipDtl)
                    .HasForeignKey(d => d.DropshipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_DROPSHIP_DTL");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DropshipDtl)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2_DROPSHIP_DTL");

                entity.HasOne(d => d.Shipday)
                    .WithMany(p => p.DropshipDtl)
                    .HasForeignKey(d => d.ShipdayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK3_DROPSHIP_DTL");
            });

            modelBuilder.Entity<DropshipHdr>(entity =>
            {
                entity.HasKey(e => e.DropshipId);

                entity.ToTable("DROPSHIP_HDR");

                entity.HasIndex(e => e.CustomertypeId)
                    .HasName("NDX3_DROPSHIP_HDR");

                entity.HasIndex(e => e.DropshipId)
                    .HasName("PK_DROPSHIP_HDR")
                    .IsUnique();

                entity.HasIndex(e => e.OrderId)
                    .HasName("NDX1_DROPSHIP_HDR");

                entity.Property(e => e.DropshipId)
                    .HasColumnName("DROPSHIP_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerAddress1)
                    .HasColumnName("CUSTOMER_ADDRESS1")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.CustomerAddress2)
                    .HasColumnName("CUSTOMER_ADDRESS2")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.CustomerDescription)
                    .IsRequired()
                    .HasColumnName("CUSTOMER_DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CUSTOMER_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.CustomerPhone)
                    .HasColumnName("CUSTOMER_PHONE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.CustomerZipcodeId)
                    .HasColumnName("CUSTOMER_ZIPCODE_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.CustomertypeId)
                    .HasColumnName("CUSTOMERTYPE_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.OrderId)
                    .HasColumnName("ORDER_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Customertype)
                    .WithMany(p => p.DropshipHdr)
                    .HasForeignKey(d => d.CustomertypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK3_DROPSHIP_HDR");
            });

            modelBuilder.Entity<EasterDates>(entity =>
            {
                entity.HasKey(e => e.Year)
                    .HasName("PK_EASTERDATES");

                entity.ToTable("EASTER_DATES");

                entity.HasIndex(e => e.Date1Id)
                    .HasName("NDX_EASTERDATES_1");

                entity.HasIndex(e => e.Date2Id)
                    .HasName("NDX_EASTERDATES_2");

                entity.HasIndex(e => e.Date3Id)
                    .HasName("NDX_EASTERDATES_3");

                entity.HasIndex(e => e.Date4Id)
                    .HasName("NDX_EASTERDATES_4");

                entity.HasIndex(e => e.Year)
                    .HasName("PK_EASTERDATES")
                    .IsUnique();

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Date1Id)
                    .HasColumnName("DATE_1_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Date2Id)
                    .HasColumnName("DATE_2_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Date3Id)
                    .HasColumnName("DATE_3_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Date4Id)
                    .HasColumnName("DATE_4_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Date1)
                    .WithMany(p => p.EasterDatesDate1)
                    .HasForeignKey(d => d.Date1Id)
                    .HasConstraintName("FK_EASTERDATES_1");

                entity.HasOne(d => d.Date2)
                    .WithMany(p => p.EasterDatesDate2)
                    .HasForeignKey(d => d.Date2Id)
                    .HasConstraintName("FK_EASTERDATES_2");

                entity.HasOne(d => d.Date3)
                    .WithMany(p => p.EasterDatesDate3)
                    .HasForeignKey(d => d.Date3Id)
                    .HasConstraintName("FK_EASTERDATES_3");

                entity.HasOne(d => d.Date4)
                    .WithMany(p => p.EasterDatesDate4)
                    .HasForeignKey(d => d.Date4Id)
                    .HasConstraintName("FK_EASTERDATES_4");
            });

            modelBuilder.Entity<Eastercode>(entity =>
            {
                entity.ToTable("EASTERCODE");

                entity.HasIndex(e => e.Code)
                    .HasName("AK_EASTERCODE_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_EASTERCODE_DESCRIPTION");

                entity.HasIndex(e => e.EastercodeId)
                    .HasName("PK_EASTERCODE")
                    .IsUnique();

                entity.HasIndex(e => e.SortParentId)
                    .HasName("NDX_EASTERCODE_PARENT");

                entity.Property(e => e.EastercodeId)
                    .HasColumnName("EASTERCODE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(2)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SortParentId)
                    .HasColumnName("SORT_PARENT_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.SortParent)
                    .WithMany(p => p.InverseSortParent)
                    .HasForeignKey(d => d.SortParentId)
                    .HasConstraintName("FK_EASTERCODE_PARENT");
            });

            modelBuilder.Entity<EdiDocument>(entity =>
            {
                entity.ToTable("EDI_DOCUMENT");

                entity.HasIndex(e => e.EdiDocumentId)
                    .HasName("PK_EDI_DOCUMENT")
                    .IsUnique();

                entity.HasIndex(e => new { e.ControlNumber, e.EdiPartnerId, e.Direction })
                    .HasName("XAK1_EDI_DOCUMENT")
                    .IsUnique();

                entity.HasIndex(e => new { e.EdiPartnerId, e.Direction, e.ControlNumber })
                    .HasName("XAK1_EDI_DOCUMENT")
                    .IsUnique();

                entity.Property(e => e.EdiDocumentId)
                    .HasColumnName("EDI_DOCUMENT_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Acknowledged)
                    .IsRequired()
                    .HasColumnName("ACKNOWLEDGED")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.ControlNumber)
                    .HasColumnName("CONTROL_NUMBER")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CREATION_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Direction)
                    .IsRequired()
                    .HasColumnName("DIRECTION")
                    .HasColumnType("VARCHAR2(7)");

                entity.Property(e => e.Document)
                    .IsRequired()
                    .HasColumnName("DOCUMENT")
                    .HasColumnType("CLOB");

                entity.Property(e => e.EdiPartnerId)
                    .HasColumnName("EDI_PARTNER_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.UsageIndicator)
                    .IsRequired()
                    .HasColumnName("USAGE_INDICATOR")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'T' ");

                entity.HasOne(d => d.EdiPartner)
                    .WithMany(p => p.EdiDocument)
                    .HasForeignKey(d => d.EdiPartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("XIE1_EDI_DOCUMENT");
            });

            modelBuilder.Entity<EdiInvoiceHdr>(entity =>
            {
                entity.ToTable("EDI_INVOICE_HDR");

                entity.HasIndex(e => e.EdiInvoiceHdrId)
                    .HasName("PK_EDI_INVOICE_HDR")
                    .IsUnique();

                entity.HasIndex(e => e.OrderId)
                    .HasName("NDX_EDI_INVOICE_HDR_1");

                entity.HasIndex(e => new { e.GroupNumber, e.TransactionNumber })
                    .HasName("UK_EDI_INVOICE_HDR_ID")
                    .IsUnique();

                entity.Property(e => e.EdiInvoiceHdrId)
                    .HasColumnName("EDI_INVOICE_HDR_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Acknowledged)
                    .HasColumnName("ACKNOWLEDGED")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.GroupNumber)
                    .HasColumnName("GROUP_NUMBER")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("ORDER_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.TransactionNumber)
                    .HasColumnName("TRANSACTION_NUMBER")
                    .HasColumnType("VARCHAR2(10)");
            });

            modelBuilder.Entity<EdiPartner>(entity =>
            {
                entity.ToTable("EDI_PARTNER");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("NDX_EDIPART_CUSTOMER");

                entity.HasIndex(e => e.CustomertypeId)
                    .HasName("NDX_EDIPART_CUSTTYPE");

                entity.HasIndex(e => e.EdiPartnerId)
                    .HasName("XPKEDI_PARTNER")
                    .IsUnique();

                entity.HasIndex(e => e.HatcheryId)
                    .HasName("NDX_EDIPART_HATCHERY");

                entity.HasIndex(e => new { e.Qualifier, e.Identifier })
                    .HasName("XAK1EDI_PARTNER")
                    .IsUnique();

                entity.Property(e => e.EdiPartnerId)
                    .HasColumnName("EDI_PARTNER_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BillingTermDays).HasColumnName("BILLING_TERM_DAYS");

                entity.Property(e => e.BillingTermDescription)
                    .HasColumnName("BILLING_TERM_DESCRIPTION")
                    .HasColumnType("VARCHAR2(80)");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CUSTOMER_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.CustomertypeId)
                    .HasColumnName("CUSTOMERTYPE_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.HatcheryId)
                    .HasColumnName("HATCHERY_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("IDENTIFIER")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasColumnType("VARCHAR2(255)");

                entity.Property(e => e.PartnerIdForUs)
                    .HasColumnName("PARTNER_ID_FOR_US")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Qualifier)
                    .IsRequired()
                    .HasColumnName("QUALIFIER")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.ShortName)
                    .HasColumnName("SHORT_NAME")
                    .HasColumnType("VARCHAR2(15)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.EdiPartner)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EDIPART2CUSTOMER");

                entity.HasOne(d => d.Customertype)
                    .WithMany(p => p.EdiPartner)
                    .HasForeignKey(d => d.CustomertypeId)
                    .HasConstraintName("FK_EDIPART2CUSTTYPE");

                entity.HasOne(d => d.Hatchery)
                    .WithMany(p => p.EdiPartner)
                    .HasForeignKey(d => d.HatcheryId)
                    .HasConstraintName("FK_EDIPART2HATCHERY");
            });

            modelBuilder.Entity<EdiPoDtl>(entity =>
            {
                entity.ToTable("EDI_PO_DTL");

                entity.HasIndex(e => e.EdiPoDtlId)
                    .HasName("PK_EDI_PO_DTL")
                    .IsUnique();

                entity.HasIndex(e => new { e.EdiPoHdrId, e.LineNumber })
                    .HasName("UK_EDI_PO_DTL_1")
                    .IsUnique();

                entity.Property(e => e.EdiPoDtlId)
                    .HasColumnName("EDI_PO_DTL_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ChangeType)
                    .HasColumnName("CHANGE_TYPE")
                    .HasColumnType("VARCHAR2(2)");

                entity.Property(e => e.EdiPoHdrId)
                    .HasColumnName("EDI_PO_HDR_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.LineNumber)
                    .HasColumnName("LINE_NUMBER")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PartnerProductId)
                    .IsRequired()
                    .HasColumnName("PARTNER_PRODUCT_ID")
                    .HasColumnType("VARCHAR2(64)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("QUANTITY")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("UNIT_PRICE")
                    .HasColumnType("NUMBER(38,4)");

                entity.Property(e => e.Units)
                    .HasColumnName("UNITS")
                    .HasColumnType("VARCHAR2(2)")
                    .HasDefaultValueSql("'EA'");

                entity.HasOne(d => d.EdiPoHdr)
                    .WithMany(p => p.EdiPoDtl)
                    .HasForeignKey(d => d.EdiPoHdrId)
                    .HasConstraintName("FK_EDI_PO_DTL_1");
            });

            modelBuilder.Entity<EdiPoHdr>(entity =>
            {
                entity.ToTable("EDI_PO_HDR");

                entity.HasIndex(e => e.EdiPoHdrId)
                    .HasName("PK_EDI_PO_HDR")
                    .IsUnique();

                entity.HasIndex(e => new { e.GroupNumber, e.TransactionNumber, e.PoNumber })
                    .HasName("UK_EDI_PO_HDR_1")
                    .IsUnique();

                entity.HasIndex(e => new { e.PoNumber, e.GroupNumber, e.TransactionNumber })
                    .HasName("UK_EDI_PO_HDR_1")
                    .IsUnique();

                entity.Property(e => e.EdiPoHdrId)
                    .HasColumnName("EDI_PO_HDR_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Acknowledged)
                    .IsRequired()
                    .HasColumnName("ACKNOWLEDGED")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.ChangeOrderDate)
                    .HasColumnName("CHANGE_ORDER_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.ChangeOrderPurpose)
                    .HasColumnName("CHANGE_ORDER_PURPOSE")
                    .HasColumnType("VARCHAR2(2)");

                entity.Property(e => e.DateReceived)
                    .HasColumnName("DATE_RECEIVED")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DoNotDeliverAfter)
                    .HasColumnName("DO_NOT_DELIVER_AFTER")
                    .HasColumnType("DATE");

                entity.Property(e => e.DoNotDeliverBefore)
                    .HasColumnName("DO_NOT_DELIVER_BEFORE")
                    .HasColumnType("DATE");

                entity.Property(e => e.DocumentType)
                    .IsRequired()
                    .HasColumnName("DOCUMENT_TYPE")
                    .HasColumnType("CHAR(3)");

                entity.Property(e => e.EdiDocumentId)
                    .HasColumnName("EDI_DOCUMENT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.GroupNumber)
                    .HasColumnName("GROUP_NUMBER")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Imported)
                    .IsRequired()
                    .HasColumnName("IMPORTED")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.PartnerCustomerId)
                    .HasColumnName("PARTNER_CUSTOMER_ID")
                    .HasColumnType("VARCHAR2(64)");

                entity.Property(e => e.PoGenerationDate)
                    .HasColumnName("PO_GENERATION_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.PoNumber)
                    .IsRequired()
                    .HasColumnName("PO_NUMBER")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.TransactionNumber)
                    .HasColumnName("TRANSACTION_NUMBER")
                    .HasColumnType("VARCHAR2(10)");

                entity.HasOne(d => d.EdiDocument)
                    .WithMany(p => p.EdiPoHdr)
                    .HasForeignKey(d => d.EdiDocumentId)
                    .HasConstraintName("FK_EDI_PO_HDR_1");
            });

            modelBuilder.Entity<EdiTranslation>(entity =>
            {
                entity.ToTable("EDI_TRANSLATION");

                entity.HasIndex(e => e.EdiPartnerId)
                    .HasName("NDX_EDI_TRANSLATION_1");

                entity.HasIndex(e => e.EdiTranslationId)
                    .HasName("PK_EDI_TRANSLATION")
                    .IsUnique();

                entity.HasIndex(e => new { e.EdiPartnerId, e.TableName, e.PartnerValue })
                    .HasName("UK_EDI_TRANSLATION_1")
                    .IsUnique();

                entity.Property(e => e.EdiTranslationId)
                    .HasColumnName("EDI_TRANSLATION_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EdiPartnerId)
                    .HasColumnName("EDI_PARTNER_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.InternalValue)
                    .IsRequired()
                    .HasColumnName("INTERNAL_VALUE")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.PartnerValue)
                    .IsRequired()
                    .HasColumnName("PARTNER_VALUE")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnName("TABLE_NAME")
                    .HasColumnType("VARCHAR2(30)");

                entity.HasOne(d => d.EdiPartner)
                    .WithMany(p => p.EdiTranslation)
                    .HasForeignKey(d => d.EdiPartnerId)
                    .HasConstraintName("FK_EDI_TRANSLATION_1");
            });

            modelBuilder.Entity<EmailQueue>(entity =>
            {
                entity.ToTable("EMAIL_QUEUE");

                entity.HasIndex(e => e.EmailQueueId)
                    .HasName("XPKEMAIL_QUEUE")
                    .IsUnique();

                entity.HasIndex(e => new { e.EmailAddress, e.EmailTemplateName, e.InstanceNumber })
                    .HasName("XAK1EMAIL_QUEUE")
                    .IsUnique();

                entity.HasIndex(e => new { e.EmailTemplateName, e.InstanceNumber, e.EmailAddress })
                    .HasName("XAK1EMAIL_QUEUE")
                    .IsUnique();

                entity.Property(e => e.EmailQueueId)
                    .HasColumnName("EMAIL_QUEUE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AttemptDate)
                    .HasColumnName("ATTEMPT_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnName("EMAIL_ADDRESS")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.EmailTemplateName)
                    .IsRequired()
                    .HasColumnName("EMAIL_TEMPLATE_NAME")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Error)
                    .HasColumnName("ERROR")
                    .HasColumnType("CLOB");

                entity.Property(e => e.InstanceNumber)
                    .HasColumnName("INSTANCE_NUMBER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.RealName)
                    .HasColumnName("REAL_NAME")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasColumnType("VARCHAR2(80)");

                entity.HasOne(d => d.EmailTemplateNameNavigation)
                    .WithMany(p => p.EmailQueue)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.EmailTemplateName)
                    .HasConstraintName("XIE1EMAIL_QUEUE");
            });

            modelBuilder.Entity<EmailQueueVars>(entity =>
            {
                entity.ToTable("EMAIL_QUEUE_VARS");

                entity.HasIndex(e => e.EmailQueueVarsId)
                    .HasName("XPKEMAIL_QUEUE_VARS")
                    .IsUnique();

                entity.HasIndex(e => new { e.EmailQueueId, e.Instance, e.Variable })
                    .HasName("XAK1EMAIL_QUEUE_VARS")
                    .IsUnique();

                entity.HasIndex(e => new { e.EmailQueueId, e.Variable, e.Instance })
                    .HasName("XAK1EMAIL_QUEUE_VARS")
                    .IsUnique();

                entity.Property(e => e.EmailQueueVarsId)
                    .HasColumnName("EMAIL_QUEUE_VARS_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EmailQueueId)
                    .HasColumnName("EMAIL_QUEUE_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Instance)
                    .HasColumnName("INSTANCE")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasColumnType("VARCHAR2(255)");

                entity.Property(e => e.Variable)
                    .IsRequired()
                    .HasColumnName("VARIABLE")
                    .HasColumnType("VARCHAR2(30)");

                entity.HasOne(d => d.EmailQueue)
                    .WithMany(p => p.EmailQueueVars)
                    .HasForeignKey(d => d.EmailQueueId)
                    .HasConstraintName("XIE1EMAIL_QUEUE_VARS");
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.ToTable("EMAIL_TEMPLATE");

                entity.HasIndex(e => e.EmailTemplateId)
                    .HasName("XPKEMAIL_TEMPLATE")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("XAK1EMAIL_TEMPLATE")
                    .IsUnique();

                entity.Property(e => e.EmailTemplateId)
                    .HasColumnName("EMAIL_TEMPLATE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FromAddress)
                    .HasColumnName("FROM_ADDRESS")
                    .HasColumnType("VARCHAR2(90)");

                entity.Property(e => e.Html)
                    .HasColumnName("HTML")
                    .HasColumnType("CLOB");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasColumnType("VARCHAR2(80)");

                entity.Property(e => e.Text)
                    .HasColumnName("TEXT")
                    .HasColumnType("CLOB");
            });

            modelBuilder.Entity<EmailTemplateArg>(entity =>
            {
                entity.ToTable("EMAIL_TEMPLATE_ARG");

                entity.HasIndex(e => e.EmailTemplateArgId)
                    .HasName("XPKEMAIL_TEMPLATE_ARG")
                    .IsUnique();

                entity.HasIndex(e => new { e.EmailTemplateId, e.TemplateVersion, e.Name })
                    .HasName("XAK1EMAIL_TEMPLATE_ARG")
                    .IsUnique();

                entity.Property(e => e.EmailTemplateArgId)
                    .HasColumnName("EMAIL_TEMPLATE_ARG_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Datatype)
                    .IsRequired()
                    .HasColumnName("DATATYPE")
                    .HasColumnType("VARCHAR2(10)")
                    .HasDefaultValueSql("'SCALAR' ");

                entity.Property(e => e.EmailTemplateId)
                    .HasColumnName("EMAIL_TEMPLATE_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Required)
                    .IsRequired()
                    .HasColumnName("REQUIRED")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.TemplateVersion)
                    .IsRequired()
                    .HasColumnName("TEMPLATE_VERSION")
                    .HasColumnType("CHAR(4)");

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasColumnType("VARCHAR2(255)");

                entity.HasOne(d => d.EmailTemplate)
                    .WithMany(p => p.EmailTemplateArg)
                    .HasForeignKey(d => d.EmailTemplateId)
                    .HasConstraintName("XIE1EMAIL_TEMPLATE_ARG");
            });

            modelBuilder.Entity<ErrorMessages>(entity =>
            {
                entity.HasKey(e => e.ConstraintName);

                entity.ToTable("ERROR_MESSAGES");

                entity.HasIndex(e => e.ConstraintName)
                    .HasName("PK_ERROR_MESSAGES")
                    .IsUnique();

                entity.Property(e => e.ConstraintName)
                    .HasColumnName("CONSTRAINT_NAME")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Actions)
                    .IsRequired()
                    .HasColumnName("ACTIONS")
                    .HasColumnType("VARCHAR2(3)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("ERROR_MESSAGE")
                    .HasColumnType("VARCHAR2(2000)");

                entity.Property(e => e.ParentChild)
                    .IsRequired()
                    .HasColumnName("PARENT_CHILD")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Hatchery>(entity =>
            {
                entity.ToTable("HATCHERY");

                entity.HasIndex(e => e.Code)
                    .HasName("AK1_HATCHERY_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.HatcheryId)
                    .HasName("PK_HATCHERY")
                    .IsUnique();

                entity.HasIndex(e => e.ZipcodeId)
                    .HasName("NDX_HATCHERY_ZIPCODE");

                entity.Property(e => e.HatcheryId)
                    .HasColumnName("HATCHERY_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasColumnType("VARCHAR2(25)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(5)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Inactive)
                    .IsRequired()
                    .HasColumnName("INACTIVE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.NpipId)
                    .HasColumnName("NPIP_ID")
                    .HasColumnType("VARCHAR2(7)");

                entity.Property(e => e.Telephone)
                    .HasColumnName("TELEPHONE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.TollfreeTelephone)
                    .HasColumnName("TOLLFREE_TELEPHONE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.ZipcodeId)
                    .HasColumnName("ZIPCODE_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Zipcode)
                    .WithMany(p => p.Hatchery)
                    .HasForeignKey(d => d.ZipcodeId)
                    .HasConstraintName("FK_HATCHERY2ZIPCODE");
            });

            modelBuilder.Entity<Hatchsessions>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("XPKP2SESSIONS");

                entity.ToTable("HATCHSESSIONS");

                entity.HasIndex(e => e.PersonId)
                    .HasName("XIF95P2SESSIONS");

                entity.HasIndex(e => e.SessionId)
                    .HasName("XPKP2SESSIONS")
                    .IsUnique();

                entity.Property(e => e.SessionId)
                    .HasColumnName("SESSION_ID")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConnectDate)
                    .HasColumnName("CONNECT_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Machine)
                    .HasColumnName("MACHINE")
                    .HasColumnType("VARCHAR2(32)");

                entity.Property(e => e.PersonId)
                    .HasColumnName("PERSON_ID")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<HundredPricing>(entity =>
            {
                entity.HasKey(e => new { e.PricesheetId, e.PostalcodeId })
                    .HasName("PK_100PRICING");

                entity.ToTable("HUNDRED_PRICING");

                entity.HasIndex(e => e.PostalcodeId)
                    .HasName("NDX_100PRICE_POSTALCODE_ID");

                entity.HasIndex(e => e.PricesheetId)
                    .HasName("NDX_100PRICE_PRICESHEET_ID");

                entity.HasIndex(e => new { e.PricesheetId, e.PostalcodeId })
                    .HasName("PK_100PRICING")
                    .IsUnique();

                entity.Property(e => e.PricesheetId)
                    .HasColumnName("PRICESHEET_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.PostalcodeId)
                    .HasColumnName("POSTALCODE_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Postalcode)
                    .WithMany(p => p.HundredPricing)
                    .HasForeignKey(d => d.PostalcodeId)
                    .HasConstraintName("FK_100PRICING_2_POSTALCODE");

                entity.HasOne(d => d.Pricesheet)
                    .WithMany(p => p.HundredPricing)
                    .HasForeignKey(d => d.PricesheetId)
                    .HasConstraintName("FK_100PRICING_2_PRICESHEET");
            });

            modelBuilder.Entity<ItemGroup>(entity =>
            {
                entity.ToTable("ITEM_GROUP");

                entity.HasIndex(e => e.ItemGroupId)
                    .HasName("PK_ITEM_GROUP")
                    .IsUnique();

                entity.HasIndex(e => new { e.SortOrder, e.Description })
                    .HasName("NDX_ITEM_GROUP");

                entity.Property(e => e.ItemGroupId)
                    .HasColumnName("ITEM_GROUP_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER(4)")
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<ItemGroupProductClass>(entity =>
            {
                entity.HasKey(e => new { e.ItemGroupId, e.ProductClassId });

                entity.ToTable("ITEM_GROUP_PRODUCT_CLASS");

                entity.HasIndex(e => e.ItemGroupId)
                    .HasName("NDX_ITEM_GROUP_PRODUCT_CLASS_1");

                entity.HasIndex(e => e.ProductClassId)
                    .HasName("NDX_ITEM_GROUP_PRODUCT_CLASS_2");

                entity.HasIndex(e => new { e.ItemGroupId, e.ProductClassId })
                    .HasName("PK_ITEM_GROUP_PRODUCT_CLASS")
                    .IsUnique();

                entity.Property(e => e.ItemGroupId)
                    .HasColumnName("ITEM_GROUP_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ProductClassId)
                    .HasColumnName("PRODUCT_CLASS_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER(4)")
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.ItemGroup)
                    .WithMany(p => p.ItemGroupProductClass)
                    .HasForeignKey(d => d.ItemGroupId)
                    .HasConstraintName("FK_ITEM_GROUP_PRODUCT_CLASS_01");

                entity.HasOne(d => d.ProductClass)
                    .WithMany(p => p.ItemGroupProductClass)
                    .HasForeignKey(d => d.ProductClassId)
                    .HasConstraintName("FK_ITEM_GROUP_PRODUCT_CLASS_02");
            });

            modelBuilder.Entity<MemoDtl>(entity =>
            {
                entity.ToTable("MEMO_DTL");

                entity.HasIndex(e => e.MemoDtlId)
                    .HasName("PK_MEMO_DTL")
                    .IsUnique();

                entity.HasIndex(e => e.MemoHdrId)
                    .HasName("NDX_MEMO_DTL1");

                entity.HasIndex(e => e.MemoReasonId)
                    .HasName("NDX_MEMO_DTL3");

                entity.HasIndex(e => e.SuborderDtlId)
                    .HasName("NDX_MEMO_DTL2");

                entity.HasIndex(e => new { e.MemoHdrId, e.SuborderDtlId })
                    .HasName("NDX_MEMO_DTL4")
                    .IsUnique();

                entity.Property(e => e.MemoDtlId)
                    .HasColumnName("MEMO_DTL_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MemoHdrId)
                    .HasColumnName("MEMO_HDR_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.MemoReasonId)
                    .HasColumnName("MEMO_REASON_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.RefundedPrice)
                    .HasColumnName("REFUNDED_PRICE")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.RefundedQuantity)
                    .HasColumnName("REFUNDED_QUANTITY")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.RefundedServices)
                    .HasColumnName("REFUNDED_SERVICES")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.SuborderDtlId)
                    .HasColumnName("SUBORDER_DTL_ID")
                    .HasColumnType("NUMBER(38)");

                entity.HasOne(d => d.MemoHdr)
                    .WithMany(p => p.MemoDtl)
                    .HasForeignKey(d => d.MemoHdrId)
                    .HasConstraintName("FK_MEMO_DTL1");

                entity.HasOne(d => d.MemoReason)
                    .WithMany(p => p.MemoDtl)
                    .HasForeignKey(d => d.MemoReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEMO_DTL3");

                entity.HasOne(d => d.SuborderDtl)
                    .WithMany(p => p.MemoDtl)
                    .HasForeignKey(d => d.SuborderDtlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEMO_DTL2");
            });

            modelBuilder.Entity<MemoHdr>(entity =>
            {
                entity.ToTable("MEMO_HDR");

                entity.HasIndex(e => e.ActivityId)
                    .HasName("NDX_MEMO_HDR2");

                entity.HasIndex(e => e.MemoHdrId)
                    .HasName("PK_MEMO_HDR")
                    .IsUnique();

                entity.HasIndex(e => e.MemoStatusId)
                    .HasName("NDX_MEMO_HDR3");

                entity.HasIndex(e => e.OrderId)
                    .HasName("NDX_MEMO_HDR1");

                entity.Property(e => e.MemoHdrId)
                    .HasColumnName("MEMO_HDR_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActivityId)
                    .HasColumnName("ACTIVITY_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.MemoDate)
                    .HasColumnName("MEMO_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.MemoStatusId)
                    .HasColumnName("MEMO_STATUS_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasColumnType("VARCHAR2(1024)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("ORDER_ID")
                    .HasColumnType("NUMBER(38)");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.MemoHdr)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_MEMO_HDR2");

                entity.HasOne(d => d.MemoStatus)
                    .WithMany(p => p.MemoHdr)
                    .HasForeignKey(d => d.MemoStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEMO_HDR3");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.MemoHdr)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEMO_HDR1");
            });

            modelBuilder.Entity<MemoReason>(entity =>
            {
                entity.ToTable("MEMO_REASON");

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_MEMO_REASON1");

                entity.HasIndex(e => e.MemoReasonId)
                    .HasName("PK_MEMO_REASON")
                    .IsUnique();

                entity.Property(e => e.MemoReasonId)
                    .HasColumnName("MEMO_REASON_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<MemoStatus>(entity =>
            {
                entity.ToTable("MEMO_STATUS");

                entity.HasIndex(e => e.ActivityTypeId)
                    .HasName("NDX_MEMO_STATUS3");

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_MEMO_STATUS1");

                entity.HasIndex(e => e.MemoStatusId)
                    .HasName("PK_MEMO_STATUS")
                    .IsUnique();

                entity.HasIndex(e => e.SortOrder)
                    .HasName("NDX_MEMO_STATUS2");

                entity.Property(e => e.MemoStatusId)
                    .HasColumnName("MEMO_STATUS_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActivityTypeId)
                    .HasColumnName("ACTIVITY_TYPE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasColumnType("NUMBER(38)");

                entity.HasOne(d => d.ActivityType)
                    .WithMany(p => p.MemoStatus)
                    .HasForeignKey(d => d.ActivityTypeId)
                    .HasConstraintName("FK_MEMO_STATUS1");
            });

            modelBuilder.Entity<Offset>(entity =>
            {
                entity.ToTable("OFFSET");

                entity.HasIndex(e => e.Code)
                    .HasName("NDX_OFFSET_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.OffsetId)
                    .HasName("XPKOFFSET")
                    .IsUnique();

                entity.HasIndex(e => e.OffsetcodeId)
                    .HasName("NDX_OFFSET_OFFSETCODE");

                entity.Property(e => e.OffsetId)
                    .HasColumnName("OFFSET_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(4)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsCod)
                    .HasColumnName("IS_COD")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IsDiscount)
                    .HasColumnName("IS_DISCOUNT")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IsInsurance)
                    .HasColumnName("IS_INSURANCE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IsPostage)
                    .HasColumnName("IS_POSTAGE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IsQuarterbox)
                    .HasColumnName("IS_QUARTERBOX")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IsService)
                    .HasColumnName("IS_SERVICE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IsSmallorder)
                    .HasColumnName("IS_SMALLORDER")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.OffsetcodeId)
                    .HasColumnName("OFFSETCODE_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Offsetcode)
                    .WithMany(p => p.Offset)
                    .HasForeignKey(d => d.OffsetcodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OFFSET2OFFSETCODE");
            });

            modelBuilder.Entity<Offsetcode>(entity =>
            {
                entity.ToTable("OFFSETCODE");

                entity.HasIndex(e => e.Code)
                    .HasName("AK1_OFFSETCODE")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_OFFSETCODE_DESCRIPTION");

                entity.HasIndex(e => e.OffsetcodeId)
                    .HasName("PK_OFFSETCODE")
                    .IsUnique();

                entity.HasIndex(e => e.SortParentId)
                    .HasName("NDX_OFFSETCODE_PARENT");

                entity.Property(e => e.OffsetcodeId)
                    .HasColumnName("OFFSETCODE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SortParentId)
                    .HasColumnName("SORT_PARENT_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.SortParent)
                    .WithMany(p => p.InverseSortParent)
                    .HasForeignKey(d => d.SortParentId)
                    .HasConstraintName("FK_OFFSETCODE_SORTPARENT");
            });

            modelBuilder.Entity<OrderHdr>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK_ORDER");

                entity.ToTable("ORDER_HDR");

                entity.HasIndex(e => e.BillingId)
                    .HasName("NDX_ORDERHDR_BILLINGID");

                entity.HasIndex(e => e.Code)
                    .HasName("NDX_ORDERHDR_CODE");

                entity.HasIndex(e => e.CustomerCreditcardId)
                    .HasName("NDX_ORDER_HDR1");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("NDX_ORDERHDR_CUSTOMERID");

                entity.HasIndex(e => e.EdiPartnerId)
                    .HasName("NDX_ORDER_HDR2");

                entity.HasIndex(e => e.OrderId)
                    .HasName("PK_ORDER")
                    .IsUnique();

                entity.HasIndex(e => e.PlacedbyId)
                    .HasName("NDX_ORDERHDR_PLACEDBY");

                entity.HasIndex(e => e.ShipdayId)
                    .HasName("NDX_ORDERHDR_SHIPDAYID");

                entity.HasIndex(e => e.ShippingHatcheryId)
                    .HasName("NDX_ORDERHDR_HATCHERY");

                entity.HasIndex(e => new { e.EdiPartnerId, e.EdiPartnerLocator })
                    .HasName("NDX_ORDER_HDR3");

                entity.HasIndex(e => new { e.ShipdayId, e.BillingId, e.CustomerId })
                    .HasName("NDX_ORDERHDR_IF1");

                entity.Property(e => e.OrderId)
                    .HasColumnName("ORDER_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AirmailAmount)
                    .HasColumnName("AIRMAIL_AMOUNT")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AirmailOverrideAmount)
                    .HasColumnName("AIRMAIL_OVERRIDE_AMOUNT")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BillingId)
                    .HasColumnName("BILLING_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BoxingAmount)
                    .HasColumnName("BOXING_AMOUNT")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CanMoveUp)
                    .IsRequired()
                    .HasColumnName("CAN_MOVE_UP")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.ChargeForCod)
                    .IsRequired()
                    .HasColumnName("CHARGE_FOR_COD")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ChargeForInsurance)
                    .IsRequired()
                    .HasColumnName("CHARGE_FOR_INSURANCE")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ChargeForPostage)
                    .IsRequired()
                    .HasColumnName("CHARGE_FOR_POSTAGE")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ChargeForQuarterBox)
                    .IsRequired()
                    .HasColumnName("CHARGE_FOR_QUARTER_BOX")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ChargeForSmallOrder)
                    .IsRequired()
                    .HasColumnName("CHARGE_FOR_SMALL_ORDER")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodAmount)
                    .HasColumnName("COD_AMOUNT")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CodOverrideAmount)
                    .HasColumnName("COD_OVERRIDE_AMOUNT")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(12)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerCreditcardId)
                    .HasColumnName("CUSTOMER_CREDITCARD_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CUSTOMER_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateChanged)
                    .HasColumnName("DATE_CHANGED")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DatePlaced)
                    .HasColumnName("DATE_PLACED")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DiscountAmount)
                    .HasColumnName("DISCOUNT_AMOUNT")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.DiscountPercent)
                    .HasColumnName("DISCOUNT_PERCENT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.EdiPartnerId)
                    .HasColumnName("EDI_PARTNER_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EdiPartnerLocator)
                    .HasColumnName("EDI_PARTNER_LOCATOR")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EdiStatus)
                    .HasColumnName("EDI_STATUS")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsuranceAmount)
                    .HasColumnName("INSURANCE_AMOUNT")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("INVOICE_NUMBER")
                    .HasColumnType("VARCHAR2(10)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InvoicePrintCount)
                    .HasColumnName("INVOICE_PRINT_COUNT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InvoiceTotal)
                    .HasColumnName("INVOICE_TOTAL")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IsCodInvoice)
                    .IsRequired()
                    .HasColumnName("IS_COD_INVOICE")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsCreditcardInvoice)
                    .IsRequired()
                    .HasColumnName("IS_CREDITCARD_INVOICE")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ItemSubtotalAmount)
                    .HasColumnName("ITEM_SUBTOTAL_AMOUNT")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.McmurryOrderId)
                    .HasColumnName("MCMURRY_ORDER_ID")
                    .HasColumnType("VARCHAR2(6)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MultipleOrderId)
                    .HasColumnName("MULTIPLE_ORDER_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasColumnType("VARCHAR2(60)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Notes2)
                    .HasColumnName("NOTES2")
                    .HasColumnType("VARCHAR2(60)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PlacedbyContact)
                    .HasColumnName("PLACEDBY_CONTACT")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PlacedbyId)
                    .HasColumnName("PLACEDBY_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PostageAmount)
                    .HasColumnName("POSTAGE_AMOUNT")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.PostageOverrideAmount)
                    .HasColumnName("POSTAGE_OVERRIDE_AMOUNT")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.PostedToAccounting)
                    .IsRequired()
                    .HasColumnName("POSTED_TO_ACCOUNTING")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PrintCodCard)
                    .IsRequired()
                    .HasColumnName("PRINT_COD_CARD")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PrintCodReport)
                    .IsRequired()
                    .HasColumnName("PRINT_COD_REPORT")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PrintInvoice)
                    .IsRequired()
                    .HasColumnName("PRINT_INVOICE")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.QuarterboxAmount)
                    .HasColumnName("QUARTERBOX_AMOUNT")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ServicesAmount)
                    .HasColumnName("SERVICES_AMOUNT")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ShipdayId)
                    .HasColumnName("SHIPDAY_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ShippingHatcheryId)
                    .HasColumnName("SHIPPING_HATCHERY_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ShouldLabelsPrint)
                    .IsRequired()
                    .HasColumnName("SHOULD_LABELS_PRINT")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SmallorderAmount)
                    .HasColumnName("SMALLORDER_AMOUNT")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ToBeDelivered)
                    .IsRequired()
                    .HasColumnName("TO_BE_DELIVERED")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ToBePickedUp)
                    .IsRequired()
                    .HasColumnName("TO_BE_PICKED_UP")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.OrderHdrBilling)
                    .HasForeignKey(d => d.BillingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORDER2BILLTO");

                entity.HasOne(d => d.CustomerCreditcard)
                    .WithMany(p => p.OrderHdr)
                    .HasForeignKey(d => d.CustomerCreditcardId)
                    .HasConstraintName("FK_ORDER_HDR1");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.OrderHdrCustomer)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORDER2SHIPTO");

                entity.HasOne(d => d.EdiPartner)
                    .WithMany(p => p.OrderHdr)
                    .HasForeignKey(d => d.EdiPartnerId)
                    .HasConstraintName("FK_ORDER_HDR2");

                entity.HasOne(d => d.Shipday)
                    .WithMany(p => p.OrderHdr)
                    .HasForeignKey(d => d.ShipdayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORDER2SHIPDAY");

                entity.HasOne(d => d.ShippingHatchery)
                    .WithMany(p => p.OrderHdr)
                    .HasForeignKey(d => d.ShippingHatcheryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORDER2SHIPHATCHERY");
            });

            modelBuilder.Entity<OrderType>(entity =>
            {
                entity.ToTable("ORDER_TYPE");

                entity.HasIndex(e => e.Classification)
                    .HasName("NDX_ORDERTYPE")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_ORDERTYPE_DESCRIPTION");

                entity.HasIndex(e => e.OrderTypeId)
                    .HasName("PK_ORDER_TYPE")
                    .IsUnique();

                entity.HasIndex(e => e.SortOrder)
                    .HasName("NDX_ORDERTYPE2");

                entity.Property(e => e.OrderTypeId)
                    .HasColumnName("ORDER_TYPE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BoxesToCodBundle)
                    .HasColumnName("BOXES_TO_COD_BUNDLE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Classification)
                    .IsRequired()
                    .HasColumnName("CLASSIFICATION")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasColumnName("IS_DEFAULT")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.SortOrder).HasColumnName("SORT_ORDER");
            });

            modelBuilder.Entity<PaymentDtl>(entity =>
            {
                entity.ToTable("PAYMENT_DTL");

                entity.HasIndex(e => e.ActivityId)
                    .HasName("NDX_PAYMENT_DTL2");

                entity.HasIndex(e => e.PaymentDtlId)
                    .HasName("PK_PAYMENT_DTL")
                    .IsUnique();

                entity.HasIndex(e => e.PaymentHdrId)
                    .HasName("NDX_PAYMENT_DTL1");

                entity.Property(e => e.PaymentDtlId)
                    .HasColumnName("PAYMENT_DTL_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActivityId)
                    .HasColumnName("ACTIVITY_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PaymentHdrId)
                    .HasColumnName("PAYMENT_HDR_ID")
                    .HasColumnType("NUMBER(38)");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.PaymentDtl)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAYMENT_DTL2");

                entity.HasOne(d => d.PaymentHdr)
                    .WithMany(p => p.PaymentDtl)
                    .HasForeignKey(d => d.PaymentHdrId)
                    .HasConstraintName("FK_PAYMENT_DTL1");
            });

            modelBuilder.Entity<PaymentHdr>(entity =>
            {
                entity.ToTable("PAYMENT_HDR");

                entity.HasIndex(e => e.BillingId)
                    .HasName("NDX_PAYMENT_HDR2");

                entity.HasIndex(e => e.PaymentHdrId)
                    .HasName("PK_PAYMENT_HDR")
                    .IsUnique();

                entity.HasIndex(e => e.PaymentSessionId)
                    .HasName("NDX_PAYMENT_HDR1");

                entity.Property(e => e.PaymentHdrId)
                    .HasColumnName("PAYMENT_HDR_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BillingId)
                    .HasColumnName("BILLING_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("PAYMENT_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.PaymentSessionId)
                    .HasColumnName("PAYMENT_SESSION_ID")
                    .HasColumnType("NUMBER(38)");

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.PaymentHdr)
                    .HasForeignKey(d => d.BillingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAYMENT_HDR2");

                entity.HasOne(d => d.PaymentSession)
                    .WithMany(p => p.PaymentHdr)
                    .HasForeignKey(d => d.PaymentSessionId)
                    .HasConstraintName("FK_PAYMENT_HDR1");
            });

            modelBuilder.Entity<PaymentSession>(entity =>
            {
                entity.ToTable("PAYMENT_SESSION");

                entity.HasIndex(e => e.PaymentSessionId)
                    .HasName("PK_PAYMENT_SESSION")
                    .IsUnique();

                entity.HasIndex(e => e.PersonId)
                    .HasName("NDX_PAYMENT_SESSION1");

                entity.Property(e => e.PaymentSessionId)
                    .HasColumnName("PAYMENT_SESSION_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateStarted)
                    .HasColumnName("DATE_STARTED")
                    .HasColumnType("DATE");

                entity.Property(e => e.IsPosted)
                    .IsRequired()
                    .HasColumnName("IS_POSTED")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.PersonId)
                    .HasColumnName("PERSON_ID")
                    .HasColumnType("NUMBER(38)");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PaymentSession)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAYMENT_SESSION1");
            });

            modelBuilder.Entity<Paymentterm>(entity =>
            {
                entity.ToTable("PAYMENTTERM");

                entity.HasIndex(e => e.Code)
                    .HasName("NDX_PMTTERM_CODE");

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_PMTTERM_DESCRIPTION");

                entity.HasIndex(e => e.PaymenttermId)
                    .HasName("PK_PAYMENTTERM_ID")
                    .IsUnique();

                entity.Property(e => e.PaymenttermId)
                    .HasColumnName("PAYMENTTERM_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ChargeCod)
                    .IsRequired()
                    .HasColumnName("CHARGE_COD")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Inactive)
                    .IsRequired()
                    .HasColumnName("INACTIVE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.IsCreditCardTerm)
                    .IsRequired()
                    .HasColumnName("IS_CREDIT_CARD_TERM")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.IsPaypalTerm)
                    .IsRequired()
                    .HasColumnName("IS_PAYPAL_TERM")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.MonthlyFinanceCharge)
                    .HasColumnName("MONTHLY_FINANCE_CHARGE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.OnlyShipCod)
                    .IsRequired()
                    .HasColumnName("ONLY_SHIP_COD")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.PerformCloseout)
                    .IsRequired()
                    .HasColumnName("PERFORM_CLOSEOUT")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("PERSON");

                entity.HasIndex(e => e.PersonId)
                    .HasName("PK_PERSON_ID")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("NDX_CUSTOMER_USERID");

                entity.Property(e => e.PersonId)
                    .HasColumnName("PERSON_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CanMergeCustomers)
                    .IsRequired()
                    .HasColumnName("CAN_MERGE_CUSTOMERS")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.CanResubmitEdi)
                    .IsRequired()
                    .HasColumnName("CAN_RESUBMIT_EDI")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.CanShutdownApp)
                    .IsRequired()
                    .HasColumnName("CAN_SHUTDOWN_APP")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.CanUnpostInvoice)
                    .IsRequired()
                    .HasColumnName("CAN_UNPOST_INVOICE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.DeleteCustomer)
                    .IsRequired()
                    .HasColumnName("DELETE_CUSTOMER")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EnterAccounting)
                    .IsRequired()
                    .HasColumnName("ENTER_ACCOUNTING")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.EnterOrders)
                    .IsRequired()
                    .HasColumnName("ENTER_ORDERS")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.IgnoreLockout)
                    .IsRequired()
                    .HasColumnName("IGNORE_LOCKOUT")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.Inactive)
                    .IsRequired()
                    .HasColumnName("INACTIVE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.ItemMaintenance)
                    .IsRequired()
                    .HasColumnName("ITEM_MAINTENANCE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.PerformShipping)
                    .IsRequired()
                    .HasColumnName("PERFORM_SHIPPING")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.ProcessCreditcards)
                    .IsRequired()
                    .HasColumnName("PROCESS_CREDITCARDS")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.RecallCustomer)
                    .IsRequired()
                    .HasColumnName("RECALL_CUSTOMER")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.SendMessages)
                    .IsRequired()
                    .HasColumnName("SEND_MESSAGES")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("USER_ID")
                    .HasColumnType("VARCHAR2(10)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PostalWeight>(entity =>
            {
                entity.ToTable("POSTAL_WEIGHT");

                entity.HasIndex(e => e.OrderTypeId)
                    .HasName("NDX_POSTALWEIGHT_ORDERTYPE");

                entity.HasIndex(e => e.PostalWeightId)
                    .HasName("PK_POSTAL_WEIGHT")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrderTypeId, e.PostalZone, e.Pounds })
                    .HasName("NDX_POSTALWEIGHT_ZONE")
                    .IsUnique();

                entity.HasIndex(e => new { e.PostalZone, e.Pounds, e.OrderTypeId })
                    .HasName("NDX_POSTALWEIGHT_ZONE")
                    .IsUnique();

                entity.Property(e => e.PostalWeightId)
                    .HasColumnName("POSTAL_WEIGHT_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrderTypeId)
                    .HasColumnName("ORDER_TYPE_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.PostalCharge)
                    .HasColumnName("POSTAL_CHARGE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.PostalZone)
                    .IsRequired()
                    .HasColumnName("POSTAL_ZONE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Pounds)
                    .HasColumnName("POUNDS")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.OrderType)
                    .WithMany(p => p.PostalWeight)
                    .HasForeignKey(d => d.OrderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_POSTALWEIGHT2ORDERTYPE");
            });

            modelBuilder.Entity<Postalcode>(entity =>
            {
                entity.ToTable("POSTALCODE");

                entity.HasIndex(e => e.Code)
                    .HasName("AK1_POSTALCODE")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_POSTALCODE_DESCRIPTION");

                entity.HasIndex(e => e.PostalcodeId)
                    .HasName("POSTALCODE_ID")
                    .IsUnique();

                entity.Property(e => e.PostalcodeId)
                    .HasColumnName("POSTALCODE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AirChargeAmount)
                    .HasColumnName("AIR_CHARGE_AMOUNT")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PerUnitWeight)
                    .HasColumnName("PER_UNIT_WEIGHT")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<PostalcodeCharge>(entity =>
            {
                entity.ToTable("POSTALCODE_CHARGE");

                entity.HasIndex(e => e.PostalcodeChargeId)
                    .HasName("PK_POSTALCODE_CHARGE")
                    .IsUnique();

                entity.HasIndex(e => e.PostalcodeId)
                    .HasName("NDX_POSTALCODE_CHARGE2");

                entity.HasIndex(e => new { e.PostalcodeId, e.PostalZone, e.MaximumQuantity })
                    .HasName("NDX_POSTALCODE_CHARGE1")
                    .IsUnique();

                entity.Property(e => e.PostalcodeChargeId)
                    .HasColumnName("POSTALCODE_CHARGE_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Charge)
                    .HasColumnName("CHARGE")
                    .HasColumnType("NUMBER(19,2)");

                entity.Property(e => e.MaximumQuantity)
                    .HasColumnName("MAXIMUM_QUANTITY")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PostalZone)
                    .HasColumnName("POSTAL_ZONE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PostalcodeId)
                    .HasColumnName("POSTALCODE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.HasOne(d => d.Postalcode)
                    .WithMany(p => p.PostalcodeCharge)
                    .HasForeignKey(d => d.PostalcodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_POSTALCODE_CHARGE1");
            });

            modelBuilder.Entity<Pricesheet>(entity =>
            {
                entity.ToTable("PRICESHEET");

                entity.HasIndex(e => e.Code)
                    .HasName("AK1_PRICESEET_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.DefaultPricesheetId)
                    .HasName("NDX_PRICESHEET_DEFAULT");

                entity.HasIndex(e => e.PricesheetId)
                    .HasName("PK_PRICESSHEET")
                    .IsUnique();

                entity.Property(e => e.PricesheetId)
                    .HasColumnName("PRICESHEET_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(2)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DefaultPricesheetId)
                    .HasColumnName("DEFAULT_PRICESHEET_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Inactive)
                    .IsRequired()
                    .HasColumnName("INACTIVE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.IsRetailDefault)
                    .IsRequired()
                    .HasColumnName("IS_RETAIL_DEFAULT")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.SocAmount)
                    .HasColumnName("SOC_AMOUNT")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.DefaultPricesheet)
                    .WithMany(p => p.InverseDefaultPricesheet)
                    .HasForeignKey(d => d.DefaultPricesheetId)
                    .HasConstraintName("FK1_PRICESHEET2PRICESHEET");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("PRODUCT");

                entity.HasIndex(e => e.BreedId)
                    .HasName("NDX_PRODUCT_BREED");

                entity.HasIndex(e => e.Code)
                    .HasName("AK_PRODUCT_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_PRODUCT_DESCRIPTION");

                entity.HasIndex(e => e.EastercodeId)
                    .HasName("NDX_PRODUCT_EASTERCODE");

                entity.HasIndex(e => e.ProductId)
                    .HasName("PK_PRODUCT")
                    .IsUnique();

                entity.HasIndex(e => e.ProductTypeId)
                    .HasName("NDX_PRODUCT_PRODTYPE");

                entity.HasIndex(e => e.ProductcolorId)
                    .HasName("NDX_PRODUCT_COLOR");

                entity.HasIndex(e => e.SortOrder)
                    .HasName("NDX_PRODUCT_SORTORDER");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BoldAvailability)
                    .IsRequired()
                    .HasColumnName("BOLD_AVAILABILITY")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.BreedId)
                    .HasColumnName("BREED_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CheckAvailability)
                    .IsRequired()
                    .HasColumnName("CHECK_AVAILABILITY")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(6)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EastercodeId)
                    .HasColumnName("EASTERCODE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Inactive)
                    .IsRequired()
                    .HasColumnName("INACTIVE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.InventoryControlAmount)
                    .HasColumnName("INVENTORY_CONTROL_AMOUNT")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InventoryControlDate)
                    .HasColumnName("INVENTORY_CONTROL_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InventoryControlMinimum)
                    .HasColumnName("INVENTORY_CONTROL_MINIMUM")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NpipCode)
                    .HasColumnName("NPIP_CODE")
                    .HasColumnType("VARCHAR2(5)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NumberToCorner)
                    .HasColumnName("NUMBER_TO_CORNER")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Pricepoint1)
                    .HasColumnName("PRICEPOINT_1")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Pricepoint2)
                    .HasColumnName("PRICEPOINT_2")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Pricepoint3)
                    .HasColumnName("PRICEPOINT_3")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Pricepoint4)
                    .HasColumnName("PRICEPOINT_4")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Pricepoint5)
                    .HasColumnName("PRICEPOINT_5")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.PrintOnAvailability)
                    .IsRequired()
                    .HasColumnName("PRINT_ON_AVAILABILITY")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.PrintOnLabel)
                    .IsRequired()
                    .HasColumnName("PRINT_ON_LABEL")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.PrintUnitAmount)
                    .IsRequired()
                    .HasColumnName("PRINT_UNIT_AMOUNT")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.ProductTypeId)
                    .IsRequired()
                    .HasColumnName("PRODUCT_TYPE_ID")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProductcolorId)
                    .HasColumnName("PRODUCTCOLOR_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasColumnType("VARCHAR2(10)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Breed)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.BreedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRODUCT2BREED");

                entity.HasOne(d => d.Eastercode)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.EastercodeId)
                    .HasConstraintName("FK_PRODUCT2EASTERCODE");

                entity.HasOne(d => d.ProductType)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FL_PRODUCT2PRODUCTTYPE");

                entity.HasOne(d => d.Productcolor)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductcolorId)
                    .HasConstraintName("FK_PRODUCT2PRODUCTCOLOR");
            });

            modelBuilder.Entity<ProductBreakpoint>(entity =>
            {
                entity.ToTable("PRODUCT_BREAKPOINT");

                entity.HasIndex(e => e.ProductBreakpointId)
                    .HasName("PK_PRODUCT_BREAKPOINT")
                    .IsUnique();

                entity.HasIndex(e => e.ProductId)
                    .HasName("NDX_PRODUCT_BREAKPOINT_1");

                entity.HasIndex(e => new { e.ProductId, e.Quantity })
                    .HasName("UK_PRODUCT_BREAKPOINT_1")
                    .IsUnique();

                entity.Property(e => e.ProductBreakpointId)
                    .HasColumnName("PRODUCT_BREAKPOINT_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("QUANTITY")
                    .HasColumnType("NUMBER(38)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductBreakpoint)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_PRODUCT_BREAKPOINT_1");
            });

            modelBuilder.Entity<ProductBreed>(entity =>
            {
                entity.ToTable("PRODUCT_BREED");

                entity.HasIndex(e => e.LeftWebImageId)
                    .HasName("NDX_PRODUCT_BREED_2");

                entity.HasIndex(e => e.ProductBreedId)
                    .HasName("PK_PRODUCT_BREED")
                    .IsUnique();

                entity.HasIndex(e => e.RightWebImageId)
                    .HasName("NDX_PRODUCT_BREED_3");

                entity.HasIndex(e => e.WebAttrGroupId)
                    .HasName("NDX_PRODUCT_BREED_1");

                entity.Property(e => e.ProductBreedId)
                    .HasColumnName("PRODUCT_BREED_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.LeftWebImageId)
                    .HasColumnName("LEFT_WEB_IMAGE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.RightWebImageId)
                    .HasColumnName("RIGHT_WEB_IMAGE_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ShowOnWeb)
                    .IsRequired()
                    .HasColumnName("SHOW_ON_WEB")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.WebAttrGroupId)
                    .HasColumnName("WEB_ATTR_GROUP_ID")
                    .HasColumnType("NUMBER(38)");
            });

            modelBuilder.Entity<ProductBreedProduct>(entity =>
            {
                entity.ToTable("PRODUCT_BREED_PRODUCT");

                entity.HasIndex(e => e.ProductBreedId)
                    .HasName("NDX_PRODUCT_BREED_PRODUCT_1");

                entity.HasIndex(e => e.ProductBreedProductId)
                    .HasName("PK_PRODUCT_BREED_PRODUCT")
                    .IsUnique();

                entity.HasIndex(e => e.ProductId)
                    .HasName("NDX_PRODUCT_BREED_PRODUCT_2");

                entity.Property(e => e.ProductBreedProductId)
                    .HasColumnName("PRODUCT_BREED_PRODUCT_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProductBreedId)
                    .HasColumnName("PRODUCT_BREED_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ShowOnWeb)
                    .IsRequired()
                    .HasColumnName("SHOW_ON_WEB")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.HasOne(d => d.ProductBreed)
                    .WithMany(p => p.ProductBreedProduct)
                    .HasForeignKey(d => d.ProductBreedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRODUCT_BREED_PRODUCT_1");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductBreedProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRODUCT_BREED_PRODUCT_2");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("PRODUCT_CATEGORY");

                entity.HasIndex(e => e.ProductCategoryId)
                    .HasName("PK_PRODUCT_CATEGORY")
                    .IsUnique();

                entity.Property(e => e.ProductCategoryId)
                    .HasColumnName("PRODUCT_CATEGORY_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(40)");
            });

            modelBuilder.Entity<ProductClass>(entity =>
            {
                entity.ToTable("PRODUCT_CLASS");

                entity.HasIndex(e => e.Description)
                    .HasName("UK_PRODUCT_CLASS_1")
                    .IsUnique();

                entity.HasIndex(e => e.ProductClassId)
                    .HasName("PK_PRODUCT_CLASS")
                    .IsUnique();

                entity.HasIndex(e => e.WebImageId)
                    .HasName("NDX_PRODUCT_CLASS_2");

                entity.HasIndex(e => e.WebPricesheetId)
                    .HasName("NDX_PRODUCT_CLASS_1");

                entity.Property(e => e.ProductClassId)
                    .HasColumnName("PRODUCT_CLASS_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.RealAvailabilityWindow)
                    .HasColumnName("REAL_AVAILABILITY_WINDOW")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("21 ");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasColumnName("SHORT_NAME")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.WebImageId)
                    .HasColumnName("WEB_IMAGE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.WebPricesheetId)
                    .HasColumnName("WEB_PRICESHEET_ID")
                    .HasColumnType("NUMBER(38)");

                entity.HasOne(d => d.WebPricesheet)
                    .WithMany(p => p.ProductClass)
                    .HasForeignKey(d => d.WebPricesheetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRODUCT_CLASS_2");
            });

            modelBuilder.Entity<ProductClassCategory>(entity =>
            {
                entity.HasKey(e => new { e.ProductClassId, e.ProductCategoryId });

                entity.ToTable("PRODUCT_CLASS_CATEGORY");

                entity.HasIndex(e => e.ProductCategoryId)
                    .HasName("NDX_PRODUCT_CLASS_CATEGORY_2");

                entity.HasIndex(e => e.ProductClassId)
                    .HasName("NDX_PRODUCT_CLASS_CATEGORY_1");

                entity.HasIndex(e => new { e.ProductClassId, e.ProductCategoryId })
                    .HasName("PK_PRODUCT_CLASS_CATEGORY")
                    .IsUnique();

                entity.Property(e => e.ProductClassId)
                    .HasColumnName("PRODUCT_CLASS_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ProductCategoryId)
                    .HasColumnName("PRODUCT_CATEGORY_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ShowOnShopPage)
                    .IsRequired()
                    .HasColumnName("SHOW_ON_SHOP_PAGE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.ProductClassCategory)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRODUCT_CLASS_CATEGORY_2");

                entity.HasOne(d => d.ProductClass)
                    .WithMany(p => p.ProductClassCategory)
                    .HasForeignKey(d => d.ProductClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRODUCT_CLASS_CATEGORY_1");
            });

            modelBuilder.Entity<ProductClassMember>(entity =>
            {
                entity.HasKey(e => new { e.ProductClassId, e.BreedId });

                entity.ToTable("PRODUCT_CLASS_MEMBER");

                entity.HasIndex(e => e.BreedId)
                    .HasName("NDX_PRODUCT_CLASS_MEMBER_02");

                entity.HasIndex(e => e.ProductClassId)
                    .HasName("NDX_PRODUCT_CLASS_MEMBER_01");

                entity.HasIndex(e => new { e.ProductClassId, e.BreedId })
                    .HasName("PK_PRODUCT_CLASS_MEMBER")
                    .IsUnique();

                entity.Property(e => e.ProductClassId)
                    .HasColumnName("PRODUCT_CLASS_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.BreedId)
                    .HasColumnName("BREED_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER(4)");

                entity.HasOne(d => d.Breed)
                    .WithMany(p => p.ProductClassMember)
                    .HasForeignKey(d => d.BreedId)
                    .HasConstraintName("FK_PRODUCT_CLASS_MEMBER_02");

                entity.HasOne(d => d.ProductClass)
                    .WithMany(p => p.ProductClassMember)
                    .HasForeignKey(d => d.ProductClassId)
                    .HasConstraintName("FK_PRODUCT_CLASS_MEMBER_01");
            });

            modelBuilder.Entity<ProductPricedate>(entity =>
            {
                entity.ToTable("PRODUCT_PRICEDATE");

                entity.HasIndex(e => e.ProductPricedateId)
                    .HasName("PK_PRODUCT_PRICEDATE")
                    .IsUnique();

                entity.HasIndex(e => new { e.EffectiveDate, e.ExpirationDate })
                    .HasName("UK_PRODUCT_PRICEDATE1")
                    .IsUnique();

                entity.Property(e => e.ProductPricedateId)
                    .HasColumnName("PRODUCT_PRICEDATE_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("EFFECTIVE_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("EXPIRATION_DATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("to_date('99991231', 'YYYYMMDD') ");
            });

            modelBuilder.Entity<ProductPricing>(entity =>
            {
                entity.ToTable("PRODUCT_PRICING");

                entity.HasIndex(e => e.PricesheetId)
                    .HasName("NDX_PRODUCT_PRICING_2");

                entity.HasIndex(e => e.ProductBreakpointId)
                    .HasName("NDX_PRODUCT_PRICING_1");

                entity.HasIndex(e => e.ProductPricedateId)
                    .HasName("NDX_PRODUCT_PRICING_3");

                entity.HasIndex(e => e.ProductPricingId)
                    .HasName("PK_PRODUCT_PRICING")
                    .IsUnique();

                entity.HasIndex(e => new { e.ProductBreakpointId, e.PricesheetId, e.ProductPricedateId })
                    .HasName("UK_PRODUCT_PRICING_1")
                    .IsUnique();

                entity.Property(e => e.ProductPricingId)
                    .HasColumnName("PRODUCT_PRICING_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("NUMBER(38,4)");

                entity.Property(e => e.PricesheetId)
                    .HasColumnName("PRICESHEET_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ProductBreakpointId)
                    .HasColumnName("PRODUCT_BREAKPOINT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ProductPricedateId)
                    .HasColumnName("PRODUCT_PRICEDATE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.HasOne(d => d.Pricesheet)
                    .WithMany(p => p.ProductPricing)
                    .HasForeignKey(d => d.PricesheetId)
                    .HasConstraintName("FK_PRODUCT_PRICING_2");

                entity.HasOne(d => d.ProductBreakpoint)
                    .WithMany(p => p.ProductPricing)
                    .HasForeignKey(d => d.ProductBreakpointId)
                    .HasConstraintName("FK_PRODUCT_PRICING_1");

                entity.HasOne(d => d.ProductPricedate)
                    .WithMany(p => p.ProductPricing)
                    .HasForeignKey(d => d.ProductPricedateId)
                    .HasConstraintName("FK_PRODUCT_PRICING_3");
            });

            modelBuilder.Entity<ProductSoldout>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ShipDate });

                entity.ToTable("PRODUCT_SOLDOUT");

                entity.HasIndex(e => e.ProductId)
                    .HasName("NDX_PRODUCT_SOLDOUT_01");

                entity.HasIndex(e => new { e.ProductId, e.ShipDate })
                    .HasName("PK_PRODUCT_SOLDOUT")
                    .IsUnique();

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ShipDate)
                    .HasColumnName("SHIP_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSoldout)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_PRODUCT_SOLDOUT_01");
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.ToTable("PRODUCT_TYPE");

                entity.HasIndex(e => e.ProductTypeId)
                    .HasName("PK_PRODUCT_TYPE")
                    .IsUnique();

                entity.Property(e => e.ProductTypeId)
                    .HasColumnName("PRODUCT_TYPE_ID")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.AvailabilityModifier).HasColumnName("AVAILABILITY_MODIFIER");

                entity.Property(e => e.CheckAvailability)
                    .IsRequired()
                    .HasColumnName("CHECK_AVAILABILITY")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("CHAR(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsEggItem)
                    .IsRequired()
                    .HasColumnName("IS_EGG_ITEM")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IsMale)
                    .IsRequired()
                    .HasColumnName("IS_MALE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IsPoultryItem)
                    .IsRequired()
                    .HasColumnName("IS_POULTRY_ITEM")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IsPullet)
                    .IsRequired()
                    .HasColumnName("IS_PULLET")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IsStraightRun)
                    .IsRequired()
                    .HasColumnName("IS_STRAIGHT_RUN")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<Productcolor>(entity =>
            {
                entity.ToTable("PRODUCTCOLOR");

                entity.HasIndex(e => e.Code)
                    .HasName("AK1_PRODUCTCOLOR")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_PRODUCTCOLOR_DESCRIPTION");

                entity.HasIndex(e => e.ProductcolorId)
                    .HasName("PK_PRODUCTCOLOR")
                    .IsUnique();

                entity.Property(e => e.ProductcolorId)
                    .HasColumnName("PRODUCTCOLOR_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(2)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<QEmail>(entity =>
            {
                entity.HasKey(e => e.Msgid)
                    .HasName("SYS_C0040745");

                entity.ToTable("Q_EMAIL");

                entity.HasIndex(e => e.Msgid)
                    .HasName("SYS_C0040745")
                    .IsUnique();

                entity.HasIndex(e => e.TimeManagerInfo)
                    .HasName("AQ$_Q_EMAIL_T");

                entity.HasIndex(e => new { e.QName, e.State, e.EnqTime, e.StepNo, e.ChainNo, e.LocalOrderNo })
                    .HasName("AQ$_Q_EMAIL_I");

                entity.Property(e => e.Msgid)
                    .HasColumnName("MSGID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChainNo)
                    .HasColumnName("CHAIN_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Corrid)
                    .HasColumnName("CORRID")
                    .HasColumnType("VARCHAR2(128)");

                entity.Property(e => e.Cscn)
                    .HasColumnName("CSCN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Delay)
                    .HasColumnName("DELAY")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.DeqTid)
                    .HasColumnName("DEQ_TID")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.DeqTime)
                    .HasColumnName("DEQ_TIME")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.DeqUid)
                    .HasColumnName("DEQ_UID")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.DequeueMsgid).HasColumnName("DEQUEUE_MSGID");

                entity.Property(e => e.Dscn)
                    .HasColumnName("DSCN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.EnqTid)
                    .HasColumnName("ENQ_TID")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.EnqTime)
                    .HasColumnName("ENQ_TIME")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.EnqUid)
                    .HasColumnName("ENQ_UID")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.ExceptionQschema)
                    .HasColumnName("EXCEPTION_QSCHEMA")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.ExceptionQueue)
                    .HasColumnName("EXCEPTION_QUEUE")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Expiration)
                    .HasColumnName("EXPIRATION")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.LocalOrderNo)
                    .HasColumnName("LOCAL_ORDER_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Priority)
                    .HasColumnName("PRIORITY")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.QName)
                    .HasColumnName("Q_NAME")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.RecipientKey)
                    .HasColumnName("RECIPIENT_KEY")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.RetryCount)
                    .HasColumnName("RETRY_COUNT")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SenderAddress)
                    .HasColumnName("SENDER_ADDRESS")
                    .HasColumnType("VARCHAR2(1024)");

                entity.Property(e => e.SenderName)
                    .HasColumnName("SENDER_NAME")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.SenderProtocol)
                    .HasColumnName("SENDER_PROTOCOL")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.StepNo)
                    .HasColumnName("STEP_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.TimeManagerInfo)
                    .HasColumnName("TIME_MANAGER_INFO")
                    .HasColumnType("TIMESTAMP(6)");
            });

            modelBuilder.Entity<Rolodex>(entity =>
            {
                entity.ToTable("ROLODEX");

                entity.HasIndex(e => e.AlphaSearch)
                    .HasName("NDX_ROLODEX_ALPHA");

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_ROLODEX_DESCRIPTION");

                entity.HasIndex(e => e.RolodexId)
                    .HasName("PK_ROLODEX")
                    .IsUnique();

                entity.HasIndex(e => e.RolodexTypeId)
                    .HasName("NDX_ROLODEX_ROLOTYPE");

                entity.HasIndex(e => e.ZipcodeId)
                    .HasName("NDX_ROLODEX_ZIPCODE");

                entity.Property(e => e.RolodexId)
                    .HasColumnName("ROLODEX_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS1")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS2")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AlphaSearch)
                    .HasColumnName("ALPHA_SEARCH")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("EMAIL_ADDRESS")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasColumnType("CLOB");

                entity.Property(e => e.Phone1)
                    .HasColumnName("PHONE1")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Phone2)
                    .HasColumnName("PHONE2")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.QuickDialNumber)
                    .HasColumnName("QUICK_DIAL_NUMBER")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.RolodexTypeId)
                    .HasColumnName("ROLODEX_TYPE_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ZipcodeId)
                    .HasColumnName("ZIPCODE_ID")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<RolodexType>(entity =>
            {
                entity.ToTable("ROLODEX_TYPE");

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_ROLODEX_TYPE_DESCRIPT");

                entity.HasIndex(e => e.RolodexTypeId)
                    .HasName("PK_ROLODEX_TYPE")
                    .IsUnique();

                entity.Property(e => e.RolodexTypeId)
                    .HasColumnName("ROLODEX_TYPE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(2)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.ToTable("ROUTE");

                entity.HasIndex(e => e.Code)
                    .HasName("NDX_ROUTE1")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_ROUTE2");

                entity.HasIndex(e => e.RouteId)
                    .HasName("PK_ROUTE")
                    .IsUnique();

                entity.Property(e => e.RouteId)
                    .HasColumnName("ROUTE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(10)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<Sessions>(entity =>
            {
                entity.ToTable("SESSIONS");

                entity.HasIndex(e => e.Id)
                    .HasName("XPKSESSIONS")
                    .IsUnique();

                entity.HasIndex(e => e.LastAccess)
                    .HasName("XIE1SESSIONS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("VARCHAR2(32)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ASession)
                    .HasColumnName("A_SESSION")
                    .HasColumnType("LONG");

                entity.Property(e => e.LastAccess)
                    .HasColumnName("LAST_ACCESS")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");
            });

            modelBuilder.Entity<ShipdayCode>(entity =>
            {
                entity.ToTable("SHIPDAY_CODE");

                entity.HasIndex(e => e.Code)
                    .HasName("NDX_SHIPDAYCODE_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_SHIPDAYCODE_DESCRIPION");

                entity.HasIndex(e => e.ShipdayCodeId)
                    .HasName("PK_SHIPDAY_CODE")
                    .IsUnique();

                entity.Property(e => e.ShipdayCodeId)
                    .HasColumnName("SHIPDAY_CODE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsEaster)
                    .IsRequired()
                    .HasColumnName("IS_EASTER")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");
            });

            modelBuilder.Entity<ShipdayDtl>(entity =>
            {
                entity.HasKey(e => new { e.ShipdayId, e.ShipdayCodeId });

                entity.ToTable("SHIPDAY_DTL");

                entity.HasIndex(e => e.ShipdayCodeId)
                    .HasName("NDX_SHIPDAYDTL_SHIPDAY_CODE");

                entity.HasIndex(e => e.ShipdayId)
                    .HasName("NDX_SHIPDAYDTL_SHIPDAY");

                entity.HasIndex(e => new { e.ShipdayId, e.ShipdayCodeId })
                    .HasName("PK_SHIPDAY_DTL")
                    .IsUnique();

                entity.Property(e => e.ShipdayId)
                    .HasColumnName("SHIPDAY_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ShipdayCodeId)
                    .HasColumnName("SHIPDAY_CODE_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.ShipdayCode)
                    .WithMany(p => p.ShipdayDtl)
                    .HasForeignKey(d => d.ShipdayCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHIPDAYDTL2SHIPDAYCODE");

                entity.HasOne(d => d.Shipday)
                    .WithMany(p => p.ShipdayDtl)
                    .HasForeignKey(d => d.ShipdayId)
                    .HasConstraintName("FK_SHIPDAYDTL2SHIPDAY");
            });

            modelBuilder.Entity<ShipdayHdr>(entity =>
            {
                entity.HasKey(e => e.ShipdayId)
                    .HasName("PK_SHIPDAY");

                entity.ToTable("SHIPDAY_HDR");

                entity.HasIndex(e => e.OrderTypeId)
                    .HasName("NDX_SHIPDAYHDR_ORDER_TYPE");

                entity.HasIndex(e => e.PreviousYearId)
                    .HasName("NDX_SHIPDAYHDR_PREVIOUSYEARID");

                entity.HasIndex(e => e.ShipDate)
                    .HasName("NDX_SHIPDAY_DATE");

                entity.HasIndex(e => e.ShipdayId)
                    .HasName("PK_SHIPDAY")
                    .IsUnique();

                entity.HasIndex(e => new { e.ShipDate, e.OrderTypeId })
                    .HasName("UK_SHIPDAY_HDR_01")
                    .IsUnique();

                entity.Property(e => e.ShipdayId)
                    .HasColumnName("SHIPDAY_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsClosed)
                    .IsRequired()
                    .HasColumnName("IS_CLOSED")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrderTypeId)
                    .HasColumnName("ORDER_TYPE_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.PreviousYearId)
                    .HasColumnName("PREVIOUS_YEAR_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ShipDate)
                    .HasColumnName("SHIP_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.OrderType)
                    .WithMany(p => p.ShipdayHdr)
                    .HasForeignKey(d => d.OrderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHIPDAYHDR2ORDERTYPE");

                entity.HasOne(d => d.PreviousYear)
                    .WithMany(p => p.InversePreviousYear)
                    .HasForeignKey(d => d.PreviousYearId)
                    .HasConstraintName("FK_SHIPDAYHDR2SHIPDAYHDR");
            });

            modelBuilder.Entity<ShipdayRoute>(entity =>
            {
                entity.HasKey(e => new { e.ShipdayId, e.RouteId });

                entity.ToTable("SHIPDAY_ROUTE");

                entity.HasIndex(e => e.RouteId)
                    .HasName("NDX_SHIPDAY_ROUTE2");

                entity.HasIndex(e => e.ShipdayId)
                    .HasName("NDX_SHIPDAY_ROUTE1");

                entity.HasIndex(e => new { e.ShipdayId, e.RouteId })
                    .HasName("PK_SHIPDAY_ROUTE")
                    .IsUnique();

                entity.Property(e => e.ShipdayId)
                    .HasColumnName("SHIPDAY_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.RouteId)
                    .HasColumnName("ROUTE_ID")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<ShippingLocation>(entity =>
            {
                entity.ToTable("SHIPPING_LOCATION");

                entity.HasIndex(e => e.Code)
                    .HasName("NDX_SHIPPING_LOCATION_CODE");

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_SHIPPING_LOCATION_DESC");

                entity.HasIndex(e => e.ShippingLocationId)
                    .HasName("PK_SHIPPING_LOCATION")
                    .IsUnique();

                entity.Property(e => e.ShippingLocationId)
                    .HasColumnName("SHIPPING_LOCATION_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ShippingTruck>(entity =>
            {
                entity.ToTable("SHIPPING_TRUCK");

                entity.HasIndex(e => e.Code)
                    .HasName("NDX_SHIPPING_TRUCK_CODE");

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_SHIPPING_TRUCK_DESC");

                entity.HasIndex(e => e.ShippingTruckId)
                    .HasName("PK_SHIPPING_TRUCK")
                    .IsUnique();

                entity.Property(e => e.ShippingTruckId)
                    .HasColumnName("SHIPPING_TRUCK_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ShippingZone>(entity =>
            {
                entity.HasKey(e => e.Zip)
                    .HasName("PK_SHIPPINGZONE");

                entity.ToTable("SHIPPING_ZONE");

                entity.HasIndex(e => e.ShippingLocationId)
                    .HasName("NDX_SHIPZONE_SHIPPING_LOCATION");

                entity.HasIndex(e => e.ShippingTruckId)
                    .HasName("NDX_SHIPZONE_SHIPPING_TRUCK");

                entity.HasIndex(e => e.Zip)
                    .HasName("PK_SHIPPINGZONE")
                    .IsUnique();

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasColumnType("VARCHAR2(3)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrintTime)
                    .IsRequired()
                    .HasColumnName("PRINT_TIME")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("null ");

                entity.Property(e => e.ShippingLocationId)
                    .HasColumnName("SHIPPING_LOCATION_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ShippingTime)
                    .IsRequired()
                    .HasColumnName("SHIPPING_TIME")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("null ");

                entity.Property(e => e.ShippingTruckId)
                    .HasColumnName("SHIPPING_TRUCK_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.UseAirmail)
                    .IsRequired()
                    .HasColumnName("USE_AIRMAIL")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("null ");

                entity.Property(e => e.Zone)
                    .IsRequired()
                    .HasColumnName("ZONE")
                    .HasColumnType("CHAR(1)");

                entity.HasOne(d => d.ShippingLocation)
                    .WithMany(p => p.ShippingZone)
                    .HasForeignKey(d => d.ShippingLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHIPPINGZONE2SHIPPINGLOC");

                entity.HasOne(d => d.ShippingTruck)
                    .WithMany(p => p.ShippingZone)
                    .HasForeignKey(d => d.ShippingTruckId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHIPPINGZONE2SHIPPINGTRUCK");
            });

            modelBuilder.Entity<SoldOut>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ShipDate });

                entity.ToTable("SOLD_OUT");

                entity.HasIndex(e => e.ProductId)
                    .HasName("NDX_SOLD_OUT_01");

                entity.HasIndex(e => new { e.ProductId, e.ShipDate })
                    .HasName("PK_SOLD_OUT")
                    .IsUnique();

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ShipDate)
                    .HasColumnName("SHIP_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SoldOut)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_SOLD_OUT_01");
            });

            modelBuilder.Entity<SpecialInstruction>(entity =>
            {
                entity.ToTable("SPECIAL_INSTRUCTION");

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_SPECINST_DESCRIPTION");

                entity.HasIndex(e => e.SpecialInstructionId)
                    .HasName("PK_SPECIAL_INSTRUCTION")
                    .IsUnique();

                entity.Property(e => e.SpecialInstructionId)
                    .HasColumnName("SPECIAL_INSTRUCTION_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(3)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DoNotChargeForBoxing)
                    .IsRequired()
                    .HasColumnName("DO_NOT_CHARGE_FOR_BOXING")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IsHealthPapers)
                    .IsRequired()
                    .HasColumnName("IS_HEALTH_PAPERS")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.MustShip)
                    .IsRequired()
                    .HasColumnName("MUST_SHIP")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SpecialService>(entity =>
            {
                entity.ToTable("SPECIAL_SERVICE");

                entity.HasIndex(e => e.OffsetId)
                    .HasName("NDX_SSERVICE_OFFSET");

                entity.HasIndex(e => e.SpecialServiceId)
                    .HasName("PK_SPECIALSERVICE_ID")
                    .IsUnique();

                entity.Property(e => e.SpecialServiceId)
                    .HasColumnName("SPECIAL_SERVICE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsVaccinate)
                    .IsRequired()
                    .HasColumnName("IS_VACCINATE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.OffsetId)
                    .HasColumnName("OFFSET_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Offset)
                    .WithMany(p => p.SpecialService)
                    .HasForeignKey(d => d.OffsetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPECSERV2OFFSET");
            });

            modelBuilder.Entity<Specials>(entity =>
            {
                entity.HasKey(e => e.SpecialId);

                entity.ToTable("SPECIALS");

                entity.HasIndex(e => e.ProductId)
                    .HasName("NDX_SPECIALS_01");

                entity.HasIndex(e => e.SpecialId)
                    .HasName("PK_SPECIALS")
                    .IsUnique();

                entity.Property(e => e.SpecialId)
                    .HasColumnName("SPECIAL_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IgnoreFirstBreakRule)
                    .IsRequired()
                    .HasColumnName("IGNORE_FIRST_BREAK_RULE")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("NUMBER(12,2)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Specials)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_SPECIALS_01");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("STATE");

                entity.HasIndex(e => e.Code)
                    .HasName("UK_STATE_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_STATE");

                entity.HasIndex(e => e.StateId)
                    .HasName("PK_STATE")
                    .IsUnique();

                entity.Property(e => e.StateId)
                    .HasColumnName("STATE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(2)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Suborder>(entity =>
            {
                entity.ToTable("SUBORDER");

                entity.HasIndex(e => e.OrderId)
                    .HasName("NDX_SUBORDER_ORDERID");

                entity.HasIndex(e => e.SuborderId)
                    .HasName("PK_SUBORDER_ID")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrderId, e.SuborderId })
                    .HasName("NDX_SUBORDER2");

                entity.Property(e => e.SuborderId)
                    .HasColumnName("SUBORDER_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrderId)
                    .HasColumnName("ORDER_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.PoNumber)
                    .HasColumnName("PO_NUMBER")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Suborder)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SUBORDER2ORDER");
            });

            modelBuilder.Entity<SuborderDtl>(entity =>
            {
                entity.ToTable("SUBORDER_DTL");

                entity.HasIndex(e => e.ProductId)
                    .HasName("NDX_SUBORDERDTL_PRODUCTID");

                entity.HasIndex(e => e.SuborderDtlId)
                    .HasName("PK_SUBORDERDTL_ID")
                    .IsUnique();

                entity.HasIndex(e => e.SuborderId)
                    .HasName("NDX_SUBORDERDTL_SUBORDER");

                entity.HasIndex(e => new { e.SuborderId, e.EdiPartnerLocator })
                    .HasName("NDX_SUBORDER_DTL1");

                entity.Property(e => e.SuborderDtlId)
                    .HasColumnName("SUBORDER_DTL_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EdiPartnerLocator)
                    .HasColumnName("EDI_PARTNER_LOCATOR")
                    .HasColumnType("VARCHAR2(64)");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OutsourceId)
                    .HasColumnName("OUTSOURCE_ID")
                    .HasColumnType("VARCHAR2(2)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OutsourceLabelQuantity)
                    .HasColumnName("OUTSOURCE_LABEL_QUANTITY")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.OutsourceReportQuantity)
                    .HasColumnName("OUTSOURCE_REPORT_QUANTITY")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Quantity)
                    .HasColumnName("QUANTITY")
                    .HasColumnType("NUMBER(38,2)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SuborderId)
                    .HasColumnName("SUBORDER_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SuborderDtl)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SUBORDERDTL2PRODUCT");

                entity.HasOne(d => d.Suborder)
                    .WithMany(p => p.SuborderDtl)
                    .HasForeignKey(d => d.SuborderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SUBORDERDTL2SUBORDER");
            });

            modelBuilder.Entity<SuggestiveSell>(entity =>
            {
                entity.ToTable("SUGGESTIVE_SELL");

                entity.HasIndex(e => e.ProductId)
                    .HasName("NDX_SUGGESTIVE_SELL_01");

                entity.HasIndex(e => e.SuggestiveSellId)
                    .HasName("PK_SUGGESTIVE_SELL")
                    .IsUnique();

                entity.Property(e => e.SuggestiveSellId)
                    .HasColumnName("SUGGESTIVE_SELL_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BegDate)
                    .HasColumnName("BEG_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER(4)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SuggestiveSell)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_SUGGESTIVE_SELL_01");
            });

            modelBuilder.Entity<TempBreedAvailability>(entity =>
            {
                entity.HasKey(e => new { e.BreedId, e.ShipDate });

                entity.ToTable("TEMP_BREED_AVAILABILITY");

                entity.HasIndex(e => new { e.ShipDate, e.BreedId })
                    .HasName("PK_TEMP_BREED_AVAILABILITY")
                    .IsUnique();

                entity.Property(e => e.BreedId)
                    .HasColumnName("BREED_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ShipDate)
                    .HasColumnName("SHIP_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.AdjBreedNonsexableAvailable)
                    .HasColumnName("ADJ_BREED_NONSEXABLE_AVAILABLE")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AdjBreedSexableAvailable)
                    .HasColumnName("ADJ_BREED_SEXABLE_AVAILABLE")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AdjTotalNonsexableAvail)
                    .HasColumnName("ADJ_TOTAL_NONSEXABLE_AVAIL")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AdjTotalSexableAvail)
                    .HasColumnName("ADJ_TOTAL_SEXABLE_AVAIL")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedAvailabilityId)
                    .HasColumnName("BREED_AVAILABILITY_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.BreedInsrcMSold)
                    .HasColumnName("BREED_INSRC_M_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedInsrcNonsexSreSold)
                    .HasColumnName("BREED_INSRC_NONSEX_SRE_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedInsrcPSold)
                    .HasColumnName("BREED_INSRC_P_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedInsrcSexSreSold)
                    .HasColumnName("BREED_INSRC_SEX_SRE_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedInsrcSrSold)
                    .HasColumnName("BREED_INSRC_SR_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedMSold)
                    .HasColumnName("BREED_M_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedNonsexableAvailable)
                    .HasColumnName("BREED_NONSEXABLE_AVAILABLE")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedNonsexableAvgEggYield)
                    .HasColumnName("BREED_NONSEXABLE_AVG_EGG_YIELD")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedNonsexableProjected)
                    .HasColumnName("BREED_NONSEXABLE_PROJECTED")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedNonsexableSreSold)
                    .HasColumnName("BREED_NONSEXABLE_SRE_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedNonsexableTrayCount)
                    .HasColumnName("BREED_NONSEXABLE_TRAY_COUNT")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedOutsrcMSold)
                    .HasColumnName("BREED_OUTSRC_M_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedOutsrcNonsexSreSold)
                    .HasColumnName("BREED_OUTSRC_NONSEX_SRE_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedOutsrcPSold)
                    .HasColumnName("BREED_OUTSRC_P_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedOutsrcSexSreSold)
                    .HasColumnName("BREED_OUTSRC_SEX_SRE_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedOutsrcSrSold)
                    .HasColumnName("BREED_OUTSRC_SR_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedPSold)
                    .HasColumnName("BREED_P_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedSexableAvailable)
                    .HasColumnName("BREED_SEXABLE_AVAILABLE")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedSexableAvgEggYield)
                    .HasColumnName("BREED_SEXABLE_AVG_EGG_YIELD")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedSexableProjected)
                    .HasColumnName("BREED_SEXABLE_PROJECTED")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedSexableSreSold)
                    .HasColumnName("BREED_SEXABLE_SRE_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedSexableTrayCount)
                    .HasColumnName("BREED_SEXABLE_TRAY_COUNT")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BreedSrSold)
                    .HasColumnName("BREED_SR_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.MFactor)
                    .HasColumnName("M_FACTOR")
                    .HasColumnType("NUMBER(4)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.PFactor)
                    .HasColumnName("P_FACTOR")
                    .HasColumnType("NUMBER(4)")
                    .HasDefaultValueSql("2 ");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER(4)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.SrFactor)
                    .HasColumnName("SR_FACTOR")
                    .HasColumnType("NUMBER(4)")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.TotalMSold)
                    .HasColumnName("TOTAL_M_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.TotalNonsexableAvailable)
                    .HasColumnName("TOTAL_NONSEXABLE_AVAILABLE")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.TotalNonsexableProjected)
                    .HasColumnName("TOTAL_NONSEXABLE_PROJECTED")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.TotalNonsexableSreSold)
                    .HasColumnName("TOTAL_NONSEXABLE_SRE_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.TotalPSold)
                    .HasColumnName("TOTAL_P_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.TotalSexableAvailable)
                    .HasColumnName("TOTAL_SEXABLE_AVAILABLE")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.TotalSexableProjected)
                    .HasColumnName("TOTAL_SEXABLE_PROJECTED")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.TotalSexableSreSold)
                    .HasColumnName("TOTAL_SEXABLE_SRE_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.TotalSrSold)
                    .HasColumnName("TOTAL_SR_SOLD")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<TempLob>(entity =>
            {
                entity.ToTable("TEMP_LOB");

                entity.HasIndex(e => e.TempLobId)
                    .HasName("XPKTEMP_LOB")
                    .IsUnique();

                entity.Property(e => e.TempLobId)
                    .HasColumnName("TEMP_LOB_ID")
                    .HasDefaultValueSql("sys_guid() ");

                entity.Property(e => e.BlobVal)
                    .HasColumnName("BLOB_VAL")
                    .HasColumnType("BLOB");

                entity.Property(e => e.ClobVal)
                    .HasColumnName("CLOB_VAL")
                    .HasColumnType("CLOB");
            });

            modelBuilder.Entity<Waitlist>(entity =>
            {
                entity.ToTable("WAITLIST");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("NDX_WAITLIST_02");

                entity.HasIndex(e => e.ProductId)
                    .HasName("NDX_WAITLIST_01");

                entity.HasIndex(e => e.WaitlistId)
                    .HasName("PK_WAITLIST")
                    .IsUnique();

                entity.Property(e => e.WaitlistId)
                    .HasColumnName("WAITLIST_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AnyPreviousOrders)
                    .IsRequired()
                    .HasColumnName("ANY_PREVIOUS_ORDERS")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CUSTOMER_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnName("EMAIL_ADDRESS")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.IsWholesaleCustomer)
                    .IsRequired()
                    .HasColumnName("IS_WHOLESALE_CUSTOMER")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("PHONE_NUMBER")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.PreviousOrderDate)
                    .HasColumnName("PREVIOUS_ORDER_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Quantity)
                    .HasColumnName("QUANTITY")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.WaitlistDate)
                    .HasColumnName("WAITLIST_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Waitlist)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_WAITLIST_02");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Waitlist)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_WAITLIST_01");
            });

            modelBuilder.Entity<WebAccount>(entity =>
            {
                entity.ToTable("WEB_ACCOUNT");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("XIE1WEB_ACCOUNT");

                entity.HasIndex(e => e.EmailAddress)
                    .HasName("XAK1WEB_ACCOUNT")
                    .IsUnique();

                entity.HasIndex(e => e.Expiry)
                    .HasName("XIF1WEB_ACCOUNT");

                entity.HasIndex(e => e.LastBillingWebAddressId)
                    .HasName("XIE2WEB_ACCOUNT");

                entity.HasIndex(e => e.LastShippingWebAddressId)
                    .HasName("XIE3WEB_ACCOUNT");

                entity.HasIndex(e => e.WebAccountId)
                    .HasName("XPKWEB_ACCOUNT")
                    .IsUnique();

                entity.Property(e => e.WebAccountId)
                    .HasColumnName("WEB_ACCOUNT_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CUSTOMER_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnName("EMAIL_ADDRESS")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Expiry)
                    .HasColumnName("EXPIRY")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastBillingWebAddressId)
                    .HasColumnName("LAST_BILLING_WEB_ADDRESS_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.LastShippingWebAddressId)
                    .HasColumnName("LAST_SHIPPING_WEB_ADDRESS_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasColumnType("VARCHAR2(100)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.WebAccount)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("XFK1WEB_ACCOUNT");

                entity.HasOne(d => d.LastBillingWebAddress)
                    .WithMany(p => p.WebAccountLastBillingWebAddress)
                    .HasForeignKey(d => d.LastBillingWebAddressId)
                    .HasConstraintName("XFK2WEB_ACCOUNT");

                entity.HasOne(d => d.LastShippingWebAddress)
                    .WithMany(p => p.WebAccountLastShippingWebAddress)
                    .HasForeignKey(d => d.LastShippingWebAddressId)
                    .HasConstraintName("XFK3WEB_ACCOUNT");
            });

            modelBuilder.Entity<WebAccountAddress>(entity =>
            {
                entity.HasKey(e => new { e.WebAccountId, e.WebAddressId, e.AddressType })
                    .HasName("XPKWEB_ACCOUNT_ADDRESS");

                entity.ToTable("WEB_ACCOUNT_ADDRESS");

                entity.HasIndex(e => e.WebAccountId)
                    .HasName("XIE1WEB_ACCOUNT_ADDRESS");

                entity.HasIndex(e => e.WebAddressId)
                    .HasName("XIE2WEB_ACCOUNT_ADDRESS");

                entity.HasIndex(e => new { e.WebAccountId, e.WebAddressId, e.AddressType })
                    .HasName("XPKWEB_ACCOUNT_ADDRESS")
                    .IsUnique();

                entity.Property(e => e.WebAccountId)
                    .HasColumnName("WEB_ACCOUNT_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.WebAddressId)
                    .HasColumnName("WEB_ADDRESS_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.AddressType)
                    .HasColumnName("ADDRESS_TYPE")
                    .HasColumnType("CHAR(1)");

                entity.HasOne(d => d.WebAccount)
                    .WithMany(p => p.WebAccountAddress)
                    .HasForeignKey(d => d.WebAccountId)
                    .HasConstraintName("XFK1WEB_ACCOUNT_ADDRESS");

                entity.HasOne(d => d.WebAddress)
                    .WithMany(p => p.WebAccountAddress)
                    .HasForeignKey(d => d.WebAddressId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("XFK2WEB_ACCOUNT_ADDRESS");
            });

            modelBuilder.Entity<WebAddress>(entity =>
            {
                entity.ToTable("WEB_ADDRESS");

                entity.HasIndex(e => e.FromWebAddressId)
                    .HasName("XIE1WEB_ADDRESS");

                entity.HasIndex(e => e.WebAddressId)
                    .HasName("PK_WEB_ADDRESS")
                    .IsUnique();

                entity.Property(e => e.WebAddressId)
                    .HasColumnName("WEB_ADDRESS_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("CITY")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("FIRST_NAME")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FromWebAddressId)
                    .HasColumnName("FROM_WEB_ADDRESS_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("LAST_NAME")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PhoneCell).HasColumnName("PHONE_CELL");

                entity.Property(e => e.PhoneDay).HasColumnName("PHONE_DAY");

                entity.Property(e => e.PhoneHome).HasColumnName("PHONE_HOME");

                entity.Property(e => e.PostalAddress)
                    .IsRequired()
                    .HasColumnName("POSTAL_ADDRESS")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("STATE")
                    .HasColumnType("CHAR(2)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasColumnType("VARCHAR2(5)");
            });

            modelBuilder.Entity<WebAttr>(entity =>
            {
                entity.ToTable("WEB_ATTR");

                entity.HasIndex(e => e.Code)
                    .HasName("XAK1WEB_ATTR")
                    .IsUnique();

                entity.HasIndex(e => e.WebAttrId)
                    .HasName("XPKWEB_ATTR")
                    .IsUnique();

                entity.Property(e => e.WebAttrId)
                    .HasColumnName("WEB_ATTR_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(80)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasColumnName("DISPLAY_NAME")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.EditPrompt)
                    .HasColumnName("EDIT_PROMPT")
                    .HasColumnType("VARCHAR2(200)");
            });

            modelBuilder.Entity<WebAttrDtl>(entity =>
            {
                entity.ToTable("WEB_ATTR_DTL");

                entity.HasIndex(e => e.SpecialServiceId)
                    .HasName("XIE2WEB_ATTR_DTL");

                entity.HasIndex(e => e.WebAttrDtlId)
                    .HasName("XPKWEB_ATTR_DTL")
                    .IsUnique();

                entity.HasIndex(e => e.WebAttrId)
                    .HasName("XIE1WEB_ATTR_DTL");

                entity.HasIndex(e => new { e.WebAttrId, e.Code })
                    .HasName("XAK2WEB_ATTR_DTL")
                    .IsUnique();

                entity.HasIndex(e => new { e.WebAttrId, e.SequenceNumber })
                    .HasName("XAK1WEB_ATTR_DTL")
                    .IsUnique();

                entity.Property(e => e.WebAttrDtlId)
                    .HasColumnName("WEB_ATTR_DTL_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.PriceModifier)
                    .HasColumnName("PRICE_MODIFIER")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.SequenceNumber)
                    .HasColumnName("SEQUENCE_NUMBER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SpecialServiceId)
                    .HasColumnName("SPECIAL_SERVICE_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.WebAttrId)
                    .HasColumnName("WEB_ATTR_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.SpecialService)
                    .WithMany(p => p.WebAttrDtl)
                    .HasForeignKey(d => d.SpecialServiceId)
                    .HasConstraintName("XFK2_WEB_ATTR_DTL");

                entity.HasOne(d => d.WebAttr)
                    .WithMany(p => p.WebAttrDtl)
                    .HasForeignKey(d => d.WebAttrId)
                    .HasConstraintName("XFK1WEB_ATTR_DTL");
            });

            modelBuilder.Entity<WebAttrGroup>(entity =>
            {
                entity.ToTable("WEB_ATTR_GROUP");

                entity.HasIndex(e => e.Description)
                    .HasName("NDX_WEB_ATTR_GROUP_1")
                    .IsUnique();

                entity.HasIndex(e => e.WebAttrGroupId)
                    .HasName("PK_WEB_ATTR_GROUP")
                    .IsUnique();

                entity.Property(e => e.WebAttrGroupId)
                    .HasColumnName("WEB_ATTR_GROUP_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WebAttrGroupDtl>(entity =>
            {
                entity.ToTable("WEB_ATTR_GROUP_DTL");

                entity.HasIndex(e => e.IconImageNormal)
                    .HasName("NDX_WEB_ATTR_GROUP_DTL_3");

                entity.HasIndex(e => e.IconImageSelected)
                    .HasName("NDX_WEB_ATTR_GROUP_DTL_4");

                entity.HasIndex(e => e.WebAttrGroupDtlId)
                    .HasName("PK_WEB_ATTR_GROUP_DTL")
                    .IsUnique();

                entity.HasIndex(e => e.WebAttrGroupId)
                    .HasName("NDX_WEB_ATTR_GROUP_DTL_1");

                entity.HasIndex(e => e.WebAttrId)
                    .HasName("NDX_WEB_ATTR_GROUP_DTL_2");

                entity.Property(e => e.WebAttrGroupDtlId)
                    .HasColumnName("WEB_ATTR_GROUP_DTL_ID")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AllowMultipleEntires)
                    .IsRequired()
                    .HasColumnName("ALLOW_MULTIPLE_ENTIRES")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.IconImageNormal)
                    .HasColumnName("ICON_IMAGE_NORMAL")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IconImageSelected)
                    .HasColumnName("ICON_IMAGE_SELECTED")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IsRequired)
                    .IsRequired()
                    .HasColumnName("IS_REQUIRED")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.Orientation)
                    .IsRequired()
                    .HasColumnName("ORIENTATION")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'V' ");

                entity.Property(e => e.PresentationType)
                    .IsRequired()
                    .HasColumnName("PRESENTATION_TYPE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'D' ");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.WebAttrGroupId)
                    .HasColumnName("WEB_ATTR_GROUP_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.WebAttrId)
                    .HasColumnName("WEB_ATTR_ID")
                    .HasColumnType("NUMBER(38)");

                entity.HasOne(d => d.IconImageNormalNavigation)
                    .WithMany(p => p.WebAttrGroupDtlIconImageNormalNavigation)
                    .HasForeignKey(d => d.IconImageNormal)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_WEB_ATTR_GROUP_DTL_3");

                entity.HasOne(d => d.IconImageSelectedNavigation)
                    .WithMany(p => p.WebAttrGroupDtlIconImageSelectedNavigation)
                    .HasForeignKey(d => d.IconImageSelected)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_WEB_ATTR_GROUP_DTL_4");

                entity.HasOne(d => d.WebAttrGroup)
                    .WithMany(p => p.WebAttrGroupDtl)
                    .HasForeignKey(d => d.WebAttrGroupId)
                    .HasConstraintName("FK_WEB_ATTR_GROUP_DTL_1");

                entity.HasOne(d => d.WebAttr)
                    .WithMany(p => p.WebAttrGroupDtl)
                    .HasForeignKey(d => d.WebAttrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WEB_ATTR_GROUP_DTL_2");
            });

            modelBuilder.Entity<WebAvailability>(entity =>
            {
                entity.ToTable("WEB_AVAILABILITY");

                entity.HasIndex(e => e.BreedId)
                    .HasName("NDX_WEB_AVAILABILITY_01");

                entity.HasIndex(e => e.WebAvailabilityId)
                    .HasName("PK_WEB_AVAILABILITY_ID")
                    .IsUnique();

                entity.HasIndex(e => new { e.BreedId, e.EffectiveDate })
                    .HasName("UK_WEB_AVAILABILITY_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.EffectiveDate, e.BreedId })
                    .HasName("UK_WEB_AVAILABILITY_01")
                    .IsUnique();

                entity.Property(e => e.WebAvailabilityId)
                    .HasColumnName("WEB_AVAILABILITY_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BreedId)
                    .HasColumnName("BREED_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("EFFECTIVE_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.EstAvailability)
                    .HasColumnName("EST_AVAILABILITY")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("EXPIRY_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.HatchRestart)
                    .HasColumnName("HATCH_RESTART")
                    .HasColumnType("VARCHAR2(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsHatching)
                    .IsRequired()
                    .HasColumnName("IS_HATCHING")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.LimitedBasis)
                    .HasColumnName("LIMITED_BASIS")
                    .HasColumnType("CHAR(3)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LimitedMagnitude)
                    .HasColumnName("LIMITED_MAGNITUDE")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Waitlistable)
                    .HasColumnName("WAITLISTABLE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y'");

                entity.HasOne(d => d.Breed)
                    .WithMany(p => p.WebAvailability)
                    .HasForeignKey(d => d.BreedId)
                    .HasConstraintName("FK_WEB_AVAILABILITY_01");
            });

            modelBuilder.Entity<WebBlackout>(entity =>
            {
                entity.ToTable("WEB_BLACKOUT");

                entity.HasIndex(e => e.ProductId)
                    .HasName("XIE1WEB_BLACKOUT");

                entity.HasIndex(e => e.ShipdayId)
                    .HasName("XIE2WEB_BLACKOUT");

                entity.HasIndex(e => e.WebBlackoutId)
                    .HasName("XPKWEB_BLACKOUT")
                    .IsUnique();

                entity.HasIndex(e => new { e.ProductId, e.ShipdayId })
                    .HasName("XAK1WEB_BLACKOUT")
                    .IsUnique();

                entity.Property(e => e.WebBlackoutId)
                    .HasColumnName("WEB_BLACKOUT_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasColumnType("VARCHAR2(400)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ShipdayId)
                    .HasColumnName("SHIPDAY_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WebBlackout)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("XIF1WEB_BLACKOUT");

                entity.HasOne(d => d.Shipday)
                    .WithMany(p => p.WebBlackout)
                    .HasForeignKey(d => d.ShipdayId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("XIF2WEB_BLACKOUT");
            });

            modelBuilder.Entity<WebBreed>(entity =>
            {
                entity.ToTable("WEB_BREED");

                entity.HasIndex(e => e.WebBreedId)
                    .HasName("PK_WEB_BREED")
                    .IsUnique();

                entity.Property(e => e.WebBreedId)
                    .HasColumnName("WEB_BREED_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(40)");
            });

            modelBuilder.Entity<WebBreedItem>(entity =>
            {
                entity.HasKey(e => new { e.WebBreedId, e.WebItemId });

                entity.ToTable("WEB_BREED_ITEM");

                entity.HasIndex(e => e.WebBreedId)
                    .HasName("NDX1_WEB_BREED_ITEM");

                entity.HasIndex(e => e.WebItemId)
                    .HasName("NDX2_WEB_BREED_ITEM");

                entity.HasIndex(e => new { e.WebBreedId, e.WebItemId })
                    .HasName("PK_WEB_BREED_ITEM")
                    .IsUnique();

                entity.Property(e => e.WebBreedId)
                    .HasColumnName("WEB_BREED_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.WebItemId)
                    .HasColumnName("WEB_ITEM_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.WebItem)
                    .WithMany(p => p.WebBreedItem)
                    .HasForeignKey(d => d.WebItemId)
                    .HasConstraintName("FK_WEB_BREED_ITEM1");
            });

            modelBuilder.Entity<WebCart>(entity =>
            {
                entity.ToTable("WEB_CART");

                entity.HasIndex(e => e.ShipdayId)
                    .HasName("AK1_WEB_CART")
                    .IsUnique();

                entity.HasIndex(e => e.WebCartId)
                    .HasName("PK_WEB_CART")
                    .IsUnique();

                entity.Property(e => e.WebCartId)
                    .HasColumnName("WEB_CART_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.QuarterboxCharge)
                    .HasColumnName("QUARTERBOX_CHARGE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ShipdayId)
                    .HasColumnName("SHIPDAY_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ShippingCharge)
                    .HasColumnName("SHIPPING_CHARGE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SmallOrderCharge)
                    .HasColumnName("SMALL_ORDER_CHARGE")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<WebCartDtl>(entity =>
            {
                entity.ToTable("WEB_CART_DTL");

                entity.HasIndex(e => e.WebCartDtlId)
                    .HasName("PK_WEB_CART_DTL")
                    .IsUnique();

                entity.HasIndex(e => new { e.WebCartId, e.ItemSequence })
                    .HasName("AK1_WEB_CART_DTL")
                    .IsUnique();

                entity.Property(e => e.WebCartDtlId)
                    .HasColumnName("WEB_CART_DTL_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Availability)
                    .HasColumnName("AVAILABILITY")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Category)
                    .HasColumnName("CATEGORY")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.EachPrice)
                    .HasColumnName("EACH_PRICE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ITEM_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ItemSequence)
                    .HasColumnName("ITEM_SEQUENCE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.NoSellReason)
                    .HasColumnName("NO_SELL_REASON")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Processed)
                    .IsRequired()
                    .HasColumnName("PROCESSED")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.WebCartId)
                    .HasColumnName("WEB_CART_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.WebCategoryId)
                    .HasColumnName("WEB_CATEGORY_ID")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<WebCartDtlAttr>(entity =>
            {
                entity.ToTable("WEB_CART_DTL_ATTR");

                entity.HasIndex(e => e.WebAttrDtlId)
                    .HasName("XIE2_WEB_CART_DTL_ATTR");

                entity.HasIndex(e => e.WebCartDtlAttrId)
                    .HasName("PK_WEB_CART_DTL_ATTR")
                    .IsUnique();

                entity.HasIndex(e => e.WebCartDtlId)
                    .HasName("XIE1_WEB_CART_DTL_ATTR");

                entity.HasIndex(e => new { e.WebCartDtlId, e.WebAttrDtlId })
                    .HasName("AK1_WEB_CART_DTL_ATTR")
                    .IsUnique();

                entity.Property(e => e.WebCartDtlAttrId)
                    .HasColumnName("WEB_CART_DTL_ATTR_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cost)
                    .HasColumnName("COST")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.WebAttrDtlId)
                    .HasColumnName("WEB_ATTR_DTL_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.WebCartDtlId)
                    .HasColumnName("WEB_CART_DTL_ID")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<WebCategory>(entity =>
            {
                entity.ToTable("WEB_CATEGORY");

                entity.HasIndex(e => e.Description)
                    .HasName("XAK1WEB_CATEGORY")
                    .IsUnique();

                entity.HasIndex(e => e.PricesheetId)
                    .HasName("NDX_WEB_CATEGORY2");

                entity.HasIndex(e => e.WebCategoryId)
                    .HasName("PK_WEB_CATEGORY")
                    .IsUnique();

                entity.HasIndex(e => e.WebImageId)
                    .HasName("XIE1WEB_CATEGORY");

                entity.Property(e => e.WebCategoryId)
                    .HasColumnName("WEB_CATEGORY_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.PricesheetId)
                    .HasColumnName("PRICESHEET_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.RealAvailabilityWindow)
                    .HasColumnName("REAL_AVAILABILITY_WINDOW")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("21 ");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasColumnName("SHORT_NAME")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.WebImageId)
                    .HasColumnName("WEB_IMAGE_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Pricesheet)
                    .WithMany(p => p.WebCategory)
                    .HasForeignKey(d => d.PricesheetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WEBCATEGORY2PRICESHEET");

                entity.HasOne(d => d.WebImage)
                    .WithMany(p => p.WebCategory)
                    .HasForeignKey(d => d.WebImageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WEBCATEGORY2WEBIMAGE");
            });

            modelBuilder.Entity<WebCategoryBreed>(entity =>
            {
                entity.HasKey(e => new { e.WebCategoryId, e.WebBreedId })
                    .HasName("PK_WEBCATEGORYBREED");

                entity.ToTable("WEB_CATEGORY_BREED");

                entity.HasIndex(e => e.WebBreedId)
                    .HasName("NDX_WEB_CATEGORY_BREED1");

                entity.HasIndex(e => e.WebCategoryId)
                    .HasName("NDX_WEB_CATEGORY_BREED2");

                entity.HasIndex(e => new { e.WebCategoryId, e.WebBreedId })
                    .HasName("PK_WEBCATEGORYBREED")
                    .IsUnique();

                entity.Property(e => e.WebCategoryId)
                    .HasColumnName("WEB_CATEGORY_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.WebBreedId)
                    .HasColumnName("WEB_BREED_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ShowOnShopPage)
                    .IsRequired()
                    .HasColumnName("SHOW_ON_SHOP_PAGE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.WebBreed)
                    .WithMany(p => p.WebCategoryBreed)
                    .HasForeignKey(d => d.WebBreedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WEB_CATEGORY_BREED1");

                entity.HasOne(d => d.WebCategory)
                    .WithMany(p => p.WebCategoryBreed)
                    .HasForeignKey(d => d.WebCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WEB_CATEGORY_BREED2");
            });

            modelBuilder.Entity<WebDescriptionFlag>(entity =>
            {
                entity.ToTable("WEB_DESCRIPTION_FLAG");

                entity.HasIndex(e => e.Flag)
                    .HasName("XAK1WEB_DESCRIPTION")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("XAK2WEB_DESCRIPTION")
                    .IsUnique();

                entity.HasIndex(e => e.WebDescriptionFlagId)
                    .HasName("XPKWEB_DESCRIPTION_FLAG")
                    .IsUnique();

                entity.Property(e => e.WebDescriptionFlagId)
                    .HasColumnName("WEB_DESCRIPTION_FLAG_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CssClass)
                    .IsRequired()
                    .HasColumnName("CSS_CLASS")
                    .HasColumnType("VARCHAR2(80)");

                entity.Property(e => e.Flag)
                    .HasColumnName("FLAG")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<WebFaq>(entity =>
            {
                entity.ToTable("WEB_FAQ");

                entity.HasIndex(e => e.WebFaqId)
                    .HasName("PK_WEB_FAQ")
                    .IsUnique();

                entity.Property(e => e.WebFaqId)
                    .HasColumnName("WEB_FAQ_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasColumnName("ANSWER")
                    .HasColumnType("CLOB");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasColumnName("QUESTION")
                    .HasColumnType("VARCHAR2(120)");

                entity.Property(e => e.Sequencing)
                    .HasColumnName("SEQUENCING")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<WebImage>(entity =>
            {
                entity.ToTable("WEB_IMAGE");

                entity.HasIndex(e => e.Description)
                    .HasName("AK1_WEB_IMAGE")
                    .IsUnique();

                entity.HasIndex(e => e.WebImageId)
                    .HasName("PK_WEB_IMAGE")
                    .IsUnique();

                entity.Property(e => e.WebImageId)
                    .HasColumnName("WEB_IMAGE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Etag)
                    .IsRequired()
                    .HasColumnName("ETAG")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Height)
                    .HasColumnName("HEIGHT")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ImgData)
                    .IsRequired()
                    .HasColumnName("IMG_DATA")
                    .HasColumnType("BLOB")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ImgType)
                    .IsRequired()
                    .HasColumnName("IMG_TYPE")
                    .HasColumnType("VARCHAR2(3)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModified)
                    .HasColumnName("LAST_MODIFIED")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Src)
                    .HasColumnName("SRC")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Width)
                    .HasColumnName("WIDTH")
                    .HasColumnType("NUMBER(38)");
            });

            modelBuilder.Entity<WebItem>(entity =>
            {
                entity.ToTable("WEB_ITEM");

                entity.HasIndex(e => e.LeftWebImageId)
                    .HasName("XIE2_WEB_ITEM");

                entity.HasIndex(e => e.RightWebImageId)
                    .HasName("XIE3_WEB_ITEM");

                entity.HasIndex(e => e.WebAttrGroupId)
                    .HasName("XIE1_WEB_ITEM");

                entity.HasIndex(e => e.WebItemId)
                    .HasName("PK_WEB_ITEM")
                    .IsUnique();

                entity.Property(e => e.WebItemId)
                    .HasColumnName("WEB_ITEM_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.LeftWebImageId)
                    .HasColumnName("LEFT_WEB_IMAGE_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.RightWebImageId)
                    .HasColumnName("RIGHT_WEB_IMAGE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ShowOnWeb)
                    .IsRequired()
                    .HasColumnName("SHOW_ON_WEB")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.WebAttrGroupId)
                    .HasColumnName("WEB_ATTR_GROUP_ID")
                    .HasColumnType("NUMBER(38)");

                entity.HasOne(d => d.LeftWebImage)
                    .WithMany(p => p.WebItemLeftWebImage)
                    .HasForeignKey(d => d.LeftWebImageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2_WEB_ITEM2WEB_IMAGE");

                entity.HasOne(d => d.RightWebImage)
                    .WithMany(p => p.WebItemRightWebImage)
                    .HasForeignKey(d => d.RightWebImageId)
                    .HasConstraintName("FK3_WEB_ITEM2WEB_IMAGE");

                entity.HasOne(d => d.WebAttrGroup)
                    .WithMany(p => p.WebItem)
                    .HasForeignKey(d => d.WebAttrGroupId)
                    .HasConstraintName("FK1_WEB_ITEM2WEB_ATTR_GROUP");
            });

            modelBuilder.Entity<WebItemDescription>(entity =>
            {
                entity.ToTable("WEB_ITEM_DESCRIPTION");

                entity.HasIndex(e => e.WebItemDescriptionId)
                    .HasName("XPKWEB_ITEM_DESCRIPTION")
                    .IsUnique();

                entity.HasIndex(e => new { e.WebItemId, e.Sequence })
                    .HasName("XAK1WEB_ITEM_DESCRIPTION")
                    .IsUnique();

                entity.Property(e => e.WebItemDescriptionId)
                    .HasColumnName("WEB_ITEM_DESCRIPTION_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Flags)
                    .HasColumnName("FLAGS")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("TEXT")
                    .HasColumnType("CLOB");

                entity.Property(e => e.WebItemId)
                    .HasColumnName("WEB_ITEM_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.WebItem)
                    .WithMany(p => p.WebItemDescription)
                    .HasForeignKey(d => d.WebItemId)
                    .HasConstraintName("XIE1WEB_ITEM_DESCRIPTION");
            });

            modelBuilder.Entity<WebItemProduct>(entity =>
            {
                entity.ToTable("WEB_ITEM_PRODUCT");

                entity.HasIndex(e => e.ProductId)
                    .HasName("XIE2_WEB_ITEM_PRODUCT");

                entity.HasIndex(e => e.WebItemId)
                    .HasName("XIE1_WEB_ITEM_PRODUCT");

                entity.HasIndex(e => e.WebItemProductId)
                    .HasName("PK_WEB_ITEM_PRODUCT")
                    .IsUnique();

                entity.HasIndex(e => new { e.WebItemId, e.ProductId })
                    .HasName("AK1_WEB_ITEM_PRODUCT")
                    .IsUnique();

                entity.Property(e => e.WebItemProductId)
                    .HasColumnName("WEB_ITEM_PRODUCT_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OverridePrice)
                    .HasColumnName("OVERRIDE_PRICE")
                    .HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.ProdType)
                    .IsRequired()
                    .HasColumnName("PROD_TYPE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ShowOnWeb)
                    .IsRequired()
                    .HasColumnName("SHOW_ON_WEB")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.WebItemId)
                    .HasColumnName("WEB_ITEM_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WebItemProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WEB_ITPROD_2_PRODUCT");

                entity.HasOne(d => d.WebItem)
                    .WithMany(p => p.WebItemProduct)
                    .HasForeignKey(d => d.WebItemId)
                    .HasConstraintName("FK_WEB_ITPROD_2_WEB_ITEM");
            });

            modelBuilder.Entity<WebOrderDtl>(entity =>
            {
                entity.ToTable("WEB_ORDER_DTL");

                entity.HasIndex(e => e.WebItemProductId)
                    .HasName("XIE2WEB_ORDER_DTL");

                entity.HasIndex(e => e.WebOrderDtlId)
                    .HasName("XPKWEB_ORDER_DTL")
                    .IsUnique();

                entity.HasIndex(e => e.WebOrderHdrId)
                    .HasName("XIE1WEB_ORDER_DTL");

                entity.HasIndex(e => new { e.WebOrderHdrId, e.LineNumber })
                    .HasName("XAK1WEB_ORDER_DTL")
                    .IsUnique();

                entity.Property(e => e.WebOrderDtlId)
                    .HasColumnName("WEB_ORDER_DTL_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Availability)
                    .HasColumnName("AVAILABILITY")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.EachPrice)
                    .HasColumnName("EACH_PRICE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.LineNumber)
                    .HasColumnName("LINE_NUMBER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.WebItemProductId)
                    .HasColumnName("WEB_ITEM_PRODUCT_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.WebOrderHdrId)
                    .HasColumnName("WEB_ORDER_HDR_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.WebItemProduct)
                    .WithMany(p => p.WebOrderDtl)
                    .HasForeignKey(d => d.WebItemProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WEBORDERDTL2WEBITEMPRODUCT");

                entity.HasOne(d => d.WebOrderHdr)
                    .WithMany(p => p.WebOrderDtl)
                    .HasForeignKey(d => d.WebOrderHdrId)
                    .HasConstraintName("FK_WEBORDERDTL2WEBORDERHDR");
            });

            modelBuilder.Entity<WebOrderDtlAttr>(entity =>
            {
                entity.ToTable("WEB_ORDER_DTL_ATTR");

                entity.HasIndex(e => e.WebAttrDtlId)
                    .HasName("XIE2WEB_ORDER_DTL_ATTR");

                entity.HasIndex(e => e.WebOrderDtlAttrId)
                    .HasName("XPKWEB_ORDER_DTL_ATTR")
                    .IsUnique();

                entity.HasIndex(e => e.WebOrderDtlId)
                    .HasName("XIE1WEB_ORDER_DTL_ATTR");

                entity.HasIndex(e => new { e.WebOrderDtlId, e.WebAttrDtlId })
                    .HasName("XAK1WEB_ORDER_DTL_ATTR")
                    .IsUnique();

                entity.Property(e => e.WebOrderDtlAttrId)
                    .HasColumnName("WEB_ORDER_DTL_ATTR_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PriceModifier)
                    .HasColumnName("PRICE_MODIFIER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.WebAttrDtlId)
                    .HasColumnName("WEB_ATTR_DTL_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.WebOrderDtlId)
                    .HasColumnName("WEB_ORDER_DTL_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.WebAttrDtl)
                    .WithMany(p => p.WebOrderDtlAttr)
                    .HasForeignKey(d => d.WebAttrDtlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("XFK2WEB_ORDER_DTL_ATTR");

                entity.HasOne(d => d.WebOrderDtl)
                    .WithMany(p => p.WebOrderDtlAttr)
                    .HasForeignKey(d => d.WebOrderDtlId)
                    .HasConstraintName("XFK1WEB_ORDER_DTL_ATTR");
            });

            modelBuilder.Entity<WebOrderHdr>(entity =>
            {
                entity.ToTable("WEB_ORDER_HDR");

                entity.HasIndex(e => e.ShipdateId)
                    .HasName("XIE2_WEB_ORDER_HDR");

                entity.HasIndex(e => e.WebOrderHdrId)
                    .HasName("PK_WEB_ORDER_HDR")
                    .IsUnique();

                entity.HasIndex(e => e.WebOrderMasterId)
                    .HasName("XIE1_WEB_ORDER_HDR");

                entity.HasIndex(e => new { e.ShipdateId, e.WebOrderMasterId })
                    .HasName("AK1_WEB_ORDER_HDR")
                    .IsUnique();

                entity.HasIndex(e => new { e.WebOrderMasterId, e.ShipdateId })
                    .HasName("AK1_WEB_ORDER_HDR")
                    .IsUnique();

                entity.Property(e => e.WebOrderHdrId)
                    .HasColumnName("WEB_ORDER_HDR_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BoxingCharge)
                    .HasColumnName("BOXING_CHARGE")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasColumnName("ORDER_TYPE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.ShipdateId)
                    .HasColumnName("SHIPDATE_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ShippingCharge)
                    .HasColumnName("SHIPPING_CHARGE")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.SmallOrderCharge)
                    .HasColumnName("SMALL_ORDER_CHARGE")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.SpecialServicesCharge)
                    .HasColumnName("SPECIAL_SERVICES_CHARGE")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.WebOrderMasterId)
                    .HasColumnName("WEB_ORDER_MASTER_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Shipdate)
                    .WithMany(p => p.WebOrderHdr)
                    .HasForeignKey(d => d.ShipdateId)
                    .HasConstraintName("FK_WEBORDERHDR2SHIPDATE");

                entity.HasOne(d => d.WebOrderMaster)
                    .WithMany(p => p.WebOrderHdr)
                    .HasForeignKey(d => d.WebOrderMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WEBORDHDR2WEBORDMSTR");
            });

            modelBuilder.Entity<WebOrderMaster>(entity =>
            {
                entity.ToTable("WEB_ORDER_MASTER");

                entity.HasIndex(e => e.BillingWebAddressId)
                    .HasName("XIE1_WEB_ORDER_MASTER");

                entity.HasIndex(e => e.CcNumber)
                    .HasName("XIF2_WEB_ORDER_MASTER");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("XIE3_WEB_ORDER_MASTER");

                entity.HasIndex(e => e.DateReceived)
                    .HasName("XIF1_WEB_ORDER_MASTER");

                entity.HasIndex(e => e.OrderHdrId)
                    .HasName("XIE4_WEB_ORDER_MASTER");

                entity.HasIndex(e => e.ShippingWebAddressId)
                    .HasName("XIE2_WEB_ORDER_MASTER");

                entity.HasIndex(e => e.WebOrderMasterId)
                    .HasName("PK_WEB_ORDER_MASTER")
                    .IsUnique();

                entity.Property(e => e.WebOrderMasterId)
                    .HasColumnName("WEB_ORDER_MASTER_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BillingWebAddressId)
                    .HasColumnName("BILLING_WEB_ADDRESS_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.CcCvv)
                    .HasColumnName("CC_CVV")
                    .HasMaxLength(30);

                entity.Property(e => e.CcExpMonth)
                    .HasColumnName("CC_EXP_MONTH")
                    .HasMaxLength(30);

                entity.Property(e => e.CcExpYear)
                    .HasColumnName("CC_EXP_YEAR")
                    .HasMaxLength(30);

                entity.Property(e => e.CcNumber)
                    .HasColumnName("CC_NUMBER")
                    .HasMaxLength(60);

                entity.Property(e => e.Comments)
                    .HasColumnName("COMMENTS")
                    .HasColumnType("VARCHAR2(2000)");

                entity.Property(e => e.ComputedShipDate)
                    .HasColumnName("COMPUTED_SHIP_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CUSTOMER_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateReceived)
                    .HasColumnName("DATE_RECEIVED")
                    .HasColumnType("DATE");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasColumnName("IP_ADDRESS")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.LocalPickup)
                    .IsRequired()
                    .HasColumnName("LOCAL_PICKUP")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.OrderHdrId)
                    .HasColumnName("ORDER_HDR_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasColumnName("PAYMENT_METHOD")
                    .HasColumnType("CHAR(2)")
                    .HasDefaultValueSql("'CC' ");

                entity.Property(e => e.RequestContactEmail)
                    .IsRequired()
                    .HasColumnName("REQUEST_CONTACT_EMAIL")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.RequestContactPhone)
                    .IsRequired()
                    .HasColumnName("REQUEST_CONTACT_PHONE")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.RequestedShipDate)
                    .HasColumnName("REQUESTED_SHIP_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.ShipEarly)
                    .IsRequired()
                    .HasColumnName("SHIP_EARLY")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.ShippingWebAddressId)
                    .HasColumnName("SHIPPING_WEB_ADDRESS_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.UserAgent)
                    .IsRequired()
                    .HasColumnName("USER_AGENT")
                    .HasColumnType("VARCHAR2(255)");

                entity.HasOne(d => d.BillingWebAddress)
                    .WithMany(p => p.WebOrderMasterBillingWebAddress)
                    .HasForeignKey(d => d.BillingWebAddressId)
                    .HasConstraintName("FK_WOM2BILLING_WEB_ADDY");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.WebOrderMaster)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_WOM2CUSTOMER");

                entity.HasOne(d => d.OrderHdr)
                    .WithMany(p => p.WebOrderMaster)
                    .HasForeignKey(d => d.OrderHdrId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_WOM2ORDER_HDR");

                entity.HasOne(d => d.ShippingWebAddress)
                    .WithMany(p => p.WebOrderMasterShippingWebAddress)
                    .HasForeignKey(d => d.ShippingWebAddressId)
                    .HasConstraintName("FK_WOM2SHIPPING_WEB_ADDY");
            });

            modelBuilder.Entity<WebPreview>(entity =>
            {
                entity.ToTable("WEB_PREVIEW");

                entity.HasIndex(e => e.LeftImageId)
                    .HasName("NDX_WEBPREVIEW2WEBIMAGE1");

                entity.HasIndex(e => e.RightImageId)
                    .HasName("NDX_WEBPREVIEW2WEBIMAGE2");

                entity.HasIndex(e => e.WebPreviewId)
                    .HasName("PK_WEB_PREVIEW")
                    .IsUnique();

                entity.Property(e => e.WebPreviewId)
                    .HasColumnName("WEB_PREVIEW_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.LeftImageId)
                    .HasColumnName("LEFT_IMAGE_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.RightImageId)
                    .HasColumnName("RIGHT_IMAGE_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.WebItemId)
                    .HasColumnName("WEB_ITEM_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.LeftImage)
                    .WithMany(p => p.WebPreviewLeftImage)
                    .HasForeignKey(d => d.LeftImageId)
                    .HasConstraintName("PK_WEBPREVIEW2WEBIMAGE1");

                entity.HasOne(d => d.RightImage)
                    .WithMany(p => p.WebPreviewRightImage)
                    .HasForeignKey(d => d.RightImageId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("PK_WEBPREVIEW2WEBIMAGE2");
            });

            modelBuilder.Entity<WebPreviewDtl>(entity =>
            {
                entity.HasKey(e => new { e.WebPreviewId, e.SortOrder });

                entity.ToTable("WEB_PREVIEW_DTL");

                entity.HasIndex(e => new { e.WebPreviewId, e.SortOrder })
                    .HasName("PK_WEB_PREVIEW_DTL")
                    .IsUnique();

                entity.Property(e => e.WebPreviewId)
                    .HasColumnName("WEB_PREVIEW_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Flags)
                    .HasColumnName("FLAGS")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.HtmlText)
                    .IsRequired()
                    .HasColumnName("HTML_TEXT")
                    .HasColumnType("CLOB");
            });

            modelBuilder.Entity<WebSearch>(entity =>
            {
                entity.ToTable("WEB_SEARCH");

                entity.HasIndex(e => e.Url)
                    .HasName("XTXT1WEB_SEARCH");

                entity.HasIndex(e => e.WebItemId)
                    .HasName("XIE1WEB_SEARCH");

                entity.HasIndex(e => e.WebSearchId)
                    .HasName("XPKWEB_SEARCH")
                    .IsUnique();

                entity.Property(e => e.WebSearchId)
                    .HasColumnName("WEB_SEARCH_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DefaultPageTitle)
                    .HasColumnName("DEFAULT_PAGE_TITLE")
                    .HasColumnType("VARCHAR2(80)");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasColumnType("VARCHAR2(2000)");

                entity.Property(e => e.WebItemId)
                    .HasColumnName("WEB_ITEM_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.WebItem)
                    .WithMany(p => p.WebSearch)
                    .HasForeignKey(d => d.WebItemId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK1WEB_SEARCH");
            });

            modelBuilder.Entity<WebSeason>(entity =>
            {
                entity.ToTable("WEB_SEASON");

                entity.HasIndex(e => e.WebItemId)
                    .HasName("XIE1WEB_SEASON");

                entity.HasIndex(e => e.WebSeasonId)
                    .HasName("PK_WEB_SEASON")
                    .IsUnique();

                entity.HasIndex(e => new { e.WebItemId, e.StartDate, e.EndDate })
                    .HasName("X1_WEB_SEASON");

                entity.Property(e => e.WebSeasonId)
                    .HasColumnName("WEB_SEASON_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.WebItemId)
                    .HasColumnName("WEB_ITEM_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.WebItem)
                    .WithMany(p => p.WebSeason)
                    .HasForeignKey(d => d.WebItemId)
                    .HasConstraintName("FB_WEBSEASON2WEBITEM");
            });

            modelBuilder.Entity<WebSession>(entity =>
            {
                entity.HasKey(e => e.Sessionid)
                    .HasName("XAK1WEB_SESSION");

                entity.ToTable("WEB_SESSION");

                entity.HasIndex(e => e.Modified)
                    .HasName("XIF1WEB_SESSION");

                entity.HasIndex(e => e.Sessionid)
                    .HasName("XAK1WEB_SESSION")
                    .IsUnique();

                entity.Property(e => e.Sessionid).HasColumnName("SESSIONID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("CLOB")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FromIp)
                    .IsRequired()
                    .HasColumnName("FROM_IP")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WebShippingInfo>(entity =>
            {
                entity.ToTable("WEB_SHIPPING_INFO");

                entity.HasIndex(e => e.WebShippingInfoId)
                    .HasName("XPKWEB_SHIPPING_INFO")
                    .IsUnique();

                entity.Property(e => e.WebShippingInfoId)
                    .HasColumnName("WEB_SHIPPING_INFO_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HtmlCode)
                    .IsRequired()
                    .HasColumnName("HTML_CODE")
                    .HasColumnType("CLOB");

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasColumnType("VARCHAR2(60)");
            });

            modelBuilder.Entity<WebSoldout>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ShipDate });

                entity.ToTable("WEB_SOLDOUT");

                entity.HasIndex(e => e.ProductId)
                    .HasName("NDX_WEB_SOLDOUT2");

                entity.HasIndex(e => new { e.ShipDate, e.ProductId })
                    .HasName("PK_WEB_SOLDOUT")
                    .IsUnique();

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ShipDate)
                    .HasColumnName("SHIP_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WebSoldout)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_WEB_SOLDOUT2");
            });

            modelBuilder.Entity<WebSpecial>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("WEB_SPECIAL");

                entity.HasIndex(e => e.ProductId)
                    .HasName("PK_WEB_SPECIAL")
                    .IsUnique();

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.RetailPrice)
                    .HasColumnName("RETAIL_PRICE")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.WholesalePrice)
                    .HasColumnName("WHOLESALE_PRICE")
                    .HasColumnType("NUMBER(38,2)")
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<WebSpecialService>(entity =>
            {
                entity.ToTable("WEB_SPECIAL_SERVICE");

                entity.HasIndex(e => e.SpecialServiceId)
                    .HasName("AK1_WEB_SPECIAL_SERVICE")
                    .IsUnique();

                entity.HasIndex(e => e.WebSpecialServiceId)
                    .HasName("PK_WEB_SPECIAL_SERVICE")
                    .IsUnique();

                entity.Property(e => e.WebSpecialServiceId)
                    .HasColumnName("WEB_SPECIAL_SERVICE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AltDescription)
                    .HasColumnName("ALT_DESCRIPTION")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.SpecialServiceId)
                    .HasColumnName("SPECIAL_SERVICE_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.SpecialService)
                    .WithOne(p => p.WebSpecialService)
                    .HasForeignKey<WebSpecialService>(d => d.SpecialServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WEB_SS2SPEC_SRV");
            });

            modelBuilder.Entity<WebSpecials>(entity =>
            {
                entity.HasKey(e => new { e.TableName, e.DuplicateId, e.OriginalId });

                entity.ToTable("WEB_SPECIALS");

                entity.HasIndex(e => new { e.TableName, e.OriginalId, e.DuplicateId })
                    .HasName("PK_WEB_SPECIALS")
                    .IsUnique();

                entity.Property(e => e.TableName)
                    .HasColumnName("TABLE_NAME")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.DuplicateId)
                    .HasColumnName("DUPLICATE_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.OriginalId)
                    .HasColumnName("ORIGINAL_ID")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<WebSuggestiveSell>(entity =>
            {
                entity.ToTable("WEB_SUGGESTIVE_SELL");

                entity.HasIndex(e => e.WebItemProductId)
                    .HasName("XIE1_WEB_SUGGESTIVE_SELL");

                entity.HasIndex(e => e.WebSuggestiveSellId)
                    .HasName("PK_WEB_SUGGESTIVE_SELL")
                    .IsUnique();

                entity.Property(e => e.WebSuggestiveSellId)
                    .HasColumnName("WEB_SUGGESTIVE_SELL_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FromDate)
                    .HasColumnName("FROM_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ToDate)
                    .HasColumnName("TO_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.WebItemProductId)
                    .HasColumnName("WEB_ITEM_PRODUCT_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.WebItemProduct)
                    .WithMany(p => p.WebSuggestiveSell)
                    .HasForeignKey(d => d.WebItemProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WEBSUGGSELL2WEBITEMPROD");
            });

            modelBuilder.Entity<WebToken>(entity =>
            {
                entity.HasKey(e => e.AuthorizationToken)
                    .HasName("XPKWEB_TOKEN");

                entity.ToTable("WEB_TOKEN");

                entity.HasIndex(e => e.AuthorizationToken)
                    .HasName("XPKWEB_TOKEN")
                    .IsUnique();

                entity.HasIndex(e => e.Expiry)
                    .HasName("XIF1WEB_TOKEN");

                entity.HasIndex(e => e.WebAccountId)
                    .HasName("XIE1WEB_TOKEN");

                entity.Property(e => e.AuthorizationToken)
                    .HasColumnName("AUTHORIZATION_TOKEN")
                    .HasDefaultValueSql("sys_guid() ");

                entity.Property(e => e.Expiry)
                    .HasColumnName("EXPIRY")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.WebAccountId)
                    .HasColumnName("WEB_ACCOUNT_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.WebAccount)
                    .WithMany(p => p.WebToken)
                    .HasForeignKey(d => d.WebAccountId)
                    .HasConstraintName("XFK1WEB_TOKEN");
            });

            modelBuilder.Entity<WebWaitlist>(entity =>
            {
                entity.ToTable("WEB_WAITLIST");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("NDX_WEB_WAITLIST2");

                entity.HasIndex(e => e.WebItemProductId)
                    .HasName("NDX_WEB_WAITLIST1");

                entity.HasIndex(e => e.WebWaitlistId)
                    .HasName("PK_WEB_WAITLIST")
                    .IsUnique();

                entity.Property(e => e.WebWaitlistId)
                    .HasColumnName("WEB_WAITLIST_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AnyPreviousOrders)
                    .IsRequired()
                    .HasColumnName("ANY_PREVIOUS_ORDERS")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CUSTOMER_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnName("EMAIL_ADDRESS")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.IsWholesaleCustomer)
                    .IsRequired()
                    .HasColumnName("IS_WHOLESALE_CUSTOMER")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("PHONE_NUMBER")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.PreviousOrderDate)
                    .HasColumnName("PREVIOUS_ORDER_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Quantity)
                    .HasColumnName("QUANTITY")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.WaitlistDate)
                    .HasColumnName("WAITLIST_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.WebItemProductId)
                    .HasColumnName("WEB_ITEM_PRODUCT_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.WebWaitlist)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FM_WEB_WAITLIST2");

                entity.HasOne(d => d.WebItemProduct)
                    .WithMany(p => p.WebWaitlist)
                    .HasForeignKey(d => d.WebItemProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WEB_WAITLIST1");
            });

            modelBuilder.Entity<ZipImport>(entity =>
            {
                entity.HasKey(e => new { e.Zip, e.State, e.City });

                entity.ToTable("ZIP_IMPORT");

                entity.HasIndex(e => new { e.Zip, e.City, e.State })
                    .HasName("PK_ZIP_IMPORT")
                    .IsUnique();

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.AreaCode)
                    .HasColumnName("AREA_CODE")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.County)
                    .HasColumnName("COUNTY")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.CountyFips)
                    .HasColumnName("COUNTY_FIPS")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Dst)
                    .HasColumnName("DST")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.MsaCode)
                    .HasColumnName("MSA_CODE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.PlaceFips)
                    .HasColumnName("PLACE_FIPS")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.StateFips)
                    .HasColumnName("STATE_FIPS")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.TimeZone)
                    .HasColumnName("TIME_ZONE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.ZipType)
                    .HasColumnName("ZIP_TYPE")
                    .HasColumnType("VARCHAR2(10)");
            });

            modelBuilder.Entity<Zipcode>(entity =>
            {
                entity.ToTable("ZIPCODE");

                entity.HasIndex(e => e.State)
                    .HasName("XIF2ZIPCODE");

                entity.HasIndex(e => e.ZipcodeId)
                    .HasName("XPKZIPCODE")
                    .IsUnique();

                entity.HasIndex(e => new { e.City, e.State })
                    .HasName("XIE1ZIPCODE");

                entity.HasIndex(e => new { e.City, e.State, e.Zip })
                    .HasName("NDX_ZIPCODE")
                    .IsUnique();

                entity.HasIndex(e => new { e.Zip, e.City, e.State })
                    .HasName("NDX_ZIPCODE")
                    .IsUnique();

                entity.Property(e => e.ZipcodeId)
                    .HasColumnName("ZIPCODE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("CITY")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastValidation)
                    .HasColumnName("LAST_VALIDATION")
                    .HasColumnType("DATE");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("STATE")
                    .HasColumnType("VARCHAR2(4)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnName("ZIP")
                    .HasColumnType("VARCHAR2(6)");
            });

            modelBuilder.HasSequence("SEQ_ACTIVITY_DTL_ID");

            modelBuilder.HasSequence("SEQ_ACTIVITY_ID");

            modelBuilder.HasSequence("SEQ_ACTIVITY_SESSION_ID");

            modelBuilder.HasSequence("SEQ_ACTIVITY_TYPE_ID");

            modelBuilder.HasSequence("SEQ_ATTRIB_DTL_ID");

            modelBuilder.HasSequence("SEQ_ATTRIB_GROUP_DTL_ID");

            modelBuilder.HasSequence("SEQ_ATTRIB_GROUP_HDR_ID");

            modelBuilder.HasSequence("SEQ_ATTRIB_HDR_ID");

            modelBuilder.HasSequence("SEQ_AUDIT_LOG_ID");

            modelBuilder.HasSequence("SEQ_AVAILABILITY_ID");

            modelBuilder.HasSequence("SEQ_BOX_DTL_ID");

            modelBuilder.HasSequence("SEQ_BOX_ID");

            modelBuilder.HasSequence("SEQ_BREED_ATTRIBUTE_ID");

            modelBuilder.HasSequence("SEQ_BREED_AVAILABILITY_ID");

            modelBuilder.HasSequence("SEQ_BREED_DESCRIPTION_ID");

            modelBuilder.HasSequence("SEQ_BREED_GROUP_ID");

            modelBuilder.HasSequence("SEQ_BREED_ID");

            modelBuilder.HasSequence("SEQ_BREED_TRAY_ID");

            modelBuilder.HasSequence("SEQ_BREED_TYPE_ID");

            modelBuilder.HasSequence("SEQ_BREEDSEARCH_DETAIL_ID");

            modelBuilder.HasSequence("SEQ_BREEDSEARCH_ID");

            modelBuilder.HasSequence("SEQ_CALLLIST_CODE_ID");

            modelBuilder.HasSequence("SEQ_CART_DTL_ATTRIB_ID");

            modelBuilder.HasSequence("SEQ_CART_DTL_ID");

            modelBuilder.HasSequence("SEQ_CART_ID");

            modelBuilder.HasSequence("SEQ_COD_CARD_ID");

            modelBuilder.HasSequence("SEQ_CREDITCARD_TRANSACTION_ID");

            modelBuilder.HasSequence("SEQ_CUSTOM_AVAIL_DETAIL_ID");

            modelBuilder.HasSequence("SEQ_CUSTOM_AVAIL_ID");

            modelBuilder.HasSequence("SEQ_CUSTOMER_CALLLIST_ID");

            modelBuilder.HasSequence("SEQ_CUSTOMER_CODE");

            modelBuilder.HasSequence("SEQ_CUSTOMER_CREDITCARD_ID");

            modelBuilder.HasSequence("SEQ_CUSTOMER_ID");

            modelBuilder.HasSequence("SEQ_CUSTOMER_NOTE_ID");

            modelBuilder.HasSequence("SEQ_CUSTOMERTYPE_ID");

            modelBuilder.HasSequence("SEQ_DROPSHIP_DTL_ID");

            modelBuilder.HasSequence("SEQ_DROPSHIP_ID");

            modelBuilder.HasSequence("SEQ_EASTERCODE_ID");

            modelBuilder.HasSequence("SEQ_EDI_DOCUMENT_ID");

            modelBuilder.HasSequence("SEQ_EDI_GROUP_CTRL_NUM");

            modelBuilder.HasSequence("SEQ_EDI_INTERCHANGE_CTRL_NUM");

            modelBuilder.HasSequence("SEQ_EDI_INVOICE_HDR_ID");

            modelBuilder.HasSequence("SEQ_EDI_PARTNER");

            modelBuilder.HasSequence("SEQ_EDI_PO_DTL_ID");

            modelBuilder.HasSequence("SEQ_EDI_PO_HDR_ID");

            modelBuilder.HasSequence("SEQ_EDI_TRANSLATION_ID");

            modelBuilder.HasSequence("SEQ_EMAIL_QUEUE");

            modelBuilder.HasSequence("SEQ_EMAIL_QUEUE_VARS");

            modelBuilder.HasSequence("SEQ_EMAIL_TEMPLATE");

            modelBuilder.HasSequence("SEQ_EMAIL_TEMPLATE_ARG");

            modelBuilder.HasSequence("SEQ_HATCHDAY_ANNUAL_ID");

            modelBuilder.HasSequence("SEQ_HATCHERY_ID");

            modelBuilder.HasSequence("SEQ_INVOICE_NUMBER");

            modelBuilder.HasSequence("SEQ_ITEM_GROUP_ID");

            modelBuilder.HasSequence("SEQ_MEMO_DTL_ID");

            modelBuilder.HasSequence("SEQ_MEMO_HDR_ID");

            modelBuilder.HasSequence("SEQ_MEMO_REASON_ID");

            modelBuilder.HasSequence("SEQ_MEMO_STATUS_ID");

            modelBuilder.HasSequence("SEQ_MULTIPLE_ORDER_ID");

            modelBuilder.HasSequence("SEQ_OFFSET_ID");

            modelBuilder.HasSequence("SEQ_OFFSETCODE_ID");

            modelBuilder.HasSequence("SEQ_ORDER_ID");

            modelBuilder.HasSequence("SEQ_ORDER_TYPE_ID");

            modelBuilder.HasSequence("SEQ_PAYMENT_DTL_ID");

            modelBuilder.HasSequence("SEQ_PAYMENT_HDR_ID");

            modelBuilder.HasSequence("SEQ_PAYMENT_SESSION_ID");

            modelBuilder.HasSequence("SEQ_PAYMENTTERM_ID");

            modelBuilder.HasSequence("SEQ_PERSON_ID");

            modelBuilder.HasSequence("SEQ_POSTAL_WEIGHT_ID");

            modelBuilder.HasSequence("SEQ_POSTALCODE_CHARGE_ID");

            modelBuilder.HasSequence("SEQ_POSTALCODE_ID");

            modelBuilder.HasSequence("SEQ_PRICESHEET_ID");

            modelBuilder.HasSequence("SEQ_PRODUCT_BREAKPOINT_ID");

            modelBuilder.HasSequence("SEQ_PRODUCT_BREED_ID");

            modelBuilder.HasSequence("SEQ_PRODUCT_BREED_PRODUCT_ID");

            modelBuilder.HasSequence("SEQ_PRODUCT_CATEGORY_ID");

            modelBuilder.HasSequence("SEQ_PRODUCT_CLASS_ID");

            modelBuilder.HasSequence("SEQ_PRODUCT_ID");

            modelBuilder.HasSequence("SEQ_PRODUCT_PRICE_ID");

            modelBuilder.HasSequence("SEQ_PRODUCT_PRICEDATE_ID");

            modelBuilder.HasSequence("SEQ_PRODUCT_PRICEPOINT_ID");

            modelBuilder.HasSequence("SEQ_PRODUCT_PRICING_ID");

            modelBuilder.HasSequence("SEQ_PRODUCTCOLOR_ID");

            modelBuilder.HasSequence("SEQ_PRODUCTPRICE_ID");

            modelBuilder.HasSequence("SEQ_REV_CUSTOMER_ID");

            modelBuilder.HasSequence("SEQ_REV_ORDER_ID");

            modelBuilder.HasSequence("SEQ_REV_SUBORDER_ID");

            modelBuilder.HasSequence("SEQ_ROLODEX_ID");

            modelBuilder.HasSequence("SEQ_ROLODEX_TYPE_ID");

            modelBuilder.HasSequence("SEQ_ROUTE_ID");

            modelBuilder.HasSequence("SEQ_SHIPDAY_CODE_ID");

            modelBuilder.HasSequence("SEQ_SHIPDAY_ID");

            modelBuilder.HasSequence("SEQ_SHIPPING_LOCATION_ID");

            modelBuilder.HasSequence("SEQ_SHIPPING_TRUCK_ID");

            modelBuilder.HasSequence("SEQ_SPECIAL_ID");

            modelBuilder.HasSequence("SEQ_SPECIAL_INSTRUCTION_ID");

            modelBuilder.HasSequence("SEQ_SPECIAL_SERVICE_ID");

            modelBuilder.HasSequence("SEQ_STATE_ID");

            modelBuilder.HasSequence("SEQ_SUBORDER_DTL_ID");

            modelBuilder.HasSequence("SEQ_SUBORDER_ID");

            modelBuilder.HasSequence("SEQ_SUGGESTIVE_SELL_ID");

            modelBuilder.HasSequence("SEQ_WAITLIST_ID");

            modelBuilder.HasSequence("SEQ_WEB_ACCOUNT");

            modelBuilder.HasSequence("SEQ_WEB_ADDRESS_ID");

            modelBuilder.HasSequence("SEQ_WEB_ATTR_DTL_ID");

            modelBuilder.HasSequence("SEQ_WEB_ATTR_GROUP_DTL_ID");

            modelBuilder.HasSequence("SEQ_WEB_ATTR_GROUP_ID");

            modelBuilder.HasSequence("SEQ_WEB_ATTR_ID");

            modelBuilder.HasSequence("SEQ_WEB_AVAILABILITY_ID");

            modelBuilder.HasSequence("SEQ_WEB_BLACKOUT");

            modelBuilder.HasSequence("SEQ_WEB_BREED_ID");

            modelBuilder.HasSequence("SEQ_WEB_CART");

            modelBuilder.HasSequence("SEQ_WEB_CART_DTL");

            modelBuilder.HasSequence("SEQ_WEB_CART_DTL_ATTR");

            modelBuilder.HasSequence("SEQ_WEB_CATEGORY_ID");

            modelBuilder.HasSequence("SEQ_WEB_DESCRIPTION_FLAG");

            modelBuilder.HasSequence("SEQ_WEB_FAQ_ID");

            modelBuilder.HasSequence("SEQ_WEB_IMAGE_ID");

            modelBuilder.HasSequence("SEQ_WEB_ITEM_DESCRIPTION_ID");

            modelBuilder.HasSequence("SEQ_WEB_ITEM_ID");

            modelBuilder.HasSequence("SEQ_WEB_ITEM_PRODUCT_ID");

            modelBuilder.HasSequence("SEQ_WEB_ORDER_DTL");

            modelBuilder.HasSequence("SEQ_WEB_ORDER_DTL_ATTR_ID");

            modelBuilder.HasSequence("SEQ_WEB_ORDER_HDR");

            modelBuilder.HasSequence("SEQ_WEB_ORDER_MASTER_ID");

            modelBuilder.HasSequence("SEQ_WEB_PREVIEW_ID");

            modelBuilder.HasSequence("SEQ_WEB_SEARCH_ID");

            modelBuilder.HasSequence("SEQ_WEB_SEASON_ID");

            modelBuilder.HasSequence("SEQ_WEB_SHIPPING_INFO");

            modelBuilder.HasSequence("SEQ_WEB_SPECIAL_SERVICE_ID");

            modelBuilder.HasSequence("SEQ_WEB_SUGGESTIVE_SELL_ID");

            modelBuilder.HasSequence("SEQ_WEB_WAITLIST");

            modelBuilder.HasSequence("SEQ_ZIPCODE_ID");
        }

        public Int64 IsUserValid(LoginModel model)
        {
            return this.Database.ExecuteSqlCommand("validate_user @p0, @p1", model.UserName, model.Password);
        }
    }
}
