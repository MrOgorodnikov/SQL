using System;
using SQLite;

namespace SQL
{
    public class Table
    {
        public Table()
        {

        }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        
        public int Id2 { get; set; }
        public string Name { get; set; }
    }
}
