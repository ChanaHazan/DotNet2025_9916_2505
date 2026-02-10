using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalApi
{
    public interface ICrud<T>
    {

        /// <summary>
        /// פונקציה ליצירת אוביקט
        /// </summary>
        /// <param name="item">מקבלת פרטי לקוח</param>
        /// <returns>מחזירה את קוד הלקוח שנוצר</returns>
        int Create(T item);

        /// <summary>
        /// פונקציה שמחזירה לקוח לפי המזהה שקיבלה 
        /// </summary>
        /// <param name="id">מזהה הלקוח הרצוי</param>
        /// <returns>מחזירה את הלקוח המבוקש</returns>
        T? Read(int id);

        /// <summary>
        /// פונקציה המחזירה רשימה של כל 
        /// </summary>
        /// <returns>רשימה של כל הלקוחות</returns>
        List<T> ReadAll(Func<T,bool>? filter=null);

        /// <summary>
        /// פונקציה המעדכנת נתוני 
        /// </summary>
        /// <param name="item">מקבלת פרטי לקוח</param>
        void Update(T item);

        /// <summary>
        /// מוחקת לקוח לפי המזהה שקיבלה
        /// </summary>
        /// <param name="id">מזהה הלקוח הרצוי למחיקה</param>
        void Delete(int id);

        T? Read(Func<T,bool>? filter);
    }
}
