using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.WebPages;
using Versus.Models;
using Versus.Models.Data;
using Versus.ViewModels;

namespace Versus.Controllers
{
    public class HomeController : Controller
    {


        #region TODO Methods
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ScoresVM model = new ScoresVM
            {


                Choices = ScoresGenerate()
            };


            return View(model);
        }

        public ActionResult Test()
        {

            return View();
        }
        #endregion


        // POST: SaveScore
        [HttpPost]
        public ActionResult SaveScore(ScoresVM model)
        {

            // Sprawdzenia model state
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // zmniejszenie wyników meczu o jeden
            --model.Score1;
            --model.Score2;

            // Pobranie id użytkownika
            model.GameId = User.Identity.GetUserId();

            // Generowanie daty oddania głosu
            model.Betdate = DateTime.Now;
            

            using (Db db = new Db())
            {

                // Inicjalizacja PageDTO
                ScoresDTO dto = new ScoresDTO();

                ///////////////////
                #region TO USE VALIDATION
                //// gdy niemamy adresu strony to przypisujemy tytul
                //if (string.IsNullOrWhiteSpace(model.Slug))
                //{
                //    slug = model.Title.Replace(" ", "-").ToLower();
                //}
                //else
                //{
                //    slug = model.Slug.Replace(" ", "-").ToLower();
                //}

                //// zapobiegamy dodanie takiej samej nazwy strony
                //if (db.Pages.Any(x => x.Title == model.Title) || db.Pages.Any(x => x.Slug == slug))
                //{
                //    ModelState.AddModelError("", "Ten tytuł lub adres strony już istnieje.");
                //    return View(model);
                //}
                #endregion
                ///////////////////

                dto.Score1 = model.Score1;
                dto.Score2 = model.Score2;
                dto.GameId = model.GameId;
                dto.BetDate = model.Betdate;
                dto.UserId = model.UserId;

                // zapis DTO
                db.Scores.Add(dto);
                db.SaveChanges();
            }

            //utworzenie zmiennej sesyjnej

            Session["score"] = model.Score1.ToString() + " - " + model.Score2.ToString();

            return RedirectToAction("LoadScore");
        }

        // GET: LoadScore
        [HttpGet]
        public ActionResult LoadScore()
        {
            //pobranie danych z sesji

            string score = (string)Session["score"];

            TempData["SM"] = score;

            return View("Test");
        }

        // GET: ScoresGenerate
        [HttpGet]
        public IEnumerable<SelectListItem> ScoresGenerate()
        {


            List<SelectListItem> choices = new List<SelectListItem>
               {
                    new SelectListItem { Text="Wybierz wynik", Value="0"}
               };

            for (int i = 0; i < 51; i++)
            {
                choices.Add
                    (
                    new SelectListItem
                    {
                        Text = i.ToString(),
                        Value = (i + 1).ToString()
                    }
                    );
            }

            return new SelectList(choices, "Value", "Text");
        }

    }
}