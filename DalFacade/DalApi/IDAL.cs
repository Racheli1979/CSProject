﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalApi
{
    public interface IDAL
    {
        ICustomer iCustomer { get; }
        IProduct iProduct { get; }
        ISale iSale { get; }
    }
}
