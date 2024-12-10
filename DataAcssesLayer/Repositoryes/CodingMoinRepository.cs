using DataAcssesLayer.Repositoryes.InterFases;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcssesLayer.Repositoryes
{
    public class CodingMoinRepository : ICodingMoinRepository
    {

        private AppDbcontext _db;
        public CodingMoinRepository(AppDbcontext db)
        {

            _db = db;
        }
        public void Add(CodingMoind CodingMoind)
        {
            _db.CodingMoind.Add(CodingMoind);
            _db.SaveChanges();

        }

        public List<CodingMoind> GetAll()
        {
            return _db.CodingMoind.ToList();
        }

        public CodingMoind GetByCodeKoll(int CodeMoin)
        {
            return _db.CodingMoind.SingleOrDefault(p => p.CodeMoin == CodeMoin);
        }
    }
}
