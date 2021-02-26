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
                new Car{CarId = 1, BrandId=1, ColorId = 1, CarName= "Opel Astra" , DailyPrice = 150, ModelYear=2017, Description = "Manuel Vites" },
                new Car{CarId = 2, BrandId=2, ColorId = 3, CarName= "Mercedes AMG", DailyPrice = 300, ModelYear=2012, Description = "Otomatik Vites" },
                new Car{CarId = 3, BrandId=3, ColorId = 2, CarName= "Peugeot 208 1.2", DailyPrice = 170, ModelYear=2018, Description = "Otomatik Vites" },
                new Car{CarId = 4, BrandId=3, ColorId = 1, CarName= "Peugeot 2008 SUV", DailyPrice = 250, ModelYear=2020, Description = "Otomatik Vites" },
                new Car{CarId = 5, BrandId=4, ColorId = 2, CarName= "Toyota Yaris Hibrid", DailyPrice = 190, ModelYear=2016, Description = "Yarı Otomatik Vites" },
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

        public Car Get(Expression<Func<Car, bool>> filter)
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
            carToUpdate.Description = car.Description;
        }
    }
}
