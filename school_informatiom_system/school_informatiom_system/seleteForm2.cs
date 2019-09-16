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
    public partial class seleteForm2 : Form
    {
        public string strr;
        public seleteForm2()
        {
            InitializeComponent();
            
        }
        public string str{
            set { strr = value; }
            get { return  strr; }
        }
        private void seleteForm2_Load(object sender, EventArgs e)
        {
            textBox1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string con, sql;
            con = "Server=.\\SQLExpress;Database=School_information_system;Integrated Security=true";

            sql = "SELECT student.StudentID,student.name ,DBsubject.Chinese,DBsubject.English,DBsubject.mathematics,DBsubject.number FROM student,DBsubject Where student.StudentID = DBsubject.StudentID AND DBsubject.StudentID = @value1";
            SqlConnection mycon = new SqlConnection(con);
            SqlCommand mySqlCmd = new SqlCommand(sql, mycon);
            mycon.Open();
            mySqlCmd.Parameters.AddWithValue("@value1", textBox1.Text);
            SqlDataReader dataReader = mySqlCmd.ExecuteReader();


            while (dataReader.Read())
            {
                string studentID = dataReader["StudentID"].ToString();
                string name = dataReader["name"].ToString();
                string Chinese = dataReader["Chinese"].ToString();
                string English = dataReader["English"].ToString();
                string mathematics = dataReader["mathematics"].ToString();
                string number = dataReader["number"].ToString();

                DataGridViewRowCollection rows = dataGridView1.Rows;
                rows.Add(new Object[] { studentID, name, Chinese, English, mathematics, number});

            }
            mycon.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }
    }
}
