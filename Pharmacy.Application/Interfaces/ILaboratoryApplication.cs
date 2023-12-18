using Pharmacy.Application.Commons.Bases.Response;
using Pharmacy.Application.Dtos.Laboratory.Request;
using Pharmacy.Application.Dtos.Laboratory.Response;
using Pharmacy.Utilities.Search.Entities;

namespace Pharmacy.Application.Interfaces
{
    public interface ILaboratoryApplication
    {
        Task<BaseResponse<LaboratoryResponseDto>> CreateLaboratory(LaboratoryDto data);
        Task<BaseResponse<Guid>> RemoveLaboratoryAsync(Guid id);
        Task<BaseResponse<PagedList<LaboratoryResponseDto>>> GetLaboratoriesAsync(int current, int pageSize);
        Task<BaseResponse<int>> getTotalAsync();
    }
}
