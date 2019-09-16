using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
namespace school_informatiom_system{
    public partial class subjectcs : Form{      
        public subjectcs(){
            InitializeComponent();
           
        }
        private void subjectcs_Load(object sender, EventArgs e){
            string cnStr, cmdText;
            cnStr = "Server=.\\SQLExpress;Database=School_information_system;Integrated Security=true";
            SqlConnection cn = new SqlConnection(cnStr);
            DataTable dt = new DataTable("Persons");
            try
            {
                cn.Open();

                // Load Data into DataGridView
                //cmdText = "SELECT student.StudentID '學號',student.name '姓名',DBsubject.number '平均成績' FROM student,DBsubject Where student.StudentID = DBsubject.StudentID";
                cmdText = "SELECT StudentID '學號',name '姓名',number '平均成績' FROM TEST";
                SqlCommand cmd = new SqlCommand(cmdText, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows) dt.Load(dr);
                dr.Close();

                dataGridView1.DataSource = dt;

                // Initialize DataGridView Columns
                dataGridView1.RowHeadersVisible = false;
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    col.ReadOnly = true;
                    if (col.GetType().Name == "DataGridViewImageColumn")
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.IsNewRow) continue;
                            row.Height = row.Cells["image"].ContentBounds.Height + 6;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
                cn = null;
            }
        }
        private void DataGridView2Excel(Excel.Worksheet Sheet){
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                // 填入欄位資料，第一欄
                Sheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;

            }
                
            for (int i = 0; i < dataGridView1.Rows.Count; i++)// 利用 DataGridView 
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    string value = dataGridView1[j, i].Value.ToString();
                    Sheet.Cells[i + 2, j + 1] = value;
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            save.FileName = "Excel Export demo";
            save.Filter = "*.xlsx|*.xlsx";
            if (save.ShowDialog() != DialogResult.OK) return;
            Excel.Application xls = null;// Excel 物件
            try{
                xls = new Excel.Application();
                Excel.Workbook book = xls.Workbooks.Add();// Excel WorkBook                
                    // 寫法1
                    Excel.Worksheet Sheet = (Excel.Worksheet)book.Worksheets.Item[1];// Excel WorkBook，預設會產生一個 WorkSheet，索引從 1 開始，而非 0
                // 寫法2
                //Excel.Worksheet Sheet = (Excel.Worksheet)book.Worksheets[1];
                // 寫法3
                //Excel.Worksheet Sheet = xls.ActiveSheet;
                DataGridView2Excel(Sheet);// 把 DataGridView 資料塞進 Excel 內
                book.SaveAs(save.FileName); // 儲存檔案
            }
            catch (Exception){
                throw;
            }
            finally{
                xls.Quit();
            }

        }
        private void button2_Click(object sender, EventArgs e){

            PrintDGV.Print_DataGridView(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.Visible = true;
        }
    }
}
