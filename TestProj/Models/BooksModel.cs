using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj.Models
{
    public class BooksModel
    {
        public int Book_Id { get; set; }
        public string Title { get; set; }
        public int? AuthorId { get; set; }
        public string Genre { get; set; }
        public int? Published_Year { get; set; }
        //Author Name
        public string Name { get; set; }
        public virtual AuthorModel Author { get; set; }
    }
}
