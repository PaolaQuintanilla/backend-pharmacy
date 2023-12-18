using Pharmacy.Application.Commons.Bases.Response;
using Pharmacy.Application.Dtos.User.Request;

namespace Pharmacy.Application.Interfaces
{
    public interface IAuthApplication
    {
        Task<BaseResponse<string>> Login(TokenRequestDto requestDto, string authType);
        Task<BaseResponse<string>> LoginWithGoogle(string credentials, string authType);
    }
}