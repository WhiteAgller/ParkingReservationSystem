using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingReservationSystem.Models
{
    internal class ReservationsModel
    {
        public string CarName { get; set; }

        public int ParkingPlaceId { get; set; }

        public DateTime DateForm { get; set; }

        public DateTime DateTo { get; set; }

        public string Description { get; set; }

    }
}
