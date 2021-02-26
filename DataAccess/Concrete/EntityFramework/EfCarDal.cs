using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, Rentalcontext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (Rentalcontext context = new Rentalcontext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId 
                             select new CarDetailDto { BrandName = c.BrandName, CarName = c.CarName, ColorName = c.ColorName, DailyPrice = c.DailyPrice };
                return result.ToList();
            }
        }
    }
}
