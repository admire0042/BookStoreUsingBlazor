using Blazored.LocalStorage;
using Blazored.SessionStorage;
using MatBlazor;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyBookAppBlazor.Data;
using MyBookAppBlazor.Data.APIServices;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookAppBlazor
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddSingleton<IAuthorService, AuthorService>();
            services.AddSingleton<IPublisherService, PublisherService>();
            services.AddBlazoredSessionStorage(); //for session storage
            services.AddBlazoredLocalStorage(); //for local storage

            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();//Now we have to tell our Application
            //route that now we are expecting CustomAuthenticationStateProvider as parameter i.e we are expecting AuthenticationStateProvider
            //as cascading parameter which could be passed accross application so that we can use it...so to do dis, go to App.razor

            InjectRefitServiceApi(services);

            services.AddMatBlazor();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }

        private void InjectRefitServiceApi(IServiceCollection services)//for the Refit
        {
            services.AddHttpClient("BookApi", c =>
            {
                c.BaseAddress = new Uri(Configuration["BaseUrl"]);
            }).AddTypedClient(x => RestService.For<IAuthorApiService>(x));
        }
    }
}
