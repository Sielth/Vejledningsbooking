using System;

namespace Vejledningsbooking.Application.Commands.Booking
{
    public class GetBookingRequest
    {
        public Guid BookingId { get; set; }
        public Guid BookingWindowId { get; set; }
    }
}
