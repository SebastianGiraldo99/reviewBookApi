using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string ISBN { get; set; }
        public DateTime DatePublish { get; set; }
        public DateTime CreationDate { get; set; }
        public int Status { get; set; }
        public string ResumeBook { get; set; }
        public int AutorId { get; set; }
        public virtual Autor Autor { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<ReviewBook> ReviewBooks { get; set; }
    }
}
