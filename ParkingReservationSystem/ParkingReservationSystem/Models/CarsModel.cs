using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingReservationSystem.Models
{
    internal class CarsGetModel
    {
        public bool Success { get; set; }
        public string Vin { get; set; }
        public Specification Specification { get; set; }

    }

    class Specification
    {
        public string Vin { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class CarsModelInputModel
    {
        public string VIN { get; set; }

        public string Description { get; set; }
    }

    class CarsModel: Specification
    {
        public string VIN { get; set; }

        public string Description { get; set; }
    }


}
