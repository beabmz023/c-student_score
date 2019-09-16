using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;


namespace school_informatiom_system
{
    public partial class newForm2 : Form
    {
        public int ID;
        public newForm2()
        {
            InitializeComponent();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string con, sql, sql_new;

            con = "Server=.\\SQLExpress;Database=School_information_system;Integrated Security=true";
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();
            sql = @"SELECT count(StudentID) studentID from student where StudentID = @value3";
            SqlCommand sqlsele = new SqlCommand(sql,mycon);
            sqlsele.Parameters.AddWithValue("@value3", label4.Text);
            SqlDataReader dataReader = sqlsele.ExecuteReader();
            while (dataReader.Read()) {
                
                ID = Convert.ToInt32(dataReader["studentID"]);
               
            }
            mycon.Close();

            if (ID == 0)
            {
                mycon.Open();
                sql_new = @"INSERT Into student(studentID, name) VALUES (@value1, @value2)INSERT Into DBsubject(StudentID,Chinese, English, mathematics,number) VALUES (@value1,0,0,0,0)";
                SqlCommand mySqlCmd = new SqlCommand(sql_new, mycon);

                mySqlCmd.Parameters.AddWithValue("@value1", label4.Text);
                mySqlCmd.Parameters.AddWithValue("@value2", textBox2.Text);

                mySqlCmd.ExecuteNonQuery();


                Form1 f = new Form1();
                this.Visible = false;
                f.Visible = true;
            }
            else
            {
                Form2 f = new Form2();

                f.Visible = true;
            }
            mycon.Close();
        }

        private void newForm2_Load_1(object sender, EventArgs e)
        {
            string con, sql_new;
            con = "Server=.\\SQLExpress;Database=School_information_system;Integrated Security=true";
            sql_new = @"SELECT max(StudentID) StudentID from student ";
            SqlConnection mycon = new SqlConnection(con);
            SqlCommand mySqlCmd = new SqlCommand(sql_new, mycon);
            mycon.Open();
            SqlDataReader reader = mySqlCmd.ExecuteReader();

           while (reader.Read())
            {
               // MessageBox.Show(reader["studentID"].ToString());
                if (reader["studentID"].ToString() == "")
                {
                   // MessageBox.Show("!");
                    label4.Text = "99113101";
                }
                else {
                    int ID;
                    ID = Convert.ToInt32(reader["StudentID"]);
                    label4.Text = String.Concat(ID + 1);
                }


            }
            
            mycon.Close();
        }



    }
}
