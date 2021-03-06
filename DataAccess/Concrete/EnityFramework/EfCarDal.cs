﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EnityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, SouthwindContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (SouthwindContext context = new SouthwindContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto { Id = c.Id, CarName = c.CarName,ColorName= co.ColorName, BrandName = b.BrandName, DailyPrice = c.DailyPrice };

                return result.ToList();
            }
            
        }
    }
}
