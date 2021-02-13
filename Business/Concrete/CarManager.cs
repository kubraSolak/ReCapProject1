using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;

        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public void Add(Car car)
        {
            
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _CarDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _CarDal.GetAll(c => c.ColorId == id);
        }

        public List<Car> GetAllByDailyPrice(decimal min, decimal max)
        {
            return _CarDal.GetAll(c => c.DailyPrice>=min && c.DailyPrice <=max);
        }
    }
}
