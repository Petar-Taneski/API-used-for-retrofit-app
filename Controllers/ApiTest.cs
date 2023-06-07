using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace APITester.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class ApiTest : Controller
    {
        // GET: ApiTest
        [Route("[action]/")]
        [AllowAnonymous]
        public ActionResult Index()
        {
            var list = new List<string> { "foo", "bar" };

            var tags = new { tags = list };

            return Json(JsonConvert.SerializeObject(tags));
        }
        [Route("[action]/")]

        // GET: ApiTest/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApiTest/Create
        public ActionResult Create()
        {
            return View();
        }
        [Route("[action]/")]

        // POST: ApiTest/Create
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
        [Route("[action]/")]

        // GET: ApiTest/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApiTest/Edit/5
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
        [Route("[action]/")]

        // GET: ApiTest/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        [Route("[action]/")]

        // POST: ApiTest/Delete/5
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
