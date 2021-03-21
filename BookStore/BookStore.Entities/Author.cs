using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookStore.Entities
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        [StringLength(10)]
        public DateTime DateBirth { get; set; }

        [StringLength(500)]
        public string ShortDescription { get; set; }

        [StringLength(40)]
        public string Language { get; set; }

        [StringLength(60)]
        public string Gender { get; set; }

        public bool Popularity { get; set; }

        //*** TODO: extra fild
        public virtual ICollection<Book> Books { get; set; }
    }
}
