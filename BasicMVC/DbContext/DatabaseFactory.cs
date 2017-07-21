namespace BasicMVC.Repository
{
    using System;
    /// <summary>
    /// The database factory.
    /// </summary>
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        /// <summary>
        /// The data context.
        /// </summary>
        private BasicDbContext dataContext;

        /// <summary>
        /// The get.
        /// </summary>
        /// <returns>The <see cref="BasicDbContext"/>.</returns>
        public BasicDbContext Get()
        {
            return this.dataContext ?? (this.dataContext = new BasicDbContext());
        }

        /// <summary>
        /// The dispose core.
        /// </summary>
        protected override void DisposeCore()
        {
            if (this.dataContext != null)
            {
                this.dataContext.Dispose();
            }
        }
    }
}
