using Vejledningsbooking.Application.Commands.Booking;

namespace Vejledningsbooking.Application.UseCaseInterfaces.Booking
{
    public interface ICreateBookingUseCase
    {
        void CreateBooking(CreateBookingRequest command);
    }
}
