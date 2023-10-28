namespace OpinionForBooks.Models
{
    public class ReviewBookModel
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Qualification { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public DateTime CreationDate { get; set; }
        public int UserId { get; set; }
    }
}
