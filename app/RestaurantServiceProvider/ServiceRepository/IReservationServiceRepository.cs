using RestaurantServiceProvider.Entities;
using System;
using System.Collections.Generic;

namespace RestaurantServiceProvider.ServiceRepository
{
    public interface IReservationServiceRepository
    {
        public abstract List<Reservation> GetReservationsById(int id);
        public abstract List<Reservation> GetReservationsByUserId(int id);
        public abstract List<Reservation> GetReservationsByDate(DateTime date);
        public abstract List<Reservation> GetReservationsByRestaurantId(int id);
        public abstract List<Reservation> GetReservations();
    }
}
