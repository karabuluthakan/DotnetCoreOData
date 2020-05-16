using Api.DataAccess;
using Api.Models;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Api
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
            services.AddOData();
            services.AddControllers();
            services.AddDbContext<GeolocationDbContext>(options =>
            {
                options.UseSqlite(Configuration.GetConnectionString("DefaultDatabaseConnection"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Country>("Countries");
            builder.EntitySet<City>("Cities");
            builder.EntitySet<Region>("Regions");
            builder.EntitySet<Continental>("Continentals");

            #region Actions

            builder.EntityType<Country>().Action("CountryNameAndSymbol").Returns<string>();
            builder.EntityType<Country>().Collection.Action("CountryNameAndSymbolWithParameter")
                .Returns<string>()
                .Parameter<int>("countryId");

            var action = builder.EntityType<Country>().Collection.Action("CountrySummary").Returns<string>();
            action.Parameter<string>("name");
            action.Parameter<string>("unCode");
            action.Parameter<string>("alpha2Code");

            builder.EntityType<Country>().Collection.Action("UserData").Returns<string>().Parameter<User>("user");

            #endregion

            #region Functions

            builder.EntityType<Country>().Collection.Function("CountryCount").Returns<int>();
            
            var function = builder.EntityType<Country>().Collection.Function("Multiple").Returns<int>();
            function.Parameter<int>("number1");
            function.Parameter<int>("number2");
            function.Parameter<int>("number3");

            #endregion

            builder.Function("GetUser").Returns<string>();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.Select().Expand().OrderBy().MaxTop(100).Count().Filter();
                endpoints.MapODataRoute("odata", "odata", builder.GetEdmModel());
                endpoints.MapControllers();
            });
        }
    }
}