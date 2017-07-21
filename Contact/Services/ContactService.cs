namespace ContactMVC.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ContactMVC.Entities;
    using ContactMVC.Repository;
    using System.Threading.Tasks;

    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ContactService(IContactRepository contactRepository, IUnitOfWork unitOfWork)
        {
            _contactRepository = contactRepository;
            _unitOfWork = unitOfWork;
        }

        public Task<ICollection<Contact>> GetAllContactsAsync()
        {
            return _contactRepository.GetAllAsync();
        }

        public Task<Contact> GetContactByIdAsync(int id)
        {
            return _contactRepository.GetByIdAsync(id);
        }

        public Task DeleteContactAsync(Contact contact)
        {
            _contactRepository.Delete(contact);
            return _unitOfWork.SaveChangesAsync();
        }

        public Task UpdateContactAsync(Contact contact)
        {
            _contactRepository.Update(contact);
            return _unitOfWork.SaveChangesAsync();
        }

        public Task CreateContactAsync(Contact contact)
        {
            _contactRepository.Insert(contact);
            return _unitOfWork.SaveChangesAsync();
        }
    }
}
