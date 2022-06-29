using DJValeting.Models;

namespace DJValeting.Repos
{
    public interface IBookingRepository
    {
        void CreateBooking(Booking booking);
    }
}