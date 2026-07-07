using BookCurator.BLL.Services.Abstract;
using BookCurator.BLL.Services.Concrete;
using BookCurator.DAL;
using BookCurator.DAL.Repositories.Abstract;
using BookCurator.DAL.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookCurator.MVC
{
    public static class MVCServiceRegistration
    {
        public static IServiceCollection AddMVCServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBookService, BookService>();

            return services;
        }
    }
}
