using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.ServiceRepository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantServiceProvider.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationsController : ControllerBase
    {
        public IReservationServiceRepository _reservation;

        public ReservationsController(IReservationServiceRepository reservation)
        {

            _reservation = reservation;
        }

        [HttpGet]
        public ActionResult<Reservation> Get()
        {
            List<Reservation> reservations = _reservation.GetReservations();
            return Ok(reservations);
        }

        [HttpGet("get/id/{id}")]
        public ActionResult<Reservation> GetReservationById(int id)
        {
            List<Reservation> reservations = _reservation.GetReservationsById(id);
            return Ok(reservations);
        }

        [HttpGet("get/user/id/{id}")]
        public ActionResult<Reservation> GetReservationByUserId(int id)
        {
            List<Reservation> reservations = _reservation.GetReservationsByUserId(id);
            return Ok(reservations);
        }

        [HttpGet("get/restaurant/id/{id}")]
        public ActionResult<Reservation> GetReservationsByRestaurantId(int id)
        {
            List<Reservation> reservations = _reservation.GetReservationsByRestaurantId(id);
            return Ok(reservations);
        }

        [HttpGet("get/date/{date}")]
        public ActionResult<Reservation> GetReservationsByDate(DateTime date)
        {
            List<Reservation> reservations = _reservation.GetReservationsByDate(date);
            return Ok(reservations);
        }
    }
}
