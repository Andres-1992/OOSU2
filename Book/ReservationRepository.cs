using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class ReservationRepository
    {
       readonly List<Reservation> reservations = new List<Reservation>();
        public void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }
       
        public Reservation GetReservationById(int id)
        {
            return reservations.FirstOrDefault(x => x.Id.Equals(id));
        }
    }
}
