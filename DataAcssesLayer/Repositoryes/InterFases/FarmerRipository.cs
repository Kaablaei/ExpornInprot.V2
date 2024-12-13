using Domain;

namespace DataAcssesLayer.Repositoryes.InterFases
{
    public class FarmerRipository : BaseRepository<Farmers>, IFarmerRipository
    {
        public FarmerRipository(AppDbcontext context) : base(context)
        {
        }

       
    }

}
