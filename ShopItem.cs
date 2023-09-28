using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshop
{
    public partial class ShopItem : Bunifu.UI.WinForms.BunifuUserControl
    {
        public ShopItem()
        {
            InitializeComponent();
        }

        private void ShopItem_Load(object sender, EventArgs e)
        {

        }
        public Image Itemimage
        {
            get
            {
                return pictureBox1.Image; 
            }
            set
            {
                pictureBox1.Image = value;
            }
        }
        public string ItemLabel
        {
            get
            {
                return bunifuLabel1.Text;
            }
            set
            {
                bunifuLabel1.Text = value;
            }
        }
        public string ItemPrice
        {
            get
            {
                return bunifuLabel2.Text;
            }
            set
            {
                bunifuLabel2.Text = value;
            }
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuRating1_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {

        }

        private void ShopItem_Click(object sender, EventArgs e)
        {

        }

        private void bunifuIconButton1_Click_1(object sender, EventArgs e)
        {

            OrderSummary order = new OrderSummary();
            {
                
            }





        }
    }
}
