using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookStore.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
                
        [StringLength(350)]
        //[Display(Name = "Title")] --- ova sluzi za da go odvois imeto za poubavo da se gleda koga ke ja pustis aplikacijata.
        public string Title { get; set; }

        [StringLength(350)]
        [Display(Name = "Author Name")]
        public string AuthorName { get; set; }

        [Display(Name = "Author")]
        public int AuthorID { get; set; }
        
        public Author Author { get; set; }

        [Display(Name = "Year Of Issue")]
        public DateTime YearOfIssue { get; set; }

        [Display(Name = "Number Of Pages")]
        public int NumberOfPages { get; set; }

        [StringLength(350)]
        [Display(Name = "Publisher Name")]
        public string PublisherName { get; set; }
        
        public Publisher Publisher { get; set; }

        [Display(Name = "Publisher")]
        public int PublisherID { get; set; }

        [Display(Name = "User Id")]
        public int UserId { get; set; }

        [StringLength(150)]        
        public string Gener { get; set; }

        [StringLength(150)]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Category")]
        public int CategoryID { get; set; }
        
        public Category Category { get; set; }
        
        public double Price { get; set; }

        [StringLength(50)]
        [Display(Name = "Book Type")]
        public string BookType { get; set; }

        [StringLength(50)]
        [Display(Name = "Book Cover Type")]
        public string BookCoverType { get; set; }  // Cover Type

        [StringLength(500)]        
        public string Description { get; set; }

        [StringLength(50)]
        public string Language { get; set; }

        [StringLength(150)]
        public string Country { get; set; }
        public int Edition { get; set; }

        [StringLength(50)]
        public string Dimensions { get; set; }
        public double Weight { get; set; }
        public int Copies { get; set; }

        [StringLength(50)]
        public string Shipping { get; set; }

        [Display(Name = "Photo")]
        public string PhotoURL { get; set; }

        [Display(Name = "Sold Items")]
        public int SoldItems { get; set; }

        public double Rating { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

       
    }

}
