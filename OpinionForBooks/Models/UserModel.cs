namespace OpinionForBooks.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public int Status { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
