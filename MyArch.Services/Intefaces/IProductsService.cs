using MyArch.Services.Dtos;
using MyArch.Services.Response;

namespace MyArch.Services.Intefaces
{
    public interface IProductsService
    {
        Task<ApiResponse<List<ProductDto>>> GetAllProducts();
    }
}
