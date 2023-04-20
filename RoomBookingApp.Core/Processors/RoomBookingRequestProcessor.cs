using System;
using RoomBookingApp.Core.Models;

namespace RoomBookingApp.Core.Processors
{
    public class RoomBookingRequestProcessor
    {
        public RoomBookingResult BookRoom(RoomBookingRequest bookingRequest)
        {
            return new RoomBookingResult
            {
               FullName = bookingRequest.FullName,
               Date = bookingRequest.Date,
               Email = bookingRequest.Email
            };
        }
    }
}