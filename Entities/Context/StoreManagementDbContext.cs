using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Entities.Context
{
    public partial class StoreManagementDbContext : DbContext
    {
        public StoreManagementDbContext()
        {
        }

        public StoreManagementDbContext(DbContextOptions<StoreManagementDbContext> options)
            : base(options)
        {
            //Database.Migrate();
        }

        public virtual DbSet<ActionStatus> ActionStatuses { get; set; }
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<AssetAction> AssetActions { get; set; }
        public virtual DbSet<AssetBarcode> AssetBarcodes { get; set; }
        public virtual DbSet<AssetCustomer> AssetCustomers { get; set; }
        public virtual DbSet<AssetPersonnel> AssetPersonnel { get; set; }
        public virtual DbSet<AssetStatus> AssetStatuses { get; set; }
        public virtual DbSet<AssetType> AssetTypes { get; set; }
        public virtual DbSet<AssetWithoutBarcode> AssetWithoutBarcodes { get; set; }
        public virtual DbSet<Claims> Claims { get; set; }
        public virtual DbSet<CommType> CommTypes { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Communication> Communications { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<LoginInfo> LoginInfos { get; set; }
        public virtual DbSet<MasterDetail> MasterDetails { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<PageClaim> PageClaims { get; set; }
        public virtual DbSet<Personnel> Personnel { get; set; }
        public virtual DbSet<PersonnelLoginInfo> PersonnelLoginInfos { get; set; }
        public virtual DbSet<PersonnelTeam> PersonnelTeams { get; set; }
        public virtual DbSet<PersonnelTypeId> PersonnelTypeIds { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RolePersonnel> RolePersonnel { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=StoreManagementDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ActionStatus>(entity =>
            {
                entity.ToTable("ActionStatus");

                entity.Property(e => e.ActionStatusId).HasColumnName("ActionStatusID");

                entity.Property(e => e.AssetActionId).HasColumnName("AssetActionID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.AssetAction)
                    .WithMany(p => p.ActionStatuses)
                    .HasForeignKey(d => d.AssetActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionStatus_Action");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ActionStatuses)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionStatus_Status");
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.ToTable("Asset");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.EntryDate).HasColumnType("date");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.MasterDetailId).HasColumnName("MasterDetailID");

                entity.Property(e => e.PriceId).HasColumnName("PriceID");

                entity.Property(e => e.RetireDate).HasColumnType("date");

                entity.HasOne(d => d.AssetType)
                    .WithMany(p => p.Assets)
                    .HasForeignKey(d => d.AssetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Asset_Type");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Assets)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Asset_Group");

                entity.HasOne(d => d.MasterDetail)
                    .WithMany(p => p.Assets)
                    .HasForeignKey(d => d.MasterDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Asset_MasterDetail");
            });

            modelBuilder.Entity<AssetAction>(entity =>
            {
                entity.ToTable("AssetAction");

                entity.Property(e => e.AssetActionId).HasColumnName("AssetActionID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<AssetBarcode>(entity =>
            {
                entity.ToTable("AssetBarcode");

                entity.Property(e => e.AssetBarcodeId).HasColumnName("AssetBarcodeID");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetBarcodes)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssetBarcode_Asset");
            });

            modelBuilder.Entity<AssetCustomer>(entity =>
            {
                entity.ToTable("AssetCustomer");

                entity.Property(e => e.AssetCustomerId).HasColumnName("AssetCustomerID");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetCustomers)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssetCustomer_Asset");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.AssetCustomers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssetCustomer_Customer");
            });

            modelBuilder.Entity<AssetPersonnel>(entity =>
            {
                entity.HasKey(e => e.AssetOwnerId)
                    .HasName("PK_AssetOwner");

                entity.Property(e => e.AssetOwnerId).HasColumnName("AssetOwnerID");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.PersonnelId).HasColumnName("PersonnelID");

                entity.Property(e => e.PersonnelTypeId).HasColumnName("PersonnelTypeID");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetPersonnel)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssetOwner_Asset");

                entity.HasOne(d => d.Personnel)
                    .WithMany(p => p.AssetPersonnel)
                    .HasForeignKey(d => d.PersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssetOwner_Personnel");

                entity.HasOne(d => d.PersonnelType)
                    .WithMany(p => p.AssetPersonnel)
                    .HasForeignKey(d => d.PersonnelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssetOwner_OwnerType");
            });

            modelBuilder.Entity<AssetStatus>(entity =>
            {
                entity.ToTable("AssetStatus");

                entity.Property(e => e.AssetStatusId).HasColumnName("AssetStatusID");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.PersonnelId).HasColumnName("PersonnelID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetStatuses)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssetStatus_Asset");

                entity.HasOne(d => d.Personnel)
                    .WithMany(p => p.AssetStatuses)
                    .HasForeignKey(d => d.PersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssetStatus_Personnel");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.AssetStatuses)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssetStatus_Status");
            });

            modelBuilder.Entity<AssetType>(entity =>
            {
                entity.ToTable("AssetType");

                entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<AssetWithoutBarcode>(entity =>
            {
                entity.ToTable("AssetWithoutBarcode");

                entity.Property(e => e.AssetWithoutBarcodeId).HasColumnName("AssetWithoutBarcodeID");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetWithoutBarcodes)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssetWithoutBarcode_Asset");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.AssetWithoutBarcodes)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssetWithoutBarcode_Unit");
            });

            modelBuilder.Entity<Claims>(entity =>
            {
                entity.ToTable("Claim");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<CommType>(entity =>
            {
                entity.ToTable("CommType");

                entity.Property(e => e.CommTypeId).HasColumnName("CommTypeID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.PersonnelId).HasColumnName("PersonnelID");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Asset");

                entity.HasOne(d => d.Personnel)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.PersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Personnel");
            });

            modelBuilder.Entity<Communication>(entity =>
            {
                entity.ToTable("Communication");

                entity.Property(e => e.CommunicationId).HasColumnName("CommunicationID");

                entity.Property(e => e.CommTypeId).HasColumnName("CommTypeID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.PersonnelId).HasColumnName("PersonnelID");

                entity.HasOne(d => d.CommType)
                    .WithMany(p => p.Communications)
                    .HasForeignKey(d => d.CommTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Communication_CommType");

                entity.HasOne(d => d.Personnel)
                    .WithMany(p => p.Communications)
                    .HasForeignKey(d => d.PersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Communication_Personnel");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("Document");

                entity.Property(e => e.DocumentId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DocumentID");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");

                entity.HasOne(d => d.DocumentNavigation)
                    .WithOne(p => p.Document)
                    .HasForeignKey<Document>(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Document_Asset");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("Group");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<LoginInfo>(entity =>
            {
                entity.ToTable("LoginInfo");

                entity.Property(e => e.LoginInfoId).HasColumnName("LoginInfoID");

                entity.Property(e => e.PasswordHash).IsRequired();

                entity.Property(e => e.PasswordSalt).IsRequired();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<MasterDetail>(entity =>
            {
                entity.ToTable("MasterDetail");

                entity.Property(e => e.MasterDetailId).HasColumnName("MasterDetailID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.MasterId).HasColumnName("MasterID");
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.ToTable("Page");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<PageClaim>(entity =>
            {
                entity.ToTable("PageClaim");

                entity.Property(e => e.PageClaimId).HasColumnName("PageClaimID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.PageClaims)
                    .HasForeignKey(d => d.ClaimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PageClaim_Claim");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.PageClaims)
                    .HasForeignKey(d => d.PageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PageClaim_Page");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.PageClaims)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PageClaim_Role");
            });

            modelBuilder.Entity<Personnel>(entity =>
            {
                entity.Property(e => e.PersonnelId).HasColumnName("PersonnelID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.MasterId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MasterID")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Personnel)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personnel_Company");
            });

            modelBuilder.Entity<PersonnelLoginInfo>(entity =>
            {
                entity.ToTable("PersonnelLoginInfo");

                entity.Property(e => e.PersonnelLoginInfoId).HasColumnName("PersonnelLoginInfoID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.LoginInfoId).HasColumnName("LoginInfoID");

                entity.Property(e => e.PersonnelId).HasColumnName("PersonnelID");

                entity.HasOne(d => d.LoginInfo)
                    .WithMany(p => p.PersonnelLoginInfos)
                    .HasForeignKey(d => d.LoginInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonnelLoginInfo_LoginInfo");

                entity.HasOne(d => d.Personnel)
                    .WithMany(p => p.PersonnelLoginInfos)
                    .HasForeignKey(d => d.PersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonnelLoginInfo_Personnel");
            });

            modelBuilder.Entity<PersonnelTeam>(entity =>
            {
                entity.ToTable("PersonnelTeam");

                entity.Property(e => e.PersonnelTeamId).HasColumnName("PersonnelTeamID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.PersonnelId).HasColumnName("PersonnelID");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");
            });

            modelBuilder.Entity<PersonnelTypeId>(entity =>
            {
                entity.HasKey(e => e.PersonnelTypeId1)
                    .HasName("PK_OwnerType");

                entity.ToTable("PersonnelTypeID");

                entity.Property(e => e.PersonnelTypeId1).HasColumnName("PersonnelTypeID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.ToTable("Price");

                entity.Property(e => e.PriceId).HasColumnName("PriceID");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Price1)
                    .HasColumnType("money")
                    .HasColumnName("Price");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.Prices)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Price_Asset");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Prices)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Price_Currency");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<RolePersonnel>(entity =>
            {
                entity.HasKey(e => e.RolePersonelId);

                entity.Property(e => e.RolePersonelId).HasColumnName("RolePersonelID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.PersonnelId).HasColumnName("PersonnelID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Personnel)
                    .WithMany(p => p.RolePersonnel)
                    .HasForeignKey(d => d.PersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolePersonnel_Personnel");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePersonnel)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolePersonnel_Role");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.ToTable("Unit");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .UseCollation("Turkish_CI_AS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
