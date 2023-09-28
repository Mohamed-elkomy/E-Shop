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
    public partial class ShippingAdress : UserControl
    {
        public ShippingAdress()
        {
            InitializeComponent();
        }

        private void ShippingAdress_Load(object sender, EventArgs e)
        {

        }
        private void clear()
        {





        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuTextBox1.Clear();
            bunifuTextBox2.Clear();
            bunifuTextBox3.Clear();
            bunifuTextBox4.Clear();
            bunifuTextBox5.Clear();
            bunifuTextBox6.Clear();
            bunifuTextBox7.Clear();
            bunifuTextBox8.Clear();

            MessageBox.Show("Address saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
