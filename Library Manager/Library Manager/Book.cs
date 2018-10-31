using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Manager
{
    public static class Book
    {
        public static string[] getBookName()
        {
            DataTable dataTable = Utility.DATABASECONNECTION.Execute("SELECT * FROM FUNCTION_GET_ALL_BOOK_NAME()");
            string[] res = new string[dataTable.Rows.Count];
            for (int i = 0; i < dataTable.Rows.Count; i++)
                res[i] = dataTable.Rows[i][0].ToString();
            return res;
        }
        public static string[] getBookSerial()
        {
            DataTable dataTable = Utility.DATABASECONNECTION.Execute("SELECT * FROM FUNCTION_GET_ALL_BOOK_SERIAL()");
            string[] res = new string[dataTable.Rows.Count];
            for (int i = 0; i < dataTable.Rows.Count; i++)
                res[i] = dataTable.Rows[i][0].ToString();
            return res;
        }
        public static DataTable findBookByName(string name)
        {
            string cmd = "";
            if (name.Length > 0)
            {
                cmd = string.Format("SELECT * FROM BOOK WHERE NAME LIKE N'{0}'", name);
                return Utility.DATABASECONNECTION.Execute(cmd);
            }
            return null;
        }
        public static DataTable findBookBySerial(string serial)
        {
            string cmd = "";
            if (serial.Length > 0)
            {
                cmd = string.Format("SELECT * FROM BOOK WHERE SERIAL LIKE '{0}'", serial);
                return Utility.DATABASECONNECTION.Execute(cmd);
            }
            return null;
        }
    }
}
