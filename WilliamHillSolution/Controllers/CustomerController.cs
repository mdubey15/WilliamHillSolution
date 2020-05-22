using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryCustomer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiddleLayer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WilliamHillSolution.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
            private BaseCustomer baseCustomer = null;
        DbContext dbContext = null;

        // GET api/Registration/MrGreen
        [HttpGet("{brandName}")]
            public string ViewCustomerData(string brandName)
            {

                return baseCustomer.View();
            }

        // POST api/Registration
        [HttpPost]
        public async Task<IActionResult> RegisterCustomer([FromBody]string Customer)
        {
            try

            {
                if (!ModelState.IsValid && string.IsNullOrEmpty(Customer))
                    return BadRequest();

                JsonResult jsonCustomer = Json(Customer);
                string brandName = jsonCustomer.Value.ToString();
                var obj = CustomerFactory.Create(brandName);
                if(obj!=null)
                {
                    dbContext.Add(obj);
                   await dbContext.SaveChangesAsync();
                }

                return new OkObjectResult(Response.StatusCode);

            }

            catch (Exception)
            {
                throw;

            }
        }
    }
}
