using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, NorthwindContext>,ICarImageDal
    {
        public bool IsExist(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.CarImages.Any(p => p.Id == id);
            }
        }

    }
}
