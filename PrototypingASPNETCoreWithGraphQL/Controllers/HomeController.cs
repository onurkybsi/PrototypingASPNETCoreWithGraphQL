using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrototypingASPNETCoreWithGraphQL.Models;

namespace PrototypingASPNETCoreWithGraphQL.Controllers
{
    public class HomeController : Controller
    {
        private IPersonRepository repository;

        public HomeController(IPersonRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            return View(repository.Persons);
        }
    }
}