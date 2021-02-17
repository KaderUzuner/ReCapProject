using Business.Abstract;
using Business.Constants;
using Core.Ultilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            var result = _rentalDal.Get(x => x.CarId == rental.CarId && x.ReturnDate == null);

            if (result != null)
            {
                return new ErrorResult(Messages.RentalAddedError);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.SuccessAdd);
        }

        public IResult CheckReturnDate(int carId)
        {
            var result = _rentalDal.GetRentalDetails(c => c.CarId == carId && c.ReturnDate == null);
            if (result.Count > 0)
            {
                return new ErrorResult(Messages.RentalAddedError);
            }
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.SuccessDelete);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.SuccessListed);

        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(c => c.RentalId == id), Messages.SuccessListed);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailsDto(int carId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Rental rental)
        {

            _rentalDal.Update(rental);
            return new SuccessResult(Messages.SuccessUpdate);
        }

        public IResult UpdateReturnDate(int id)
        {
            var result = _rentalDal.GetAll(c => c.CarId == id);
            var updatedRental = result.LastOrDefault();
            if (updatedRental.ReturnDate != null)
            {
                return new ErrorResult(Messages.RentalUpdatedReturnDateError);
            }
            updatedRental.ReturnDate = DateTime.Now;
            _rentalDal.Update(updatedRental);
            return new SuccessResult(Messages.RentalUpdatedReturnDate);
        }
    }
}
