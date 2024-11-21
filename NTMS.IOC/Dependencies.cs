using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NTMS.BLL.Services;
using NTMS.DAL.Repository;
using NTMS.DAL.Repository.Abstract;
using NTMS.Model;
using NTMS.Utility;

namespace NTMS.IOC
{
    public static class Dependencies
    {
        public static void InjectDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NtmsContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("TmsConnection"));
            });
            services.AddTransient(typeof(IGenericRepository<>),typeof(GenericRepository<>));

            services.AddAutoMapper(typeof(AytoMapperProfile));
            services.AddScoped<BLL.Services.Abstract.ITenantService, TenantService>();
            services.AddScoped<BLL.Services.Abstract.IFlatService, FlatService>();
            services.AddScoped<BLL.Services.Abstract.IEmeterService, EmeterService>();
            services.AddScoped<BLL.Services.Abstract.IEreadingService, EreadingService>();

        }
    }
}
