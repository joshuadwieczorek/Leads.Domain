using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Leads.Domain.Contracts.v1
{
    public interface IInstaller
    {
        /// <summary>
        /// Install services.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        void InstallServices(IServiceCollection services, IConfiguration configuration);
    }
}