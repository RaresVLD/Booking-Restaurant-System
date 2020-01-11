using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using RestaurantServiceProvider.Crawlers;
using RestaurantServiceProvider.Service;
using RestaurantServiceProvider.ServiceRepository;

namespace RestaurantServiceProvider
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


            services.AddMvc(option => option.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
            //var connectionString = @"Server=(localdb)\mssqllocaldb;Database=Restaurant_DBNewFinal;Trusted_Connection=True;";
            var connectionString = "Server=localhost,1432; Database=BookingRestaurant_DBFinal; User=SA; Password=reallyStrongPwd123";
            services.AddDbContext<RestaurantServiceProviderContext>(options => options.UseSqlServer(connectionString));


            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IRestaurantRepository, RestaurantRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IBookingRepository, BookingRepository>();

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IRestaurantService, RestaurantService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IBookingService, BookingService>();



            services.AddControllers();
            services.AddCors();
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

            app.UseCors(x => x
             .AllowAnyOrigin()
             .AllowAnyMethod()
             .AllowAnyHeader()
         );

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
