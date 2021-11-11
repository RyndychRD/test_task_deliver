using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test_task_deliver_RyndychRD.Interfaces;
using test_task_deliver_RyndychRD.Repository;

namespace test_task_deliver_RyndychRD
{
    public class Startup
    {


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllersWithViews();
            services.AddMvc();
            services.AddTransient<IOrder, RepositoryOrder>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
   
            app.UseStaticFiles();

            //Тестовое наполнение базы данных
/*            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent appDBcontent = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBInitial.InitialFill(appDBcontent);
            }
*/

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Home",
                    pattern: "{controller=Home}/{action=Index}");
                endpoints.MapControllerRoute(
                    name: "ShowOrders",
                    pattern: "{controller=Home}/{action=ShowOrders}");
            });
        }
       
    }
}
