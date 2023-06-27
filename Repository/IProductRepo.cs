using Microsoft.AspNetCore.Mvc;
using WebAppSession_4.Contex;

namespace WebAppSession_4.Repository
{
    public interface IProductRepo
    {
        List<Product> GetProduct();
    }
}
