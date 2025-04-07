using DataAccess.Context;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class PollRepository : IPollRepository
    {
        private PollDbContext context;

        public PollRepository(PollDbContext _context)
        {
            this.context = _context;
        }

        public void CreatePoll(Poll poll)
        {
            this.context.Polls.Add(poll);
            this.context.SaveChanges();
        }
    }
}