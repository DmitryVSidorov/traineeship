﻿using System;

namespace ConsoleGeom
{
    class EventHandler
    {
        public double ChangeCosoleLine()
        {
            string parameterSet;
            double parameterGet = 0;
            double number;
            bool canPars = false;

            do
            {
                parameterSet = Console.ReadLine();
                    if (double.TryParse(parameterSet, out number))
                    {
                        parameterGet = Convert.ToDouble(parameterSet);
                        canPars = true;
                    }
                    else
                    {
                        Console.WriteLine("Only numbers");
                        canPars = false;
                    }
            }
            while (!canPars);
            return parameterGet;
        }
    }
}
