using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAcssesLayer.Repositoryes.InterFases
{
    public class Customer
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public int KollId { get; set; }
        public int MoinId { get; set; }

        //حقیقی یا حقوقی
        public bool IsHagigi { get; set; }

        public string? Address { get; set; }

        //نوع مالکیت
        public string Noehmalekiyat { get; set; }
        //تابلو
        public string? Tablo { get; set; }
        public string PhoneNumber { get; set; }

        public string Landlinephone { get; set; }


        
        public int CityId { get; set; }
        public City City { get; set; }
    }




}
