﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //Snipper aslında hazır kodlar demek. Otomatik geliyor herhangi bir şey yazdığımızda(kod parçacığı).
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //CRUD=>Create,Read,Update,Delete
    }
}
