using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RPG.Models;

namespace RPG.Controllers
{
    public class PlayerController : Controller
    {
        private RPGDbContext _db = new RPGDbContext();

        public PlayerController(RPGDbContext db)
        {
            _db = db;
        }

        public PlayerController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Player player)
        {
            _db.Players.Add(player);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
