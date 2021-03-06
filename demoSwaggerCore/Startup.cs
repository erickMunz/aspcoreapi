﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using demoSwaggerCore.Modelos;
using System.Reflection;
using System.IO;
namespace demoSwaggerCore
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
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<BEPENSAContext>((serviceProvider, options) =>
                     options.UseSqlServer(Configuration.GetConnectionString("BepensaContext"))
                                         .UseInternalServiceProvider(serviceProvider));
            services.AddMvc();
            
            services.AddSwaggerGen(c =>
                    {
                        c.SwaggerDoc("v1", new Info {
                            Title = "API Bepensa",
                            Version = "v1",
                            Description = "Especificacion de servicios RESTful para la integración BEPENSA",
                            Contact = new Contact
                            {
                                Name = "Christian Badillo",
                                Email = "bamx.praxis.com.mx",
                            }
                        });
                        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                        c.IncludeXmlComments(xmlPath);
                    }
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c=> {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Bepensa V1");
            }
            );
            app.UseMvc();
        }
    }
}
