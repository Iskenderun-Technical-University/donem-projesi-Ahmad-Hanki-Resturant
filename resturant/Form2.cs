using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resturant
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string order { get; set; }
        public int price { get; set; }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
        string[] ordText = new string[500];
        int[] pri = new int[500];
        static public int i=1;

        private void Form2_Load(object sender, EventArgs e)
        {
            ordText[i] = order;
            pri[i] = price;
        }

        public void AddItem (int i, string ordText, int pri )
        {
            dataGridView1.Rows.Add(i, ordText, pri);     
        }

        private void view_Click(object sender, EventArgs e)
        {
            if (ordText[i]==""||pri[i]==0)
            {
                MessageBox.Show("Bir şey eklenmemiş!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string or = ordText[i];
                int tot = pri[i];
                AddItem(i, or, tot);
                i++;
            }
        }
    }
}
