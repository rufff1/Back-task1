using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using car.Models;

namespace car.ViewModels.Home
{
    public class HomeVM
    {
        public CarName CarName { get; set; }
        public CarModel CarModel { get; set; }
        public List<CarName> Cars { get; set; }
    }
}
