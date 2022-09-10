using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DatabaseAccessNonEntity
    {
        public static string connectionString = GetConnectionString();
        public static string connectionStringEntity = GetConnectionStringEntity();
        public static string GetConnectionString()
        {
            string connectionString = @"Data Source=DESKTOP-JG34C6B\DONG;Initial Catalog=QLDIENTHOAI;Integrated Security=True";
            return connectionString;
        }

        public static string GetConnectionStringEntity()
        {
            string connectionString = @"metadata = res://*/QUANLIDIENTHOAI.csdl|res://*/QUANLIDIENTHOAI.ssdl|res://*/QUANLIDIENTHOAI.msl;provider=System.Data.SqlClient;provider connection string='data source=DESKTOP-JG34C6B\DONG;initial catalog=QLDIENTHOAI;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework'";
            return connectionString;
        }
    }
}
