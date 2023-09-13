using BuberBreakfast.Services.Breakfasts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// AddSingleton tells the framework the first time that someone requests the IBreakfastService interface, then create a new breakfast service
// object but from now on, through the lifetime of the application, everytime someone request the same interface, always use the same
// BreakfastService object. AddScoped says that within the lifetime of a single request, the first time someone request the interface,
// create a new object but from now on until we finish processing the request, everytime we create an object and request the interface,
// then return the same BreakfastService onject that was created before. AddTransient says everytime someone requests this interface,
// create a new BreakfastService object.
builder.Services.AddSingleton<IBreakfastService, BreakfastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler("/error");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
