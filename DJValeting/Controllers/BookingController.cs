using AutoMapper;
using DJValeting.Models;
using DJValeting.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DJValeting.Controllers
{
    [Route("api/v{version:apiVersion}/booking")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ApiController]

    public class BookingController : ControllerBase
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IMapper _mapper;

        public BookingController(IBookingRepository bookingRepository, IMapper mapper)
        {
            _bookingRepository = bookingRepository;
            _mapper = mapper;
        }


        [Consumes("application/json")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [HttpPost(Name = "Createtemplate")]
        public  ActionResult<Booking> Post(BookingDTO booking)
        {
            var bookingEntity = _mapper.Map<Booking>(booking);
            _bookingRepository.CreateBooking(bookingEntity);

            return Ok(true);
        }

    }
}
