using DB.Models;
using Microsoft.AspNetCore.Mvc;
using OpinionForBooks.InterfacesServices;
using OpinionForBooks.Models;
using OpinionForBooks.Models.DTO;

namespace OpinionForBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase

    {
        private readonly IReviewAppServices _reviewBookService;
        public ReviewsController(IReviewAppServices reviewServices)
        {
            _reviewBookService = reviewServices;
        }
        // GET: api/<ReviewsController>
        [HttpGet("GetAllReviews")]
        public IEnumerable<ReviewBookDTO> GetReviews()
        {
            return _reviewBookService.GetReviews();
        }

        // GET api/<ReviewsController>/5
        [HttpGet("GetReview")]
        public ReviewBookDTO Get(int id)
        {
            return _reviewBookService.GetReview(id);
        }

        // POST api/<ReviewsController>
        [HttpPost("SaveReview")]
        public string Post([FromBody] ReviewBookModel value)
        {
            try
            {
                return _reviewBookService.SaveReview(value);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // DELETE api/<ReviewsController>/5
        [HttpPost("DeleteReview")]
        public string Delete(int id)
        {
            try
            {
                return _reviewBookService.DeleteReview(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
