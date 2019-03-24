using BusinessLayerClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string connString;
        protected void Page_Load(object sender, EventArgs e)
        {
            connString = ConfigurationManager.ConnectionStrings["AnjiSQLConnectionString"].ConnectionString;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            int empId = int.Parse(TextBox1.Text);
            obj.DeleteEmployee(empId);
        }

        protected void btnInsertEmployee_Click(object sender, EventArgs e)
        {
            //Step 1:Connect to DB and Open the connection
            //string connString = "Data source=Anji\\SQLEXPRESS; Initial catalog=chandu;User ID=sa;Password=12345";
            SqlConnection sqlConn = new SqlConnection(connString);
            sqlConn.Open();
            //Step 2:Execute insertCommand by passing insertQuery
            string empid = TextBox2.Text.ToString();
            string empname = TextBox3.Text.ToString();
            int empage = int.Parse(TextBox4.Text);
            string insertQuery = "insert into EmployeeList(EmpID,EmpName,EmpAge) values('" + empid + "','" + empname + "','" + empage  + "')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConn);
            insertCommand.ExecuteNonQuery();
            //Step 3: Dispose the SqlCommand and close the SqlConnection
            insertCommand.Dispose();
            sqlConn.Close();
            Label2.Text = "insert successfully";
            Employee obj = new Employee();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Step 1:Connect to DB and Open the connection
            //string connString = "Data source=Anji\\SQLEXPRESS; Initial catalog=chandu;User ID=sa;Password=12345";
            SqlConnection sqlConn = new SqlConnection(connString);
            sqlConn.Open();
            //Step 2:Execute insertCommand by passing insertQuery
            string empid = TextBox5.Text.ToString();
            string empname = TextBox6.Text.ToString();
            string updateQuery = "Update EmployeeList set EmpName='" + TextBox6.Text + "' where EmpID='" + TextBox5.Text + "'";
            SqlCommand updatecommand = new SqlCommand(updateQuery, sqlConn);
            updatecommand.ExecuteNonQuery();
            //Step 3:Dispose SqlCommand and close the connection
            
            updatecommand.Dispose();
            sqlConn.Close();
            Label3.Text = "Updated successfully";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            int empId = int.Parse(TextBox7.Text);
            try
            {
                obj.DeleteEmployee(empId);
                Label4.Text = "Delete successfully";
            }
            catch (Exception ex)
            {
                Label4.Text = ex.Message.ToString();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //Step 1:Connect to DB and Open the connection
            //string connString = "Data source=Anji\\SQLEXPRESS; Initial catalog=chandu;User ID=sa;Password=12345";
            SqlConnection sqlConn = new SqlConnection(connString);
            sqlConn.Open();
            string selectQuery = "select* from EmployeeList";
            SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConn);
            SqlDataReader sqlReader = selectCommand.ExecuteReader();

            sqlConn.Close();


        }
    }
}