using static webapiDotNetTrainingGround.Controllers.DevelopersController;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var db = new Db();
builder.Services.AddSingleton<Db>(db);
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

app.UseHttpsRedirection(); // to do redirection to https when using http

app.UseAuthorization(); // allows users to be authorized

app.MapControllers(); // tells the application to use a controllers with the default conventions.

app.Run();
