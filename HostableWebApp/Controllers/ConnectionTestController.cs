using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HostableBL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HostableWebApp.Controllers
{
    [Route("api/[controller]")]
    public class ConnectionTestController : Controller
    {
        public IConnectionTest repo;

        public ConnectionTestController(IConnectionTest repo)
        {
            this.repo = repo;
        }
        
        [HttpGet("[action]")]
        public IActionResult Get()
        {
            return Json(new { data = repo.GetNumber() });
        }

        [HttpGet("[action]")]
        public IActionResult GetDB()
        {
            var data = repo.Get();
            return Json(new { data = data });
        }
    }
}
