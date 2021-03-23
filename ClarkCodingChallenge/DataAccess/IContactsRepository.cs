using System.Collections.Generic;
using System.Threading.Tasks;
using ClarkCodingChallenge.Entities;

namespace ClarkCodingChallenge.DataAccess
{
    public interface IContactsRepository
    {
        void AddContact(Contact contact);

        Contact GetContactByEmail(string email);
        IEnumerable<Contact> GetMailingListEntries(string lastName, string sortOrder);
    }
}
