using System.Threading.Tasks;
using AspNetCoreBoilerplate.Configuration.Dto;

namespace AspNetCoreBoilerplate.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
