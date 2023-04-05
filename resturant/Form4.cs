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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            txt.Text = "The food we use is locally and been checked\nby a good team of healthy food organization.\nWe only try to get you the best and trusted food ever.\nWe believe that a good food must be served with\nlove and smile that is why you always\nfeel happy with us(; ";
        }

        

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.Black;
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor = Color.Red;
        }

        private void eng_Click(object sender, EventArgs e)
        {
            txt.Text = "The food we use is locally and been checked\nby a good team of healthy food organization.\nWe only try to get you the best and trusted food ever.\nWe believe that a good food must be served with\nlove and smile that is why you always\nfeel happy with us(; ";

        }

        private void tur_Click(object sender, EventArgs e)
        {
            txt.Text = "Kullandığımız yiyecekler yereldir ve iyi bir\nsağlıklı yemek organizasyonu ekibi tarafından\nkontrol edilmiştir.\nSadece en iyisini ve güvenilirini elde etmeye\nçalışıyoruz, sizi önemsiyoruz.\nİyi bir yemeğin sevgi ve gülümsemeyle sunulması\ngerektiğine inanıyoruz, bu yüzden bizimle her\nzaman mutlu hissediyorsunuz";
        }
    }
}
