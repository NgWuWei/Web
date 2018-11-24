using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Tutor
{
    public partial class AddTestDetails : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QuestionTypeList.SelectedItem.Equals("Multiple Question"))
            {
                Response.Redirect("~/AddMultipleTest.aspx");
            }
            else if (QuestionTypeList.SelectedItem.Equals("True False"))
            {
                Response.Redirect("AddMultipleTest");
            }
            else if (QuestionTypeList.SelectedItem.Equals("Matching"))
            {
                Response.Redirect("AddMultipleTest");
            }
            else if (QuestionTypeList.SelectedItem.Equals("Essay"))
            {
                Response.Redirect("AddMultipleTest");
            }
            else if (QuestionTypeList.SelectedItem.Equals("Free Text"))
            {
                Response.Redirect("AddMultipleTest");
            }
            else
            {
                Response.Write("Please select the type of question");
            }
        }

        static int i = 0;
        protected void Button1_Click1(object sender, EventArgs e)
        {
            TextBox tb;
            i++;
            for (int j = 0; j < i; j++)
            {
                tb = new TextBox {
                    ID = j.ToString()
                };

                PlaceHolder1.Controls.Add(tb);
                PlaceHolder1.Controls.Add(new LiteralControl("<br />"));

            }
        }
    }
}