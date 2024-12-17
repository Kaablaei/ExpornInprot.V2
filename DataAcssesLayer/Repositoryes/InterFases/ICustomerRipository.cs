namespace DataAcssesLayer.Repositoryes.InterFases
{
    public interface ICustomerRipository
    {
        public void Add(Customer Customer);
        public Customer GetByCode(int Code);

        public List<Customer> GetAll();
    }

}
