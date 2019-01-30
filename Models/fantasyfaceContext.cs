using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace supermasks.Models
{
    public partial class fantasyfaceContext : DbContext
    {
        public fantasyfaceContext(DbContextOptions<fantasyfaceContext> options) : base(options){}

        public virtual DbSet<AgentMaster> AgentMaster { get; set; }
        public virtual DbSet<ApiDetails> ApiDetails { get; set; }
        public virtual DbSet<AppMaster> AppMaster { get; set; }
        public virtual DbSet<Baskets> Baskets { get; set; }
        public virtual DbSet<BstatusMaster> BstatusMaster { get; set; }
        public virtual DbSet<CatsImages> CatsImages { get; set; }
        public virtual DbSet<CatsMaster> CatsMaster { get; set; }
        public virtual DbSet<CatsProducts> CatsProducts { get; set; }
        public virtual DbSet<ColorMaster> ColorMaster { get; set; }
        public virtual DbSet<ColorProducts> ColorProducts { get; set; }
        public virtual DbSet<ConfirmDetails> ConfirmDetails { get; set; }
        public virtual DbSet<CurrencyDetails> CurrencyDetails { get; set; }
        public virtual DbSet<CurrencyMaster> CurrencyMaster { get; set; }
        public virtual DbSet<CustomerMaster> CustomerMaster { get; set; }
        public virtual DbSet<DiscountCodes> DiscountCodes { get; set; }
        public virtual DbSet<DiscountDetails> DiscountDetails { get; set; }
        public virtual DbSet<DmessageMaster> DmessageMaster { get; set; }
        public virtual DbSet<DtypeMaster> DtypeMaster { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<EuDetails> EuDetails { get; set; }
        public virtual DbSet<Ftpimages> Ftpimages { get; set; }
        public virtual DbSet<FunctionComments> FunctionComments { get; set; }
        public virtual DbSet<GenderMaster> GenderMaster { get; set; }
        public virtual DbSet<GenderProducts> GenderProducts { get; set; }
        public virtual DbSet<HolidayMaster> HolidayMaster { get; set; }
        public virtual DbSet<ImageProds> ImageProds { get; set; }
        public virtual DbSet<LogDetails> LogDetails { get; set; }
        public virtual DbSet<LogtypeMaster> LogtypeMaster { get; set; }
        public virtual DbSet<MessageDetails> MessageDetails { get; set; }
        public virtual DbSet<ModuleMaster> ModuleMaster { get; set; }
        public virtual DbSet<OfferDetails> OfferDetails { get; set; }
        public virtual DbSet<PageDetails> PageDetails { get; set; }
        public virtual DbSet<PageMaster> PageMaster { get; set; }
        public virtual DbSet<PostageMaster> PostageMaster { get; set; }
        public virtual DbSet<PresaleCustomerDetails> PresaleCustomerDetails { get; set; }
        public virtual DbSet<PresaleDetails> PresaleDetails { get; set; }
        public virtual DbSet<PricelistLogs> PricelistLogs { get; set; }
        public virtual DbSet<PrintMaster> PrintMaster { get; set; }
        public virtual DbSet<PrintReports> PrintReports { get; set; }
        public virtual DbSet<ProductLogs> ProductLogs { get; set; }
        public virtual DbSet<ProductMaster> ProductMaster { get; set; }
        public virtual DbSet<PromotionMaster> PromotionMaster { get; set; }
        public virtual DbSet<PtierMaster> PtierMaster { get; set; }
        public virtual DbSet<Rbaskets> Rbaskets { get; set; }
        public virtual DbSet<RecentprodsDetails> RecentprodsDetails { get; set; }
        public virtual DbSet<RelatedProds> RelatedProds { get; set; }
        public virtual DbSet<ReorderDetails> ReorderDetails { get; set; }
        public virtual DbSet<RoleMaster> RoleMaster { get; set; }
        public virtual DbSet<RoleModule> RoleModule { get; set; }
        public virtual DbSet<RscsaleReport> RscsaleReport { get; set; }
        public virtual DbSet<SaleonlineMaster> SaleonlineMaster { get; set; }
        public virtual DbSet<SalesDetails> SalesDetails { get; set; }
        public virtual DbSet<SalesinfoDetails> SalesinfoDetails { get; set; }
        public virtual DbSet<SaleslogDetails> SaleslogDetails { get; set; }
        public virtual DbSet<SalesMaster> SalesMaster { get; set; }
        public virtual DbSet<SearchResults> SearchResults { get; set; }
        public virtual DbSet<SeoDetails> SeoDetails { get; set; }
        public virtual DbSet<SiteMaster> SiteMaster { get; set; }
        public virtual DbSet<SizeMaster> SizeMaster { get; set; }
        public virtual DbSet<StatsMaster> StatsMaster { get; set; }
        public virtual DbSet<StockDetails> StockDetails { get; set; }
        public virtual DbSet<StockProds> StockProds { get; set; }
        public virtual DbSet<StocktakeCats> StocktakeCats { get; set; }
        public virtual DbSet<StocktakeDetails> StocktakeDetails { get; set; }
        public virtual DbSet<SupplierMaster> SupplierMaster { get; set; }
        public virtual DbSet<SupplyprodDetails> SupplyprodDetails { get; set; }
        public virtual DbSet<TermsDetails> TermsDetails { get; set; }
        public virtual DbSet<TermsMaster> TermsMaster { get; set; }
        public virtual DbSet<TierMaster> TierMaster { get; set; }
        public virtual DbSet<TypeMaster> TypeMaster { get; set; }
        public virtual DbSet<UrlDetails> UrlDetails { get; set; }
        public virtual DbSet<UserMaster> UserMaster { get; set; }
        public virtual DbSet<UserSession> UserSession { get; set; }
        public virtual DbSet<VerificationDetails> VerificationDetails { get; set; }
        public virtual DbSet<VoucherDetails> VoucherDetails { get; set; }
        public virtual DbSet<VoucherSession> VoucherSession { get; set; }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgentMaster>(entity =>
            {
                entity.HasKey(e => e.Agentid);

                entity.ToTable("agent_master");

                entity.Property(e => e.Agentid).HasColumnName("agentid");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fname)
                    .HasColumnName("fname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasColumnName("lname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("pcode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Share).HasColumnName("share");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Town)
                    .HasColumnName("town")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnName("vat")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApiDetails>(entity =>
            {
                entity.HasKey(e => e.Apiid);

                entity.ToTable("api_details");

                entity.Property(e => e.Apiid).HasColumnName("apiid");

                entity.Property(e => e.Apikey)
                    .HasColumnName("apikey")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<AppMaster>(entity =>
            {
                entity.HasKey(e => e.Appid);

                entity.ToTable("app_master");

                entity.Property(e => e.Appid).HasColumnName("appid");

                entity.Property(e => e.Appcode)
                    .HasColumnName("appcode")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Baskets>(entity =>
            {
                entity.HasKey(e => e.Basketid);

                entity.ToTable("baskets");

                entity.HasIndex(e => e.Bsession)
                    .HasName("ph_session");

                entity.HasIndex(e => e.Orderid)
                    .HasName("pk_orderid");

                entity.HasIndex(e => e.Prodid)
                    .HasName("pk_bas_prodid");

                entity.Property(e => e.Basketid).HasColumnName("basketid");

                entity.Property(e => e.Basketstatus)
                    .HasColumnName("basketstatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Bsession)
                    .HasColumnName("bsession")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Custid)
                    .HasColumnName("custid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isvat)
                    .HasColumnName("isvat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lpage)
                    .HasColumnName("lpage")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Siteid).HasColumnName("siteid");

                entity.Property(e => e.Sizeid)
                    .HasColumnName("sizeid")
                    .HasDefaultValueSql("((1000000))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<BstatusMaster>(entity =>
            {
                entity.HasKey(e => e.Statusid);

                entity.ToTable("bstatus_master");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatsImages>(entity =>
            {
                entity.HasKey(e => e.Catimageid);

                entity.ToTable("cats_images");

                entity.HasIndex(e => e.Catcode)
                    .HasName("pk_ci_catcode");

                entity.HasIndex(e => e.Siteid)
                    .HasName("pk_siteid_img");

                entity.Property(e => e.Catimageid).HasColumnName("catimageid");

                entity.Property(e => e.Catcode).HasColumnName("catcode");

                entity.Property(e => e.Catimg)
                    .HasColumnName("catimg")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Headimg)
                    .HasColumnName("headimg")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Menuimg)
                    .HasColumnName("menuimg")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Siteid).HasColumnName("siteid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CatsMaster>(entity =>
            {
                entity.HasKey(e => e.Catid);

                entity.ToTable("cats_master");

                entity.HasIndex(e => e.Code)
                    .HasName("pk_code");

                entity.HasIndex(e => e.Parentcode)
                    .HasName("pk_parentcode");

                entity.HasIndex(e => e.Url)
                    .HasName("pk_cm_url");

                entity.Property(e => e.Catid).HasColumnName("catid");

                entity.Property(e => e.Arsc)
                    .HasColumnName("arsc")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Fancy Dress')");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Corder).HasColumnName("corder");

                entity.Property(e => e.Islens)
                    .HasColumnName("islens")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ismain)
                    .HasColumnName("ismain")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Issale)
                    .HasColumnName("issale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Longname)
                    .HasColumnName("longname")
                    .HasMaxLength(154)
                    .IsUnicode(false);

                entity.Property(e => e.Maincatid).HasColumnName("maincatid");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Onweb)
                    .HasColumnName("onweb")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Parentcode).HasColumnName("parentcode");

                entity.Property(e => e.Pc)
                    .HasColumnName("pc")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatsProducts>(entity =>
            {
                entity.HasKey(e => e.Catindexid);

                entity.ToTable("cats_products");

                entity.HasIndex(e => e.Catcode)
                    .HasName("pk_cp_catcode");

                entity.HasIndex(e => e.Ismain)
                    .HasName("pk_ismain");

                entity.HasIndex(e => e.Prodid)
                    .HasName("pk_cp_prodid");

                entity.Property(e => e.Catindexid).HasColumnName("catindexid");

                entity.Property(e => e.Catcode).HasColumnName("catcode");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ismain)
                    .HasColumnName("ismain")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ColorMaster>(entity =>
            {
                entity.HasKey(e => e.Colorid);

                entity.ToTable("color_master");

                entity.Property(e => e.Colorid).HasColumnName("colorid");

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ColorProducts>(entity =>
            {
                entity.HasKey(e => e.Colorindexid);

                entity.ToTable("color_products");

                entity.Property(e => e.Colorindexid).HasColumnName("colorindexid");

                entity.Property(e => e.Colorid).HasColumnName("colorid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ConfirmDetails>(entity =>
            {
                entity.ToTable("confirm_details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Authcode)
                    .HasColumnName("authcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Md5hash)
                    .HasColumnName("MD5HASH")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CurrencyDetails>(entity =>
            {
                entity.HasKey(e => e.Cdid);

                entity.ToTable("currency_details");

                entity.Property(e => e.Cdid).HasColumnName("cdid");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Empid).HasColumnName("empid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Rrate).HasColumnName("rrate");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CurrencyMaster>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("currency_master");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Ccode)
                    .HasColumnName("ccode")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Cname)
                    .HasColumnName("cname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Corder).HasColumnName("corder");

                entity.Property(e => e.Ctcode)
                    .HasColumnName("ctcode")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CustomerMaster>(entity =>
            {
                entity.HasKey(e => e.Custid);

                entity.ToTable("customer_master");

                entity.Property(e => e.Custid).HasColumnName("custid");

                entity.Property(e => e.Agent)
                    .HasColumnName("agent")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Agentid)
                    .HasColumnName("agentid")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Cfname)
                    .HasColumnName("cfname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Clname)
                    .HasColumnName("clname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cname)
                    .HasColumnName("cname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasColumnName("county")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Customerno)
                    .HasColumnName("customerno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dcountry)
                    .HasColumnName("dcountry")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dcounty)
                    .HasColumnName("dcounty")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dhno)
                    .HasColumnName("dhno")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dpcode)
                    .HasColumnName("dpcode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dstreet)
                    .HasColumnName("dstreet")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dtown)
                    .HasColumnName("dtown")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hno)
                    .HasColumnName("hno")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Isdel)
                    .HasColumnName("isdel")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Isvat)
                    .HasColumnName("isvat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("pcode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Town)
                    .HasColumnName("town")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnName("vat")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiscountCodes>(entity =>
            {
                entity.HasKey(e => e.Dcid);

                entity.ToTable("discount_codes");

                entity.Property(e => e.Dcid).HasColumnName("dcid");

                entity.Property(e => e.Dccode)
                    .HasColumnName("dccode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<DiscountDetails>(entity =>
            {
                entity.HasKey(e => e.Discountid);

                entity.ToTable("discount_details");

                entity.Property(e => e.Discountid).HasColumnName("discountid");

                entity.Property(e => e.Catid)
                    .HasColumnName("catid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Edate)
                    .HasColumnName("edate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sdate)
                    .HasColumnName("sdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<DmessageMaster>(entity =>
            {
                entity.HasKey(e => e.Msgid);

                entity.ToTable("dmessage_master");

                entity.HasIndex(e => e.Siteid)
                    .HasName("pk_siteid");

                entity.Property(e => e.Msgid).HasColumnName("msgid");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Msg)
                    .HasColumnName("msg")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Siteid).HasColumnName("siteid");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<DtypeMaster>(entity =>
            {
                entity.HasKey(e => e.Dtypeid);

                entity.ToTable("dtype_master");

                entity.Property(e => e.Dtypeid).HasColumnName("dtypeid");

                entity.Property(e => e.Dtype)
                    .HasColumnName("dtype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.HasKey(e => e.Logid);

                entity.ToTable("error_log");

                entity.Property(e => e.Logid).HasColumnName("logid");

                entity.Property(e => e.Appcode)
                    .HasColumnName("appcode")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Logval)
                    .HasColumnName("logval")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Mfunction)
                    .HasColumnName("mfunction")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Moduleid).HasColumnName("moduleid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<EuDetails>(entity =>
            {
                entity.HasKey(e => e.Euid);

                entity.ToTable("EU_details");

                entity.Property(e => e.Euid).HasColumnName("euid");

                entity.Property(e => e.Eucode)
                    .HasColumnName("eucode")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Ftpimages>(entity =>
            {
                entity.HasKey(e => e.Imgid);

                entity.ToTable("ftpimages");

                entity.Property(e => e.Imgid).HasColumnName("imgid");

                entity.Property(e => e.Img)
                    .HasColumnName("img")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Prodid)
                    .HasColumnName("prodid")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<FunctionComments>(entity =>
            {
                entity.HasKey(e => e.Fcid);

                entity.ToTable("function_comments");

                entity.Property(e => e.Fcid).HasColumnName("fcid");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<GenderMaster>(entity =>
            {
                entity.HasKey(e => e.Genderid);

                entity.ToTable("gender_master");

                entity.Property(e => e.Genderid).HasColumnName("genderid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<GenderProducts>(entity =>
            {
                entity.HasKey(e => e.Genindexid);

                entity.ToTable("gender_products");

                entity.Property(e => e.Genindexid).HasColumnName("genindexid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Genderid).HasColumnName("genderid");

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HolidayMaster>(entity =>
            {
                entity.HasKey(e => e.Holidayid);

                entity.ToTable("holiday_master");

                entity.Property(e => e.Holidayid).HasColumnName("holidayid");

                entity.Property(e => e.Hdate)
                    .HasColumnName("hdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ImageProds>(entity =>
            {
                entity.HasKey(e => e.Imageid);

                entity.ToTable("Image_prods");

                entity.HasIndex(e => e.Prodid)
                    .HasName("pk_ip_prodid");

                entity.Property(e => e.Imageid).HasColumnName("imageid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Imgname)
                    .HasColumnName("imgname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<LogDetails>(entity =>
            {
                entity.HasKey(e => e.Actionid);

                entity.ToTable("log_details");

                entity.Property(e => e.Actionid).HasColumnName("actionid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Logtypeid).HasColumnName("logtypeid");

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Siteid).HasColumnName("siteid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<LogtypeMaster>(entity =>
            {
                entity.HasKey(e => e.Logtypeid);

                entity.ToTable("logtype_master");

                entity.Property(e => e.Logtypeid).HasColumnName("logtypeid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Logtype)
                    .HasColumnName("logtype")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rpt)
                    .HasColumnName("rpt")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tbl)
                    .HasColumnName("tbl")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MessageDetails>(entity =>
            {
                entity.HasKey(e => e.Msgid);

                entity.ToTable("message_details");

                entity.HasIndex(e => e.Email)
                    .HasName("pk_email");

                entity.HasIndex(e => e.Siteid)
                    .HasName("pk_siteid");

                entity.Property(e => e.Msgid).HasColumnName("msgid");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Siteid).HasColumnName("siteid");
            });

            modelBuilder.Entity<ModuleMaster>(entity =>
            {
                entity.HasKey(e => e.Moduleid);

                entity.ToTable("module_master");

                entity.Property(e => e.Moduleid).HasColumnName("moduleid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Frmname)
                    .HasColumnName("frmname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Menu)
                    .HasColumnName("menu")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mname)
                    .HasColumnName("mname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Morder).HasColumnName("morder");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<OfferDetails>(entity =>
            {
                entity.HasKey(e => e.Offerid);

                entity.ToTable("offer_details");

                entity.Property(e => e.Offerid).HasColumnName("offerid");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Edate)
                    .HasColumnName("edate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sdate)
                    .HasColumnName("sdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Siteid).HasColumnName("siteid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<PageDetails>(entity =>
            {
                entity.HasKey(e => e.Pagecatid);

                entity.ToTable("page_details");

                entity.Property(e => e.Pagecatid).HasColumnName("pagecatid");

                entity.Property(e => e.Catcode).HasColumnName("catcode");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pageid).HasColumnName("pageid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<PageMaster>(entity =>
            {
                entity.HasKey(e => e.Pageid);

                entity.ToTable("page_master");

                entity.Property(e => e.Pageid).HasColumnName("pageid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H1txt)
                    .HasColumnName("h1txt")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.H2txt)
                    .HasColumnName("h2txt")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Headimg)
                    .HasColumnName("headimg")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Metadesc)
                    .HasColumnName("metadesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Metakey)
                    .HasColumnName("metakey")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pagename)
                    .HasColumnName("pagename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Seobot)
                    .HasColumnName("seobot")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Seotop)
                    .HasColumnName("seotop")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PostageMaster>(entity =>
            {
                entity.HasKey(e => e.Postageid);

                entity.ToTable("postage_master");

                entity.Property(e => e.Postageid).HasColumnName("postageid");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Edays).HasColumnName("edays");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isdiscount)
                    .HasColumnName("isdiscount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Iseu).HasColumnName("iseu");

                entity.Property(e => e.Isimp)
                    .HasColumnName("isimp")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Isnd).HasColumnName("isnd");

                entity.Property(e => e.Issd).HasColumnName("issd");

                entity.Property(e => e.Issignature).HasColumnName("issignature");

                entity.Property(e => e.Isww).HasColumnName("isww");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("text");

                entity.Property(e => e.Method)
                    .HasColumnName("method")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mtype)
                    .HasColumnName("mtype")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Pamount)
                    .HasColumnName("pamount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Porder).HasColumnName("porder");

                entity.Property(e => e.Sdays)
                    .HasColumnName("sdays")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.Siteid).HasColumnName("siteid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Telesale).HasColumnName("telesale");
            });

            modelBuilder.Entity<PresaleCustomerDetails>(entity =>
            {
                entity.HasKey(e => e.Custaddid);

                entity.ToTable("presale_customer_details");

                entity.Property(e => e.Custaddid).HasColumnName("custaddid");

                entity.Property(e => e.Add1)
                    .HasColumnName("add1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Add2)
                    .HasColumnName("add2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("pcode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<PresaleDetails>(entity =>
            {
                entity.HasKey(e => e.Presaleid);

                entity.ToTable("presale_details");

                entity.HasIndex(e => e.Bsession)
                    .HasName("pk_pd_session");

                entity.HasIndex(e => e.Orderid)
                    .HasName("pk_pd_orderid");

                entity.Property(e => e.Presaleid).HasColumnName("presaleid");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Bsession)
                    .HasColumnName("bsession")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Curcode)
                    .HasColumnName("curcode")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('GBP')");

                entity.Property(e => e.Custadd)
                    .HasColumnName("custadd")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Custemail)
                    .HasColumnName("custemail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Custid)
                    .HasColumnName("custid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Custphone)
                    .HasColumnName("custphone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Deladd)
                    .HasColumnName("deladd")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Discountcode)
                    .HasColumnName("discountcode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Donation)
                    .HasColumnName("donation")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Istele).HasColumnName("istele");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Postage)
                    .HasColumnName("postage")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Postageid).HasColumnName("postageid");

                entity.Property(e => e.Ptype)
                    .HasColumnName("ptype")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Siteid).HasColumnName("siteid");

                entity.Property(e => e.Vat)
                    .HasColumnName("vat")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.PostageNavigation)
                    .WithMany(p => p.PresaleDetails)
                    .HasForeignKey(d => d.Postageid)
                    .HasConstraintName("FK_presale_details_postage_master");
            });

            modelBuilder.Entity<PricelistLogs>(entity =>
            {
                entity.HasKey(e => e.Logid);

                entity.ToTable("pricelist_logs");

                entity.Property(e => e.Logid).HasColumnName("logid");

                entity.Property(e => e.Barcode)
                    .HasColumnName("barcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lfcost).HasColumnName("lfcost");

                entity.Property(e => e.Lrcost).HasColumnName("lrcost");

                entity.Property(e => e.Minorder)
                    .HasColumnName("minorder")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nbarcode)
                    .HasColumnName("nbarcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nfcost).HasColumnName("nfcost");

                entity.Property(e => e.Nminorder)
                    .HasColumnName("nminorder")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nrcost).HasColumnName("nrcost");

                entity.Property(e => e.Prodcode)
                    .HasColumnName("prodcode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Spid).HasColumnName("spid");

                entity.Property(e => e.Updated)
                    .HasColumnName("updated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<PrintMaster>(entity =>
            {
                entity.HasKey(e => e.Printid);

                entity.ToTable("print_master");

                entity.Property(e => e.Printid).HasColumnName("printid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Porder).HasColumnName("porder");

                entity.Property(e => e.Printname)
                    .HasColumnName("printname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rptcode)
                    .HasColumnName("rptcode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Usp)
                    .HasColumnName("usp")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrintReports>(entity =>
            {
                entity.HasKey(e => e.Rptid);

                entity.ToTable("print_reports");

                entity.Property(e => e.Rptid).HasColumnName("rptid");

                entity.Property(e => e.Altprodcode)
                    .HasColumnName("altprodcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Altsupp)
                    .HasColumnName("altsupp")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Catcode).HasColumnName("catcode");

                entity.Property(e => e.Cnt).HasColumnName("cnt");

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Crprice)
                    .HasColumnName("crprice")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Empid).HasColumnName("empid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isbest)
                    .HasColumnName("isbest")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Online).HasColumnName("online");

                entity.Property(e => e.Page)
                    .HasColumnName("page")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Prodcode)
                    .HasColumnName("prodcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Prodname)
                    .HasColumnName("prodname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Prodsize)
                    .HasColumnName("prodsize")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reorder)
                    .HasColumnName("reorder")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Roid).HasColumnName("roid");

                entity.Property(e => e.Sprice)
                    .HasColumnName("sprice")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Suppid).HasColumnName("suppid");

                entity.Property(e => e.Supplier)
                    .HasColumnName("supplier")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tierid).HasColumnName("tierid");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Webprice)
                    .HasColumnName("webprice")
                    .HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<ProductLogs>(entity =>
            {
                entity.HasKey(e => e.Prodlogid);

                entity.ToTable("product_logs");

                entity.HasIndex(e => e.Prodid)
                    .HasName("pk_logs_prodid");

                entity.HasIndex(e => e.Userid)
                    .HasName("pk_logs_uid");

                entity.Property(e => e.Prodlogid).HasColumnName("prodlogid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ProductMaster>(entity =>
            {
                entity.HasKey(e => e.Prodid);

                entity.ToTable("product_master");

                entity.HasIndex(e => e.Catcode)
                    .HasName("pk_catcode");

                entity.HasIndex(e => e.Descr)
                    .HasName("pk_pd_descr");

                entity.HasIndex(e => e.Isonline)
                    .HasName("pk_isonline");

                entity.HasIndex(e => e.Isshop)
                    .HasName("pk_isshop");

                entity.HasIndex(e => e.Isstock)
                    .HasName("pk_isstock");

                entity.HasIndex(e => e.Mprodid)
                    .HasName("pk_mprodid");

                entity.HasIndex(e => e.Name)
                    .HasName("pk_pd_name");

                entity.HasIndex(e => e.Price)
                    .HasName("pk_price");

                entity.HasIndex(e => e.Tierid)
                    .HasName("pk_tierid");

                entity.HasIndex(e => e.Url)
                    .HasName("pk_url");

                entity.HasIndex(e => e.Webprice)
                    .HasName("pk_webprice");

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Btype)
                    .HasColumnName("btype")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Catcode)
                    .HasColumnName("catcode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Colorid)
                    .HasColumnName("colorid")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Cqty).HasColumnName("cqty");

                entity.Property(e => e.Crprice)
                    .HasColumnName("crprice")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Delivery)
                    .HasColumnName("delivery")
                    .HasMaxLength(1000);

                entity.Property(e => e.Descr)
                    .HasColumnName("descr")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Esize)
                    .HasColumnName("esize")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fbdes)
                    .HasColumnName("fbdes")
                    .HasMaxLength(1000);

                entity.Property(e => e.Img)
                    .HasColumnName("img")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NO-PICTURE-AVAILABLE.JPG')");

                entity.Property(e => e.Isballoon)
                    .HasColumnName("isballoon")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Iscap)
                    .HasColumnName("iscap")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ischange)
                    .HasColumnName("ischange")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Isonline)
                    .HasColumnName("isonline")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Isreduced)
                    .HasColumnName("isreduced")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Isshop)
                    .HasColumnName("isshop")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isstock)
                    .HasColumnName("isstock")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Isxl)
                    .HasColumnName("isxl")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Maxqty).HasColumnName("maxqty");

                entity.Property(e => e.Mdes)
                    .HasColumnName("mdes")
                    .HasMaxLength(1000);

                entity.Property(e => e.Mdesc)
                    .HasColumnName("mdesc")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Minqty).HasColumnName("minqty");

                entity.Property(e => e.Mkeys)
                    .HasColumnName("mkeys")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Mprodid)
                    .HasColumnName("mprodid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Oprice)
                    .HasColumnName("oprice")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pndes)
                    .HasColumnName("pndes")
                    .HasMaxLength(1000);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Prodcode)
                    .HasColumnName("prodcode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Pssdes)
                    .HasColumnName("pssdes")
                    .HasMaxLength(1000);

                entity.Property(e => e.Ptid)
                    .HasColumnName("ptid")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.Ptitle)
                    .HasColumnName("ptitle")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rrprice)
                    .HasColumnName("rrprice")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rwprice)
                    .HasColumnName("rwprice")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sizeid)
                    .HasColumnName("sizeid")
                    .HasDefaultValueSql("((1000000))");

                entity.Property(e => e.Soffer)
                    .HasColumnName("soffer")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Specification)
                    .HasColumnName("specification")
                    .HasMaxLength(1000);

                entity.Property(e => e.Sprice)
                    .HasColumnName("sprice")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tierid)
                    .HasColumnName("tierid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Wdes)
                    .HasColumnName("wdes")
                    .HasMaxLength(1000);

                entity.Property(e => e.Webprice)
                    .HasColumnName("webprice")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Wsale)
                    .HasColumnName("wsale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Zerovat)
                    .HasColumnName("zerovat")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PromotionMaster>(entity =>
            {
                entity.HasKey(e => e.Dcid);

                entity.ToTable("promotion_master");

                entity.Property(e => e.Dcid).HasColumnName("dcid");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Dtypeid).HasColumnName("dtypeid");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Img)
                    .HasColumnName("img")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Postageid).HasColumnName("postageid");

                entity.Property(e => e.Siteid).HasColumnName("siteid");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Dtype)
                    .WithMany(p => p.PromotionMaster)
                    .HasForeignKey(d => d.Dtypeid)
                    .HasConstraintName("FK_promotion_master_dtype_master");
            });

            modelBuilder.Entity<PtierMaster>(entity =>
            {
                entity.HasKey(e => e.Ptid);

                entity.ToTable("ptier_master");

                entity.Property(e => e.Ptid).HasColumnName("ptid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Rbaskets>(entity =>
            {
                entity.HasKey(e => e.Rbid);

                entity.ToTable("rbaskets");

                entity.Property(e => e.Rbid).HasColumnName("rbid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InfoId).HasColumnName("infoID");

                entity.Property(e => e.Isvat)
                    .HasColumnName("isvat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Saleid).HasColumnName("saleid");

                entity.Property(e => e.Sitecode)
                    .HasColumnName("sitecode")
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.Siteid).HasColumnName("siteid");

                entity.Property(e => e.Sizeid).HasColumnName("sizeid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<RecentprodsDetails>(entity =>
            {
                entity.HasKey(e => e.Recentid);

                entity.ToTable("recentprods_details");

                entity.HasIndex(e => e.Prodid)
                    .HasName("pk_rp_prodid");

                entity.HasIndex(e => e.Sessionid)
                    .HasName("pk_rp_session");

                entity.Property(e => e.Recentid).HasColumnName("recentid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Sessionid)
                    .HasColumnName("sessionid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RelatedProds>(entity =>
            {
                entity.HasKey(e => e.Relid);

                entity.ToTable("related_prods");

                entity.HasIndex(e => e.Prodid)
                    .HasName("pk_prodid");

                entity.HasIndex(e => e.Rprodid)
                    .HasName("pk_rprodid");

                entity.Property(e => e.Relid).HasColumnName("relid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Rprodid).HasColumnName("rprodid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ReorderDetails>(entity =>
            {
                entity.HasKey(e => e.Roid);

                entity.ToTable("reorder_details");

                entity.Property(e => e.Roid).HasColumnName("roid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Rorder).HasColumnName("rorder");

                entity.Property(e => e.Sorder)
                    .HasColumnName("sorder")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<RoleMaster>(entity =>
            {
                entity.HasKey(e => e.Roleid);

                entity.ToTable("role_master");

                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isshop)
                    .HasColumnName("isshop")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Issuper)
                    .HasColumnName("issuper")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<RoleModule>(entity =>
            {
                entity.HasKey(e => e.Rmid);

                entity.ToTable("role_module");

                entity.Property(e => e.Rmid).HasColumnName("rmid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Moduleid).HasColumnName("moduleid");

                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.Property(e => e.Roletype)
                    .HasColumnName("roletype")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<RscsaleReport>(entity =>
            {
                entity.HasKey(e => e.Rptid);

                entity.ToTable("rscsale_report");

                entity.HasIndex(e => e.Empid)
                    .HasName("pk_empid_rsc");

                entity.HasIndex(e => e.Prodid)
                    .HasName("pk_prodid_rsc");

                entity.Property(e => e.Rptid).HasColumnName("rptid");

                entity.Property(e => e.Empid)
                    .HasColumnName("empid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Entrydatetime)
                    .HasColumnName("entrydatetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Prodid)
                    .HasColumnName("prodid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Store)
                    .HasColumnName("store")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Trade)
                    .HasColumnName("trade")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SaleonlineMaster>(entity =>
            {
                entity.HasKey(e => e.Saleonlineid);

                entity.ToTable("saleonline_master");

                entity.Property(e => e.Saleonlineid).HasColumnName("saleonlineid");

                entity.Property(e => e.Saleonline)
                    .HasColumnName("saleonline")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SalesDetails>(entity =>
            {
                entity.HasKey(e => e.Saleid);

                entity.ToTable("sales_details");

                entity.HasIndex(e => e.InfoId)
                    .HasName("pk_sd_infoid");

                entity.HasIndex(e => e.Prodid)
                    .HasName("pk_prodid");

                entity.HasIndex(e => e.Siteid)
                    .HasName("pk_siteid");

                entity.Property(e => e.Saleid).HasColumnName("saleid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InfoId).HasColumnName("infoID");

                entity.Property(e => e.Isvat)
                    .HasColumnName("isvat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Sitecode)
                    .HasColumnName("sitecode")
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.Siteid).HasColumnName("siteid");

                entity.Property(e => e.Sizeid).HasColumnName("sizeid");
            });

            modelBuilder.Entity<SalesinfoDetails>(entity =>
            {
                entity.HasKey(e => e.Sinfoid);

                entity.ToTable("salesinfo_details");

                entity.HasIndex(e => e.InfoId)
                    .HasName("pk_sid_infoid");

                entity.Property(e => e.Sinfoid).HasColumnName("sinfoid");

                entity.Property(e => e.Billing)
                    .HasColumnName("billing")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Delivery)
                    .HasColumnName("delivery")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InfoId).HasColumnName("infoID");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SaleslogDetails>(entity =>
            {
                entity.HasKey(e => e.Slogind);

                entity.ToTable("saleslog_details");

                entity.Property(e => e.Slogind).HasColumnName("slogind");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasColumnName("info")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Infoid).HasColumnName("infoid");

                entity.Property(e => e.Siteid).HasColumnName("siteid");
            });

            modelBuilder.Entity<SalesMaster>(entity =>
            {
                entity.HasKey(e => e.Infoid);

                entity.ToTable("sales_master");

                entity.HasIndex(e => e.Entrydate)
                    .HasName("pk_sm_entrydate");

                entity.HasIndex(e => e.Orderid)
                    .HasName("pk_orderid");

                entity.HasIndex(e => e.Sitecode)
                    .HasName("pk_sitecode");

                entity.HasIndex(e => e.Siteid)
                    .HasName("pk_sm_siteid");

                entity.Property(e => e.Infoid).HasColumnName("infoid");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Curcode)
                    .HasColumnName("curcode")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('GBP')");

                entity.Property(e => e.Custid)
                    .HasColumnName("custid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Deltype)
                    .HasColumnName("deltype")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Discountcode)
                    .HasColumnName("discountcode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Donation)
                    .HasColumnName("donation")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Info)
                    .HasColumnName("info")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Isprint)
                    .HasColumnName("isprint")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Isremoved)
                    .HasColumnName("isremoved")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Istele).HasColumnName("istele");

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Paypalid)
                    .HasColumnName("paypalid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Paytype)
                    .HasColumnName("paytype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("pcode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Postage)
                    .HasColumnName("postage")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Postageid).HasColumnName("postageid");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Sitecode)
                    .HasColumnName("sitecode")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Siteid).HasColumnName("siteid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Vat)
                    .HasColumnName("vat")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SearchResults>(entity =>
            {
                entity.HasKey(e => e.Srid);

                entity.ToTable("search_results");

                entity.Property(e => e.Srid).HasColumnName("srid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Srank).HasColumnName("srank");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<SeoDetails>(entity =>
            {
                entity.HasKey(e => e.Seoid);

                entity.ToTable("seo_details");

                entity.HasIndex(e => e.Catcode)
                    .HasName("pk_sd_catcode");

                entity.HasIndex(e => e.Siteid)
                    .HasName("pk_sd_siteid");

                entity.Property(e => e.Seoid).HasColumnName("seoid");

                entity.Property(e => e.Breadcrumb)
                    .HasColumnName("breadcrumb")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Catcode)
                    .HasColumnName("catcode")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Description2)
                    .HasColumnName("description2")
                    .HasColumnType("text");

                entity.Property(e => e.Header)
                    .HasColumnName("header")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Header2)
                    .HasColumnName("header2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Islive)
                    .HasColumnName("islive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Metadesc)
                    .HasColumnName("metadesc")
                    .HasColumnType("text");

                entity.Property(e => e.Metakeys)
                    .HasColumnName("metakeys")
                    .HasColumnType("text");

                entity.Property(e => e.Siteid).HasColumnName("siteid");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SiteMaster>(entity =>
            {
                entity.HasKey(e => e.Siteid);

                entity.ToTable("site_master");

                entity.Property(e => e.Siteid).HasColumnName("siteid");

                entity.Property(e => e.Add1)
                    .HasColumnName("add1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Add2)
                    .HasColumnName("add2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dbname)
                    .HasColumnName("dbname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Imgfolder)
                    .HasColumnName("imgfolder")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isonline)
                    .HasColumnName("isonline")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Maintitle)
                    .HasColumnName("maintitle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Metadesc)
                    .HasColumnName("metadesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Metakeys)
                    .HasColumnName("metakeys")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.Paypalemail)
                    .HasColumnName("paypalemail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Priceid)
                    .HasColumnName("priceid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Realcode)
                    .HasColumnName("realcode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Realmoto)
                    .HasColumnName("realmoto")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Servername)
                    .HasColumnName("servername")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sitecode)
                    .HasColumnName("sitecode")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Sitedescription)
                    .HasColumnName("sitedescription")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Sitename)
                    .HasColumnName("sitename")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ssite)
                    .HasColumnName("ssite")
                    .HasMaxLength(15);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SizeMaster>(entity =>
            {
                entity.HasKey(e => e.Specid);

                entity.ToTable("size_master");

                entity.Property(e => e.Specid).HasColumnName("specid");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Longname)
                    .HasColumnName("longname")
                    .HasMaxLength(154)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sname)
                    .HasColumnName("sname")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<StatsMaster>(entity =>
            {
                entity.HasKey(e => e.Statid);

                entity.ToTable("stats_master");

                entity.Property(e => e.Statid).HasColumnName("statid");

                entity.Property(e => e.Rfrom)
                    .HasColumnName("rfrom")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rorder)
                    .HasColumnName("rorder")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rtype)
                    .HasColumnName("rtype")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Statname)
                    .HasColumnName("statname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Usp)
                    .HasColumnName("usp")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockDetails>(entity =>
            {
                entity.HasKey(e => e.Stockid);

                entity.ToTable("stock_details");

                entity.Property(e => e.Stockid).HasColumnName("stockid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<StockProds>(entity =>
            {
                entity.HasKey(e => e.Stockid);

                entity.ToTable("stock_prods");

                entity.HasIndex(e => e.Prodid)
                    .HasName("pk_prodid");

                entity.Property(e => e.Stockid).HasColumnName("stockid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locked)
                    .HasColumnName("locked")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Store)
                    .HasColumnName("store")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Trade)
                    .HasColumnName("trade")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Val)
                    .HasColumnName("val")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<StocktakeCats>(entity =>
            {
                entity.HasKey(e => e.Catid);

                entity.ToTable("stocktake_cats");

                entity.Property(e => e.Catid)
                    .HasColumnName("catid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Done).HasColumnName("done");

                entity.Property(e => e.Lastaction)
                    .HasColumnName("lastaction")
                    .HasColumnType("datetime");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StocktakeDetails>(entity =>
            {
                entity.HasKey(e => e.Rptid);

                entity.ToTable("stocktake_details");

                entity.Property(e => e.Rptid).HasColumnName("rptid");

                entity.Property(e => e.Catcode).HasColumnName("catcode");

                entity.Property(e => e.Empid).HasColumnName("empid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ncode).HasColumnName("ncode");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Qtylast).HasColumnName("qtylast");

                entity.Property(e => e.Val)
                    .HasColumnName("val")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vallast).HasColumnName("vallast");
            });

            modelBuilder.Entity<SupplierMaster>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.ToTable("supplier_master");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cpaid)
                    .HasColumnName("cpaid")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mdetails)
                    .HasColumnName("mdetails")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Multiplier)
                    .HasColumnName("multiplier")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Oldname)
                    .HasColumnName("oldname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pass)
                    .HasColumnName("pass")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Scontact)
                    .HasColumnName("scontact")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sfax)
                    .HasColumnName("sfax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasColumnName("site")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sphone)
                    .HasColumnName("sphone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SupplyprodDetails>(entity =>
            {
                entity.HasKey(e => e.Spid);

                entity.ToTable("supplyprod_details");

                entity.HasIndex(e => e.Barcode)
                    .HasName("pk_barcode");

                entity.HasIndex(e => e.Cost)
                    .HasName("pk_cost");

                entity.HasIndex(e => e.Isbest)
                    .HasName("pk_isbest");

                entity.HasIndex(e => e.Prodcode)
                    .HasName("sk_prodcode");

                entity.HasIndex(e => e.Prodid)
                    .HasName("sk_prodid");

                entity.Property(e => e.Spid)
                    .HasColumnName("spid")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Barcode)
                    .HasColumnName("barcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isbarcode)
                    .HasColumnName("isbarcode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Isbest)
                    .HasColumnName("isbest")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ischange)
                    .HasColumnName("ischange")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Isdead)
                    .HasColumnName("isdead")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Issue)
                    .HasColumnName("issue")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Minorder)
                    .HasColumnName("minorder")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text");

                entity.Property(e => e.Pagenr)
                    .HasColumnName("pagenr")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Prodcode)
                    .HasColumnName("prodcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Rawcost)
                    .HasColumnName("rawcost")
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Roid)
                    .HasColumnName("roid")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Sp)
                    .WithOne(p => p.InverseSp)
                    .HasForeignKey<SupplyprodDetails>(d => d.Spid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_supplyprod_details_supplyprod_details");
            });

            modelBuilder.Entity<TermsDetails>(entity =>
            {
                entity.HasKey(e => e.Termid);

                entity.ToTable("terms_details");

                entity.Property(e => e.Termid).HasColumnName("termid");

                entity.Property(e => e.Deliveries)
                    .HasColumnName("deliveries")
                    .HasColumnType("text");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("text");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nondelivery)
                    .HasColumnName("nondelivery")
                    .HasColumnType("text");

                entity.Property(e => e.Payment)
                    .HasColumnName("payment")
                    .HasColumnType("text");

                entity.Property(e => e.Pricing)
                    .HasColumnName("pricing")
                    .HasColumnType("text");

                entity.Property(e => e.Privacy)
                    .HasColumnName("privacy")
                    .HasColumnType("text");

                entity.Property(e => e.Products)
                    .HasColumnName("products")
                    .HasColumnType("text");

                entity.Property(e => e.Returntxt)
                    .HasColumnName("returntxt")
                    .HasColumnType("text");

                entity.Property(e => e.Siteid).HasColumnName("siteid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TermsMaster>(entity =>
            {
                entity.HasKey(e => e.Termid);

                entity.ToTable("terms_master");

                entity.Property(e => e.Termid).HasColumnName("termid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Returnpol)
                    .HasColumnName("returnpol")
                    .HasColumnType("text");

                entity.Property(e => e.Siteid).HasColumnName("siteid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Termsbot)
                    .HasColumnName("termsbot")
                    .HasColumnType("text");

                entity.Property(e => e.Termstop)
                    .HasColumnName("termstop")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TierMaster>(entity =>
            {
                entity.HasKey(e => e.Tierid);

                entity.ToTable("tier_master");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tier)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TypeMaster>(entity =>
            {
                entity.HasKey(e => e.Itid);

                entity.ToTable("type_master");

                entity.Property(e => e.Itid).HasColumnName("itid");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Itcode)
                    .HasColumnName("itcode")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ittype)
                    .HasColumnName("ittype")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<UrlDetails>(entity =>
            {
                entity.HasKey(e => e.Urlid);

                entity.ToTable("url_details");

                entity.HasIndex(e => e.Catcode)
                    .HasName("pk_url_codes");

                entity.HasIndex(e => e.Url)
                    .HasName("pk_url");

                entity.Property(e => e.Urlid).HasColumnName("urlid");

                entity.Property(e => e.Catcode).HasColumnName("catcode");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lvl).HasColumnName("lvl");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserMaster>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("user_master");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Ecode).HasColumnName("ecode");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Epass)
                    .HasColumnName("epass")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lastonline)
                    .HasColumnName("lastonline")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pricesite)
                    .HasColumnName("pricesite")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Roleid)
                    .HasColumnName("roleid")
                    .HasDefaultValueSql("((6))");

                entity.Property(e => e.Sessid)
                    .HasColumnName("sessid")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Userpass)
                    .HasColumnName("userpass")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserSession>(entity =>
            {
                entity.HasKey(e => e.Sessionid);

                entity.ToTable("user_session");

                entity.Property(e => e.Sessionid).HasColumnName("sessionid");

                entity.Property(e => e.Iscompleted)
                    .HasColumnName("iscompleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Logindate)
                    .HasColumnName("logindate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Logoutdate)
                    .HasColumnName("logoutdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sessiond)
                    .HasColumnName("sessiond")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<VerificationDetails>(entity =>
            {
                entity.HasKey(e => e.Verid);

                entity.ToTable("verification_details");

                entity.Property(e => e.Verid).HasColumnName("verid");

                entity.Property(e => e.Chk)
                    .HasColumnName("chk")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Custid).HasColumnName("custid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<VoucherDetails>(entity =>
            {
                entity.HasKey(e => e.Gvid);

                entity.ToTable("voucher_details");

                entity.Property(e => e.Gvid).HasColumnName("gvid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Redemed)
                    .HasColumnName("redemed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Terminal)
                    .HasColumnName("terminal")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Transactionid).HasColumnName("transactionid");

                entity.Property(e => e.Vamt)
                    .HasColumnName("vamt")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Vcode)
                    .HasColumnName("vcode")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VoucherSession>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.ToTable("voucher_session");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sessionid)
                    .HasColumnName("sessionid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Voucher)
                    .HasColumnName("voucher")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
