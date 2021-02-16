using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int id);
        List<Car> GetAllByColorId(int id);
        List<Car> GetAllByDailyPrice(decimal min, decimal max);
        void Add(Car car);
        List<CarDetailDto> GetCarDetails();
    }
}
