using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Statistics 
    {
        public double Average
        {
            get 
            {
                return Sum / Count;
            }
        }
        public double High;
        public double Low;

        public char Letter
        {
            get 
            {
                switch(Average)
                {
                    case var a when a >= 90.0:
                        return 'A';
                    case var a when a >= 80.0:
                        return 'B';
                    case var a when a >= 70.0:
                        return 'C';
                    case var a when a >= 60.0:
                        return 'D';
                    default:
                        return 'F';
                }
            }
        }

        public double Sum;
        public int Count;

        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            Low = Math.Min(number, Low);
            High = Math.Max(number, High);
        }

        public Statistics() 
        {
            Count = 0;
            Sum = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }
    }
}