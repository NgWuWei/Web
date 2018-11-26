﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Web.Tutor
{
    public partial class AddTestDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTestName.Text = Session["TestName"] as String;
            QuestionTypelbl.Text = Session["TestType"] as String;
        }

        static int i = 0;
        static int questionNumber = 1;

        protected void AddAnswerOptionbtn_Click(object sender, EventArgs e)
        {
            TextBox mulquestiontb;
            TextBox mulquestionResulttxt;
            Label mulquestionlbl;
            Label mulquestionResultlbl;
            Label mulquestionlbl2;
            Label spacelbl;
            CheckBox cb;
            Label Text;
            i++;
            for (int j = 0; j < i; j++)
            {
                mulquestiontb = new TextBox();
                mulquestionResulttxt = new TextBox();
                mulquestionlbl = new Label();

                mulquestionResultlbl = new Label();
                mulquestionlbl2 = new Label();
                spacelbl = new Label();

                Text = new Label();
                cb = new CheckBox();
                cb.ID = "chb_" + j;

                mulquestiontb.ID = j.ToString();
                mulquestionResulttxt.ID = j.ToString();

                spacelbl.Text = "    ";
                Text.Text = "This answer option is correct";

                mulquestionlbl.Text = Convert.ToChar(j + 65).ToString();
                mulquestionlbl2.Text = "(" + Convert.ToChar(j + 65).ToString() + ")";

                PlaceHolder1.Controls.Add(new LiteralControl("<br />"));
                PlaceHolder1.Controls.Add(mulquestionlbl2);
                PlaceHolder1.Controls.Add(spacelbl);

                PlaceHolder1.Controls.Add(new LiteralControl("<br />"));
                PlaceHolder1.Controls.Add(mulquestiontb);
                PlaceHolder1.Controls.Add(new LiteralControl("<br />"));
                
                PlaceHolder1.Controls.Add(cb);
                PlaceHolder1.Controls.Add(spacelbl);
                PlaceHolder1.Controls.Add(Text);
                PlaceHolder1.Controls.Add(new LiteralControl("<br />"));

            }
            CorrectAnswerddl.Items.Add(mulquestionlbl.Text);
        }

        protected void savebtn_Click(object sender, EventArgs e)
        {
            CheckBox cb = new CheckBox();
            // get selected cehckbox only
            for (int i = 0; i < questionNumber; i++)
            {
                if (cb.ID.Equals("body_chk_" + i) == true)
                {
                   CorrectAnswerddl.SelectedItem.Value += cb.Text;
                }

            }

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
                conn.Open();
                string insertQuery1 = "INSERT into MultiQuestion(TestID, TestName, QuestionType, QuestionDesc, QuestionResult, AnswerCorrect) values (@TestID, @TestName, @QuestionType, @QuestionDesc, @QuestionResult, @AnswerCorrect)";
                string insertQuery2 = "INSERT into MultiQuestionDetails(TestID,AnswerDesc, AnswerLabel )values (@TestID, @AnswerDesc, @AnswerLabel)";

                SqlCommand cmd = new SqlCommand(insertQuery1, conn);
                SqlCommand cmd2 = new SqlCommand(insertQuery2, conn);

                cmd.Parameters.AddWithValue("@TestID", lblTestName.Text);
                cmd.Parameters.AddWithValue("@TestName", lblTestName.Text);
                cmd.Parameters.AddWithValue("@QuestionType", QuestionTypelbl.Text);
                cmd.Parameters.AddWithValue("@QuestionDesc", QuestionTxt.Text);
                cmd.Parameters.AddWithValue("@QuestionResult", Resulttxt.Text);
                cmd.Parameters.AddWithValue("@AnswerCorrect", CorrectAnswerddl.SelectedItem.Value);

               cmd2.Parameters.AddWithValue("@TestID", lblTestName.Text);
               cmd2.Parameters.AddWithValue("@AnswerDesc", mulquestiontb.Text);
               cmd2.Parameters.AddWithValue("@AnswerLabel", mulquestionlbl.Text);

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();


                Response.Write("New Test Name Added Successfully!!!Thank you");
                conn.Close();
                QuestionNolbl.Text = questionNumber.ToString();
                questionNumber++;

                //Response.Redirect("~/Tutor/AddMultipleTest.aspx");

        }

        
    }
}