namespace DataAcssesLayer.Repositoryes.InterFases
{
    public interface ICityripository
    {
        public void Add(City Farmers);
        public City GetById(int Id);


        public List<City> GetAll();
    }

}
