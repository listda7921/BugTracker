using BugTracker.Infrastructure;
using BugTracker.Models;
using BugTracker.Services.Models;
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
        public ICollection<BugDTO> GetBugList()
        {
            return (from b in _bugRepo.List()
                    select new BugDTO()
                    {
                        Title = b.Title,
                        Description = b.Description,
                        Date = b.Date,
                        IsResolved = b.IsResolved,
                        Severity = b.Severity
                    }).ToList();
        }

        public void AddBug(BugDTO bugDTO)
        {
            Bug bug = new Bug
            {
                Title = bugDTO.Title,
                Description = bugDTO.Description,
                Date = DateTime.Now,
                IsResolved = bugDTO.IsResolved,
                Severity = bugDTO.Severity
            };
            _bugRepo.Add(bug);
            _bugRepo.SaveChanges();
        }
    }
}
