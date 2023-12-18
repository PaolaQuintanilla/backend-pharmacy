using Pharmacy.Application.Commons.Bases.Response;
using Pharmacy.Application.Dtos.Laboratory.Request;
using Pharmacy.Application.Dtos.Laboratory.Response;
using Pharmacy.Application.Interfaces;
using Pharmacy.Utilities.Search.Entities;

namespace Pharmacy.Application.Services
{
    public class LaboratoryApplication : ILaboratoryApplication
    {
        private readonly ILaboratoryRepository repository;
        public LaboratoryApplication(ILaboratoryRepository repository)
        {
            this.repository = repository;
        }
        public Task<BaseResponse<LaboratoryResponseDto>> CreateLaboratory(LaboratoryDto data)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<PagedList<LaboratoryResponseDto>>> GetLaboratoriesAsync(int current, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<int>> getTotalAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Guid>> RemoveLaboratoryAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
