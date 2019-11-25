using Microsoft.EntityFrameworkCore;
using RestaurantServiceProvider.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantServiceProvider.ServiceRepository
{
    public class ReservationServiceRepository : IReservationServiceRepository
    {
        private DbSet<Reservation> reservations;

        public ReservationServiceRepository(RestaurantServiceProviderContext context)
        {
            reservations = context.Reservations;
        }

        public List<Reservation> GetReservationsById(int id) => reservations.Where(reservation => reservation.Id == id).ToList();

        public List<Reservation> GetReservationsByUserId(int id) => reservations.Where(reservation => reservation.User.Id == id).ToList();

        public List<Reservation> GetReservationsByDate(DateTime date) => reservations.Where(reservation => reservation.ReservationDate == date).ToList();

        public List<Reservation> GetReservationsByRestaurantId(int id) => reservations.Where(reservation => reservation.Restaurant.Id == id).ToList();
        public List<Reservation> GetReservations() => reservations.ToList();
    }
}
