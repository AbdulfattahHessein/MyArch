using Microsoft.AspNetCore.Mvc;
using MyArch.Services.Intefaces;
using SchoolProject.Api.Baises;

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
    }
}
