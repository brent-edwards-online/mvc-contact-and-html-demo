using System;

namespace ContactMVC.Repository
{
    using Entities;
    using System.Collections.Generic;
    using System.Linq;

    public class ContactRepository : GenericRepository<Contact>, IContactRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompetitionEntryRepository"/> class.
        /// </summary>
        /// <param name="factory">The factory.</param>
        public ContactRepository(IDatabaseFactory factory)
            : base(factory)
        {
        }

    }
}
