using FlatRockTech_DataAccess.Data;
using FlatRockTech_Models.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FlatRockTech.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<User> userList = _db.Users.ToList();
            return View(userList);
        }

        public IActionResult Upsert(int? id)
        {
            User  obj = new User();
            if (id == null)
                return View(obj);

            obj = _db.Users.FirstOrDefault(u => u.User_Id == id);
            if (obj == null)
                return NotFound();

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(User obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.User_Id == 0)
                {
                    //this is create
                    _db.Users.Add(obj);
                }
                else
                {
                    //this is an update
                    _db.Users.Update(obj);
                }
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }

        public IActionResult Delete(int id)
        {
            var objFormDb = _db.Users.FirstOrDefault(u => u.User_Id == id);
            _db.Users.Remove(objFormDb);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
