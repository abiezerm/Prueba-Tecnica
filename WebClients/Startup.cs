using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebClients.Models;
using Microsoft.EntityFrameworkCore;

namespace WebClients
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}
		// Allow CORDS VARRIABLE
		readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			//services.AddControllers().AddNewtonsoftJson();
			//Adding a list of allowed domains
			services.AddCors(options =>
			{
				options.AddPolicy(name: MyAllowSpecificOrigins,
								  builder =>
								  {
									  builder.WithOrigins("http://localhost:*",
														  "*:*");
								  });
			});
			services.AddControllersWithViews();
			// ********************************************************************************************************************************************************
			//Here we configurate the connection with the server
			// ********************************************************************************************************************************************************
			var connectionStr = @"Data Source=MIA;Initial Catalog=CFTEST;Integrated Security=True";
			// Inject Dependency for DB Context
			services.AddDbContext<myDBContext>(options => options.UseSqlServer(connectionStr));
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
			}
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();
			// USE MY CORDS 
			app.UseCors(MyAllowSpecificOrigins);
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
