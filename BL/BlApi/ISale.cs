using BO;
namespace BlApi;

public interface ISale 
{
    /// <summary>
    /// פונקציה ליצירת אוביקט
    /// </summary>
    /// <param name="item">מקבלת פרטי לקוח</param>
    /// <returns>מחזירה את קוד הלקוח שנוצר</returns>
    int Create(Sale item);

    /// <summary>
    /// פונקציה שמחזירה לקוח לפי המזהה שקיבלה 
    /// </summary>
    /// <param name="id">מזהה הלקוח הרצוי</param>
    /// <returns>מחזירה את הלקוח המבוקש</returns>
    Sale? Read(int id);

    /// <summary>
    /// פונקציה המחזירה רשימה של כל 
    /// </summary>
    /// <returns>רשימה של כל הלקוחות</returns>
    List<Sale> ReadAll(Func<Sale, bool>? filter = null);

    /// <summary>
    /// פונקציה המעדכנת נתוני 
    /// </summary>
    /// <param name="item">מקבלת פרטי לקוח</param>
    void Update(Sale item);

    /// <summary>
    /// מוחקת לקוח לפי המזהה שקיבלה
    /// </summary>
    /// <param name="id">מזהה הלקוח הרצוי למחיקה</param>
    void Delete(int id);

    Sale? Read(Func<Sale, bool>? filter);
}
