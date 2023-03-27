using TaskAPI.Services.Todos;
using TaskAPI.Services.Authors;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
}).AddXmlDataContractSerializerFormatters();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton(); //only one instance for application  ------- note
//builder.Services.AddScoped(); //new object is created per request
//builder.Services.AddTransient(); //always a new object is presented


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); //inject automapper-----

builder.Services.AddScoped<ITodoRepository, TodoSqlServerService>(); //dependency injection----
builder.Services.AddScoped<IAuthorRepository, AuthorSqlServerService>();

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

app.Run();
