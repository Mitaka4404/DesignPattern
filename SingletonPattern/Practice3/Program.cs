using System.Data;

namespace Practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            DataRow row1 = dt.Rows.Add("Lee");
            DataRow row2 = dt.Rows.Add("LEE");

            // Singleton インスタンス
            bool same = DataRowComparer<DataRow>.Default.Equals(row1, row2);
            Console.WriteLine(same);
        }
    }
}