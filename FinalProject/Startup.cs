using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FinalProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerDocument();
            services.AddDbContext<TeamNameContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("TeamNameContext")));
            services.AddDbContext<FavoriteFoodContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("FavoriteFoodContext")));
            services.AddDbContext<FavoriteVenueContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("FavoriteVenueContext")));
            services.AddDbContext<FavoriteMusicContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("FavoriteMusicContext")));
            services.AddScoped<ITeamNameContextDAO, TeamNameContextDAO>();
            services.AddScoped<IFavoriteVenueContextDAO, FavoriteVenueContextDAO>();
            services.AddScoped<IFavoriteMusicContextDAO, FavoriteMusicContextDAO>();
            services.AddScoped<IFavoriteFoodContextDAO, FavoriteFoodContextDAO>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, TeamNameContext db1, FavoriteFoodContext db2, FavoriteVenueContext db3, FavoriteMusicContext db4)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseOpenApi();
            app.UseSwaggerUi3();



            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
