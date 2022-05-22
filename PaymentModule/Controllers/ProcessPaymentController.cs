using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessPaymentController : ControllerBase
    {
       [HttpGet]
        public IActionResult ProcessPayment(string creditNo, int creditlimit, int totalcharge)
        {

            int balanceamt = 0;
            if (creditlimit>0 && totalcharge>0 && creditlimit >= totalcharge)

            {

                balanceamt = creditlimit - totalcharge;
            }
            else
            {

                balanceamt = -1;
            }
            if (balanceamt != -1) {
                return Ok(balanceamt);
            }
            return BadRequest();
        }


    }
}
