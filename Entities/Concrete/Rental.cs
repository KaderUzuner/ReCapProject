﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Rental:IEntity
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime RentStartDate { get; set; }
        public DateTime? RentEndDate { get; set; }
        public DateTime? ReturnDate { get; set; }

    }

}
