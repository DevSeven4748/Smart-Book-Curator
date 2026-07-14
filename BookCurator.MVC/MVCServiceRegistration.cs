using BookCurator.BLL.Options;
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
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<ITvShowRepository, TvShowRepository>();

            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<ITvShowService, TvShowService>();

            services.Configure<GeminiOptions>(configuration.GetSection("Gemini"));
            services.AddHttpClient<IRecommendationService, GeminiRecommendationService>();

            return services;
        }
    }
}
