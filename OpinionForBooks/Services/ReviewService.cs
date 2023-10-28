using AutoMapper;
using DB.Models;
using OpinionForBooks.IDomainService;
using OpinionForBooks.InterfacesServices;
using OpinionForBooks.Models;
using OpinionForBooks.Models.DTO;

namespace OpinionForBooks.Services
{
    public class ReviewService : IReviewAppServices
    {
        private IReviewDomainService _reviewDomainServices;
        private readonly IMapper _mapper;
        public ReviewService(IReviewDomainService reviewDomainService, IMapper mapper)
        {
            _reviewDomainServices = reviewDomainService;
            _mapper = mapper;
        }
        public string DeleteReview(int id)
        {
            return _reviewDomainServices.DeleteReview(id);
        }

        public ReviewBookDTO GetReview(int id)
        {
            return _mapper.Map<ReviewBookDTO>(_reviewDomainServices.GetReview(id));
        }

        public IEnumerable<ReviewBookDTO> GetReviews()
        {
            var reviewsBook = _reviewDomainServices.GetReviews();
            var reviewBookDTO = _mapper.Map<IEnumerable<ReviewBookDTO>>(reviewsBook);
            return reviewBookDTO;
        }

        public string SaveReview(ReviewBookModel reviewBook)
        {
            try
            {
                var reviewBookMapper = _mapper.Map<ReviewBook>(reviewBook);
                return _reviewDomainServices.SaveReview(reviewBookMapper);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }  
    }
}
