using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace First_Asp_Class
{
    public class DbCon
    {
        private SqlConnection SqlCon;
        public DbCon()
        {
            SqlCon = new SqlConnection("Data Source=DESKTOP-K7I2IUV;Initial Catalog=LAB-TASK-2;Integrated Security=True");
        }
        public bool UDI(string qry)
        {
            SqlCon.Open();
            SqlCommand cmd = new SqlCommand(qry, SqlCon);
            int res = cmd.ExecuteNonQuery();
            SqlCon.Close();
            if (res > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable Search(string qry)
        {
            SqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(qry, SqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlCon.Close();
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
    }
}
