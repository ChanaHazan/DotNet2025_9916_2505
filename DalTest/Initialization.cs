
using DO;
using DalApi;
namespace DalTest;

public static class Initialization
{
    private static IDal s_dal;

    static void CreateCustomer()
    {
        Customer customer = new Customer();
        s_dal.Customer.Create(new Customer());
        s_dal.Customer.Create(new Customer());
        s_dal.Customer.Create(new Customer());
        s_dal.Customer.Create(new Customer());

    }
    static void CreateSale()
    {
        Sale sale = new Sale();
        s_dal.Sale.Create(sale);
    }
    static void CreateProduct()
    {
        s_dal.Product.Create(new Product(0, "BeefSteak", Categries.Meats, 120.5, 50));   
        // סטייק בקר
        s_dal.Product.Create(new Product(0, "GroundBeef", Categries.Meats, 65.0, 80));   
        // בשר בקר טחון
        s_dal.Product.Create(new Product(0, "TurkeyBreast", Categries.Poultry, 82.0, 70));
        // חזה הודו
        s_dal.Product.Create(new Product(0, "TurkeySlices", Categries.Poultry, 80.7, 100));
        // פרוסות הודו
        s_dal.Product.Create(new Product(0, "BlackPepper", Categries.Spices, 12.0, 200));   
        // פלפל שחור
        s_dal.Product.Create(new Product(0, "Paprika", Categries.Spices, 10.0, 180));
        //פפריקה
        s_dal.Product.Create(new Product(0, "FrozenBerries", Categries.Frozens, 25.0, 70));       
        // פירות יער קפואים
        s_dal.Product.Create(new Product(0, "FrozenFalafel", Categries.Frozens, 20.0, 110));      
        // פלאפל קפוא
        s_dal.Product.Create(new Product(0, "Tilapia", Categries.Fish, 60.0, 80));        
        // אמנון
        s_dal.Product.Create(new Product(0, "Sardines", Categries.Fish, 35.0, 100));      
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
