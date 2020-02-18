using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inhouse_Products.Data;
using Microsoft.AspNetCore.Mvc;

namespace Inhouse_Products.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}