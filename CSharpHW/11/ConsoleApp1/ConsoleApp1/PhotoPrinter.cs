﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PhotoPrinter :Printer
    {
        public override void Print(string str)
        {
            Console.WriteLine("photoprint-" + str);
        }
    }
}
