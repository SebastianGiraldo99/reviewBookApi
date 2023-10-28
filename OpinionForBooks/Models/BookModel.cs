namespace OpinionForBooks.Models
{
    public class BookModel
    {
        public string  BookName { get; set; }
        public string ISBN { get; set; }
        public DateTime DatePublish { get; set; }
        public DateTime DateCreation { get; set; }
        public int Status { get; set; }
        public string summary { get; set; }
        public int AutorId { get; set; }
        public int CategoryId { get; set; }
    }
}
