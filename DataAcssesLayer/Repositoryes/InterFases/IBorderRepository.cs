using Domain;

namespace DataAcssesLayer.Repositoryes.InterFases
{
    public interface IBorderRepository
    {
        public void Add(Border Border);
        public Border GetByCode(int Code);

        public List<Border> GetAll();
    }

}
