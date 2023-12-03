﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KomarovMA.Sprint6.Task2.V15.Lib
{
    public class DataService : ISprint6Task2V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y = 0;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (3 * x + 1.2 == 0)
                {
                    valueArray[count] = 0;
                    count++;
                    continue;
                }
                y = (((double)Math.Sin(x) * 2) / (3 * x + 1.2) + Math.Cos(x) - 7 * x * 2);
                valueArray[count] = Math.Round(y, 2);
                count++;

            }
            return valueArray;
        }
    }
}