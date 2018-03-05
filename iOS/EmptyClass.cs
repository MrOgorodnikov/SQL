using System;
using System.IO;
using SQL.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(EmptyClass))]
namespace SQL.iOS
{
    public class EmptyClass : ISQLite
    {
        public EmptyClass()
        {
        }

        public string GetDatabasePath(string sqliteFilename)
        {
            // определяем путь к бд
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentsPath,"..", "Library", "Databases"); // папка библиотеки

            if (!Directory.Exists(libraryPath))
            {
                Directory.CreateDirectory(libraryPath);
            }

            var path = Path.Combine(libraryPath, sqliteFilename);

            return path;
        }
    }
}
