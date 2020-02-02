using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class ReservationRepository
    {
        List<Reservation> reservations = new List<Reservation>();
        public void addReservation(Reservation res)
        {
            reservations.Add(res);
        }
        public Member findMember(int reservationNumber)
        {
            return reservations.FirstOrDefault(x => x.id.Equals(reservationNumber)).member;
        }

    }
}
