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
    public partial class main : Form
    {
        
        public main()
        {
            InitializeComponent();
        }
        
        private void Home_Click(object sender, EventArgs e)
        {
            panelSepete.Visible = false;
            panelHome.Visible = true;
            panelMenu.Visible = true;
            panelMezeler.Visible = false;
            panelSanvic.Visible = false;
            panelIceck.Visible = false;
        }
        int load = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (load ==1)
            {
                // opens the loading form
                Loading lo = new Loading();
                lo.ShowDialog();
                load++;
            }
            // opens the menu home page first
            this.ControlBox = false;
            panelSepete.Visible = false;
            panelHome.Visible = true;
            panelMenu.Visible = true;
            panelMezeler.Visible = false;
            panelSanvic.Visible = false;
            panelIceck.Visible = false;
            
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

        int x1 = 0; 
        int i1=0;
        // numers to count the prices and the amount of food
        // x for how many meal and i for the price
        int x5, x6, x7, x8, x9, x10, x11, x12;
        int i5, i6, i7, i8, i9, i10, i11, i12;

        // e (ekleme ) to add a meal to the cart
        private void e1_Click(object sender, EventArgs e)
        {
            
            x1++;
            n1.Text = x1.ToString();
             i1 = 55 * x1;
            p1.Text = i1.ToString()+"TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }
        // c (cikart) to remove a meal from the cart
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

        // buttons to add and remove from the cart
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            x1++;
            n1.Text = x1.ToString();
            i1= 55 * x1;
            p1.Text = i1.ToString()+"TL";
            int z = top();
            Toplam.Text = z.ToString() + "TL";
        }
        
        // to save the order's name in a string and the id of it
        public string ord ="";
        static int id = 1;
        
        Cart form2 = new Cart();
        // top function to count the total 
        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            ord ="";
            int z = top();
            // pasing the order to form 2
            if (x1!=0)
            {
                
               int adet = i1 / 55;
                ord =l1.Text + " x"+adet.ToString() + ", ";
            }
            if (x2 != 0)
            {
                int adet = i2 / 99;
                ord = ord + l2.Text + " x" + adet.ToString() + ", ";
            }
            if (x3 != 0)
            {
                int adet = i3 / 45;
                ord = ord + l3.Text + " x" + adet.ToString() + ", ";
            }
            if (x4 != 0)
            {
                int adet = i4 / 30;
                ord = ord + l4.Text + " x" + adet.ToString() + ", ";
            }
            if (x5 != 0)
            {
                int adet = i5 / 59;
                ord = ord + l5.Text + " x" + adet.ToString() + ", ";
            }
            if (x6 != 0)
            {
                int adet = i6 / 29;
                ord = ord+ l6.Text + " x" + adet.ToString() + ", ";
            }
            if (x7 != 0)
            {
                int adet = i7 / 25;
                ord = ord+ l7.Text + " x" + adet.ToString() + ", ";
            }
            if (x8 != 0)
            {
                int adet = i8 / 20;
                ord = ord+ l8.Text + " x" + adet.ToString() + ", ";
            }
            if (x9 != 0)
            {
                int adet = i9 / 15;
                ord = ord+ l9.Text + " x" + adet.ToString() + ", ";
            }
            if (x10 != 0)
            {
                int adet = i10 / 3;
                ord = ord+ l10.Text + " x" + adet.ToString() + ", ";
            }
            if (x11 != 0)
            {
                int adet = i11 / 13;
                ord = ord + l11.Text + " x" + adet.ToString() + ", ";
            }
            if (x12 != 0)
            {
                int adet = i12 / 5;
                ord = ord+ l12.Text + " x" + adet.ToString() + ", ";
            }

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
                    MessageBox.Show("Siparişiniz hazırlanıyor^^, sipariş listindeki görebilirsiniz!", "yaaay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form2.order = ord;
                    form2.price = z;
                    form2.ide = id;

                    x1 = 0;
                    n1.Text = x1.ToString();
                    i1 = 0;
                    p1.Text = i1.ToString();

                    x2 = 0;
                    n2.Text = x2.ToString();
                    i2 = 0;
                    p2.Text = i2.ToString();

                    x3 = 0;
                    n3.Text = x3.ToString();
                    i3 = 0;
                    p3.Text = i3.ToString();

                    x4 = 0;
                    n4.Text = x4.ToString();
                    i4 = 0;
                    p4.Text = i4.ToString();

                    x5 = 0;
                    n5.Text = x5.ToString();
                    i5 = 0;
                    p5.Text = i5.ToString();

                    x6 = 0;
                    n6.Text = x6.ToString();
                    i6 = 0;
                    p6.Text = i6.ToString();

                    x7 = 0;
                    n7.Text = x7.ToString();
                    i7 = 0;
                    p7.Text = i7.ToString();

                    x8 = 0;
                    n8.Text = x8.ToString();
                    i8 = 0;
                    p8.Text = i8.ToString();

                    x9 = 0;
                    n9.Text = x9.ToString();
                    i9 = 0;
                    p9.Text = i9.ToString();

                    x10 = 0;
                    n10.Text = x10.ToString();
                    i10 = 0;
                    p10.Text = i10.ToString();

                    x11 = 0;
                    n11.Text = x11.ToString();
                    i11 = 0;
                    p11.Text = i11.ToString();

                    x12 = 0;
                    n12.Text = x12.ToString();
                    i12 = 0;
                    p12.Text = i12.ToString();

                    Toplam.Text = "";
                    top();
                    id++;
                    form2.ShowDialog();


                }
                else
                {
                    return;
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

        private void orders_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }
        About abt = new About();
        private void label2_Click(object sender, EventArgs e)
        {
            abt.ShowDialog();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.SkyBlue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.White;
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor = Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.DodgerBlue;

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
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
