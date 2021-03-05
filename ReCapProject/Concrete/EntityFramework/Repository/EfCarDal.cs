using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            { 

                var result =from c in context.Cars
                            join co in context.Colors
                            on c.ColorId equals co.ColorId
                            join br in context.Brands
                            on c.BrandId equals br.BrandId
                            select new CarDetailDto
                            {
                                CarId = c.CarId,
                                BrandId = br.BrandId,
                                BrandName = br.BrandName,
                                DailyPrice = c.DailyPrice,
                                Description = c.Description,
                                ModelYear = c.ModelYear
                            };

                return result.ToList();
            }
        
        }
    }
}
