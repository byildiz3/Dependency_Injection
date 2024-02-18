using DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//////............................SCOPED.......................///////
//Uygulama aya�a kalkt���nda ve her requestte  1 adet yeni instance yarat�r ve g�nderir.
//builder.Services.AddScoped<INumGenerator, NumGeneretor>();
//builder.Services.AddScoped<INumGenerator2, NumGenerator2>();

//////............................TRANSIET.......................///////

//Uygulama aya�a kalkt���nda �al���r ama her yeni requestte 1 adet �retir. AddScoped ile fark� => Ayn� request �zerinden scoped ayn�s�n� kullan�rken Transiet yeni yarat�r.
builder.Services.AddTransient<INumGenerator, NumGeneretor>(); 
builder.Services.AddTransient<INumGenerator2, NumGenerator2>(); 


//////............................SINGLETON.......................///////

//Uygulama aya�a kalkt���nda �al���r ve uygulama kapanana kadar sabit kal�r.
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
