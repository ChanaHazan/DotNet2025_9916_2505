
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
        s_dal.Product.Create(new Product(0, "BeefSteak", Categories.Meats, 120.5, 50));   
        // סטייק בקר
        s_dal.Product.Create(new Product(0, "GroundBeef", Categories.Meats, 65.0, 80));   
        // בשר בקר טחון
        s_dal.Product.Create(new Product(0, "TurkeyBreast", Categories.Poultry, 82.0, 70));
        // חזה הודו
        s_dal.Product.Create(new Product(0, "TurkeySlices", Categories.Poultry, 80.7, 100));
        // פרוסות הודו
        s_dal.Product.Create(new Product(0, "BlackPepper", Categories.Spices, 12.0, 200));   
        // פלפל שחור
        s_dal.Product.Create(new Product(0, "Paprika", Categories.Spices, 10.0, 180));
        //פפריקה
        s_dal.Product.Create(new Product(0, "FrozenBerries", Categories.Frozens, 25.0, 70));       
        // פירות יער קפואים
        s_dal.Product.Create(new Product(0, "FrozenFalafel", Categories.Frozens, 20.0, 110));      
        // פלאפל קפוא
        s_dal.Product.Create(new Product(0, "Tilapia", Categories.Fish, 60.0, 80));        
        // אמנון
        s_dal.Product.Create(new Product(0, "Sardines", Categories.Fish, 35.0, 100));      
        // סרדינים

    }


    public static void Initialize(IDal dal)
    {
        s_dal = dal;
        CreateCustomer();
        CreateProduct();
        CreateSale();
    }

}
