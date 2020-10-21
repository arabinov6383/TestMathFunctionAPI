
namespace MathFunctions
{
    using System;
    using MathFuncInterface;

    public static class MathFunctions
    {
        public static string FuncAdd(double Arg1, double Arg2, double Arg3, double Arg4, double Arg5)
        {
            return (Arg1 + Arg2 + Arg3 + Arg4 + Arg5).ToString();
        }

        public static string FuncSubtract(double Arg1, double Arg2, double Arg3, double Arg4, double Arg5)
        {
            return (Arg1 - Arg2 - Arg3 - Arg4 - Arg5).ToString();
        }

        public static string FuncMult(double Arg1, double Arg2, double Arg3, double Arg4, double Arg5)
        {
            return (Arg1 * Arg2 * Arg3 * Arg4 * Arg5).ToString();
        }

        public static string FuncMult(double Arg1, double Arg2, double Arg3, double Arg4)
        {
            return (Arg1 * Arg2 * Arg3 * Arg4).ToString();
        }

        public static string FuncMult(double Arg1, double Arg2, double Arg3)
        {
            return (Arg1 * Arg2 * Arg3).ToString();
        }

        public static string FuncMult(double Arg1, double Arg2)
        {
            return (Arg1 * Arg2).ToString();
        }

        public static string FuncDivide(double Arg1, double Arg2, double Arg3, double Arg4, double Arg5)
        {
            if (Arg2 == 0 || Arg3 == 0 || Arg4 == 0 || Arg5 == 0)
            {
                return "Error Occurred: Division by zero";
            }
            else
            {
                try
                {
                    return (Arg1 / Arg2 / Arg3 / Arg4 / Arg5).ToString();
                }
                catch (Exception ex)
                {
                    return "Error Occurred: " + ex.InnerException;
                }

            }
        }

        public static string FuncDivide(double Arg1, double Arg2, double Arg3, double Arg4)
        {
            if (Arg2 == 0 || Arg3 == 0 || Arg4 == 0)
            {
                return "Error Occurred: Division by zero";
            }
            else
            {
                try
                {
                    return (Arg1 / Arg2 / Arg3 / Arg4).ToString();
                }
                catch (Exception ex)
                {
                    return "Error Occurred: " + ex.InnerException;
                }
            }
        }

        public static string FuncDivide(double Arg1, double Arg2, double Arg3)
        {
            if (Arg2 == 0 || Arg3 == 0)
            {
                return "Error Occurred: Division by zero";
            }
            else
            {
                try
                {
                    return (Arg1 / Arg2 / Arg3).ToString();
                }
                catch (Exception ex)
                {
                    return "Error Occurred: " + ex.InnerException;
                }
            }
        }

        public static string FuncDivide(double Arg1, double Arg2)
        {
            if (Arg2 == 0)
            {
                return "Error Occurred: Division by zero";
            }
            else
            {
                try
                {
                    return (Arg1 / Arg2).ToString();
                }
                catch (Exception ex)
                {
                    return "Error Occurred: " + ex.InnerException;
                }
            }
        }

        public static string MathFunc(this IMathFuncInterface mathInterface)
        {
            return null;
        }
    }
}
