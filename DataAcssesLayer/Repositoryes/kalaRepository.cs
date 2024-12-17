using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcssesLayer.Repositoryes
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


    public interface ISarfkhaneRipository
    {
        public List<sardkhane> GetAll();
        public void Add(sardkhane border);

    }
    public class SarfkhaneRipository : BaseRepository<sardkhane>, ISarfkhaneRipository
    {
        public SarfkhaneRipository(AppDbcontext context) : base(context)
        {

        }
    }


    public interface ITarkhisKarRepository
    {
        public void Add(TarkhisKar tarkhisKar);
        public List<TarkhisKar> GetAll();

        public List<TarkhisKar> GetIrani();
        public List<TarkhisKar> GetIraqi();

    }
    public class TarkhisKarRepository : BaseRepository<TarkhisKar>, ITarkhisKarRepository
    {
        public TarkhisKarRepository(AppDbcontext context) : base(context)
        {

        }

        public List<TarkhisKar> GetIrani()
        {
            return _context.TarkhisKars.Where(p => p.IsIraqi == false).ToList();
        }

        public List<TarkhisKar> GetIraqi()
        {
            return _context.TarkhisKars.Where(p => p.IsIraqi == true).ToList();
        }
    }



}
