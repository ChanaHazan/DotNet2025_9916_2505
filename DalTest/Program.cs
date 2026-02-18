using Dal;
using DalApi;
using DO;
using Tools;


namespace DalTest
{
    internal class Program
    {
        static readonly IDal s_dal = new Dal.DalList();
        private static void Main(string[] args)
        {
            try
            {
                Initialization.Initialize(s_dal);
                while (true)
                {
                    int select1 = PrintMainMenu();
                    switch (select1)
                    {
                        case 1:
                            ProductMenu();
                            break;
                        case 2:
                            CustomerMenu();
                            break;
                        case 3:
                            SaleMenu();
                            break;
                        case 4:
                            LogManager.DeleteFromLog();
                            break;
                        default:
                            return;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void ProductMenu()
        {
            while (true)
            {
                int select = PrintSubMenu("Product");
                switch (select)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        Delete(s_dal.Product);
                        break;
                    case 3:
                        UpdateProduct();
                        break;
                    case 4:
                        Read(s_dal.Product);
                        break;
                    case 5:
                        ReadAll(s_dal.Product);
                        break;
                    default:
                        return; // חזרה לתפריט הראשי
                }
            }
        }

        private static void CustomerMenu()
        {
            while (true)
            {
                int select = PrintSubMenu("Customer");
                switch (select)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        Delete(s_dal.Customer);
                        break;
                    case 3:
                        UpdateCustomer();
                        break;
                    case 4:
                        Read(s_dal.Customer);
                        break;
                    case 5:
                        ReadAll(s_dal.Customer);
                        break;
                    default:
                        return;
                }
            }
        }
        private static void SaleMenu()
        {
            while (true)
            {
                int select = PrintSubMenu("Sale");
                switch (select)
                {
                    case 1:
                        AddSale();
                        break;
                    case 2:
                        Delete(s_dal.Sale);
                        break;
                    case 3:
                        UpdateSale();
                        break;
                    case 4:
                        Read(s_dal.Sale);
                        break;
                    case 5:
                        ReadAll(s_dal.Sale);
                        break;
                    default:
                        return;
                }
            }
        }
    
        private static Product AskProduct(int id=0)
        {
            string productName;
            Categories category;
            double price;
            int stock;
            int cat;

            Console.WriteLine("enter product name");
            productName=Console.ReadLine();

            Console.WriteLine("Enter the category: between 0 to 4 ");
            if (!int.TryParse(Console.ReadLine(), out cat))
                category = 0;
            else
                category = (Categories)cat;

            Console.WriteLine("enetr price");
            double.TryParse(Console.ReadLine(),out price);

            Console.WriteLine("enter stock");
            int.TryParse(Console.ReadLine(), out stock);
            return new Product(id, productName, category, price, stock);

        }
        private static Customer AskCustomer(int id = 0)
        {
            string customerName;
            string adress;
            string phone;

            Console.WriteLine("enter customer name");
            customerName=Console.ReadLine();
            Console.WriteLine("enter customer adress");
            adress=Console.ReadLine();
            Console.WriteLine("enter customer phone");
            phone=Console.ReadLine();

            return new Customer(id,customerName,adress,phone);
        }
        private static Sale AskSale(int id = 0)
        {
            int productId;
            int quantityRequier;
            double salePrice;
            bool isSaleToCustomer;
            DateTime startSale;
            DateTime endSale;

            Console.WriteLine("enter product id");
            int.TryParse(Console.ReadLine(),out productId);

            Console.WriteLine("enter quantity requier");
            int.TryParse(Console.ReadLine(),out quantityRequier);

            Console.WriteLine("enter sale price");
            double.TryParse(Console.ReadLine(), out salePrice);

            Console.WriteLine("enter is sale to customer");
            bool.TryParse(Console.ReadLine(),out  isSaleToCustomer);

            Console.WriteLine("enter start sale date");
            DateTime.TryParse(Console.ReadLine(),out startSale);

            Console.WriteLine("enter end sale date");
            DateTime.TryParse(Console.ReadLine() ,out endSale);

            return new Sale(id,productId,quantityRequier,salePrice,isSaleToCustomer,startSale,endSale);

        }

        private static void AddProduct()
        {
            Product product = AskProduct();
            int id=s_dal.Product.Create(product);
            Console.WriteLine($"add product with id: {id}"); 
        }
        private static void AddCustomer()
        {
            Console.WriteLine("enter id");
            int id=int.Parse(Console.ReadLine());
            Customer customer = AskCustomer(id);
            s_dal.Customer.Create(customer);
            Console.WriteLine("created customer succes!");
        }
        private static void AddSale()
        {
            Sale sale = AskSale();
            int id=s_dal.Sale.Create(sale);
            Console.WriteLine($"add sale with id: {id}");
        }

        private static void UpdateProduct()
        {
            Console.WriteLine("enter id for update product");
            int id=int.Parse(Console.ReadLine());
            Product product = AskProduct(id);
            s_dal.Product.Update(product);
            Console.WriteLine("product update!");
        }
        private static void UpdateCustomer()
        {
            Console.WriteLine("enter id for update customer");
            int id = int.Parse(Console.ReadLine());
            Customer customer = AskCustomer(id);
            s_dal.Customer.Update(customer);
            Console.WriteLine("customer update!");
        }
        private static void UpdateSale()
        {
            Console.WriteLine("enter id for update sale");
            int id = int.Parse(Console.ReadLine());
            Sale sale = AskSale(id);
            s_dal.Sale.Update(sale);
            Console.WriteLine("sale update!");
        }

        private static void ReadAll<T>(ICrud<T> icrud)
        {
            foreach (T t in icrud.ReadAll())
                if (t != null)
                    Console.WriteLine(t);
        }
        private static void Read<T>(ICrud<T> crud)
        {
            try
            {
                Console.WriteLine("enter id");
                Console.WriteLine(crud.Read(int.Parse(Console.ReadLine())));
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        private static void Delete<T>(ICrud<T> crud)
        {
            try
            {
                Console.WriteLine("enter id to remove");
                crud.Delete(int.Parse(Console.ReadLine()));
                Console.WriteLine("deleted by id");
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
        public static int PrintMainMenu()
        {
            int choice;
            Console.WriteLine("Product? press 1, Customer? press 2, Sale? press 3,delete from log? press 4, exit? press another key");
            return int.Parse(Console.ReadLine());
        }
        public static int PrintSubMenu(string item)
        {
            int choice;
            Console.WriteLine($"{item} menu: create - 1, delete - 2, update - 3, read - 4, read all - 5, exit - any key");
            int.TryParse(Console.ReadLine(), out choice);
            return choice;

        }

    }
}
