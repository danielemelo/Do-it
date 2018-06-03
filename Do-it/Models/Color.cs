using System.ComponentModel.DataAnnotations;

namespace Do_it.Models
{
    public class Color
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public string RGB { get; set; }
    }
}