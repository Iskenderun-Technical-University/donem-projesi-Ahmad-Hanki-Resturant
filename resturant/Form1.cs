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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void homeB_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        Form2 form2 = new Form2();
        private void Home_Click(object sender, EventArgs e)
        {
            panelSepete.Visible = false;
            panelHome.Visible = true;
            panelMenu.Visible = true;
            panelMezeler.Visible = false;
            panelSanvic.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelSepete.Visible = false;
        }

        private void menuu_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            panelIceck.Visible = false;
            panelSanvic.Visible = false;
            panelMezeler.Visible = false;
        }

        private void cart_Click(object sender, EventArgs e)
        {
            panelSepete.Visible = true;
            panelHome.Visible = false;
        }

        private void orders_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        int x1 = 0;
        int i1=0;
        int x5, x6, x7, x8, x9, x10, x11, x12;
        int i5, i6, i7, i8, i9, i10, i11, i12;
        private void e1_Click(object sender, EventArgs e)
        {
            
            x1++;
            n1.Text = x1.ToString();
             i1 = 55 * x1;
            p1.Text = i1.ToString()+"TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void c1_Click(object sender, EventArgs e)
        {
            if (x1>=1)
            {
                x1--;
            }
             i1 = x1 * 55;
            n1.Text = x1.ToString();
            p1.Text = i1.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }
        
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            x1++;
            n1.Text = x1.ToString();
            i1= 55 * x1;
            p1.Text = i1.ToString()+"TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void n1_Click(object sender, EventArgs e)
        {

        }

        private void l2_Click(object sender, EventArgs e)
        {

        }
        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            int z = top();
            if (z==0)
            {
                MessageBox.Show("Bir şey eklemeniz gerekiyor","Eklenmemiş",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Onyalamak ister misiniz?", "Onaylamak", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    form2.ShowDialog();
                }
            }
        }
        int x2;
        int i2;

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            x5++;
            n5.Text = x5.ToString();
            i5 = 59 * x5;
            p5.Text = i5.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void e6_Click(object sender, EventArgs e)
        {
            x6++;
            n6.Text = x6.ToString();
            i6 = 29 * x6;
            p6.Text = i6.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void e7_Click(object sender, EventArgs e)
        {
            x7++;
            n7.Text = x7.ToString();
            i7 = 25 * x7;
            p7.Text = i7.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void se6_Click(object sender, EventArgs e)
        {
            x6++;
            n6.Text = x6.ToString();
            i6 = 29 * x6;
            p6.Text = i6.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void se7_Click(object sender, EventArgs e)
        {
            x7++;
            n7.Text = x7.ToString();
            i7 = 25 * x7;
            p7.Text = i7.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void se8_Click(object sender, EventArgs e)
        {
            x8++;
            n8.Text = x8.ToString();
            i8 = 20 * x8;
            p8.Text = i8.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void se9_Click(object sender, EventArgs e)
        {
            x9++;
            n9.Text = x9.ToString();
            i9 = 15 * x9;
            p9.Text = i9.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void Sandwitch_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            panelIceck.Visible = false;
            panelSanvic.Visible = true;
            panelMezeler.Visible = false;
        }

        private void Side_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            panelIceck.Visible = false;
            panelSanvic.Visible = false;
            panelMezeler.Visible = true;
        }

        private void Drinks_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            panelIceck.Visible = true;
            panelSanvic.Visible = false;
            panelMezeler.Visible = false;
        }

        private void se10_Click(object sender, EventArgs e)
        {
            x10++;
            n10.Text = x10.ToString();
            i10 = 3 * x10;
            p10.Text = i10.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void se11_Click(object sender, EventArgs e)
        {
            x11++;
            n11.Text = x11.ToString();
            i11 = 13 * x11;
            p11.Text = i11.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void se12_Click(object sender, EventArgs e)
        {
            x12++;
            n12.Text = x12.ToString();
            i12 = 5 * x12;
            p12.Text = i12.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void e8_Click(object sender, EventArgs e)
        {
            x8++;
            n8.Text = x8.ToString();
            i8 = 20 * x8;
            p8.Text = i8.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void e9_Click(object sender, EventArgs e)
        {
            x9++;
            n9.Text = x9.ToString();
            i9 = 15 * x9;
            p9.Text = i9.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void e10_Click(object sender, EventArgs e)
        {
            x10++;
            n10.Text = x10.ToString();
            i10 = 3 * x10;
            p10.Text = i10.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void e11_Click(object sender, EventArgs e)
        {
            x11++;
            n11.Text = x11.ToString();
            i11 = 13 * x11;
            p11.Text = i11.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void e12_Click(object sender, EventArgs e)
        {
            x12++;
            n12.Text = x12.ToString();
            i12 = 5 * x12;
            p12.Text = i12.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void c4_Click(object sender, EventArgs e)
        {
            if (x4 >= 1)
            {
                x4--;
            }
            i4 = x4 * 30;
            n4.Text = x4.ToString();
            p4.Text = i4.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void c5_Click(object sender, EventArgs e)
        {
            if (x5 >= 1)
            {
                x5--;
            }
            i5 = x5 * 59;
            n5.Text = x5.ToString();
            p5.Text = i5.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void c6_Click(object sender, EventArgs e)
        {
            if (x6 >= 1)
            {
                x6--;
            }
            i6 = x6 * 25;
            n6.Text = x6.ToString();
            p6.Text = i6.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void c9_Click(object sender, EventArgs e)
        {
            if (x9 >= 1)
            {
                x9--;
            }
            i9 = x9 * 15;
            n9.Text = x9.ToString();
            p9.Text = i9.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void c8_Click(object sender, EventArgs e)
        {
            if (x8 >= 1)
            {
                x8--;
            }
            i8 = x8 * 20;
            n8.Text = x8.ToString();
            p8.Text = i8.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void c7_Click(object sender, EventArgs e)
        {
            if (x7 >= 1)
            {
                x7--;
            }
            i7 = x7 * 25;
            n7.Text = x7.ToString();
            p7.Text = i7.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void c10_Click(object sender, EventArgs e)
        {
            if (x10 >= 1)
            {
                x10--;
            }
            i10 = x10 * 3;
            n10.Text = x10.ToString();
            p10.Text = i10.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void c11_Click(object sender, EventArgs e)
        {
            if (x11 >= 1)
            {
                x11--;
            }
            i11 = x11 * 13;
            n11.Text = x11.ToString();
            p11.Text = i11.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }
        
        private void c12_Click(object sender, EventArgs e)
        {
            if (x12 >= 1)
            {
                x12--;
            }
            i12 = x12 * 5;
            n12.Text = x12.ToString();
            p12.Text = i12.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void se2_Click(object sender, EventArgs e)
        {
            x2++;
            n2.Text = x2.ToString();
            i2 = 99 * x2;
            p2.Text = i2.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void e2_Click(object sender, EventArgs e)
        {
            x2++;
            n2.Text = x2.ToString();
            i2 = 99 * x2;
            p2.Text = i2.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void c2_Click(object sender, EventArgs e)
        {
            if (x2 >= 1)
            {
                x2--;
            }
            i2 = x2 * 55;
            n2.Text = x2.ToString();
            p2.Text = i2.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }
        int x3;
        int i3;
        private void se3_Click(object sender, EventArgs e)
        {
            x3++;
            n3.Text = x3.ToString();
            i3 = 45 * x3;
            p3.Text = i3.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void e3_Click(object sender, EventArgs e)
        {
            x3++;
            n3.Text = x3.ToString();
            i3 = 45 * x3;
            p3.Text = i3.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void c3_Click(object sender, EventArgs e)
        {
            if (x3 >= 1)
            {
                x3--;
            }
            i3 = x3 * 55;
            n3.Text = x3.ToString();
            p3.Text = i3.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void se5_Click(object sender, EventArgs e)
        {
            x5++;
            n5.Text = x5.ToString();
            i5 = 59 * x5;
            p5.Text = i5.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }
        int x4;
        int i4;
        private void se4_Click(object sender, EventArgs e)
        {
            x4++;
            n4.Text = x4.ToString();
            i4 = 30 * x4;
            p4.Text = i4.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            x4++;
            n4.Text = x4.ToString();
            i4 = 30 * x4;
            p4.Text = i4.ToString() + "TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }
        public int top ()
        {
            int TOTAL = i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12;
            if (TOTAL>0)
            {
                Warning.Text = "Eklenmiş";
                Warning.ForeColor = Color.Red;
            }
            if (TOTAL==0)
            {
                Warning.Text = "";
            }
            return TOTAL;
        }
    }
}
