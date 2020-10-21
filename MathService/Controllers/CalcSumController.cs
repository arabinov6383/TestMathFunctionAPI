using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MathService.Controllers
{
    [Route("api/CalcSum")]
    [ApiController]
    public class CalcSumController : ControllerBase
    {
        // GET: api/CalcSum
        [HttpGet]
        public string Get(double arg1, double arg2, double arg3, double arg4, double arg5)
        {
            return MathFunctions.MathFunctions.FuncAdd(arg1, arg2,arg3,arg4,arg5).ToString();
        }

    }
}
