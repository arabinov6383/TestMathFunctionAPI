using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MathService.Controllers
{
    [Route("api/CalcDiff")]
    [ApiController]
    public class CalcDiffController : ControllerBase
    {
        // GET: api/CalcDiff
        [HttpGet]
        public string Get(double arg1, double arg2, double arg3, double arg4, double arg5)
        {
            return MathFunctions.MathFunctions.FuncSubtract(arg1, arg2, arg3, arg4, arg5).ToString();
        }

    }
}
