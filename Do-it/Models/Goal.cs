using System;
using System.ComponentModel.DataAnnotations;

namespace Do_it.Models
{
    public class Goal
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }
    }
}