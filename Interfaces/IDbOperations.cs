﻿using Bank_Management_System.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System.Interfaces
{
    interface IDbOperations
    {
        bool verifyLogin(string username, string password);
        Customer searchCustomer(string cusAccNo);
        bool removeCustomer(string cusAccNo);
        string getManagerAccNo();
    }
}
