using Domain;

namespace DataAcssesLayer.Repositoryes.InterFases
{
    public interface IFarmerRipository
    {
        public void Add(Farmers Farmers);
        

        public List<Farmers> GetAll();
    }

}
