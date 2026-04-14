

using BlApi;

namespace BlImplemention
{
    internal class CustomerImplementation:ICustomer
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

    }
}
