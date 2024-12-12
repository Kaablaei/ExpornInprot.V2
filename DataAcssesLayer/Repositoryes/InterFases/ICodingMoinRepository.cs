using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcssesLayer.Repositoryes.InterFases
{
    public interface ICodingMoinRepository
    {
        public void Add(CodingMoin CodingMoind);
        public CodingMoin GetByCodeKoll(int CodeMoin);

        public List<CodingMoin> GetAll();


    }

    public class CodingMoinRepository : BaseRepository<CodingMoin>, ICodingMoinRepository
    {
        public CodingMoinRepository(AppDbcontext context) : base(context)
        {
        }

        public CodingMoin GetByCodeKoll(int CodeMoin)
        {
           return _context.CodingMoind.SingleOrDefault(p=>p.CodeMoin==CodeMoin);
        }
    }
}
