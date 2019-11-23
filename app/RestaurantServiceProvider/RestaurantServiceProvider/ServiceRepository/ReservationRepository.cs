using Microsoft.EntityFrameworkCore;
using RestaurantServiceProvider.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantServiceProvider.ServiceRepository
{
    public class ReservationRepository
    {
        private DbSet<Reservation> reservations;
        public ReservationRepository(RestaurantServiceProviderContext context)
        {
            reservations = context.Reservations;
        }

        public List<Reservation> GetReservationsById(int id) => reservations.Where(reservation => reservation.Id == id).ToList();
        public List<Reservation> GetReservationsByUser(User user) => reservations.Where(reservation => reservation.User.Id == user.Id).ToList();
        public List<Reservation> GetReservationsByDate(DateTime date) => reservations.Where(reservation => reservation.ReservationDate == date).ToList();
        public List<Reservation> GetReservationsByRestaurant(Restaurant restaurant) => reservations.Where(reservation => reservation.Restaurant.Id == restaurant.Id).ToList();
    }
}
