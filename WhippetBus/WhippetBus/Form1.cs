using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhippetBus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long input = int.Parse(textBox1.Text);
            long first_reqA = Convert.ToInt64(0);
            long first_reqB = Convert.ToInt64(99);
            long second_reqA = Convert.ToInt64(100);
            long second_reqB = Convert.ToInt64(299);
            long third_reqA = Convert.ToInt64(300);
            long third_reqB = Convert.ToInt64(499);
            long fourth_req = Convert.ToInt64(500);

            double first_price = Convert.ToDouble(label7.Text);
            double second_price = Convert.ToDouble(label10.Text);
            double third_price = Convert.ToDouble(label9.Text);
            double fourth_price = Convert.ToDouble(label8.Text);


            if(input < first_reqA)
            {
                label12.Visible = true;
                label15.Visible = true;
                label15.Text = "We do not transport in reverse.";


            }

            if (!(input > first_reqB) && (input >= first_reqA))
            {

                label12.Visible = true;
                label15.Visible = true;
                label15.Text = "$ " + Convert.ToString(first_price);

            }

            if (!(input > second_reqB) && (input >= second_reqA))
            {
                label12.Visible = true;
                label15.Visible = true;
                label15.Text = "$ " + Convert.ToString(second_price);

            }


            if (!(input > third_reqB) && (input >= third_reqA))
            {

                label12.Visible = true;
                label15.Visible = true;
                label15.Text = "$ " + Convert.ToString(third_price);



            }

            if ((input >= fourth_req) && (!(input >= 5999)))
            {


                label12.Visible = true;
                label15.Visible = true;
                label15.Text = "$ " + Convert.ToString(fourth_price);
            }
            if (input >= 6000)
            {
                label12.Visible = true;
                label15.Visible = true;
                label15.Text = "Mileage entered exceeds allowable amount.";


            };
        }
    
    }
}
