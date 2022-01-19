using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Registrarse.Data;
using Registrarse.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse
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

            String cadenaconexion = Configuration.GetConnectionString("cadenahospitalazure");

            services.AddTransient<RepositoryPersona>();
            services.AddDbContext<PersonasContext>(options => options.UseSqlServer(cadenaconexion));

           
            services.AddTransient<RepositoryCoche>();
            services.AddDbContext<PersonasContext>(options => options.UseSqlServer(cadenaconexion));

            
            services.AddTransient<RepositoryChasi>();
            services.AddDbContext<PersonasContext>(options => options.UseSqlServer(cadenaconexion));

            
            services.AddTransient<RepositoryModelo>();
            services.AddDbContext<PersonasContext>(options => options.UseSqlServer(cadenaconexion));

           
            services.AddTransient<RepositoryMarca>();
            services.AddDbContext<PersonasContext>(options => options.UseSqlServer(cadenaconexion));

           
            services.AddTransient<RepositoryImagen>();
            services.AddDbContext<PersonasContext>(options => options.UseSqlServer(cadenaconexion));

           
            services.AddTransient<RepositoryRegistro>();
            services.AddDbContext<PersonasContext>(options => options.UseSqlServer(cadenaconexion));

           
            services.AddTransient<RepositoryRestaurante>();
            services.AddDbContext<PersonasContext>(options => options.UseSqlServer(cadenaconexion));

            services.AddTransient<RepositoryPack>();
            services.AddDbContext<PersonasContext>(options => options.UseSqlServer(cadenaconexion));

            services.AddMvc();




            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Registrarse", Version = "v1" });
            });
            
            services.AddControllers();
        }

      
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Registrarse v1"));
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
