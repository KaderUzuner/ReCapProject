using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental, NorthwindContext>,IRentalDal
    {
        public List<RentalDetailDto> GetAllRentalDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from rent in context.Rentals
                             join car in context.Cars
                             on rent.CarId equals car.CarId
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             join customer in context.Customers
                             on rent.CustomerId equals customer.CustomerId
                             join user in context.Users
                             on customer.UserId equals user.Id
                             select new RentalDetailDto
                             {
                                 RentalId = rent.RentalId,
                                 CarName = brand.BrandName + car.CarName,
                                 CustomerFullName = user.FirstName + user.LastName,
                                 RentDate = rent.RentDate,
                                 RentStartDate = rent.RentStartDate,
                                 RentEndDate = rent.RentEndDate,
                                 ReturnDate = rent.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}