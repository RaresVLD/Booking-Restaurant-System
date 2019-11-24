using System;
using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.Utils
{
    public static class ReservationSeed
    {
       public static Reservation[] CreateReservations()
        {
            return new Reservation[2]
            {
                Reservation.Create(11, 5, new DateTime(2019, 12, 10, 18, 23, 21), 9, 1),
                Reservation.Create(12, 3, new DateTime(2019, 12, 10, 18, 23, 21), 10, 2)
            };
        }
    }
}
