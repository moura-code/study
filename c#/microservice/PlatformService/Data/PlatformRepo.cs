using PlatformService.Data;
using PlatformService.Models;

namespace PlataformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;
        public PlatformRepo(AppDbContext _context)
        {
            _context = _context;
        }
        public void CreatePlataform(Platform plat)
        {
            if (plat == null)
            {
                throw new ArgumentNullException();
            }
            return;
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }

        public Platform GetPlatformByid(int id) => _context.Platforms.FirstOrDefault(p => p.Id == id);

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}