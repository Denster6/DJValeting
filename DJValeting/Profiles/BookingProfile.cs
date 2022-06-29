using AutoMapper;
using DJValeting.Models;

namespace DJValeting.Profiles
{
    public class BookingProfile : Profile
    {

        public BookingProfile()
        {
            CreateMap<BookingDTO, Booking>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FullName));
        }
    }
}
