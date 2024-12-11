using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CodingMoind
    {
        public int id { get; set; }
        public int CodeMoin { get; set; }  // کد حساب معین
        public string MoinName { get; set; }
    
        public string? Adrees { get; set; }
        public string? Expalein { get; set; }
        public string? Phonenumber { get; set; }
        public bool StatuseIsActive { get; set; }


        public string AccountStatuseText => StatuseIsActive ? "غیرفال" : "فعال";

        // ارتباط حساب معین با حساب کل
        public int? CodeKoll { get; set; }
        public string? KollName { get; set; } 
        
        
        public int TafsiliGropId{ get; set; }
        public string? TafsiliGropName { get; set; }
    }
}
