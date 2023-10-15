using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ToDoList.Models;

namespace ToDoList
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();

      // new line!
      DBConfiguration.ConnectionString = builder.Configuration["ConnectionStrings:DefaultConnection"];

      WebApplication app = builder.Build();

      ...

      app.Run();
    }
  }
}