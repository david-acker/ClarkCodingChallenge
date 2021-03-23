using System.Collections.Generic;
using System.Threading.Tasks;
using ClarkCodingChallenge.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClarkCodingChallenge.DataAccess
{
    public class MailingListEntryRepository
    {
        private readonly DbContext _context;

        public MailingListEntryRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<MailingListEntry>> GetMailingListEntries(string lastName, string sortOrder)
        {

        }
    }
}
