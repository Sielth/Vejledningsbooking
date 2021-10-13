using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vejledningsbooking.Application.Commands.Booking;
using Vejledningsbooking.Application.Persistence;
using Vejledningsbooking.Application.UseCaseInterfaces.Booking;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Implementation
{
    public class GetBookingUseCase : IGetBookingUseCase
    {
        private readonly IBookingRepository _bookingRepository;

        public GetBookingUseCase(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        Booking IGetBookingUseCase.GetBooking(GetBookingRequest command)
        {
            return _bookingRepository.GetBooking(command.BookingId);
        }

        IEnumerable<Booking> IGetBookingUseCase.GetBookings(GetBookingRequest command)
        {
            return _bookingRepository.GetBookings(command.BookingWindowId);
        }
    }
}
