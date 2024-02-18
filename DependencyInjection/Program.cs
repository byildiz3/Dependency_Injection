using DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//////............................SCOPED.......................///////
//Uygulama ayaða kalktýðýnda ve her requestte  1 adet yeni instance yaratýr ve gönderir.
//builder.Services.AddScoped<INumGenerator, NumGeneretor>();
//builder.Services.AddScoped<INumGenerator2, NumGenerator2>();

//////............................TRANSIET.......................///////

//Uygulama ayaða kalktýðýnda çalýþýr ama her yeni requestte 1 adet üretir. AddScoped ile farký => Ayný request üzerinden scoped aynýsýný kullanýrken Transiet yeni yaratýr.
builder.Services.AddTransient<INumGenerator, NumGeneretor>(); 
builder.Services.AddTransient<INumGenerator2, NumGenerator2>(); 


//////............................SINGLETON.......................///////

//Uygulama ayaða kalktýðýnda çalýþýr ve uygulama kapanana kadar sabit kalýr.
//builder.Services.AddSingleton<INumGenerator, NumGeneretor>(); 

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
