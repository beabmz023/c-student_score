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
    public partial class Form1 : Form
    {
        public string modify_studentID, modify_name, modify_Chinese, modify_English, modify_mathematics;
        public Form1()
        {
            InitializeComponent();


            string con, sql;
            con = "Server=.\\SQLExpress;Database=School_information_system;Integrated Security=true";

            sql = "SELECT student.StudentID,student.name ,DBsubject.Chinese,DBsubject.English,DBsubject.mathematics FROM student,DBsubject Where student.StudentID = DBsubject.StudentID";
            SqlConnection mycon = new SqlConnection(con);
            SqlCommand mySqlCmd = new SqlCommand(sql, mycon);
            mycon.Open();

            SqlDataReader dataReader = mySqlCmd.ExecuteReader();


            while (dataReader.Read())
            {
                string studentID = dataReader["studentID"].ToString();
                string name = dataReader["Name"].ToString();
                string Chinese = dataReader["Chinese"].ToString();
                string English = dataReader["English"].ToString();
                string mathematics = dataReader["mathematics"].ToString();
                
                DataGridViewRowCollection rows = dataGridView1.Rows;
                rows.Add(new Object[] { studentID, name, Chinese, English, mathematics, (double.Parse(Chinese) + double.Parse(English) + double.Parse(mathematics)) / 3 });
                
            }
            mycon.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newForm2 f = new newForm2();
            this.Visible = false;
            f.Visible = true;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            modify_studentID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            modify_name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            modify_Chinese = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            modify_English = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            modify_mathematics = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            modifyForm2 f = new modifyForm2();
            this.Visible = false;
            if (modify_studentID == null)
            {

                f.strr = dataGridView1.Rows[0].Cells[0].Value.ToString();
                f.aname = dataGridView1.Rows[0].Cells[1].Value.ToString();
                f.fmodifyChinese = dataGridView1.Rows[0].Cells[2].Value.ToString();
                f.fmodifyEnglish = dataGridView1.Rows[0].Cells[3].Value.ToString();
                f.fmodifymathematics = dataGridView1.Rows[0].Cells[4].Value.ToString();
            }
            else
            {
                f.strr = modify_studentID;
                f.aname = modify_name;
                f.fmodifyChinese = modify_Chinese;
                f.fmodifyEnglish = modify_English;
                f.fmodifymathematics = modify_mathematics;
            }
            f.Visible = true;
        }



        private void button4_Click(object sender, EventArgs e)
        {
            string con, sql;
            con = "Server=.\\SQLExpress;Database=School_information_system;Integrated Security=true";
            sql = @"Delete From student WHERE StudentID = @value1;
                    Delete From DBsubject WHERE StudentID = @value2;";
            SqlConnection mycon = new SqlConnection(con);
            SqlCommand mySqlCmd = new SqlCommand(sql, mycon);
            mycon.Open();
            if (modify_studentID == null)
            {
                modify_studentID = dataGridView1.Rows[0].Cells[0].Value.ToString();//讀取dataGrideview第一行資料Rows橫、cells直
                //MessageBox.Show(modify_studentID);//對話視窗
                //MessageBox.Show("!");
                mySqlCmd.Parameters.AddWithValue("@value1", modify_studentID);
                mySqlCmd.Parameters.AddWithValue("@value2", modify_studentID);
                mySqlCmd.ExecuteNonQuery();
                Form1 f = new Form1();
                this.Visible = false;
                f.Visible = true;
            }
            else {
                mySqlCmd.Parameters.AddWithValue("@value1", modify_studentID);
                mySqlCmd.Parameters.AddWithValue("@value2", modify_studentID);
                mySqlCmd.ExecuteNonQuery();
                Form1 f = new Form1();
                this.Visible = false;
                f.Visible = true;
            }


            mycon.Close();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string con, sql;
            con = "Server=.\\SQLExpress;Database=School_information_system;Integrated Security=true";
            sql = "SELECT a1.StudentID,a3.Name ,a1.Chinese, a1.English, a1.mathematics, a1.number, COUNT(a2.number) Sales_Rank  FROM DBsubject a1, DBsubject a2 ,student a3 WHERE (a1.number <= a2.number OR a1.number=a2.number and a1.StudentID = a2.StudentID )and a3.StudentID = a1.StudentID GROUP BY a1.StudentID, a1.Chinese, a1.English, a1.mathematics, a1.number ,a3.Name ORDER BY a1.number DESC, a1.StudentID DESC ";
            SqlConnection mycon = new SqlConnection(con);
            SqlCommand mySqlCmd = new SqlCommand(sql, mycon);
            mycon.Open();

            SqlDataReader dataReader = mySqlCmd.ExecuteReader();


            while (dataReader.Read())
            {
                string studentID = dataReader["studentID"].ToString();
                string name = dataReader["Name"].ToString();
                string Chinese = dataReader["Chinese"].ToString();
                string English = dataReader["English"].ToString();
                string mathematics = dataReader["mathematics"].ToString();
                string number = dataReader["number"].ToString();
                string Sales_Rank = dataReader["Sales_Rank"].ToString();
                DataGridViewRowCollection rows = dataGridView1.Rows;
                rows.Add(new Object[] { studentID, name, Chinese, English, mathematics, number, Sales_Rank });

            }
            mycon.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.ClearSelection();//取消選取預設dataGraidview資料
           // dataGridView1.Rows[0].Cells[1].Style.BackColor = Color.Red;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = false;
            dataGridView1.Columns[3].ReadOnly = false;
            dataGridView1.Columns[4].ReadOnly = false;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            
            comboBox1.Items.Add(new ComboboxItem("newForm2", "新增"));
            comboBox1.Items.Add(new ComboboxItem("seleteForm2", "查詢"));
            comboBox1.Items.Add(new ComboboxItem("modifyForm2", "修改"));
            comboBox1.Items.Add(new ComboboxItem("delete", "刪除"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seleteForm2 f = new seleteForm2();
            if (modify_studentID == null)
            {
                f.strr = dataGridView1.Rows[0].Cells[0].Value.ToString();
            }
            else {
                f.strr = modify_studentID;
            }
            this.Visible = false;
            f.Visible = true;
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            subjectcs f = new subjectcs();
            this.Visible = false;
            f.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem item = comboBox1.Items[comboBox1.SelectedIndex] as ComboboxItem;
            string a = item.Value.ToString();
            if (a == "newForm2")
            {            
                newForm2 f = new newForm2();
                this.Visible = false;
                f.Visible = true;
            }
            else if (a == "seleteForm2")
            {
                seleteForm2 f = new seleteForm2();
                if (modify_studentID == null)
                {
                    modify_studentID = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    f.strr = modify_studentID;
                }
                else {
                    f.strr = modify_studentID;                    
                }
                this.Visible = false;
                f.Visible = true;
            }
            else if (a == "modifyForm2")
            {
                modifyForm2 f = new modifyForm2();
                this.Visible = false;
                if (modify_studentID == null)
                {
                    f.strr = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    f.aname = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    f.fmodifyChinese = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    f.fmodifyEnglish = dataGridView1.Rows[0].Cells[3].Value.ToString();
                    f.fmodifymathematics = dataGridView1.Rows[0].Cells[4].Value.ToString();
                }
                else
                {
                    f.strr = modify_studentID;
                    f.aname = modify_name;
                    f.fmodifyChinese = modify_Chinese;
                    f.fmodifyEnglish = modify_English;
                    f.fmodifymathematics = modify_mathematics;
                }
                f.Visible = true;
            }
            else {
                string con, sql;
                con = "Server=.\\SQLExpress;Database=School_information_system;Integrated Security=true";
                sql = @"Delete From student WHERE StudentID = @value1;
                    Delete From DBsubject WHERE StudentID = @value2;";
                SqlConnection mycon = new SqlConnection(con);
                SqlCommand mySqlCmd = new SqlCommand(sql, mycon);
                mycon.Open();
                if (modify_studentID == null)
                {
                    modify_studentID = dataGridView1.Rows[0].Cells[0].Value.ToString();//讀取dataGrideview第一行資料Rows橫、cells直
                    //MessageBox.Show(modify_studentID);//對話視窗
                    //MessageBox.Show("!");
                    mySqlCmd.Parameters.AddWithValue("@value1", modify_studentID);
                    mySqlCmd.Parameters.AddWithValue("@value2", modify_studentID);
                    mySqlCmd.ExecuteNonQuery();
                    Form1 f = new Form1();
                    this.Visible = false;
                    f.Visible = true;
                }
                else
                {
                    mySqlCmd.Parameters.AddWithValue("@value1", modify_studentID);
                    mySqlCmd.Parameters.AddWithValue("@value2", modify_studentID);
                    mySqlCmd.ExecuteNonQuery();
                    Form1 f = new Form1();
                    this.Visible = false;
                    f.Visible = true;
                }
                mycon.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string con, sql;

            con = "Server=.\\SQLExpress;Database=School_information_system;Integrated Security=true";
            SqlConnection mycon = new SqlConnection(con);
   
            mycon.Open();

            for (int i = 0; i < dataGridView1.RowCount; i++){
                sql = @"Update DBsubject SET Chinese = @value1, English = @value2, Mathematics = @value3 , number = @value6 WHERE StudentID = @value4;

                    Update student SET name = @value5 WHERE StudentID = @value4";
                SqlCommand mySqlCmd = new SqlCommand(sql, mycon);
                if (int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) <= 100 && int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) <= 100 && int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()) <= 100)
                {
                    mySqlCmd.Parameters.AddWithValue("@value1", dataGridView1.Rows[i].Cells[2].Value.ToString());
                    mySqlCmd.Parameters.AddWithValue("@value2", dataGridView1.Rows[i].Cells[3].Value.ToString());
                    mySqlCmd.Parameters.AddWithValue("@value3", dataGridView1.Rows[i].Cells[4].Value.ToString());
                    mySqlCmd.Parameters.AddWithValue("@value6", (double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString())+double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString())+double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()))/3);
                    mySqlCmd.Parameters.AddWithValue("@value4", dataGridView1.Rows[i].Cells[0].Value.ToString());
                    mySqlCmd.Parameters.AddWithValue("@value5", dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
                else
                {
                    if (int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) > 100 || int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) > 100 || int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()) > 100)
                    {
                        MessageBox.Show("有輸入成績超過100分!，請重新輸入");
                    }
                    mycon.Close();
                    return;
                }
                mySqlCmd.ExecuteNonQuery();
            }
            mycon.Close();
            Form1 f = new Form1();
            this.Visible = false;
            f.Visible = true;
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            int value = (int)key;
            //value 鍵盤對應數字
            if ((value >= 48 && value <= 57) || value == 46 || value == 8 || value == 43 || value == 45)
            {
               e.Handled = false;
            }
            else {
                e.Handled = true;
                MessageBox.Show("只能輸入數字！");
            }  
        }
    }
}
