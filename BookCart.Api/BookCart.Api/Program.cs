/*using Books.Models.Books.Data;
using Books.Services.Books;*/

using BookCart.Models.Data;
using BookCart.Services.BookCart;

var builder = WebApplication.CreateBuilder(args);

var _policyName = "CorsPolicy";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//CORS for passing data to json
//builder.Services.AddCors(c =>
//{
//    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
//});

/*var builder = WebApplication.CreateBuilder(args);*/



builder.Services.AddCors(opt =>
{
    opt.AddPolicy(name: _policyName, builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});


builder.Services.AddDbContext<BookCartDbContext>();
builder.Services.AddScoped<IBookCartService, BookCartService>();


var app = builder.Build();
// Configure the HTTP request pipeline. @if (app. Environment. IsDevelopment),

app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();
app.MapControllers();
app.UseRouting();
//CORS for passing data to json
app.UseCors(builder => builder
     .AllowAnyOrigin()
     .AllowAnyMethod()
     .AllowAnyHeader());

app.Run();
