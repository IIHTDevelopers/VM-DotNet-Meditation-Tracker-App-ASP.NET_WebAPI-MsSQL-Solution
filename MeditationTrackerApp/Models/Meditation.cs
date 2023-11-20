using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MeditationTrackerApp.Models
{
    public class Meditation
    {
        [Key]
        public int MeditationSessionId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        public string MeditationType { get; set; }
        public string Notes { get; set; }
        public bool IsFavorite { get; set; }
        public string Goal { get; set; }
    }
}