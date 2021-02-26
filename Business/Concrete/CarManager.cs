using Business.Abstract;
using Business.Contants;
using Core.Utilities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        private Rentalcontext rentalcontext;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public CarManager(Rentalcontext rentalcontext)
        {
            this.rentalcontext = rentalcontext;
        }

        public IResult Add(Car car)
        {
            if (car.CarName.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<List<Car>> GetAllBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(b => b.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetAllColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(co => co.ColorId == colorId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IResult Update(Car car)
        {
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}