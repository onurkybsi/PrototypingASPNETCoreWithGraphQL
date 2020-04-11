using GraphiQl;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PrototypingASPNETCoreWithGraphQL.Models;
using PrototypingASPNETCoreWithGraphQL.Models.GraphQLModels;

namespace PrototypingASPNETCoreWithGraphQL
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<PrototypingASPNETCoreWithGraphQLDbContext>(options => options.UseSqlServer(Configuration["Data:PrototypingASPNETCoreWithGraphQL:ConnectionString"]));
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<PersonQuery>();
            services.AddSingleton<PersonType>();
            var sp = services.BuildServiceProvider();
            services.AddSingleton<ISchema>(new PersonSchema(new FuncDependencyResolver(type => sp.GetService(type))));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseGraphiQl();
            app.UseMvcWithDefaultRoute();
        }
    }
}
