using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imt2.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int Doors { get; set; }
        public int Seats { get; set; }
        public int Luggage { get; set; }
        public int Transmission { get; set; }
        public int Age { get; set; }
        public int CarModelId { get; set; }
        public Marka Marka { get; set; }

    }


}
