using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StackwIdentity.Data;
using StackwIdentity.Models;

namespace StackwIdentity.Controllers
{
    public class QuestionController : Controller
    {
        private ApplicationDbContext _db { get; set; }

        public QuestionController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: QuestionController
        public ActionResult Index()
        {
            // list all questions based on the most recent

            var questions = _db.Question.Include(q => q.Answers)
                .Include(q => q.Votes)
                .Include(q => q.User)
                .Include(q => q.Tags)
                .ToList();

            return View(questions);
        }

        // GET: QuestionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuestionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult QuestionDetails(int id)
        {
            Question question = _db.Question
                .Include(q => q.Answers)
                .Include(q => q.Votes)
                .Include(q => q.User)
                .First(q => q.Id == id);

            List<Answer> answers = _db.Answers
                .Include(a => a.User)
                .Include(a => a.Votes)
                .Include(a => a.Comments)
                .Where(a => a.QuestionId == id).ToList();

            QuestionDetailsVM vm = new QuestionDetailsVM
            {
                Question = question,
                Answers = answers
            };

            return View(vm);
        }

        // GET: QuestionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuestionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuestionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
