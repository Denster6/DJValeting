using DJValeting.Models;

namespace DJValeting.Repos
{
    public class BookingRepository : IBookingRepository
    {
        private readonly AppDbContext _dbContext;

        public BookingRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateBooking(Booking booking)
        {

            _dbContext.Bookings.Add(booking);
            _dbContext.SaveChanges();

        }
    }
}
