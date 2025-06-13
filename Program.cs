using EquipamentosApi.Services;
using EquipamentosApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 🔧 Serviços antes do builder.Build()
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=equipamentos.db"));

builder.Services.AddScoped<EquipamentoService>();

builder.Services.AddControllers();

// ✅ Adicione o CORS aqui, ANTES do Build
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTudo",
        policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();

// ✅ Inicialização do banco
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.Migrate();
    DbInitializer.Initialize(dbContext);
}

// ✅ Middleware
app.UseCors("PermitirTudo");
app.UseStaticFiles();
app.UseAuthorization();
app.MapControllers();
app.Run();
