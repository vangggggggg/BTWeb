using System.ComponentModel.DataAnnotations;

namespace CrudBook.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required,StringLength(120)]

        public string Name { get; set; }
        [Required, StringLength(120)]
        public string Title { get; set;}

        [Required]
        public string Description { get; set; }
        [Required]
        public string Author { get; set;}

        [Required, Range(10,3000)]
        public int Price {  get; set; }

        public string? Image {  get; set; }
    }
}
