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
            else if (QuestionTypeList.SelectedItem.Equals("Free Text"))
            {
                Response.Redirect("AddMultipleTest");
            }
            else
            {
                Response.Write("Please select the type of question");
            }
        }

        TextBox mulquestiontb;
        TextBox mulquestionResulttxt;
        Label mulquestionlbl;
        CheckBox mulquestioncb;

        static int i = 0;
        
        protected void Button1_Click1(object sender, EventArgs e)
        {

            i++;
            for (int j = 0; j < i; j++)
            {
                mulquestiontb = new TextBox();
                mulquestionResulttxt = new TextBox();
                mulquestionlbl = new Label();
                mulquestioncb = new CheckBox();

                mulquestiontb.ID = j.ToString();
                mulquestionlbl.ID = j.ToString();
                mulquestioncb.ID = j.ToString();
                mulquestionResulttxt.ID = j.ToString();
                mulquestionlbl.Text = Convert.ToChar(j + 65).ToString();

                PlaceHolder1.Controls.Add(new LiteralControl("<br />"));
                PlaceHolder1.Controls.Add(mulquestionlbl);
                PlaceHolder1.Controls.Add(mulquestioncb);
                PlaceHolder1.Controls.Add(new LiteralControl("<br />"));
                PlaceHolder1.Controls.Add(mulquestiontb);
                PlaceHolder1.Controls.Add(mulquestionResulttxt);
                PlaceHolder1.Controls.Add(new LiteralControl("<br />"));

            }
        }
    }
}