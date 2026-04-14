



using BlApi;

namespace BlImplemention
{
    internal class ProductImplementation:IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

    }
}
