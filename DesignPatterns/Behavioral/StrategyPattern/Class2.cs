﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.StrategyPattern
{
    public class Class2 : IStrategy
    {
        public string Algorithm()
        {
            return "Class 2 Strategy";
        }
    }
}
