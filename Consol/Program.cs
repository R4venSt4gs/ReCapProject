using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Consol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Marka \t Model \t Renk \t Fiyat");
            
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var carDetail in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(carDetail.BrandName + "\t" + carDetail.CarName + "\t" + carDetail.ColorName + carDetail.DailyPrice);
            }

            Console.WriteLine(" ");
            Console.WriteLine("\t ********* \t");
            Console.WriteLine(" ");

            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine("Renk: {0} Color Id: {1} ", color.ColorName, color.ColorId);
            }
            
            Console.WriteLine(" ");
            Console.WriteLine("\t ********* \t");
            Console.WriteLine(" ");

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine("Marka: {0} \t Brand Id: {1} ", brand.BrandName, brand.BrandId);
            }

            Console.WriteLine(" ");
            Console.WriteLine("\t ********* \t");
            Console.WriteLine(" ");

            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetAll();
            if (result.Success == true)
            {
                foreach (var user in result.Data)
                {   
                    Console.WriteLine(user.FirstName + " " + user.LastName);
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("\t ********* \t");
            Console.WriteLine(" ");

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var results = rentalManager.Add(new Rental
            { 
                CustomerId = 1, 
                RentDate = "03.01.2021", 
                ReturnDate = "13.01.2021", 
                CarId = 4, 
                RentalId = 7
            });
            if (results.Success)
            {
                Console.WriteLine(results.Message);
            }

            Console.ReadLine();
            
        }
    }
}
