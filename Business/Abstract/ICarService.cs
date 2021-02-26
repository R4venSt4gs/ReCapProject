using Core.Utilities;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllBrandId(int brandId);
        IDataResult<List<Car>> GetAllColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
