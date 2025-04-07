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

        public IQueryable<Poll> GetPolls()
        {
            return this.context.Polls;
        }

        public void CreatePoll(Poll poll)
        {
            poll.CreatedAt = DateTime.Now;
            this.context.Polls.Add(poll);
            this.context.SaveChanges();
        }
    }
}