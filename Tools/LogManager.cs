using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Tools;

public static class LogManager
{
    const string LogPath = "Log";//static??
    public static string GetLogPath()
    {
        return $"{LogPath}/{DateTime.Now.Month} - {DateTime.Now.Year}";
    }
    public static string getFilePath()
    {
        return $"{GetLogPath()}/{DateTime.Now.Day}.txt";
    }

    public static void WriteToLog(string message, string nameProject, string nameFanction)
    {
        if (!Directory.Exists(GetLogPath()))
        {
            Directory.CreateDirectory(GetLogPath());
        }
        if (!File.Exists(getFilePath()))
        {
            File.Create(getFilePath()).Close();
        }
        using (StreamWriter writer = new StreamWriter(getFilePath(), true))
        {
            writer.WriteLine($"{DateTime.Now}\t{nameProject}.{nameFanction}:\t{message}");
        }
    }

    public static void DeleteFromLog()
    {
        DateTime now = DateTime.Now;

        // חישוב החודשים והשנים לשמירה
        DateTime currentMonth = new DateTime(now.Year, now.Month, 1);
        DateTime previousMonth = currentMonth.AddMonths(-1);
        DateTime twoMonthsAgo = currentMonth.AddMonths(-2);

        // רשימת התיקיות לשמירה
        string[] keepFolders = new string[]
        {
            $"{currentMonth.Month} - {currentMonth.Year}",
            $"{previousMonth.Month} - {previousMonth.Year}",
            $"{twoMonthsAgo.Month} - {twoMonthsAgo.Year}"
        };

        // קריאת כל התיקיות בתיקיית LOG
        if (Directory.Exists(LogPath))
        {
            string[] directories = Directory.GetDirectories(LogPath);

            foreach (string dir in directories)
            {
                string folderName = Path.GetFileName(dir);

                // בדיקה אם התיקייה לא נמצאת ברשימת השמירה
                if (Array.IndexOf(keepFolders, folderName) == -1)
                {
                    try
                    {
                        Directory.Delete(dir, true); // מחיקת התיקייה וכל התוכן שלה
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Failed To Delete Folder");//FailedToDeleteFolder
                    }
                }
            }
        }
        else
        {
            throw new Exception("Log directory does not exist.");
        }

    }

}



