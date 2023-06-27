using Microsoft.AspNetCore.Mvc;
using WebAppSession_4.Contex;

namespace WebAppSession_4.Repository
{
    public class ProductRepo:IProductRepo
    {
        readonly ApplicationDbCon _Context;
        public ProductRepo(ApplicationDbCon context)
        {
            _Context = context;
        }

        public List<Product> GetProduct()
        {

            return _Context.Products.ToList();
        }

      
    }
}
