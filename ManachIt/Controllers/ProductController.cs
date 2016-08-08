using ManachIt.DAL.Concrete;
using ManachIt.DAL.Interfaces;
using System.Web.Mvc;

namespace ManachIt.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;
        public ProductController()
        {
            _productRepository = new ProductRepository(); // TODO Dependency Injection
        }
        // GET: Product
        public ActionResult Index(int productId)
        {
            //Aqui ver si regresaremos el modelo o un ViewModel o que onda con lo de frontend
            _productRepository.Get(productId);
            return View();
        }
    }
}