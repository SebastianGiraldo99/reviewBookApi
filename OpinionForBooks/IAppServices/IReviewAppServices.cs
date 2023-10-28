using DB.Models;
using OpinionForBooks.Models;
using OpinionForBooks.Models.DTO;

namespace OpinionForBooks.InterfacesServices
{
    public interface IReviewAppServices
    {
        IEnumerable<ReviewBookDTO> GetReviews();
        ReviewBookDTO GetReview(int id);
        string SaveReview(ReviewBookModel reviewBook);
        string DeleteReview(int id);
    }

}
