using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshop
{
    public partial class ShopItem2 : UserControl
    {
        public ShopItem2()
        {
            InitializeComponent();
        }

        private void ShopItem2_Load(object sender, EventArgs e)
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
    }
}
