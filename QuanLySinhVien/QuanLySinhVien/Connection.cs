using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class Connection
    {
        private static string strConnect = @"Data Source=LAPTOP-H5NS9UIK;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(strConnect);
            return conn;
        }
    }
}
