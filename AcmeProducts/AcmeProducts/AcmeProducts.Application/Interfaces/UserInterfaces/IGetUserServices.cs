using AcmeProducts.Application.DTOs.Account.Requests;
using AcmeProducts.Application.DTOs.Account.Responses;
using AcmeProducts.Application.Wrappers;
using System.Threading.Tasks;

namespace AcmeProducts.Application.Interfaces.UserInterfaces
{
    public interface IGetUserServices
    {
        Task<PagedResponse<UserDto>> GetPagedUsers(GetAllUsersRequest model);
    }
}
