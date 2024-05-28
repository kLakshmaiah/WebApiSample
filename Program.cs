using WebApplication5.IRepository;
using WebApplication5.Repository;

var builder = WebApplication.CreateBuilder(args);

// Service or DI(Dependency)
builder.Services.Add(new ServiceDescriptor(
    typeof(IStudentService),
    typeof(StudentService),
    ServiceLifetime.Transient));//
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

app.Run();
