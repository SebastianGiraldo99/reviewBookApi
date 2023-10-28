using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Models
{
    public class ReviewBook
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReviewBookId { get; set; }
        public string Title { get; set; }
        public int Qualification { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public DateTime CreationDate { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("BookId")]
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
