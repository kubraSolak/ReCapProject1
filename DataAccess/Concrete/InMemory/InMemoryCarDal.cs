using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal :ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=5888, ModelYear=1996, Description="x type"},
            new Car{Id=2, BrandId=2, ColorId=2, DailyPrice=78888, ModelYear=1996, Description="y type"},
            new Car{Id=3, BrandId=3, ColorId=3, DailyPrice=45698, ModelYear=1996, Description="z type"},
            new Car{Id=4, BrandId=4, ColorId=4, DailyPrice=456982, ModelYear=1996, Description="q type"},
            new Car{Id=5, BrandId=5, ColorId=5, DailyPrice=1000000, ModelYear=1996, Description="t type"}
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

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

    }
}
