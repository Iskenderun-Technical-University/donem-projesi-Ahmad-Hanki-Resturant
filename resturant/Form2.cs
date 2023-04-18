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
        string[] ordText = new string[500];
        int[] pri = new int[500];
        int id;
        int tele;
        string FName;

        static public int i;

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView1.ScrollBars = ScrollBars.Horizontal;

            ordText[i] = order;
            pri[i] = price;
            id = ide;
            tele = phoNUM;
            FName = FullNAME;

            if (i==id)
            { 
                return;
            }
            else
            {

                string or = ordText[i];
                int tot = pri[i];
                string FLN = FName;
                int tel = tele;
                AddItem(id, or, tot, FLN, tel);
                i++;

            }
            if (id>1)
            {
                not.Text = "Note: If you see that the ID number is not a one, that is because of an order that is before this one is been given, you can see it in the database file.";
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
    }
}
