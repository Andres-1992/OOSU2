using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class ReservationRepository
    {
       private List<Reservation> reservations = new List<Reservation>();
        internal void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }
       
        internal Reservation GetReservationById(int id)
        {
            return reservations.FirstOrDefault(x => x.Id.Equals(id));
        }
    }
}
