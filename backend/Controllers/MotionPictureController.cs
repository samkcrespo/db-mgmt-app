using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    public class MotionPictureController : Controller
    {
        // GET: MotionPictureController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MotionPictureController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MotionPictureController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MotionPictureController/Create
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

        // GET: MotionPictureController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MotionPictureController/Edit/5
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

        // GET: MotionPictureController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MotionPictureController/Delete/5
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
