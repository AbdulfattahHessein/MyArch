using Microsoft.AspNetCore.Mvc;
using MyArch.Api.Bases;
using MyArch.BusinessLogic.Intefaces;
using MyArch.Core.Entities;

namespace MyArch.Api.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class ProductsController : AppControllerBase
    {
        private readonly IProductsService _productsService;
        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await _productsService.GetAllProducts();

            return ApiResult(response);

        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            var response = await _productsService.CreateProduct(product);

            return ApiResult(response);

        }
    }
}
