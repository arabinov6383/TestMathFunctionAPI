using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MathService.Controllers
{
    [Route("api/CalcProd")]
    [ApiController]
    public class CalcProdController : ControllerBase
    {
        // GET: api/CalcProduct
        [HttpGet]
        //public string Get(double arg1, double arg2, double arg3, double arg4, double arg5)
        //{
        //    return MathFunctions.MathFunctions.FuncMult(arg1, arg2, arg3, arg4, arg5).ToString();
        //}
        public string Get(string arg1, string arg2, string arg3, string arg4, string arg5)
        {
            int numargs = 0;
            string[] args = new string[5];
            int i = 0;
            if (arg1 != null )
            {
                numargs++;
                args[i] = arg1;
                i++;
            }

            if (arg2 != null)
            {
                numargs++;
                args[i] = arg2;
                i++;
            }

            if (arg3 != null)
            {
                numargs++;
                args[i] = arg3;
                i++;
            }

            if (arg4 != null)
            {
                numargs++;
                args[i] = arg4;
                i++;
            }

            if (arg5 != null)
            {
                numargs++;
                args[i] = arg5;
                i++;
            }
            double ArgA = Convert.ToDouble(args[0]);
            double ArgB = Convert.ToDouble(args[1]);
            double ArgC = Convert.ToDouble(args[2]);
            double ArgD = Convert.ToDouble(args[3]);
            double ArgE = Convert.ToDouble(args[4]);
            string result = "";
            switch (numargs)
            {
                case 0:
                    result = "Please provide numbers to multiply";
                    break;
                case 1:
                    result = args[0];
                    break;
                case 2:
                    result = MathFunctions.MathFunctions.FuncMult(ArgA, ArgB).ToString();
                    break;
                case 3:
                    result = MathFunctions.MathFunctions.FuncMult(ArgA, ArgB, ArgC).ToString();
                    break;
                case 4:
                    result = MathFunctions.MathFunctions.FuncMult(ArgA, ArgB, ArgC, ArgD).ToString();
                    break;
                default:
                    result = MathFunctions.MathFunctions.FuncMult(ArgA, ArgB, ArgC, ArgD, ArgE).ToString();
                    break;
            }

            return result;
        }
    }
}

