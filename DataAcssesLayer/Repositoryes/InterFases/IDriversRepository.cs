using Domain;

namespace DataAcssesLayer.Repositoryes.InterFases
{
    public interface IDriversRepository
    {
        public List<Drivers> GetAll();
     
 
        public void Add(Drivers Drivers);



        public List<Drivers> GetIrani();
        public List<Drivers> GetIraqi();


    }

}
