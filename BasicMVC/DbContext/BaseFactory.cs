namespace BasicMVC.Repository
{
    /// <summary>
    /// The base factory.
    /// </summary>
    public class BaseFactory
    {
        /// <summary>
        /// The context.
        /// </summary>
        private BasicDbContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseFactory"/> class.
        /// </summary>
        /// <param name="databaseFactory">The database factory.</param>
        public BaseFactory(IDatabaseFactory databaseFactory)
        {
            this.DatabaseFactory = databaseFactory;
        }

        /// <summary>
        /// Gets database factory.
        /// </summary>
        protected IDatabaseFactory DatabaseFactory { get; private set; }

        /// <summary>
        /// Gets the data context.
        /// </summary>
        protected BasicDbContext DataContext
        {
            get { return this.context ?? (this.context = this.DatabaseFactory.Get()); }
        }
    }
}
