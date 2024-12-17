using DataAcssesLayer.Repositoryes.InterFases;

namespace DataAcssesLayer.Repositoryes
{
    public class CityRipository : BaseRepository<City>, ICityripository
    {
        public CityRipository(AppDbcontext context) : base(context)
        {
        }


    }

}
