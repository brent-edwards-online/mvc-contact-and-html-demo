namespace ContactMVC.ViewModel
{
    using ContactMVC.Entities;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    public class ContactsViewModel
    {
        public IEnumerable<string> qualifications;
        public Contact contact;
        public IEnumerable<SelectListItem> Qualifications
        {
            get
            {
                var allFlavors = qualifications.Select(qualification => new SelectListItem
                {
                    Value = qualification,
                    Text = qualification
                });
                return allFlavors;

            }
        }
    }
}