using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClarkCodingChallenge.Entities;

namespace ClarkCodingChallenge.DataAccess
{
    public class ContactsRepository : IContactsRepository
    {
        private readonly AppDbContext _context;
        
        public ContactsRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Contact> GetMailingListEntries(string lastName, string sortOrder)
        {
            var query = _context.Contacts as IQueryable<Contact>;

            if (!string.IsNullOrEmpty(lastName))
            {
                query = query.Where(x => x.LastName == lastName);
            }

            if (sortOrder == "desc")
            {
                query = query
                    .OrderByDescending(x => x.LastName)
                    .ThenByDescending(x => x.FirstName);
            }
            else
            {
                query = query
                    .OrderBy(x => x.LastName)
                    .ThenBy(x => x.FirstName);
            }

            return query.ToList();
        }
    }
}
