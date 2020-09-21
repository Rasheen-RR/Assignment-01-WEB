using System;

namespace Calculator
{
    public class Calculator
    {
        public static Result DoOperation(double num1, double num2, string op)
        {
            Result result = new Result
            {
                result = double.NaN,
                op = ""
            };

            switch (op.ToLower())
            {
                case "a":
                    result.result = num1 + num2;
                    result.op = "+";
                    break;
                case "s":
                    result.result = num1 - num2;
                    result.op = "-";
                    break;
                case "m":
                    result.result = num1 * num2;
                    result.op = "*";
                    break;
                case "d":
                    if (num2 != 0)
                    {
                        result.result = num1 / num2;
                        result.op = "/";
                    }
                    break;
                case "r":
                    result.result = num1 % num2;
                    result.op = "%";
                    break;
                default:
                    break;
            }
            return result;
        }


    }
}
