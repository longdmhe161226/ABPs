using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace ApiDemo.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public string GetList()
        {
            return "Getlist";
        }
        [HttpPut]
        [Route("{id}")]
        public string UpdateAsync(Guid id)
        {
            return "id:" + id;
        }
    }
}
