using AcmeProducts.Application.DTOs.Account.Requests;
using AcmeProducts.Application.DTOs.Account.Responses;
using AcmeProducts.Application.Wrappers;
using System.Threading.Tasks;

namespace AcmeProducts.Application.Interfaces.UserInterfaces
{
    public interface IAccountServices
    {
        Task<BaseResult<string>> RegisterGostAccount();
        Task<BaseResult> ChangePassword(ChangePasswordRequest model);
        Task<BaseResult> ChangeUserName(ChangeUserNameRequest model);
        Task<BaseResult<AuthenticationResponse>> Authenticate(AuthenticationRequest request);
        Task<BaseResult<AuthenticationResponse>> AuthenticateByUserName(string username);

    }
}
