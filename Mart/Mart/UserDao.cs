using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Mart
{
    public class UserDao
    {
        SqlConnection con = Connection.getConnection();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;

        public List<User> GetUser()
        {
            List<User> list = new List<User>();
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from tbUser", con);
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(new User((int)row["id"], (string)row["name"]));
                }
            }
            catch (SqlException ex) {

            }
            finally
            {
                con.Close();
            }

            return list;
        }

        public void FillDataGrid(DataGridView dgv)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from tbUser", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                con.Close();
            }
        }




    }
}
