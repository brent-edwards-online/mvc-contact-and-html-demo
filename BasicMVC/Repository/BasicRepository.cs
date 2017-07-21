using System;

namespace BasicMVC.Repository
{
    using Entities;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicRepository : GenericRepository<BasicEntity>, IBasicRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompetitionEntryRepository"/> class.
        /// </summary>
        /// <param name="factory">The factory.</param>
        public BasicRepository(IDatabaseFactory factory)
            : base(factory)
        {
        }

    }
}
