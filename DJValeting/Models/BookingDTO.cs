using System;
using System.ComponentModel.DataAnnotations;

namespace DJValeting.Models
{
    public enum SizeEnum
    {
        small,
        medium,
        large,
        Van
    }

    public class BookingDTO
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public DateTime Bookingdate { get; set; }
        [Range(1, 3)]
        public int FlexibilityDays { get; set; }
        [Required]
        public SizeEnum VehicleSize { get; set; }
        [Required]
        public int ContactNumber { get; set; }
        [Required]
        public string EmailAddress { get; set; }
    }
}
