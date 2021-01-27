using System;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shop.Application.Cart;
using Shop.Database;
using Shop.Domain.Infrastructure;
using Shop.UI.Infrastructure;
using Stripe;


namespace Shop.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }

        public IConfiguration _config { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //to inject Http accessor into our Isession services
            services.AddHttpContextAccessor();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            //adding the database in the next line
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(_config["DefaultConnection"]));

            services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireDigit = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredUniqueChars = 1;

            })
                .AddEntityFrameworkStores<ApplicationDbContext>();

            //Changing LoginPath on clicking "Admin" link from Index.cshtml to avoid broiler plate error
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Accounts/Login";
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", policy => policy.RequireClaim("Role" , "Admin"));
               // options.AddPolicy("Manager", policy => policy.RequireClaim("Role" , "Manager"));
                //Making the Admin have both manager and admin accesses
                options.AddPolicy("Manager", policy => policy
                      .RequireAssertion(context => 
                          context.User.HasClaim("Role", "Manager")
                            || context.User.HasClaim("Role", "Admin")));
            });

            services.AddMvc()
                //Authorizing the entire Admin folder
                .AddRazorPagesOptions(options =>
                {
                    options.Conventions.AuthorizeFolder("/Admin");
                    options.Conventions.AuthorizePage("/Admin/ConfigureUsers" ,  "Admin");
                })
                
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddFluentValidation( x => x.RegisterValidatorsFromAssembly(typeof(Startup).Assembly));
            
             
            services.AddSession(options =>
            {
                options.Cookie.Name = "Cart";
                options.Cookie.MaxAge = TimeSpan.FromMinutes(20);
            });

                       
            //Stripe configuration
            StripeConfiguration.ApiKey = _config.GetSection("Stripe")["SecretKey"];

            services.AddApplicationServices();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCookiePolicy();
            app.UseSession();

            app.UseAuthentication();
                
            app.UseMvcWithDefaultRoute();
        }
    }
}
