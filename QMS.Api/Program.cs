using Microsoft.EntityFrameworkCore;
using QMS.Api.Models.QmsContext;
namespace QMS.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            //builder.Services.AddDbContext<QMSContext>(opt =>
            //    opt.UseInMemoryDatabase("TodoList"));
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<QMSContext>(options =>
              options.UseSqlServer(builder.Configuration.GetConnectionString("QmsContext")));
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            //创建数据库
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var context = services.GetRequiredService<QMSContext>();
                context.Database.EnsureCreated();
                //DbInitializer.Initialize(context);
            }
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
