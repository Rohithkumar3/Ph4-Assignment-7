using Assignment7.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment7.Controllers
{
    public class PlayerController : Controller
    {
        static List<Player> PlayerList = new List<Player>()
        {
           new Player() {PId=1,PName="Rohith",PCountry="India",PType="All-rounder"},
           new Player() {PId=2,PName="V.Kohili",PCountry="India",PType="Batsman"},
           new Player() {PId=3,PName="David",PCountry="Australia",PType="Wicketkeeper"}
        };
        public IActionResult Index()
        {
            return View(PlayerList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Player());
        }
        [HttpPost]
        public IActionResult Create(Player player)
        {
            if (ModelState.IsValid)
            {
                PlayerList.Add(player);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
