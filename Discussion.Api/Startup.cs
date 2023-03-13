using Discussion.Repository;
using Discussion.Repository.Implementations;
using Discussion.Repository.Interfaces;
using Discussion.Service.Implementations;
using Discussion.Service.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace Discussion.Api
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

            services.AddDbContext<ApplicationContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("DiscussionConnection"),
                 options => options.MigrationsAssembly("Discussion.Repository")));

            services.AddCors(options =>
             options.AddDefaultPolicy(
                 builder =>
                 {
                     builder
                      .AllowAnyMethod()
                      .AllowAnyHeader()
                     .AllowCredentials()
                     .WithExposedHeaders("WWW-Authenticate")
                     .WithOrigins(
                         Configuration["WebBaseUrl"]
                         );
                 }
             ));

            MapServices(services);
            MapRepositories(services);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Discussion.Api", Version = "v1" });
            });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Discussion.Api v1"));
            }

            app.UseCors();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
        private void MapServices(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDiscussionService, DiscussionService>();
        }
        private void MapRepositories(IServiceCollection services)
        {

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IDiscussionRepository, DisccusionRepository>();
        }
    }
}
