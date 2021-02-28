using System;
using System.Collections.Generic;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            var tempCars= carManager.GetAll();
            foreach (var car in tempCars)
            {
                Console.WriteLine(car.Description);
            }
            Console.ReadLine();
        }
        
    }
}
