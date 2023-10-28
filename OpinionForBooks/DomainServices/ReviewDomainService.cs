using BooksClass;
using DB.Models;
using OpinionForBooks.IDomainService;
using OpinionForBooks.Models;

namespace OpinionForBooks.Domain
{
    public class ReviewDomainService : IReviewDomainService
    {
        private readonly ControlBoxContext _contex;
        public ReviewDomainService(ControlBoxContext contex)
        {
            _contex = contex;
        }
        public string DeleteReview(int id)
        {
            var data = _contex.ReviewBooks.Find(id);
            if(data != null)
            {
                data.Status = 0;
                _contex.SaveChanges();
                return "Review eliminado con exito";
            }
            else
            {
                return "La review no existe";
            }
        }

        public ReviewBook GetReview(int id)
        {
            return _contex.ReviewBooks.Find(id);
        }

        public IEnumerable<ReviewBook> GetReviews()
        {
            return _contex.ReviewBooks.Where(x => x.Status != 0).ToList();
        }

        public string SaveReview(ReviewBook reviewBook)
        {
            try
            {
                _contex.Add(reviewBook);
                _contex.SaveChanges();
                return "Creado con exito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }
    }
}
