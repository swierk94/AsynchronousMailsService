﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Versus.Models.Data
{
    [Table("Scores")]
    public class ScoresDTO
    {
        [Key]
        public int Id { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string GameId { get; set; }
        public DateTime BetDate { get; set; }
        public string UserId { get; set; }
    }
}