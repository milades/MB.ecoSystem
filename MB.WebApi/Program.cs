using MB.AuthDefinition.Entities.Identity;
using MB.WebApi.Data.dbContext;
using MB.WebApi.Data.SeedData;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;



var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");


builder.Services.AddDbContext<mb_db_context>(options => options.UseSqlServer(connectionString, 
    b => b.MigrationsAssembly(typeof(mb_db_context).Assembly.FullName)));

builder.Services.AddIdentity<Users, Roles>().AddEntityFrameworkStores<mb_db_context>().AddDefaultTokenProviders();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();


// Add services to the container.
//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

var ScopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = ScopeFactory.CreateScope())
{
    var rolemanager = scope.ServiceProvider.GetRequiredService<RoleManager<Roles>>();
    var usermanager = scope.ServiceProvider.GetRequiredService<UserManager<Users>>();
    var _db_context = scope.ServiceProvider.GetRequiredService<mb_db_context>();
    AppDataInit.SeedData(usermanager, rolemanager, _db_context);
}
app.Run();
