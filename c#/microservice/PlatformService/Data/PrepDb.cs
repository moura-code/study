
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder  app){
            using(var serviceScope = app.ApplicationServices.CreateScope()){
                SendData(serviceScope.ServiceProvider.GetService<AppDbContext>());
                }
        }

        private static void SendData(AppDbContext context){
            if(!context.Platforms.Any())
            {
                Console.WriteLine("seending data");

                context.Platforms.AddRange(
                    new Platform(){Name="Dot Net",Publicher="Microsoft",Cost="Free"},
                    new Platform(){Name="SQL Server Express",Publicher="Microsoft",Cost="Free",},
                    new Platform(){Name="Kubernetes",Publicher="Clound",Cost="Free",}
                );
                context.SaveChanges();
            }else{
                Console.WriteLine("we already have data");
            }
        }
    }
}