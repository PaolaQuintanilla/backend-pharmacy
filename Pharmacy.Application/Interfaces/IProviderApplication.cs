using Pharmacy.Application.Commons.Bases.Request;
using Pharmacy.Application.Commons.Bases.Response;
using Pharmacy.Application.Dtos.Provider.Request;
using Pharmacy.Application.Dtos.Provider.Response;

namespace Pharmacy.Application.Interfaces
{
    public interface IProviderApplication
    {
        Task<BaseResponse<IEnumerable<ProviderResponseDto>>> ListProviders(BaseFiltersRequest filters);
        Task<BaseResponse<ProviderByIdResponseDto>> ProviderById(int providerId);
        Task<BaseResponse<bool>> RegisterProvider(ProviderRequestDto requestDto);
        Task<BaseResponse<bool>> EditProvider(int providerId, ProviderRequestDto requestDto);
        Task<BaseResponse<bool>> RemoveProvider(int providerId);
    }
}