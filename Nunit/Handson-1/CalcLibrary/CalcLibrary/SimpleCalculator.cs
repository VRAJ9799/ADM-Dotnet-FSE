﻿using System;

namespace CalcLibrary
{
    public class SimpleCalculator : IMathLibrary
    {
        double result = 0;
        public double Addidtion(double a, double b)
        {
            result = a + b;
            return result;
        }
        public double Subtraction(double a, double b)
        {
            result = a - b;
            return result;
        }
        public double Multiplication(double a, double b)
        {
            result = a * b;
            return result;
        }
        public double Division(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("Second Parameter Can't be Zero");
            result = a / b;
            return result;
        }
        public void AllClear()
        {
            result = 0;
        }
        public double GetResult
        {
            get
            {
                return result;
            }
        }
    }
}
