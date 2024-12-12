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
        public CodingTafsili GetByCode(int CodeMoin);

        public List<CodingTafsili> GetAll();
    }

    public class CoingTafsiliRepository : ICoingTafsiliRepository
    {
        private AppDbcontext _db;
        public CoingTafsiliRepository(AppDbcontext db)
        {

            _db = db;
        }
        public void Add(CodingTafsili codingTafsili)
        {
            _db.CodingTafsili.Add(codingTafsili);
            _db.SaveChanges();
        }

        public List<CodingTafsili> GetAll()
        {
            return _db.CodingTafsili.ToList();
        }

        public CodingTafsili GetByCode(int CodeMoin)
        {
            return _db.CodingTafsili.SingleOrDefault(p => p.CodeTafsili == CodeMoin);
        }
    }

}
