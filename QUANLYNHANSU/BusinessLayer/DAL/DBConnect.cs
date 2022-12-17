using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DAL
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True");

    }
}
