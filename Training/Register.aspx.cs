using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Training
{
    public partial class Register : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        //1.Design UI form
        //2.Create database table to store data
        //3.Implement front end validations using js
        //4.Setup connectionstring in web.config
        //5.Create connection class in back end file
        //6.Write ado.net code to insert data into database table
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Users values (@name,@contact,@email,@city)",con);
            cmd.Parameters.AddWithValue("@name",txtName.Text);
            cmd.Parameters.AddWithValue("@contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@city", ddlCities.SelectedItem.Text);
            con.Open();
            cmd.ExecuteNonQuery();

            txtName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            ddlCities.SelectedIndex = 0;
    
            Response.Write("<script>alert('Data Inserted Successfully')</script>");
        }
    }
}