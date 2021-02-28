using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;
        private ICarDal _carDalImplementation;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    BrandId = 1, ColorId = 1, DailyPrice = 100, Description = "Spor araç", Id = 1, ModelYear = 2013
                },
                new Car
                {
                    BrandId = 2, ColorId = 2, DailyPrice = 120, Description = "Ticari araç", Id = 1, ModelYear = 2015
                },
                new Car
                {
                    BrandId = 3, ColorId = 3, DailyPrice = 200, Description = "Hachback", Id = 1, ModelYear = 2020
                },
                new Car
                {
                    BrandId = 4, ColorId = 4, DailyPrice = 150, Description = "Pick-up truck", Id = 1, ModelYear = 2016
                },
                new Car {BrandId = 5, ColorId = 5, DailyPrice = 180, Description = "Minivan", Id = 1, ModelYear = 2017},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
