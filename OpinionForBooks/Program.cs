using AutoMapper;
using BooksClass;
using Microsoft.EntityFrameworkCore;
using OpinionForBooks.AutoMapper;
using OpinionForBooks.Controllers;
using OpinionForBooks.Domain;
using OpinionForBooks.DomainServices;
using OpinionForBooks.IAppServices;
using OpinionForBooks.IDomainService;
using OpinionForBooks.InterfacesServices;
using OpinionForBooks.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IReviewAppServices, ReviewService>();
builder.Services.AddScoped<IReviewDomainService, ReviewDomainService>();
builder.Services.AddScoped<IBookAppService,BookService>();
builder.Services.AddScoped<IBookDomainService, BookDomainService>();
builder.Services.AddScoped<IUserAppService, UserService>();
builder.Services.AddScoped<IUserDomainService, UserDomainService>();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ControlBoxContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ReviewBooks")));


var mappingConf = new MapperConfiguration((options) =>
{
    options.AddProfile<MapperProfile>();
});

var mapper = mappingConf.CreateMapper();
builder.Services.AddSingleton<IMapper>(mapper);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost4200", builder =>
    {
        builder.WithOrigins("http://localhost:4200")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dataContex = scope.ServiceProvider.GetRequiredService<ControlBoxContext>();
    dataContex.Database.Migrate();
}
app.UseCors("AllowLocalhost4200");



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
