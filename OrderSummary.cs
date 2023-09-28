using Bunifu.UI.WinForms;
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
    public partial class OrderSummary : UserControl
    {

        


        public OrderSummary()
        {
            InitializeComponent();
            int a, b, c, d, m, f;
            a = int.Parse(textBox3.Text);
            b = int.Parse(textBox4.Text);
            c = int.Parse(textBox7.Text);
            d = int.Parse(textBox6.Text);
            m = int.Parse(textBox11.Text);
            f = int.Parse(textBox10.Text);
          
      
            int result = b + a + c + d + m + f;
            textBox5.Text = ((result).ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (Convert.ToInt32(textBox1.Text) <= 1000) //convert the textBox value to integer and check for your Upper Limit 
            {
                // if so, increment by your step (i used 1)
                val = Convert.ToInt32(textBox1.Text);
                val += 1;
                textBox1.Text = val.ToString();

            }
            else
            {
                // otherwise,  reset to your Default (i used 0)
                textBox1.Text = "0";

            }


            textBox3.Text = ((val * 800).ToString());
            int a, b, c, d, m, f;
            a = int.Parse(textBox3.Text);
            b = int.Parse(textBox4.Text);
            c = int.Parse(textBox7.Text);
            d = int.Parse(textBox6.Text);
            m = int.Parse(textBox11.Text);
            f = int.Parse(textBox10.Text);


            int result = b + a + c + d + m + f;
            textBox5.Text = ((result).ToString());




        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (Convert.ToInt32(textBox1.Text) > 0) //convert the textBox value to integer and check for your Lower Limit 
            {
                // if so, decrement by your step (i used 1)
                val = Convert.ToInt32(textBox1.Text);
                val -= 1;
                textBox1.Text = val.ToString();

            }
            else
            {
                // otherwise,  reset to your Default (i used 0)
                textBox1.Text = "0";

            }

            textBox3.Text = ((val * 800).ToString());
            int a, b, c, d, m, f;
            a = int.Parse(textBox3.Text);
            b = int.Parse(textBox4.Text);
            c = int.Parse(textBox7.Text);
            d = int.Parse(textBox6.Text);
            m = int.Parse(textBox11.Text);
            f = int.Parse(textBox10.Text);


            int result = b + a + c + d + m + f;
            textBox5.Text = ((result).ToString());


        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (Convert.ToInt32(textBox2.Text) <= 1000) //convert the textBox value to integer and check for your Upper Limit 
            {
                // if so, increment by your step (i used 1)
                val = Convert.ToInt32(textBox2.Text);
                val += 1;
                textBox2.Text = val.ToString();

            }
            else
            {
                // otherwise,  reset to your Default (i used 0)
                textBox2.Text = "0";

            }
            textBox4.Text = ((val * 40).ToString());
            int a, b;
            a = int.Parse(textBox3.Text);
            b = int.Parse(textBox4.Text);
            int result = b + a;
            textBox5.Text = ((result).ToString());
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (Convert.ToInt32(textBox2.Text) > 0) //convert the textBox value to integer and check for your Lower Limit 
            {
                // if so, decrement by your step (i used 1)
                val = Convert.ToInt32(textBox2.Text);
                val -= 1;
                textBox2.Text = val.ToString();

            }
            else
            {
                // otherwise,  reset to your Default (i used 0)
                textBox2.Text = "0";

            }
            textBox4.Text = ((val * 40).ToString());
            int a, b, c, d, m, f;
            a = int.Parse(textBox3.Text);
            b = int.Parse(textBox4.Text);
            c = int.Parse(textBox7.Text);
            d = int.Parse(textBox6.Text);
            m = int.Parse(textBox11.Text);
            f = int.Parse(textBox10.Text);


            int result = b + a + c + d + m + f;
            textBox5.Text = ((result).ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator12_Click(object sender, EventArgs e)
        {

        }

        private void OrderSummary_Load(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(textBox1.Text);
            textBox3.Text = ((val * 800).ToString());
            

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            textBox1.Text = ((0).ToString());
            textBox2.Text = ((0).ToString());
            textBox3.Text = ((0).ToString());
            textBox4.Text = ((0).ToString());
            textBox5.Text = ((0).ToString());
            textBox6.Text = ((0).ToString());
            textBox7.Text = ((0).ToString());
            textBox8.Text = ((0).ToString());
            textBox9.Text = ((0).ToString());
            textBox10.Text = ((0).ToString());
            textBox11.Text = ((0).ToString());
            textBox12.Text = ((0).ToString());
            textBox13.Text = ((0).ToString());


            MessageBox.Show("Order Confirmed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (Convert.ToInt32(textBox9.Text) <= 1000) //convert the textBox value to integer and check for your Upper Limit 
            {
                // if so, increment by your step (i used 1)
                val = Convert.ToInt32(textBox9.Text);
                val += 1;
                textBox9.Text = val.ToString();

            }
            else
            {
                // otherwise,  reset to your Default (i used 0)
                textBox9.Text = "0";

            }


            textBox7.Text = ((val * 350).ToString());
            int a, b, c, d, m, f;
            a = int.Parse(textBox3.Text);
            b = int.Parse(textBox4.Text);
            c = int.Parse(textBox7.Text);
            d = int.Parse(textBox6.Text);
            m = int.Parse(textBox11.Text);
            f = int.Parse(textBox10.Text);
            


            int result = b + a + c + d + m + f;
            textBox5.Text = ((result).ToString());
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (Convert.ToInt32(textBox9.Text) > 0) //convert the textBox value to integer and check for your Upper Limit 
            {
                // if so, increment by your step (i used 1)
                val = Convert.ToInt32(textBox9.Text);
                val -= 1;
                textBox9.Text = val.ToString();

            }
            else
            {
                // otherwise,  reset to your Default (i used 0)
                textBox9.Text = "0";

            }


            textBox7.Text = ((val * 350).ToString());
            int a, b, c, d, m, f;
            a = int.Parse(textBox3.Text);
            b = int.Parse(textBox4.Text);
            c = int.Parse(textBox7.Text);
            d = int.Parse(textBox6.Text);
            m = int.Parse(textBox11.Text);
            f = int.Parse(textBox10.Text);



            int result = b + a + c + d + m + f;
            textBox5.Text = ((result).ToString());
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (Convert.ToInt32(textBox8.Text) <= 1000) //convert the textBox value to integer and check for your Upper Limit 
            {
                // if so, increment by your step (i used 1)
                val = Convert.ToInt32(textBox8.Text);
                val += 1;
                textBox8.Text = val.ToString();

            }
            else
            {
                // otherwise,  reset to your Default (i used 0)
                textBox8.Text = "0";

            }


            textBox6.Text = ((val * 20).ToString());
            int a, b, c, d, m, f;
            a = int.Parse(textBox3.Text);
            b = int.Parse(textBox4.Text);
            c = int.Parse(textBox7.Text);
            d = int.Parse(textBox6.Text);
            m = int.Parse(textBox11.Text);
            f = int.Parse(textBox10.Text);
            


            int result = b + a + c + d + m + f;
            textBox5.Text = ((result).ToString());
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (Convert.ToInt32(textBox8.Text) > 0) //convert the textBox value to integer and check for your Upper Limit 
            {
                // if so, increment by your step (i used 1)
                val = Convert.ToInt32(textBox8.Text);
                val -= 1;
                textBox8.Text = val.ToString();

            }
            else
            {
                // otherwise,  reset to your Default (i used 0)
                textBox8.Text = "0";

            }


            textBox6.Text = ((val * 20).ToString());
            int a, b, c, d, m, f;
            a = int.Parse(textBox3.Text);
            b = int.Parse(textBox4.Text);
            c = int.Parse(textBox7.Text);
            d = int.Parse(textBox6.Text);
            m = int.Parse(textBox11.Text);
            f = int.Parse(textBox10.Text);



            int result = b + a + c + d + m + f;
            textBox5.Text = ((result).ToString());
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (Convert.ToInt32(textBox13.Text) <= 1000) //convert the textBox value to integer and check for your Upper Limit 
            {
                // if so, increment by your step (i used 1)
                val = Convert.ToInt32(textBox13.Text);
                val += 1;
                textBox13.Text = val.ToString();

            }
            else
            {
                // otherwise,  reset to your Default (i used 0)
                textBox13.Text = "0";

            }


            textBox11.Text = ((val * 90).ToString());
            int a, b, c, d, m, f;
            a = int.Parse(textBox3.Text);
            b = int.Parse(textBox4.Text);
            c = int.Parse(textBox7.Text);
            d = int.Parse(textBox6.Text);
            m = int.Parse(textBox11.Text);
            f = int.Parse(textBox10.Text);

          

            int result = b + a + c + d + m + f;
            textBox5.Text = ((result).ToString());
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (Convert.ToInt32(textBox13.Text) > 0) //convert the textBox value to integer and check for your Upper Limit 
            {
                // if so, increment by your step (i used 1)
                val = Convert.ToInt32(textBox13.Text);
                val -= 1;
                textBox13.Text = val.ToString();

            }
            else
            {
                // otherwise,  reset to your Default (i used 0)
                textBox13.Text = "0";

            }


            textBox11.Text = ((val * 90).ToString());
            int a, b, c, d, m, f;
            a = int.Parse(textBox3.Text);
            b = int.Parse(textBox4.Text);
            c = int.Parse(textBox7.Text);
            d = int.Parse(textBox6.Text);
            m = int.Parse(textBox11.Text);
            f = int.Parse(textBox10.Text);



            int result = b + a + c + d + m + f;
            textBox5.Text = ((result).ToString());
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (Convert.ToInt32(textBox12.Text) <= 1000) //convert the textBox value to integer and check for your Upper Limit 
            {
                // if so, increment by your step (i used 1)
                val = Convert.ToInt32(textBox12.Text);
                val += 1;
                textBox12.Text = val.ToString();

            }
            else
            {
                // otherwise,  reset to your Default (i used 0)
                textBox12.Text = "0";

            }
           

            textBox10.Text = ((val * 240).ToString());
            int a, b, c, d, m, f;
            a = int.Parse(textBox3.Text);
            b = int.Parse(textBox4.Text);
            c = int.Parse(textBox7.Text);
            d = int.Parse(textBox6.Text);
            m = int.Parse(textBox11.Text);
            f = int.Parse(textBox10.Text);

            

            int result = b + a + c + d + m + f;
            textBox5.Text = ((result).ToString());
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (Convert.ToInt32(textBox12.Text) > 0) //convert the textBox value to integer and check for your Upper Limit 
            {
                // if so, increment by your step (i used 1)
                val = Convert.ToInt32(textBox12.Text);
                val -= 1;
                textBox12.Text = val.ToString();

            }
            else
            {
                // otherwise,  reset to your Default (i used 0)
                textBox12.Text = "0";

            }


            textBox10.Text = ((val * 240).ToString());
            int a, b, c, d, m, f;
            a = int.Parse(textBox3.Text);
            b = int.Parse(textBox4.Text);
            c = int.Parse(textBox7.Text);
            d = int.Parse(textBox6.Text);
            m = int.Parse(textBox11.Text);
            f = int.Parse(textBox10.Text);



            int result = b + a + c + d + m + f;
            textBox5.Text = ((result).ToString());
        }
    }
}