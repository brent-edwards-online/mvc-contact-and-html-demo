namespace ContactMVC.Services
{
    using ContactMVC.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IContactService
    {
        Task<ICollection<Contact>> GetAllContactsAsync();

        Task<Contact> GetContactByIdAsync(int id);

        Task DeleteContactAsync(Contact contact);

        Task UpdateContactAsync(Contact contact);

        Task CreateContactAsync(Contact contact);
    }
}