using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int questions = 0, trueQuestion = 0, falseQuestion = 0;
        private void BtnContinue_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnContinue.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;

            questions++;
            LblQuestions.Text = questions.ToString();
            if (questions == 1)
            {
                richTextBox1.Text = "Which of the following is the SQL function that rounds the decimal part of a specified field?";
                BtnA.Text = "A) Update";
                BtnB.Text = "B) Alter";
                BtnC.Text = "C) Round";
                BtnD.Text = "D) Revoke";
                label4.Text = "C) Round";

            }
            if (questions == 2)
            {
                richTextBox1.Text = "Which of the following is the command used to search for multiple values in a specified single field?";
                BtnA.Text = "A) Search";
                BtnB.Text = "B) In";
                BtnC.Text = "C) As";
                BtnD.Text = "D) Round";
                label4.Text = "B) In";
            }
            if (questions == 3)
            {
                richTextBox1.Text = "Which of the following command lines prints the first 4 letters of the word 'America'?";
                BtnA.Text = "A) Select Left(4,'America')";
                BtnB.Text = "B) Select Substring('America',4)";
                BtnC.Text = "C) Select Right('America',4)";
                BtnD.Text = "D) Select Left('America',4)";
                label4.Text = "D) Select Left('America',4)";
            }
            if (questions == 4)
            {
                richTextBox1.Text = "What is the purpose of the command SELECT * FROM CUSTOMERS WHERE ID IN (SELECT CUSTOMERID FROM ADDRESS GROUP BY CUSTOMERID HAVING COUNT(CUSTOMERID) > 2)";
                BtnA.Text = "A) To retrieve customers with more than 2 address";
                BtnB.Text = "B) To retrieve customers with only 2 addresses";
                BtnC.Text = "C) To retrieve all customers without an address";
                BtnD.Text = "D) To retrieve all customers with an address";
                label4.Text = "A) To retrieve customers with more than 2 address";
            }
            if (questions == 5)
            {
                richTextBox1.Text = "What does SQL Server Instance mean?";
                BtnA.Text = "A) Each SQL Server service running on a server is an instance";
                BtnB.Text = "B) It is the administrator account information of SQL Server";
                BtnC.Text = "C) It is the IP information of SQL Server";
                BtnD.Text = "D) It is the installation language information of SQL Server";
                label4.Text = "A) Each SQL Server service running on a server is an instance";
            }
            if (questions == 6)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnContinue.Enabled = false;
                MessageBox.Show("True: " + trueQuestion + "\n" + "False: " + falseQuestion); ;
            }
        }
        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnContinue.Enabled = true;

            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                trueQuestion++;
                LblTrue.Text = trueQuestion.ToString();
                BtnA.BackColor = Color.Green;
                pictureBox1.Visible = true;
            }
            else
            {
                falseQuestion++;
                LblFalse.Text = falseQuestion.ToString();
                pictureBox2.Visible = true;
            }
        }
        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnContinue.Enabled = true;

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                trueQuestion++;
                LblTrue.Text = trueQuestion.ToString();
                BtnB.BackColor = Color.Green;
                pictureBox1.Visible = true;
            }
            else
            {
                falseQuestion++;
                LblFalse.Text = falseQuestion.ToString();
                pictureBox2.Visible = true;
            }
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnContinue.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                trueQuestion++;
                LblTrue.Text = trueQuestion.ToString();
                BtnC.BackColor = Color.Green;
                pictureBox1.Visible = true;
            }
            else
            {
                falseQuestion++;
                LblFalse.Text = falseQuestion.ToString();
                pictureBox2.Visible = true;
            }
        }
        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnContinue.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                trueQuestion++;
                LblTrue.Text = trueQuestion.ToString();
                BtnD.BackColor = Color.Green;
                pictureBox1.Visible = true;
            }
            else
            {
                falseQuestion++;
                LblFalse.Text = falseQuestion.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
