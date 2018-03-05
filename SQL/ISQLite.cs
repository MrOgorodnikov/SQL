using System;
namespace SQL
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
