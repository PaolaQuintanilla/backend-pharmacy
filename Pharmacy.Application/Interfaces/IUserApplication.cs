using Pharmacy.Application.Commons.Bases.Response;
using Pharmacy.Application.Dtos.User.Request;

namespace Pharmacy.Application.Interfaces
{
    public interface IUserApplication
    {
        Task<BaseResponse<bool>> RegisterUser(UserRequestDto requestDto);
    }
}