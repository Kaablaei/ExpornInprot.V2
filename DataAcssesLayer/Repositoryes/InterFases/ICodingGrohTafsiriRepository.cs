using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcssesLayer.Repositoryes.InterFases
{
    public interface ICodingGrohTafsiriRepository
    {
        public void Add(CodingGrohTafsili CodingGrohTafsili);
        public CodingGrohTafsili GetByCode(int Codegeoh);

        public List<CodingGrohTafsili> GetAll();
        public void Edit(CodingGrohTafsili CodingGrohTafsili);

    }

    public class CodingGrohTafsiriRepository : BaseRepository<CodingGrohTafsili>, ICodingGrohTafsiriRepository
    {
   

        public CodingGrohTafsiriRepository(AppDbcontext context) :base(context)
        {
         
        }

     

        public void Edit(CodingGrohTafsili CodingGrohTafsili)
        {
            var existingItem = _context.CodingGrohTafsili.SingleOrDefault(p => p.Code == CodingGrohTafsili.Code);
            existingItem.Name = CodingGrohTafsili.Name;

            _context.CodingGrohTafsili.Update(existingItem);
            _context.SaveChanges();
        }

        public CodingGrohTafsili GetByCode(int Codegeoh)
        {
            return _context.CodingGrohTafsili.SingleOrDefault(p => p.Code == Codegeoh);
        
        }
    }
}
