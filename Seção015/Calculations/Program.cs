﻿using Calculations.Services;

namespace Calculations;
delegate void BinaryNumericOperation(double n1, double n2);
class Program
{
    static void Main(string[] args)
    {


        // double a = 10;
        // double b = 12;
        // BinaryNumericOperation op = CalculationService.Sum;
        // //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
        // double result = op(a, b);
        // //double result = op.Invoke(a, b);
        // Console.WriteLine(result);

        double a = 10;
        double b = 12;
        BinaryNumericOperation op = CalculationService.ShowSum;
        op += CalculationService.ShowMax;
        op(a, b);


    }
}


