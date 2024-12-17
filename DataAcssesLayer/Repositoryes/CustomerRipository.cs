using DataAcssesLayer.Repositoryes.InterFases;

namespace DataAcssesLayer.Repositoryes
{
    public class CustomerRipository : BaseRepository<Customer>, ICustomerRipository
    {
        public CustomerRipository(AppDbcontext context) : base(context)
        {
        }


        Customer ICustomerRipository.GetByCode(int Code)
        {
            return _context.customer.SingleOrDefault(p => p.CustomerId == Code);
        }
    }

}
