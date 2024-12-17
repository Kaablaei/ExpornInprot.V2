using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAcssesLayer.Repositoryes.InterFases
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { get; set; }

        public string CityName { get; set; }

        //فاصله شهر
        public string Distance { get; set; }



        public List<Customer> Customers { get; set; }
    }




}
