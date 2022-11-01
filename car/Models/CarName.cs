using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car.Models
{
    public class CarName
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public List<CarModel> carModels { get; set; }


    }
}
