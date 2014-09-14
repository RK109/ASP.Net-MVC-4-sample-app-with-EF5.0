using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Titles.Models;
using Titles.Common;
using Titles.BusinessLayer;
using Titles.Models;

namespace Titles.Controllers
{
    public class TitlesController : Controller
    {
        IRepository repository;

        public TitlesController()
        {
            repository = new Repository();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TitlesModel titleMode)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Titles = repository.GetTitlesByName(titleMode.TitleName);
            }

            return View("Index");
        }

        
        [HttpGet]
        public ActionResult GetTitleDetails(int titleId)
        {
            var result = repository.GetTitleDetails(titleId);

            return PartialView("GetTitleDetails", result);
        }


        [HttpGet]
        public ActionResult Search(SearchOption searchOption, string searchText)
        {
            switch ((int)searchOption)
            {
                case 0:
                    // search by Title Name
                    return RedirectToAction("/GetTitlesByName", new { titleName = searchText });
                    break;
                case 1:
                    // search by Genre
                    return RedirectToAction("/GetTitlesByGenre", new { genre = searchText });
                    break;
                case 2:
                    // search by Language
                    return RedirectToAction("/GetTitlesByLanguage", new { language = searchText });
                    break;
                case 3:
                    // search by Participant
                    return RedirectToAction("/GetTitlesByParticipant", new { participant = searchText });
                    break;
                default:
                    // All
                    return RedirectToAction("/GetAllTitles/");
                    break;
            }
        }

        [HttpGet]
        public ActionResult GetTitlesByName(string titleName)
        {
            if (!string.IsNullOrWhiteSpace(titleName)) {
                @ViewBag.Titles = new Repository().GetTitlesByName(titleName);
            }

            return View();
        }

        [HttpGet]
        public ActionResult GetTitlesByGenre(string genre)
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }


        [HttpGet]
        public ActionResult GetTitlesByLanguage(string language)
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [HttpGet]
        public ActionResult GetTitlesByParticipant(string participant)
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult GetAllTitles()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        //[HttpGet]
        //public ActionResult GetTitleDetails(int titleId)
        //{
        //    ViewBag.Message = "Your app description page.";

        //    return View();
        //}

    }
}
