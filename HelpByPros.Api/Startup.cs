
using HelpByPros.Api.Model;
using HelpByPros.BusinessLogic.IRepo;
using HelpByPros.DataAccess.Entities;
using HelpByPros.DataAccess.Repo;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace PH
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

            services.AddEntityFrameworkNpgsql().AddDbContext<PH_DbContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("PHDB"));
            });

           
            services.AddScoped<ISentMessage, TwillioAPICalls>();
            
       
            // Create Gmail API service.
           


            services.AddControllers();
            services.AddScoped<IUserRepo, UserRepo>();
       


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
