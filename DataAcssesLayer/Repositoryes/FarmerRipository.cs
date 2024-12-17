using DataAcssesLayer.Repositoryes.InterFases;
using Domain;

namespace DataAcssesLayer.Repositoryes
{
    public class FarmerRipository : BaseRepository<Farmers>, IFarmerRipository
    {
        public FarmerRipository(AppDbcontext context) : base(context)
        {
        }


    }

}
