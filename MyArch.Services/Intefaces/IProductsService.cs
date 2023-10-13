using MyArch.BusinessLogic.Dtos;
using MyArch.Core.Entities;
using MyArch.Core.Interfaces.ApiResponse;
namespace MyArch.BusinessLogic.Intefaces
{
    public interface IProductsService
    {
        Task<IApiResponse<ProductDto>> CreateProduct(Product product);
        Task<IApiResponse<List<ProductDto>>> GetAllProducts();
    }
}
