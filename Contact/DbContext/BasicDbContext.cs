namespace ContactMVC.Repository
{
    using Entities;
    using System.Data.Entity;
    using System.Diagnostics;

    /// <summary>
    /// The fit cloud commissions context.
    /// </summary>
    public partial class BasicDbContext : DbContext
    {
        /// <summary>
        /// Initializes static members of the <see cref="BasicDbContext"/> class.
        /// </summary>
        static BasicDbContext()
        {
            Database.SetInitializer<BasicDbContext>(null);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicDbContext"/> class.
        /// </summary>
        public BasicDbContext()
            : base("Name=BasicConnectionString")
        {
            this.Database.CommandTimeout = 180;
            this.Database.Log = sql => Debug.Write(sql);
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }

        /// <summary>
        /// The on model creating.
        /// </summary>
        /// <param name="modelBuilder">The model builder.</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //one-to-many 
            modelBuilder.Entity<Address>()
                        .HasRequired<Contact>(c => c.Contact) // Student entity requires Standard 
                        .WithMany(a => a.Addresses); // Standard entity includes many Students entities
        }
    }
}
