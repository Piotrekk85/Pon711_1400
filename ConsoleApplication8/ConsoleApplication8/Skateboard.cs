﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Skateboard : IRideable
    {
        public void Ride()
        {
            Console.WriteLine("Jadę na deskorolce");
        }
    }
}
