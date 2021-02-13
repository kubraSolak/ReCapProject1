using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EnityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, SouthwindContext>,IColorDal
    {
        
    }
}
