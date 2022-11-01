using PlatformService.Models;
namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();

        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformByid(int id);
        void CreatePlataform(Platform plat);
    }
}