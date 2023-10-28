using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Models
{
    public class Autor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutorId { get; set; }
        public string NickName { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
