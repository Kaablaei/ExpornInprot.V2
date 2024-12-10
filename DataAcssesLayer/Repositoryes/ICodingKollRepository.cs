using Domain;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcssesLayer.Repositoryes
{
    public interface ICodingKollRepository 
    {
        public void Add(CodeingKoll codeingKoll);
        public CodeingKoll GetByCodeKoll(int CodeKoll);

      public List<CodeingKoll> GetAll ();
    }
}
