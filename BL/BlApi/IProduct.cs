using BO;

namespace BlApi;

public interface IProduct
{
    /// <summary>
    /// פונקציה ליצירת אוביקט
    /// </summary>
    /// <param name="item">מקבלת פרטי לקוח</param>
    /// <returns>מחזירה את קוד הלקוח שנוצר</returns>
    int Create(Product item);

    /// <summary>
    /// פונקציה שמחזירה לקוח לפי המזהה שקיבלה 
    /// </summary>
    /// <param name="id">מזהה הלקוח הרצוי</param>
    /// <returns>מחזירה את הלקוח המבוקש</returns>
    Product? Read(int id);

    /// <summary>
    /// פונקציה המחזירה רשימה של כל 
    /// </summary>
    /// <returns>רשימה של כל הלקוחות</returns>
    List<Product> ReadAll(Func<Product, bool>? filter = null);

    /// <summary>
    /// פונקציה המעדכנת נתוני 
    /// </summary>
    /// <param name="item">מקבלת פרטי לקוח</param>
    void Update(Product item);

    /// <summary>
    /// מוחקת לקוח לפי המזהה שקיבלה
    /// </summary>
    /// <param name="id">מזהה הלקוח הרצוי למחיקה</param>
    void Delete(int id);

    Product? Read(Func<Product, bool>? filter);

    void AllAvailableSales(Product product);
}
