using DataAcssesLayer.Repositoryes.InterFases;
using Domain;

namespace DataAcssesLayer.Repositoryes
{
    public class DriversRepository : BaseRepository<Drivers>, IDriversRepository
    {
        public DriversRepository(AppDbcontext context) : base(context)
        {

        }

        public List<Drivers> GetIrani()
        {
            return _context.Drivers.Where(p => p.IsIraqi == false).ToList();
        }

        public List<Drivers> GetIraqi()
        {
            return _context.Drivers.Where(p => p.IsIraqi == true).ToList();
        }
    }

}
