using AutoMapper;
using MyArch.Core.Interfaces.Bases;
using MyArch.Services.Dtos;
using MyArch.Services.Intefaces;
using MyArch.Services.Response;

using static MyArch.Services.Response.ApiResponseHandler;
namespace MyArch.Services.AppServices
{
    public class ProductsService : AppService, IProductsService
    {
        public ProductsService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        //public async Task<List<ProductDto>> GetAllProducts()
        public async Task<ApiResponse<List<ProductDto>>> GetAllProducts()
        {
            var products = await UnitOfWork.Products.GetAllAsync(p => p.Category);
            var result = Mapper.Map<List<ProductDto>>(products);

            //var products = await UnitOfWork.Products.GetWhere(p => p.Id > 0)
            //                                        .Select(p => new ProductDto(
            //                                            p.Id, p.Name, p.Price, p.Description, p.Category.Name)
            //                                        )
            //                                        .ToListAsync();
            //var result = products;

            //return result;
            return Success(result);
        }
    }
}
