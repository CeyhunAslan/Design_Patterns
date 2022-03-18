﻿using Decorator.Example_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example_1.Decarators
{
    public class Decorator_A : IBilesen
    {
        private IBilesen _bilsen;

        public Decorator_A(IBilesen bilesen)
        {
            this._bilsen = bilesen;
        }

        public string Operation()
        {
            return $"{_bilsen.Operation()} extended mug..!";
        }
    }
}
