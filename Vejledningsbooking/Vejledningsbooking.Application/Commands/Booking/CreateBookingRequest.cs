using System;

namespace Vejledningsbooking.Application.Commands.Booking
{
    public class CreateBookingRequest
    {
        public Guid BookingWindowId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
