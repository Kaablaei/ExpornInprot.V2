using DataAcssesLayer.Repositoryes.InterFases;
using Domain;

namespace DataAcssesLayer.Repositoryes
{
    public class BorderRepository : BaseRepository<Border>, IBorderRepository
    {
        public BorderRepository(AppDbcontext context) : base(context)
        {
        }

        public Border GetByCode(int Code)
        {
            return _context.Border.SingleOrDefault(p => p.Id == Code);
        }
    }

}
