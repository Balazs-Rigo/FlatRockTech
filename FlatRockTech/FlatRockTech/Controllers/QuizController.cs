using FlatRockTech_DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FlatRockTech.Controllers
{
    public class QuizController : Controller
    {
        private ApplicationDbContext _db;

        public QuizController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var obj = _db.Questions.Include(u=>u.Answers).ToList();
            Random rand = new Random();
            int randomNumber = rand.Next(0,obj.Count);

            return View(obj[randomNumber]);
        }
    }
}
