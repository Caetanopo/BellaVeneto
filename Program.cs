namespace BellaVeneto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            // Habilita arquivos padrão (procura por index.html) e arquivos estáticos
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.Run();

        }
    }
}
