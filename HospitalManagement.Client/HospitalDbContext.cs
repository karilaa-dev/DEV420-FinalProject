using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Client
{
    internal class HospitalDbContext : DbContext
    {
        private readonly string connectionString;

        public HospitalDbContext()
            : this(AppConnections.GetSqlConnectionString())
        {
        }

        public HospitalDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<DoctorProfile> DoctorProfiles { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<InventoryTransaction> InventoryTransactions { get; set; }
        public DbSet<ChatConversation> ChatConversations { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<PatientVitals> PatientVitals { get; set; }
        public DbSet<SystemNotification> SystemNotifications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patients");
                entity.HasKey(e => e.PatientId);
                entity.Property(e => e.PatientId).ValueGeneratedOnAdd();
                entity.Property(e => e.PatientUserId).HasMaxLength(50);
                entity.Property(e => e.Name).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Gender).HasMaxLength(50);
                entity.Property(e => e.Phone).HasMaxLength(50);
                entity.Property(e => e.Notes).HasMaxLength(500);
                entity.HasIndex(e => e.PatientUserId)
                    .IsUnique()
                    .HasFilter("[PatientUserId] IS NOT NULL");
            });

            modelBuilder.Entity<DoctorProfile>(entity =>
            {
                entity.ToTable("DoctorProfiles");
                entity.HasKey(e => e.DoctorProfileId);
                entity.Property(e => e.DoctorProfileId).ValueGeneratedOnAdd();
                entity.Property(e => e.UserId).HasMaxLength(50).IsRequired();
                entity.Property(e => e.Username).HasMaxLength(100).IsRequired();
                entity.Property(e => e.DisplayName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("SYSDATETIME()");
                entity.Property(e => e.UpdatedAt).HasDefaultValueSql("SYSDATETIME()");
                entity.HasIndex(e => e.UserId).IsUnique();
                entity.HasIndex(e => e.Username).IsUnique();
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointments");
                entity.HasKey(e => e.AppointmentId);
                entity.Property(e => e.AppointmentId).ValueGeneratedOnAdd();
                entity.Property(e => e.VisitReason).HasMaxLength(200).IsRequired();
                entity.Property(e => e.AppointmentStatus).HasMaxLength(50).IsRequired();
                entity.Property(e => e.Notes).HasMaxLength(500);
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("SYSDATETIME()");
                entity.HasOne(e => e.Patient)
                    .WithMany(e => e.Appointments)
                    .HasForeignKey(e => e.PatientId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.DoctorProfile)
                    .WithMany(e => e.Appointments)
                    .HasForeignKey(e => e.DoctorProfileId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<InventoryItem>(entity =>
            {
                entity.ToTable("InventoryItems");
                entity.HasKey(e => e.InventoryItemId);
                entity.Property(e => e.InventoryItemId).ValueGeneratedOnAdd();
                entity.Property(e => e.ItemName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Category).HasMaxLength(100).IsRequired();
                entity.Property(e => e.StorageLocation).HasMaxLength(100);
                entity.Property(e => e.UpdatedAt).HasDefaultValueSql("SYSDATETIME()");
            });

            modelBuilder.Entity<InventoryTransaction>(entity =>
            {
                entity.ToTable("InventoryTransactions");
                entity.HasKey(e => e.InventoryTransactionId);
                entity.Property(e => e.InventoryTransactionId).ValueGeneratedOnAdd();
                entity.Property(e => e.ItemName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Category).HasMaxLength(100).IsRequired();
                entity.Property(e => e.TransactionReason).HasMaxLength(200);
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("SYSDATETIME()");
                entity.HasOne(e => e.InventoryItem)
                    .WithMany(e => e.InventoryTransactions)
                    .HasForeignKey(e => e.InventoryItemId)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<ChatConversation>(entity =>
            {
                entity.ToTable("ChatConversations");
                entity.HasKey(e => e.ChatConversationId);
                entity.Property(e => e.ChatConversationId).ValueGeneratedOnAdd();
                entity.Property(e => e.ConversationName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.ConversationType).HasMaxLength(50).IsRequired();
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("SYSDATETIME()");
                entity.HasIndex(e => e.ConversationName).IsUnique();
                entity.HasIndex(e => e.PatientId).IsUnique();
                entity.HasOne(e => e.Patient)
                    .WithOne(e => e.ChatConversation)
                    .HasForeignKey<ChatConversation>(e => e.PatientId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<ChatMessage>(entity =>
            {
                entity.ToTable("ChatMessages");
                entity.HasKey(e => e.ChatMessageId);
                entity.Property(e => e.ChatMessageId).ValueGeneratedOnAdd();
                entity.Property(e => e.SenderName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.SenderRole).HasMaxLength(100);
                entity.Property(e => e.MessageText).HasMaxLength(1000).IsRequired();
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("SYSDATETIME()");
                entity.HasOne(e => e.ChatConversation)
                    .WithMany(e => e.ChatMessages)
                    .HasForeignKey(e => e.ChatConversationId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<PatientVitals>(entity =>
            {
                entity.ToTable("PatientVitals");
                entity.HasKey(e => e.PatientVitalsId);
                entity.Property(e => e.PatientVitalsId).ValueGeneratedOnAdd();
                entity.Property(e => e.BloodPressure).HasMaxLength(50);
                entity.Property(e => e.Temperature).HasColumnType("decimal(5,1)");
                entity.Property(e => e.VitalsStatus).HasMaxLength(50).IsRequired();
                entity.Property(e => e.Notes).HasMaxLength(500);
                entity.Property(e => e.UpdatedAt).HasDefaultValueSql("SYSDATETIME()");
                entity.HasOne(e => e.Patient)
                    .WithMany(e => e.PatientVitals)
                    .HasForeignKey(e => e.PatientId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<SystemNotification>(entity =>
            {
                entity.ToTable("SystemNotifications");
                entity.HasKey(e => e.SystemNotificationId);
                entity.Property(e => e.SystemNotificationId).ValueGeneratedOnAdd();
                entity.Property(e => e.NotificationType).HasMaxLength(100).IsRequired();
                entity.Property(e => e.MessageText).HasMaxLength(500).IsRequired();
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("SYSDATETIME()");
            });
        }
    }
}
