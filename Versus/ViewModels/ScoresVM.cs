using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Versus.Models.Data;

namespace Versus.ViewModels
{

    public class ScoresVM
    {
        public ScoresVM()
        {

        }

        public ScoresVM(ScoresDTO row)
        {
            Id = row.Id;
            Score1 = row.Score1;
            Score2 = row.Score2;
            GameId = row.GameId;
            Betdate = row.BetDate;
            UserId = row.UserId;
        }
        [Required]
        public int Id { get; set; }
        [Required]
        public int Score1 { get; set; }
        [Required]
        public int Score2 { get; set; }
        // [Required]
        public string GameId { get; set; }
        // [Required]
        public DateTime Betdate { get; set; }
        // [Required]
        public int UserId { get; set; }

        public IEnumerable<SelectListItem> Choices { get; set; }

        //[Required]
        //[StringLength(50, MinimumLength =3)]
        //[Display(Name = "Tytuł Strony")]
        //public string Title { get; set; }
        //[Display(Name = "Adres Strony")]
        //public string Slug { get; set; }
        //[Required]
        //[StringLength(int.MaxValue, MinimumLength = 3)]
        //[Display(Name = "Zawartość Strony")]
        //[AllowHtml]
        //public string Body { get; set; }
        //public int Sorting { get; set; }
        //[Display(Name = "Pasek Boczny")]
        //public bool HasSidebar { get; set; }
    }
}