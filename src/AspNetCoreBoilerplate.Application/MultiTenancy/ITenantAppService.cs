using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AspNetCoreBoilerplate.MultiTenancy.Dto;

namespace AspNetCoreBoilerplate.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
