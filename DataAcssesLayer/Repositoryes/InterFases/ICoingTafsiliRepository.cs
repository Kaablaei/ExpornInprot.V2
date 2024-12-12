using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcssesLayer.Repositoryes.InterFases
{
    public interface ICoingTafsiliRepository
    {
        public void Add(CodingTafsili codingTafsili);
        public CodingTafsili GetByCode(int Code);

        public List<CodingTafsili> GetAll();
    }

    public class CoingTafsiliRepository : BaseRepository<CodingTafsili>, ICoingTafsiliRepository
    {
        public CoingTafsiliRepository(AppDbcontext context) : base(context)
        {
        }

        public CodingTafsili GetByCode(int Code)
        {
          return  _context.CodingTafsili.SingleOrDefault(p => p.CodeTafsili == Code);
        }
    }

}
