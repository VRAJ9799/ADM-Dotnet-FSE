﻿using System;

namespace BuilderDP
{
    public class Package
    {
        public int childNoOfPackage = 0;
        public int adultNoOfPackage = 0;


        public void PrintPackages()
        {
            Console.WriteLine($"Packages are shown below:\nChild Package: {childNoOfPackage}\nAdult Package: {adultNoOfPackage}");
        }
    }
}
