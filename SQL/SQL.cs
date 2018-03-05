using System;
using System.Linq;
using SQLite;
using Xamarin.Forms;

namespace SQL
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath("db.db3");

            var database = new SQLiteConnection(databasePath);
            database.CreateTable<Table>();

            var t = database.Table<Table>();

            database.Insert(new Table{
                Id2 = 99,
                Name = "QQQW"
            });

            var t1 = database.Table<Table>().ToList();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
