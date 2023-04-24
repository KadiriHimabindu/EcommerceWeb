
using EcommerceWeb.Models;
using EcommerceWeb.Repository;
using EcommerceWeb.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace EcommerceWeb.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public HomeController(ILogger<HomeController> logger,IUnitOfWork unitOfWork, IShoppingCartRepository shoppingCartRepository)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _shoppingCartRepository = shoppingCartRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category");
            return View(productList);
        }
        public IActionResult Details(int productId)
        {
            Product product = _unitOfWork.Product.Get(u=>u.Id==productId,includeProperties: "Category");
            return View(product);
        }
        [HttpGet]
        [Authorize]
        public IActionResult AddtoCart(int ProductId,int Count)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = "1";
            if(claimsIdentity.Name != null)
            {
                 userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
                
            }
            ShoppingCart cart = new ShoppingCart();
            cart.ProductId = ProductId;
            cart.Count = Count;
            cart.ApplicationUserId = userId;
            _shoppingCartRepository.add(cart);

            //IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category");
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}