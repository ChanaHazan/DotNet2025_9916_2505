
using DO;
using DalApi;
namespace DalTest;

public static class Initialization
{
    private static IDal s_dal;

    static void CreateCustomer()
    {
       Customer customer = new Customer();
       s_dal.Customer.Create(customer);
    }
    static void CreateSale()
    {
        Sale sale = new Sale();
        s_dal.Sale.Create(sale);
    }
    static void CreateProduct()
    {
        Product product = new Product();
        s_dal.Product.Create(product);
    }
    public static void Initialize(IDal dal)
    {
        s_dal = dal;
        CreateCustomer();
        CreateProduct();
        CreateSale();
    }


}
