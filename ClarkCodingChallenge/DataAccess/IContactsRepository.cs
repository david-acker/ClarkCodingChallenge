using System.Collections.Generic;
using System.Threading.Tasks;
using ClarkCodingChallenge.Entities;

namespace ClarkCodingChallenge.DataAccess
{
    public interface IContactsRepository
    {
        IEnumerable<Contact> GetMailingListEntries(string lastName, string sortOrder);
    }
}
