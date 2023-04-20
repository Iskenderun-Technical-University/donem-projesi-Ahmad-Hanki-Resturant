using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace resturant
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }
        public string order { get; set; }
        public int price { get; set; }
        public int ide { get; set; }
        public string FullNAME { get; set; }
        public int phoNUM { get; set; }

        
        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
        string ordText;
        int pri;
        int id;
        int tele;
        string FName;

        static public int i;
        
        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            
            
                dataGridView2.Visible = false;
                BackToOriginal.Visible = false;
                dataGridView1.Visible = true;
                databaseBUT.Visible = true;
                label.Text = "C# Tablosu";
                
            
            
            this.FormBorderStyle = FormBorderStyle.None;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView1.ScrollBars = ScrollBars.Horizontal;

            ordText = order;
            pri = price;
            id = ide;
            tele = phoNUM;
            FName = FullNAME;

            if (tele==0)
            { 
                return;
            }
            else
            {

                string or = ordText;
                int tot = pri;
                string FLN = FName;
                int tel = tele;
                AddItem(id, or, tot, FLN, tel);
                i++;
                tele = 0;
            }
            
        }

        public void AddItem (int i, string ordText, int pri, string name , int numberphone )
        {
            dataGridView1.Rows.Add(i, ordText, pri, name, numberphone);     
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor = Color.Red;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.Black;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Side_Click(object sender, EventArgs e)
        {
            
            dataGridView2.DataSource = null;
            //copy everything
            string sql = "SELECT * FROM MyTable";
            

            try
            {
                DataTable data = DatabaseReader.GetDataTable(sql);
                dataGridView2.DataSource = data;
                foreach (DataGridViewColumn col in dataGridView2.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                dataGridView1.ScrollBars = ScrollBars.Horizontal;

                dataGridView1.Visible = false;
                databaseBUT.Visible = false;
                dataGridView2.Visible = true;
                BackToOriginal.Visible = true;
                label.Text = "VeriTabanı Tablosu";
            }
            catch 
            {
                MessageBox.Show("couldn't complete the because of the wrong current database connection\nthat your device is connected on");
            }
           
        }

        private void BackToOriginal_Click(object sender, EventArgs e)
        {
            BackToOriginal.Visible = false;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            databaseBUT.Visible = true;
            label.Text = "C# Tablosu";
        }
        
        private void delete_Click(object sender, EventArgs e)
        {
            // set the data grid view1 to 0;!!
            


            //and from the database too
            Delete delee = new Delete();
            try
            {
                delee.DeleteAll("MyTable");
                MessageBox.Show("Everything deleted!","sucsess",MessageBoxButtons.OK,MessageBoxIcon.Information);
                main ma = new main();
                dataGridView1.Rows.Clear();
                int one = 1;
                ma.ide = 1;
                ma.myid();
                dataGridView1.Visible = false;
                databaseBUT.Visible = false;
                dataGridView2.Visible = true;
                BackToOriginal.Visible = true;
                label.Text = "C# Tablosu";
            }
            catch 
            {
                MessageBox.Show("couldn't complete the because of the wrong current database connection\nthat your device is connected on");
            }

        }
    }
}
