using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Tools
{
    public class LogManager
    {
        private static string path = "Log";

        public static string GetPathOfCurrentDirectory()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), $"{path}\\{DateTime.Now:yyyyMM}");
        }

        public static string GetPathOfCurrentFile()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), $"{path}\\{DateTime.Now:yyyyMM}\\log_{DateTime.Now:yyyyMMdd}.txt");
        }

        public static void WriteToLog(string nameOfProject, string funcName, string message)
        {
            if (!Directory.Exists(GetPathOfCurrentDirectory()))
            {
                Directory.CreateDirectory(GetPathOfCurrentDirectory());
            }
            Console.WriteLine(GetPathOfCurrentFile());
            File.AppendAllText(GetPathOfCurrentFile(), $"{DateTime.Now}   {nameOfProject}.{funcName}:   {message}\n");
        }

        public static void DeleteOldDirrectories()
        {
            string[] dirrectories = Directory.GetDirectories(Path.Combine(Directory.GetCurrentDirectory(), $"{path}"));
            // קבלת הזמן הנוכחי כדי לבודקו עם שאר הזמנים של שאר התיקיות
            int currentTime = Int32.Parse($"{DateTime.Now:yyyyMM}");
            foreach (string d in dirrectories)
            {
                // קבלת הזמן של התיקייה הנוכחית
                int time = Int32.Parse(d.Substring(d.Length - 6));
                // אם עבר חודשיים מוחקים את התיקייה
                if (currentTime - time > 2)
                {
                    Directory.Delete(d, true);
                }
            }
        }
    }
}
