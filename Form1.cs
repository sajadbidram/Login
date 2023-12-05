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
        ---------------------------------------------------------------------
        این کد خطا هل تغییر کرد و در پایین اتصال انجام شد 
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
------------------------------------------------------------------------------------------------------------------

شروع اتصال به دیتابیس و تست گرفتن 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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


            string enteredUsername = tx_n.Text;
            string enteredPassword = tx_p.Text;
            SqlConnection sqcon = new SqlConnection("Data Source=DESKTOP-LCRV0CN\\SQL;Initial Catalog=AdminDb;Integrated Security=True;");
            SqlCommand com = new SqlCommand();
            com.Connection = sqcon;
            com.CommandText = "SELECT id,UserName,password FROM [AdminDb].[dbo].[Table_Login]";
            try
            {
                com.Connection.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string username = reader.GetString(1);
                    decimal password =reader.GetDecimal(2);
                    if (enteredUsername == username && enteredPassword ==
                        password.ToString()) {

                        MessageBox.Show("برسی پسورد , نام کاربری شما درست است ");
                        return;
                    }


                }
                MessageBox.Show("Invalid username or password.");

            }
            catch(Exception ex)
            {
                MessageBox.Show("خطا: " + ex.Message);

            }
            finally
            {
                if (sqcon.State == ConnectionState.Open)
                    sqcon.Close();
            }
            
            

     
                
           
        }

        private void lb_pasword_Click(object sender, EventArgs e)
        {

        }

        private void tx_n_TextChanged(object sender, EventArgs e)
        {

        }
    }
}







