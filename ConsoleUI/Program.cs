using Business.Concrete;

using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            / Data Transformation Object
            CarTest();
            //IoC 
            //CategoryTest();

            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EFCustomerDal());
            RentalManager rentalManager = new RentalManager(new EFRentalDal());
            foreach (var car in carManager.GetAll());
            {

            }
        }
    }
}
