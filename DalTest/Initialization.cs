
using DO;
using DalApi;
namespace DalTest;

public static class Initialization
{
    private static IDal s_dal;
    static List<int> productIds = new List<int>();

    static void CreateCustomer()
    {
        s_dal.Customer.Create(new Customer(1001, "Chana Levi", "Jerusalem", "052-7119706"));
        s_dal.Customer.Create(new Customer(1002, "Miriam Cohen", "Tel Aviv", "054-3332211"));
        s_dal.Customer.Create(new Customer(1003, "Yael Friedman", "Haifa", "050-9876543"));
        s_dal.Customer.Create(new Customer(1004, "Rina Gold", "Be'er Sheva", "053-4455667"));

    }

    static void CreateSale()
    {
        s_dal.Sale.Create(new Sale(1, productIds[0], 5, 49.90, true, DateTime.Now, DateTime.Now.AddDays(7)));
        s_dal.Sale.Create(new Sale(2, productIds[1], 10, 39.90, true, DateTime.Now.AddDays(-3), DateTime.Now.AddDays(3)));
        s_dal.Sale.Create(new Sale(3, productIds[2], 20, null, false, null, null));
        s_dal.Sale.Create(new Sale(4, productIds[3], 3, 59.90, true, DateTime.Now, DateTime.Now.AddMonths(1)));
    }


    static void CreateProduct()
    {
        productIds.Add(s_dal.Product.Create(new Product(0, "BeefSteak", Categories.Meats, 120.5, 50)));
        // סטייק בקר
        productIds.Add(s_dal.Product.Create(new Product(0, "GroundBeef", Categories.Meats, 65.0, 80)));
        // בשר בקר טחון
        productIds.Add(s_dal.Product.Create(new Product(0, "TurkeyBreast", Categories.Poultry, 82.0, 70)));
        // חזה הודו
        productIds.Add(s_dal.Product.Create(new Product(0, "TurkeySlices", Categories.Poultry, 80.7, 100)));
        // פרוסות הודו
        productIds.Add(s_dal.Product.Create(new Product(0, "BlackPepper", Categories.Spices, 12.0, 200)));
        // פלפל שחור
        productIds.Add(s_dal.Product.Create(new Product(0, "Paprika", Categories.Spices, 10.0, 180)));
        //פפריקה
        productIds.Add(s_dal.Product.Create(new Product(0, "FrozenBerries", Categories.Frozens, 25.0, 70)));
        // פירות יער קפואים
        productIds.Add(s_dal.Product.Create(new Product(0, "FrozenFalafel", Categories.Frozens, 20.0, 110)));
        // פלאפל קפוא
        productIds.Add(s_dal.Product.Create(new Product(0, "Tilapia", Categories.Fish, 60.0, 80)));
        // אמנון
        productIds.Add(s_dal.Product.Create(new Product(0, "Sardines", Categories.Fish, 35.0, 100)));      
        // סרדינים
    }


    public static void Initialize()
    {
        s_dal = DalApi.Factory.Get;
        CreateCustomer();
        CreateProduct();
        CreateSale();
    }

}
