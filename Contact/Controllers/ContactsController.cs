namespace ContactMVC.Controllers
{
    using ContactMVC.Entities;
    using ContactMVC.Services;
    using ContactMVC.ViewModel;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Net;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    public class ContactsController : Controller
    {
        private IContactService _contactService;
        private IEnumerable<string> _qualifications;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
            _qualifications = _contactService.GetQualifications();
        }

        // GET: Contacts
        public async Task<ActionResult> Index()
        {
            return View(await _contactService.GetAllContactsAsync());
        }

        // GET: Contacts/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = await _contactService.GetContactByIdAsync(id.Value);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // GET: Contacts/Create
        public ActionResult Create()
        {
            ContactsViewModel model = new ContactsViewModel();
            model.contact = new Contact();
            model.qualifications = _qualifications;
            return View(model);
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ContactId,FirstName,LastName,Email,Password,Gender,DOB,Phone,HighestQualification")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                await _contactService.CreateContactAsync(contact);
                return RedirectToAction("Index");
            }

            ContactsViewModel model = new ContactsViewModel();
            model.contact = contact;
            model.qualifications = _qualifications;
            return View(model);
        }
        
        
        // GET: Contacts/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = await _contactService.GetContactByIdAsync(id.Value);
            if (contact == null)
            {
                return HttpNotFound();
            }

            ContactsViewModel model = new ContactsViewModel();
            model.contact = contact;
            model.qualifications = _qualifications;
            return View(model);
        }

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ContactId,FirstName,LastName,Email,Password,Gender,DOB,Phone,HighestQualification")] Contact contact)
        {
            if (ModelState.IsValid)
            {                
                await _contactService.UpdateContactAsync(contact);
                return RedirectToAction("Index");
            }
            ContactsViewModel model = new ContactsViewModel();
            model.contact = contact;
            model.qualifications = _qualifications;
            return View(model);
        }

        // GET: Contacts/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = await _contactService.GetContactByIdAsync(id.Value);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Contact contact = await _contactService.GetContactByIdAsync(id);
            await _contactService.DeleteContactAsync(contact);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
