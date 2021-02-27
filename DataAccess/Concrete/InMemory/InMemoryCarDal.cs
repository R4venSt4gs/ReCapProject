using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId=1, ColorId = 1, CarName= "A4", BrandName= "Audi", DailyPrice = 350, ModelYear=2017, Descriptions = "Dizel Otomatik Vites" },
                new Car{CarId = 2, BrandId=2, ColorId = 3, CarName= "C180", BrandName= "Mercedes-Benz", DailyPrice = 350, ModelYear=2018, Descriptions = "Dizel Otomatik Vites" },
                new Car{CarId = 3, BrandId=3, ColorId = 2, CarName= "3.20D", BrandName= "BMW", DailyPrice = 300, ModelYear=2018, Descriptions = "Dizel Otomatik Vites" },
                new Car{CarId = 4, BrandId=3, ColorId = 1, CarName= "5.30D", BrandName= "BMW", DailyPrice = 450, ModelYear=2020, Descriptions = "Dizel Otomatik Vites" },
                new Car{CarId = 5, BrandId=4, ColorId = 2, CarName= "S60 D4", BrandName= "Volvo", DailyPrice = 350, ModelYear=2019, Descriptions = "Dizel Yarı Otomatik Vites" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.CarName = car.CarName;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;
        }
    }
}
