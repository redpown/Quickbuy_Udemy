using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Quickbuy_Udemy.Dominio.Contract;
using Quickbuy_Udemy.Repositorio.Contexto;
using Quickbuy_Udemy.Repositorio.Repositorios;

namespace Quickbuy_Udemy.web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            //andre
            //criu essa variavel para pegar o json que eu criei no diretorio raiz
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("config.json", optional:false, reloadOnChange:true);
            Configuration = builder.Build();
            //comento essa chamada.
           // Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //andre
            //criar a string de conexao dentro do json
            //abra e use como exmpla,obs, ele esta para postgres
            var connectionString = Configuration.GetConnectionString("QuickBuy_Udemy_DB");//craido no json dentro da ConnectionStrings -> QuickBuy_Udemy_DB
            //adciona a classe de QuickyBuy_Udemy_DB_Entity
            //se nao aparecer btn direito em cima de dependencias-> adcionar depencias
            //ao usar o entityframework usar tb .UseLazyLoadingProxies()
            services.AddDbContext<QuickyBuy_Udemy_DB_Entity>(option => option
                                                                       .UseLazyLoadingProxies()
                                                                       .UseNpgsql(connectionString, 
                                                                                  m => m.MigrationsAssembly("Quickbuy_Udemy.Repositorio")));//caminho ou projeto onde sera gerado 
                                                                                                                                            //adicionar e remover o projeto de inicailizacao caso der erro doesn't match your migrations assembly
                                                                                                                                            //o codigo para criar ou atualixar o banco de dados
            //ele adciona as referencias dentro do angular e faz instancia
            services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

            services.AddControllersWithViews();
            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
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
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");//aqui diz que vou pegar o nome do arquivo sem o Controller
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
