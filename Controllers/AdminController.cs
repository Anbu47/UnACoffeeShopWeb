using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnACoffeeShop.HelperScript;
using UnACoffeeShop.Models.ShopItemModelFirebase;

namespace UnACoffeeShop.Controllers
{
    [ApiController]
    [Route("api/data")]
    public class AdminController : ControllerBase

    {
        //No Respond
        [HttpPost("login")]
        public bool Login([FromBody] AdminModel adminModel)
        {
            if (adminModel.AccountID == "ThaiNgocxinhdep" && adminModel.Password == "ThaiNgociscute")
            {
                return true;
            }
                return false;
        }
    }
}
