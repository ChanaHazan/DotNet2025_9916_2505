
using DO;
using DalApi;
namespace DalTest;

public static class Initialization
{
    private static IDal s_dal;

    static void CreateCustomer()
    {
        s_dal.Customer.Create(new Customer(1001, "Chana Levi", "Jerusalem", "052-7119706"));
        s_dal.Customer.Create(new Customer(1002, "Miriam Cohen", "Tel Aviv", "054-3332211"));
        s_dal.Customer.Create(new Customer(1003, "Yael Friedman", "Haifa", "050-9876543"));
        s_dal.Customer.Create(new Customer(1004, "Rina Gold", "Be'er Sheva", "053-4455667"));
    }

    static void CreateSale()
    {
        s_dal.Sale.Create(new Sale(1, 1001, 5, 49.90, true, DateTime.Now, DateTime.Now.AddDays(7)));
        s_dal.Sale.Create(new Sale(2, 1002, 10, 39.90, true, DateTime.Now.AddDays(-3), DateTime.Now.AddDays(3)));
        s_dal.Sale.Create(new Sale(3, 1003, 20, null, false, null, null));
        s_dal.Sale.Create(new Sale(4, 1004, 3, 59.90, true, DateTime.Now, DateTime.Now.AddMonths(1)));
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
