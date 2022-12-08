using Bacchus.Business;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;
using Bacchus.DataAccess.DbContext;
using Bacchus.DataAccess.UnitOfWork;
using Bacchus.DataAccess.UnitOfWork.Repositories;
using Bacchus.Service;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// injection des services
builder.Services.AddScoped<IService<AddressResource>, AddressService>();
builder.Services.AddScoped<IService<GrapeVarietyResource>, GrapeVarietyService>();
builder.Services.AddScoped<IService<OrderResource>, OrderService>();
builder.Services.AddScoped<IService<OrderLineResource>, OrderLineService>();
builder.Services.AddScoped<IService<OrderStatusResource>, OrderStatusService>();
builder.Services.AddScoped<IService<OrderTypeResource>, OrderTypeService>();
builder.Services.AddScoped<IService<RoleResource>, RoleService>();
builder.Services.AddScoped<IService<SupplierResource>, SupplierService>();
builder.Services.AddScoped<IService<UserResource>, UserService>();
builder.Services.AddScoped<IService<UserRoleResource>, UserRoleService>();
builder.Services.AddScoped<IService<WineResource>, WineService>();
builder.Services.AddScoped<IService<WineFamilyResource>, WineFamilyService>();

// injection des repositories
builder.Services.AddScoped<IRepository<AddressEntity>, AddressRepository>();
builder.Services.AddScoped<IRepository<GrapeVarietyEntity>, GrapeVarietyRepository>();
builder.Services.AddScoped<IRepository<OrderEntity>, OrderRepository>();
builder.Services.AddScoped<IRepository<OrderWineEntity>, OrderLineRepository>();
builder.Services.AddScoped<IRepository<OrderStatusEntity>, OrderStatusRepository>();
builder.Services.AddScoped<IRepository<OrderTypeEntity>, OrderTypeRepository>();
builder.Services.AddScoped<IRepository<RoleEntity>, RoleRepository>();
builder.Services.AddScoped<IRepository<SupplierEntity>, SupplierRepository>();
builder.Services.AddScoped<IRepository<UserEntity>, UserRepository>();
builder.Services.AddScoped<IRepository<UserRoleEntity>, UserRoleRepository>();
builder.Services.AddScoped<IRepository<WineEntity>, WineRepository>();
builder.Services.AddScoped<IRepository<WineFamilyEntity>, WineFamilyRepository>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<BacchusDbContext>();

builder.Services.AddMvc();
builder.Services.AddCors();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddDbContext<BacchusDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("BacchusDb"));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
