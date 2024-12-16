using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAcssesLayer.Repositoryes.InterFases
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { get; set; }
        public int CityName { get; set; }

        //فاصله شهر
        public string Distance { get; set; }


        //
        public ICollection<Customer> Customers { get; set; } = new List<Customer>();
    }




}
