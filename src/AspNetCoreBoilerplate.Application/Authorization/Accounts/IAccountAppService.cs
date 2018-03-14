using System.Threading.Tasks;
using Abp.Application.Services;
using AspNetCoreBoilerplate.Authorization.Accounts.Dto;

namespace AspNetCoreBoilerplate.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
