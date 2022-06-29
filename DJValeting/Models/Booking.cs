using System;
using System.ComponentModel.DataAnnotations;

namespace DJValeting.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Bookingdate { get; set; }
        public int FlexibilityDays { get; set; }
        public SizeEnum VehicleSize { get; set; }   
        public int ContactNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
