using Microsoft.AspNetCore.Mvc;
using Repository.RepositoryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShopAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class StoreController : Controller
   {
    public IStoreData Context;

    public StoreController(IStoreData storContext)
    {
      Context = storContext;
    }

    [HttpGet]
    [Route("/all")]
    public IActionResult GetStores()
    {
      return Ok(Context.GetAllStores());
    }

 
   }
}
