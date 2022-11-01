using car.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using car.ViewModels.Home;

namespace car.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<CarName> _cars;

        public HomeController()
        {
            _cars = new List<CarName>
            {
                new CarName{
                    Id=1,
                    Name="bmw",
                    carModels=new List<CarModel>
                    {
                        new CarModel
                        {
                            Model="M5 competition",
                            Color="Black",
                            FuelType="Gasoline"
                        },
                        new CarModel
                        {
                            Model="r8",
                            Color="DarkGrey",
                            FuelType="Diesel"

                        },
                        new CarModel
                        {
                            Model="cls 6.3",
                            Color="DarkBlack",
                            FuelType="Gasoline"
                        },
                        new CarModel
                        {
                            Model="E39",
                            Color="Black",
                            FuelType="Gasoline"
                        },
                        new CarModel
                        {
                            Model="A4",
                            Color="Gray",
                            FuelType="Diesel"
                        },
                          new CarModel
                        {
                            Model="A3",
                            Color="Gray",
                            FuelType="Diesel"
                        },
                            new CarModel
                        {
                            Model="rs6",
                            Color="Gray",
                            FuelType="Diesel"
                        },
                              new CarModel
                        {
                            Model="M4",
                            Color="Gray",
                            FuelType="Diesel"
                        }



                    }
               

                },
                new CarName{Id=2
                ,Name="mercedes",
                 carModels=new List<CarModel>
                    {
                        new CarModel
                        {
                            Model="M5 competition",
                            Color="Black",
                            FuelType="Gasoline"
                        },
                        new CarModel
                        {
                            Model="r8",
                            Color="DarkGrey",
                            FuelType="Diesel"

                        },
                        new CarModel
                        {
                            Model="cls 6.3",
                            Color="DarkBlack",
                            FuelType="Gasoline"
                        },
                        new CarModel
                        {
                            Model="E39",
                            Color="Black",
                            FuelType="Gasoline"
                        },
                        new CarModel
                        {
                            Model="A4",
                            Color="Gray",
                            FuelType="Diesel"
                        },
                          new CarModel
                        {
                            Model="A3",
                            Color="Gray",
                            FuelType="Diesel"
                        },
                            new CarModel
                        {
                            Model="rs6",
                            Color="Gray",
                            FuelType="Diesel"
                        },
                              new CarModel
                        {
                            Model="M4",
                            Color="Gray",
                            FuelType="Diesel"
                        }



                    }

                },
                new CarName{Id=3,
                    Name="audi",
                     carModels=new List<CarModel>
                    {
                        new CarModel
                        {
                            Model="M5 competition",
                            Color="Black",
                            FuelType="Gasoline"
                        },
                        new CarModel
                        {
                            Model="r8",
                            Color="DarkGrey",
                            FuelType="Diesel"

                        },
                        new CarModel
                        {
                            Model="cls 6.3",
                            Color="DarkBlack",
                            FuelType="Gasoline"
                        },
                        new CarModel
                        {
                            Model="E39",
                            Color="Black",
                            FuelType="Gasoline"
                        },
                        new CarModel
                        {
                            Model="A4",
                            Color="Gray",
                            FuelType="Diesel"
                        },
                          new CarModel
                        {
                            Model="A3",
                            Color="Gray",
                            FuelType="Diesel"
                        },
                            new CarModel
                        {
                            Model="rs6",
                            Color="Gray",
                            FuelType="Diesel"
                        },
                              new CarModel
                        {
                            Model="M4",
                            Color="Gray",
                            FuelType="Diesel"
                        }



                    }
                }
            };
        }

        public IActionResult Index()
        {

            CarName carName = new CarName
            {
                Name="bmw"
            };
            CarModel carModel = new CarModel
            {
               Model="m5 compatition",
               Color="black",
               FuelType="gasoline"
            };

            HomeVM homeVM = new HomeVM
            {
                CarName=carName,
                CarModel=carModel,
                Cars = _cars
            };
            return View(homeVM);
        }

        public IActionResult Details(int? Id)
        {
            CarName carName = _cars.Find(g => g.Id == Id);
            return View(carName);
        }


    }
}
