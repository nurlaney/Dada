using AutoMapper;
using Dada.Hubs;
using Dada.Services.EmailServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository.Data;
using Repository.Repositories.AccountRepositories;
using Repository.Repositories.GroupRepositories;
using Repository.Repositories.MainRepositories;
using Repository.Repositories.PostRepositories;
using Repository.Repositories.ProfileRepositories;
using Repository.Repositories.SearchRepositories;
using Repository.Repositories.SettingsRepositories;

namespace Dada
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
            services.AddAutoMapper(typeof(Startup));
            services.AddSignalR();


            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IProfileRepository, ProfileRepository>();
            services.AddTransient<IPostRepository, PostRepository>();
            services.AddTransient<IGroupRepository, GroupRepository>();
            services.AddTransient<IMainRepositories, MainRepositories>();
            services.AddTransient<ISearchRepository, SearchRepository>();
            services.AddTransient<ISettingRepository, SettingRepository>();
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddDbContext<DadaDbContext>(options =>
                  options.UseSqlServer(Configuration.GetConnectionString("Default"),
                  x => x.MigrationsAssembly("Repository")));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapHub<NotificationHub>("/notificationhub");

            });
        }
    }
}
