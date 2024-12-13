using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcssesLayer.Repositoryes.InterFases
{

    public interface IkalaRepository 
    {
        public List<Kala> GetAll();
        public void Add(Kala kala);

    }
    public class kalaRepository : BaseRepository<Kala>, IkalaRepository
    {
        public kalaRepository(AppDbcontext context) : base(context)
        {

        }
    }
    
    public interface IDriversRepository
    {
        public List<Drivers> GetAll();
     
 
        public void Add(Drivers Drivers);



        public List<Drivers> GetIrani();
        public List<Drivers> GetIraqi();


    }
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
