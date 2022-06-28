using FlatRockTech_DataAccess.Data;
using FlatRockTech_Models.Models;
using FlatRockTech_Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace FlatRockTech.Controllers
{
    public class QuestionController : Controller
    {
        private readonly ApplicationDbContext _db;

        public QuestionController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Question> questions = _db.Questions.ToList();
            return View(questions);
        }

        public IActionResult Delete(int id)
        {
            var question = _db.Questions.FirstOrDefault(u => u.Question_Id == id);
            _db.Questions.Remove(question);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Upsert(int? id)
        {
            QuestionVM obj = new QuestionVM();
            obj.AnswerTypeList = _db.AnswerTypes.Select(i => new SelectListItem
            {
                Text = i.AnswerTypeChoice.ToString(),
                Value = i.AnswerType_Id.ToString()
            });

            if (id == null)
                return View(obj);

            return View(obj);
            //obj = _db.Questions.FirstOrDefault(u => u.Question_Id == id);
            //if (obj == null)
            //    return NotFound();

            //return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(QuestionVM obj)
        {
            //if (ModelState.IsValid)
            //{
            //    if (obj.Question_Id == 0)
            //    {
            //        //this is create
            //        _db.Questions.Add(obj);
            //    }
            //    else
            //    {
            //        //this is an update
            //        _db.Questions.Update(obj);
            //    }
            //    _db.SaveChanges();
            //    return RedirectToAction(nameof(Index));
            //}
            return View(obj);
        }
    }
}
