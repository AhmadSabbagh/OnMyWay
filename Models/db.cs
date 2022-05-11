using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnMyWay2.Models
{
    public class db
    {/*
        public static SqlConnection conn =
            new SqlConnection
            ("Data Source=DESKTOP-PBPDNIE\\MSSQLSERVER01;Initial Catalog=OnMyWay;Integrated Security=true");
        */
		public static SqlConnection conn =
			new SqlConnection
			("Data Source = SQL5097.site4now.net; Initial Catalog = DB_A74C1D_onmyway3; User Id = DB_A74C1D_onmyway3_admin; Password=ryiad_123;");
		


    }
}
