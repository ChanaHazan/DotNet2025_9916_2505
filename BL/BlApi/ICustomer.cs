using BO;
namespace BlApi;

public interface ICustomer {
    /// <summary>
    /// פונקציה ליצירת אוביקט
    /// </summary>
    /// <param name="item">מקבלת פרטי לקוח</param>
    /// <returns>מחזירה את קוד הלקוח שנוצר</returns>
    int Create(Customer item);

    /// <summary>
    /// פונקציה שמחזירה לקוח לפי המזהה שקיבלה 
    /// </summary>
    /// <param name="id">מזהה הלקוח הרצוי</param>
    /// <returns>מחזירה את הלקוח המבוקש</returns>
    Customer? Read(int id);

    /// <summary>
    /// פונקציה המחזירה רשימה של כל 
    /// </summary>
    /// <returns>רשימה של כל הלקוחות</returns>
    List<Customer> ReadAll(Func<Customer, bool>? filter = null);

    /// <summary>
    /// פונקציה המעדכנת נתוני 
    /// </summary>
    /// <param name="item">מקבלת פרטי לקוח</param>
    void Update(Customer item);

    /// <summary>
    /// מוחקת לקוח לפי המזהה שקיבלה
    /// </summary>
    /// <param name="id">מזהה הלקוח הרצוי למחיקה</param>
    void Delete(int id);

    Customer? Read(Func<Customer, bool>? filter);

    bool IsExists(int id);
}
