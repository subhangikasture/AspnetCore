﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithStrategyDesignPattern
{
    internal interface IPaymentStrategy
    {
        void pay(decimal amount);
    }
}
