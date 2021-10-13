using System;
using Vejledningsbooking.Application.Commands.Booking;
using Vejledningsbooking.Application.Persistence;
using Vejledningsbooking.Application.UseCaseInterfaces.Booking;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Implementation
{
    public class CreateBookingUseCase : ICreateBookingUseCase
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IBookingWindowRepository _bookingWindowRepository;

        public CreateBookingUseCase(IBookingRepository bookingRepository, IBookingWindowRepository bookingWindowRepository)
        {
            _bookingRepository = bookingRepository;
            _bookingWindowRepository = bookingWindowRepository;
        }

        public void CreateBooking(CreateBookingRequest command)
        {
            var bookingWindow = _bookingWindowRepository.GetBookingWindow(command.BookingWindowId);
            var otherBookings = _bookingRepository.GetBookings(bookingWindow.Id);
            var booking = new Booking(command.StartTime, command.EndTime);

            foreach (var item in otherBookings)
            {
                if (booking.IsOverlapping(item)) throw new Exception();
            }

            _bookingRepository.Save(booking);
        }
    }
}
