using MiniAPI;
using System.Security.Cryptography.X509Certificates;

namespace MiniAPI
{
    public class Program 
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Olá pessoal");

            app.MapPost("/login", (MiniAPI.DTOs.LoginTDO loginDTO) =>
            {
                if (loginDTO.Email == "adm@teste" && loginDTO.Senha == "123456")
                    return Results.Ok("Login com sucesso");
                else
                    return Results.Unauthorized();

            });
            
            app.Run();
        }
    }
}
