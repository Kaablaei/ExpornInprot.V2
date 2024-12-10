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
        public CodingGrohTafsili GetByCodeKoll(int Codegeoh);

        public List<CodingGrohTafsili> GetAll();

    }

    public class CodingGrohTafsiriRepository : ICodingGrohTafsiriRepository
    {
        private AppDbcontext _appdbcontext;

        public CodingGrohTafsiriRepository(AppDbcontext appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }


        public void Add(CodingGrohTafsili codingGrohTafsili)
        {
            _appdbcontext.CodingGrohTafsili.Add(codingGrohTafsili);
            _appdbcontext.SaveChanges();
        }

        public List<CodingGrohTafsili> GetAll()
        {

            return _appdbcontext.CodingGrohTafsili.ToList();
        }
        public CodingGrohTafsili GetByCodeKoll(int Code)
        {
            var item = _appdbcontext.CodingGrohTafsili.SingleOrDefault(p => p.Code == Code);
            return item;

        }
    }
}
