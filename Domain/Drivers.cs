using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Drivers
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }


        public int KollId { get; set; }
        public int MoinId { get; set; }

        public string DriverName { get; set; }

        public string CarNumber { get; set; }
        public string PhoneNumber { get; set; }


        public bool IsIraqi { get; set; }


    }
}
