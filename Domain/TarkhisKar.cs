using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class TarkhisKar
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int KollId { get; set; }
        public int MoinId { get; set; }

        public string TarkisKarName { get; set; }
        public string TarkisKarMojavez { get; set; }
        public string TarkisKarHazine { get; set; }


        public bool IsIraqi { get; set; }
    }


}
