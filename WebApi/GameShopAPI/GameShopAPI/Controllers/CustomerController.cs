using Microsoft.AspNetCore.Mvc;
using Repository.RepositoryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;

namespace GameShopAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        public ICustomerData Context;

        public CustomerController(ICustomerData custContext)
        {
            Context = custContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Context.GetAllCustomers());
        }

        [HttpGet]
        [Route("/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(Context.getCustomer(id));
        }
        [HttpPost]
        public IActionResult AddCustomer(Acustomer newCust)
        {
            return Ok(Context.CreateCustomer(newCust));
        }
    }
}
