using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary4;

namespace WindowsFormsApp2
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void btnsign_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void txtsign_password_TextChanged(object sender, EventArgs e)
        {
            txtsign_password.PasswordChar = '*';
        }

        private void txtsign_password2_TextChanged(object sender, EventArgs e)
        {
            txtsign_password2.PasswordChar = '*';
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            WindowsFormsApp2.Program.username = txtsign_username.Text;
            WindowsFormsApp2.Program.password = txtsign_password.Text;
            WindowsFormsApp2.Program.final = new int[WindowsFormsApp2.Program.password.Length];
            char[] a = txtsign_password.Text.ToCharArray();
            char[] b = txtsign_password2.Text.ToCharArray();
            int[] asc1 = new int[a.Length];
            int[] asc2 = new int[b.Length];
            for(int i = 0; i < a.Length; i++)
            {
                asc1[i] = a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                asc2[i] = b[i];
            }
            Class1 cl = new Class1();
            bool flag = cl.compare(asc1, asc2);
            if (flag == true)
            {
                MessageBox.Show("Account Created Successfully.");
                for(int i = 0; i < asc1.Length; i++)
                {
                    WindowsFormsApp2.Program.final[i] = asc1[i];
                }
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Password don't match.");
        }
    }
}
