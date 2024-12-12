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
  
}
