using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Kala
    {
    
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }


        public int KollId { get; set; }
        public int MoinId { get; set; }


        public string KalName { get; set; }


        public int Weight { get; set; }

        public string VahedMoayan { get; set; }

        public string Vahedjoz { get; set; }

        public int MabnayeMohasebat { get; set; }

        public bool Status { get; set; }
    }


}
