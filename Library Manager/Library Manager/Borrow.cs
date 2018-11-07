using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Manager
{
    public static class Borrow
    {
        public static string[] getBorrowId()
        {
            DataTable dataTable = Utility.DATABASECONNECTION.Execute("SELECT * FROM FUNCTION_GET_ALL_BORROW_ID()");
            string[] res = new string[dataTable.Rows.Count];
            for (int i = 0; i < dataTable.Rows.Count; i++)
                res[i] = dataTable.Rows[i][0].ToString();
            return res;
        }

        public static DataTable findBorrowById(string id)
        {
            string cmd = "";
            if (id.Length > 0)
            {
                cmd = string.Format("SELECT * FROM BORROW WHERE ID = '{0}'", id);
                return Utility.DATABASECONNECTION.Execute(cmd);
            }
            return null;
        }

        public static bool insertBorrow(string idStudent, List<string> cart, string phone, string email, string imageLoc)
        {
            //string cmd = string.Format("SELECT ID FROM BORROW WHERE ID = '{0}'", id);
            //if (Utility.DATABASECONNECTION.Execute(cmd).Rows.Count > 0)
            //{
            //    return false;
            //}
            //else
            //{
            //    try
            //    {
            //        byte[] img = null;
            //        FileStream fileStream = new FileStream(imageLoc, FileMode.Open, FileAccess.Read);
            ////        BinaryReader binaryReader = new BinaryReader(fileStream);
            ////        img = binaryReader.ReadBytes((int)fileStream.Length);
            ////        SqlCommand sqlCommand;
            ////        cmd = string.Format("EXEC PROC_INSERT_BORROW " +
            ////                            "'{0}', N'{1}', '{2}', '{3}', @img", id, name, phone, email);
            ////        sqlCommand = new SqlCommand(cmd, Utility.DATABASECONNECTION.sqlConn);
            ////        sqlCommand.Parameters.Add("@img", img);
            ////        sqlCommand.ExecuteNonQuery();
            ////    }
            ////    catch (Exception e)
            ////    {
            ////        Console.WriteLine(e.Message);
            ////    }
            //}
            return true;
        }
        public static bool deleteBorrow(string id)
        {
            string cmd = "";
            try
            {
                cmd = string.Format("EXEC PROC_DELETE_BORROW {0}", id);
                Utility.DATABASECONNECTION.ExecuteNonQuery(cmd);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
