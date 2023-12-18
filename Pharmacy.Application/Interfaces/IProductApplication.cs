using Pharmacy.Application.Commons.Bases.Request;
using Pharmacy.Application.Commons.Bases.Response;
using Pharmacy.Application.Dtos.Product.Response;

namespace Pharmacy.Application.Interfaces
{
    public interface IProductApplication
    {
        Task<BaseResponse<IEnumerable<ProductResponseDto>>> ListProducts(BaseFiltersRequest filters);
        Task<BaseResponse<ProductByIdResponseDto>> ProductById(int productId);
    }
}