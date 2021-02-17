using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EdCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll());
            {

            }
        }
    }
}
