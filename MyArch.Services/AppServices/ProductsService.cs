using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MyArch.BusinessLogic.Dtos;
using MyArch.BusinessLogic.Intefaces;
using MyArch.BusinessLogic.Validators;
using MyArch.Core.Entities;
using MyArch.Core.Interfaces.ApiResponse;
using MyArch.Core.Interfaces.Bases;
using static MyArch.BusinessLogic.Response.ApiResponseHandler;
namespace MyArch.BusinessLogic.AppServices
{
    public class ProductsService : AppService, IProductsService
    {
        public ProductsService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public async Task<IApiResponse<ProductDto>> CreateProduct(Product product)
        {
            var validator = new ProductValidator();
            ValidationResult validatorResult = validator.Validate(product);

            if (!validatorResult.IsValid)
            {
                throw new ValidationException(validatorResult.Errors);
            }

            product.Category = (await UnitOfWork.Categories.GetByIdAsync(product.CategoryId))!;
            await UnitOfWork.Products.InsertAsync(product);
            await UnitOfWork.CommitAsync();

            var result = Mapper.Map<ProductDto>(product);

            return Success(result);
        }
        public async Task<IApiResponse<List<ProductDto>>> GetAllProducts()
        {
            var products = await UnitOfWork.Products.GetAllAsync();
            var result = Mapper.Map<List<ProductDto>>(products);

            #region anoher way (best performance)
            //var products = await UnitOfWork.Products.GetWhere(p => p.Id > 0)
            //                                        .Select(p => new ProductDto(
            //                                            p.Id, p.Name, p.Price, p.Description, p.Category.Name)
            //                                        )
            //                                        .ToListAsync();
            //var result = products;

            //return result;
            #endregion

            return Success(result);
        }
    }
}
