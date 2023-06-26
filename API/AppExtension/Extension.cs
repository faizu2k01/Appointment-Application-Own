using APi.Services;
using APi.Services.IServices;
using infrastructure.DadabaseContext;
using infrastructure.EFRepositories;
using infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace APi.AppExtension
{
    public static class Extension
    {
        public static IServiceCollection GetServices(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            services.AddIdentityCore<AppUser>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<DataContext>();


            services.AddTransient<IAppoinmentProcess, AppointmentProcess>();
            services.AddTransient<IRepository, Repository>();
            return services;
        }
    }
}
