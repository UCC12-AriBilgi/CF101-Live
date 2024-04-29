using Microsoft.EntityFrameworkCore;
using P02_CF_wFakeData.Data;
using P02_CF_wFakeData.Service;
using Newtonsoft.Json.Serialization;




namespace P02_CF_wFakeData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<AppDbContext>();

            // Dependency Injection

            string connString = builder.Configuration.GetConnectionString("Connection"); // appsettings.json dosyasýndan öðreniliyor

            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connString));
            // Fake Data Serice de ekleniyor.

            builder.Services.AddTransient<IFakeDataService, FakeDataService>();

            // Fake servisi Json yapýsýnda çalýþacak. Bu yüzden controllerlarýma bir taným yapmam gerekiyor.
            builder.Services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ContractResolver=new DefaultContractResolver();
            });





            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}