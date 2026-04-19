
namespace BlApi
{
    public interface IBI
    {
        public ICustomer ICustomer { get; }
        public IProduct IProduct { get; }
        public ISale ISale { get;}
        public IOrder IOrder { get; }
    }
}
