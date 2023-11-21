using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp326
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String c = "12345", d = "sajad";

            if(tx_n.Text==d && tx_p.Text == c)
            {
                MessageBox.Show("برسی پسورد , نام کاربری شما درست است "); 
            }
            else
            {
                MessageBox.Show("پسورد و نام کاربری  اشتباه است ");
            }            
                
           
        }

        private void lb_pasword_Click(object sender, EventArgs e)
        {

        }
    }
}
