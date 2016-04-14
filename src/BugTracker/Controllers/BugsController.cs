using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using BugTracker.Services;
using BugTracker.Services.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BugTracker.Controllers
{
    [Route("api/[controller]")]
    public class BugsController : Controller
    {
        private BugService _bugServ;
        public BugsController(BugService bugServ)
        {
            _bugServ = bugServ;

        }

        // GET: api/values
        [HttpGet]
        public ICollection<BugDTO> GetAllBugs()
        {
            return _bugServ.GetBugList().ToList();
        }

        
    }
}
