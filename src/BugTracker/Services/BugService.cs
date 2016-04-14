using BugTracker.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Services
{
    public class BugService
    {
        private BugRepository _bugRepo;
        public BugService(BugRepository bugRepo) {
            _bugRepo = bugRepo;
        }
    }
}
