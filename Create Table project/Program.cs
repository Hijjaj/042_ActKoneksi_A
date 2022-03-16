using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Create_Table_project
{
    class Program
    {
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-OG8P1VHL\\HIJJAJ;database=ProdiTI;Integrated Security = TRUE");
                con.Open();
            } catch (Exception e)
            {

            }
        }
    }
}
