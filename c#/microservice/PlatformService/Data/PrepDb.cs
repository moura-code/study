
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
            
        }
    }
}