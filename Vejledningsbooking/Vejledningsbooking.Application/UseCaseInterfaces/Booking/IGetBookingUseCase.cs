using System.Collections.Generic;
using Vejledningsbooking.Application.Commands.Booking;

namespace Vejledningsbooking.Application.UseCaseInterfaces.Booking
{
    public interface IGetBookingUseCase
    {
        Domain.Entities.Booking GetBooking(GetBookingRequest command);
        IEnumerable<Domain.Entities.Booking> GetBookings(GetBookingRequest command);
    }
}
