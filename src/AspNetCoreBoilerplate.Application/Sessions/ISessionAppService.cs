using System.Threading.Tasks;
using Abp.Application.Services;
using AspNetCoreBoilerplate.Sessions.Dto;

namespace AspNetCoreBoilerplate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
