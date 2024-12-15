using Domain;
using Microsoft.EntityFrameworkCore;
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
        public CodingMoin GetByCode(int CodeMoin);

        public List<CodingMoin> GetAll();
        public List<CodingMoin> GetByCodeKoll(int codeKoll);

        public void Edite(CodingMoin codingMoin);

    }

    public class CodingMoinRepository : BaseRepository<CodingMoin>, ICodingMoinRepository
    {
        public CodingMoinRepository(AppDbcontext context) : base(context)
        {
        }

        public void Edite(CodingMoin codingMoin)
        {
            var existingEntity = _context.CodingMoind.SingleOrDefault(p => p.CodeMoin == codingMoin.CodeMoin);
            if (existingEntity != null)
            {

                existingEntity.MoinName = codingMoin.MoinName;
                existingEntity.Phonenumber = codingMoin.Phonenumber;
                existingEntity.Expalein = codingMoin.Expalein;
                existingEntity.CodeKoll = codingMoin.CodeKoll;
                existingEntity.TafsiliGropId = codingMoin.TafsiliGropId;
                existingEntity.StatuseIsActive = codingMoin.StatuseIsActive;



                _context.SaveChanges();
            };
        }
        

        public CodingMoin GetByCode(int CodeMoin)
        {
           return _context.CodingMoind.SingleOrDefault(p=>p.CodeMoin==CodeMoin);
        }

        public List<CodingMoin> GetByCodeKoll(int codeKoll)
        {
            return _context.CodingMoind.Where(p => p.CodeKoll == codeKoll).ToList();
        }

    }
}
