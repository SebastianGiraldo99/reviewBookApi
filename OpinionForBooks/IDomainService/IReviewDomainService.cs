using DB.Models;
using OpinionForBooks.Models;

namespace OpinionForBooks.IDomainService
{
    public interface IReviewDomainService
    {
        IEnumerable<ReviewBook> GetReviews();
        ReviewBook GetReview(int id);
        string SaveReview(ReviewBook reviewBook);
        string DeleteReview(int id);
    }
}
