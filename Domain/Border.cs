using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    public class Border
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int KollId { get; set; }
        public int MoinId { get; set; }
        public string BorderName { get; set; }
        public string Borderdistance { get; set; }
    }
}
