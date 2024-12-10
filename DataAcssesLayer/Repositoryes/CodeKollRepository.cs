using Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcssesLayer.Repositoryes
{
    public class CodeKollRepository : ICodingKollRepository
    {

        private AppDbcontext _appdbcontext;

        public CodeKollRepository(AppDbcontext appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }


        public void Add(CodeingKoll codeingKoll)
        {
            _appdbcontext.CodeingKoll.Add(codeingKoll);
            _appdbcontext.SaveChanges();
        }

        public List<CodeingKoll> GetAll()
        {
          
            return _appdbcontext.CodeingKoll.ToList();
        }
        public CodeingKoll GetByCodeKoll(int CodeKoll)
        {
            var item = _appdbcontext.CodeingKoll.SingleOrDefault(p => p.CodeKoll == CodeKoll);
            return item;
        }
    }
}
