using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppSession_4.Contex;
using WebAppSession_4.Repository;

namespace WebAppSession_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly public IProductRepo _ProductRepo;
        public ProductController(IProductRepo productRepo)
        {
            _ProductRepo = productRepo;
        }
        [HttpGet]
        public ActionResult GetProduct()
        {
            List<Product> allpro= _ProductRepo.GetProduct();
            return Ok(allpro);
        }
    }
}
