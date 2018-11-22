using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web {
    public partial class Login : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
        }

        protected void BtnLogin_Click(object sender, EventArgs e) {
            Session["userId"] = userId.Text;
            string isTutor = "";
            string isStudent = "";
            // TODO get user role from database, if tutor then go to Tutor page
            // index 2, 1 is tutor, 0 is student

            // match user ID to see if valid
            string str = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            //string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\Web\Web\App_Data\Database1.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(str);
            // open connection
            connection.Open();

            // add model in Models Folder
            SqlCommand cmd = new SqlCommand("select tutId from Tutors where tutId = @tutId", connection);
            // identify id as tutor
            cmd.Parameters.AddWithValue("@tutId", userId.Text);
            isTutor = cmd.ExecuteScalar() as string;
            // get student
            cmd = new SqlCommand("select studId from Students where studId = @studId", connection);
            cmd.Parameters.AddWithValue("@studId", userId.Text);
            isStudent = cmd.ExecuteScalar() as string;

            connection.Close();

            if (isTutor != null) {
                Response.Redirect("~/Tutor/Tutor.aspx");
            }else if(isStudent != null) {
                Response.Redirect("~/Student/Student.aspx");
            } else {
                Response.Redirect("~/Login.aspx");
            }

            //TODO either sign in by email or given id
        }

        //TODO a function to toggle textmode of password textfield
    }

}