using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace school_informatiom_system
{
    public partial class modifyForm2 : Form
    {
        public string strr;
        public string aname, fmodifyChinese, fmodifyEnglish, fmodifymathematics;
        public modifyForm2()
        {
            InitializeComponent();
        }
        public string str
        {
            set { strr = value; }
            get { return strr; }
        }
        public string DAname
        {
            set { aname = value; }
            get { return aname; }
        }
        public string DAmodify_Chinese
        {
            set { fmodifyChinese = value; }
            get { return fmodifyChinese; }
        }
        public string DAfmodifyEnglish
        {
            set { fmodifyEnglish = value; }
            get { return fmodifyEnglish; }
        }
        public string DAfmodifymathematics
        {
            set { fmodifymathematics = value; }
            get { return fmodifymathematics; }
        }

        private void modifyForm2_Load(object sender, EventArgs e)
        {
            label6.Text = str;
            textBox2.Text = DAname;

            numericUpDown1.Value = int.Parse(DAmodify_Chinese);
            numericUpDown2.Value = int.Parse(DAfmodifyEnglish);
            numericUpDown3.Value = int.Parse(DAfmodifymathematics); 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con, sql, sql2;

            con = "Server=.\\SQLExpress;Database=School_information_system;Integrated Security=true";

            sql = @"Update DBsubject SET Chinese = @value1, English = @value2, Mathematics = @value3 WHERE StudentID = @value4;

                    Update student SET name = @value5 WHERE StudentID = @value4";

            SqlConnection mycon = new SqlConnection(con);
            SqlCommand mySqlCmd = new SqlCommand(sql, mycon);
            mycon.Open();

            mySqlCmd.Parameters.AddWithValue("@value1", numericUpDown1.Value);
            mySqlCmd.Parameters.AddWithValue("@value2", numericUpDown2.Value);
            mySqlCmd.Parameters.AddWithValue("@value3", numericUpDown3.Value);

            mySqlCmd.Parameters.AddWithValue("@value4", label6.Text);
            mySqlCmd.Parameters.AddWithValue("@value5", textBox2.Text);

            mySqlCmd.ExecuteNonQuery();
            mycon.Close();
            mycon.Open();

            sql2 = @"Update DBsubject SET number = @value6 WHERE StudentID = @value7";
            SqlCommand mySqlCmd1 = new SqlCommand(sql2, mycon);


            mySqlCmd1.Parameters.AddWithValue("@value6", (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value) / 3);
            mySqlCmd1.Parameters.AddWithValue("@value7", label6.Text);

            mySqlCmd1.ExecuteNonQuery();
            mycon.Close();
            Form1 f = new Form1();
            this.Visible = false;
            f.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.Visible = true;
        }


    }
}
