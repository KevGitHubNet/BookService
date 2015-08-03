using System.ComponentModel.DataAnnotations;

namespace BookService.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }

        // Foreign Key
        public int AuthorId { get; set; }
        // Navigation property
        public Author Author { get; set; }
        /*******lazy loading*************/
        ///requires multiple database trips
        ///EF automatically loads a related entity when the navigation property for that entity is dereferenced
        ///var books = db.Books.ToList();  // Does not load authors
        ///var author = books[0].Author;   // Loads the author for books[0]
        ///When lazy loading is enabled, accessing the Author property on books[0] causes EF to query the database for the author because EF sends a query each time it retrieves a related entity.
        ///make property virtual
        // Virtual navigation property
        //public virtual Author Author { get; set; }
    }
}