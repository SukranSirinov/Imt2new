using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imt2.Models
{
    public class Marka
    {
        public int Id { get; set; }
        public string CarModel { get; set; }
        public List<Car> cars { get; set; }

    }
}
