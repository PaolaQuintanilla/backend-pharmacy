using Pharmacy.Application.Commons.Bases.Response;
using Pharmacy.Application.Dtos.DocumentType.Response;

namespace Pharmacy.Application.Interfaces
{
    public interface IDocumentTypeApplication
    {
        Task<BaseResponse<IEnumerable<DocumentTypeResponseDto>>> ListDocumentTypes();
    }
}
