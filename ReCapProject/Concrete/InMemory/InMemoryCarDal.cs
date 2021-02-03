﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
              new Car(){Id=1, BrandId=10, ColorId=1, ModelYear=2010, DailyPrice=50000, Description="bmw" },
              new Car(){Id=2, BrandId=20, ColorId=2, ModelYear=2017, DailyPrice=60000, Description="mercedes" },
              new Car(){Id=3, BrandId=30, ColorId=3, ModelYear=2019, DailyPrice=70000, Description="Lan Rover" }


             };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //Linq
            
           Car carToDelete=_cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
           return _cars.Where(c=>c.BrandId==brandId).ToList();
        }

        public void GetByld(Car car)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
           

        }

    }
}
