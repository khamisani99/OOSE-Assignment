using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace WindowsFormsApp2
{
    public partial class PlaceOrder : Form
    {

        public PlaceOrder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            lblusername.Text = WindowsFormsApp2.Program.username;

            txtpriceapple.Text = WindowsFormsApp2.Program.apple.ToString();
            txtpricesamsung.Text = WindowsFormsApp2.Program.samsung.ToString();
            txtpricehuawei.Text = WindowsFormsApp2.Program.huawei.ToString();
            txtpricevivo.Text = WindowsFormsApp2.Program.vivo.ToString();
            txtpricesony.Text = WindowsFormsApp2.Program.sony.ToString();
            txtpricemotorolla.Text = WindowsFormsApp2.Program.motorolla.ToString();
            txtpriceoneplus.Text = WindowsFormsApp2.Program.oneplus.ToString();

            txtpriceapple.Enabled = false;
            txtpricesamsung.Enabled = false;
            txtpricehuawei.Enabled = false;
            txtpricevivo.Enabled = false;
            txtpricesony.Enabled = false;
            txtpricemotorolla.Enabled = false;
            txtpriceoneplus.Enabled = false;

            txtqtyapple.Enabled = false;
            txtqtysamsung.Enabled = false;
            txtqtyhuawei.Enabled = false;
            txtqtyvivo.Enabled = false;
            txtqtysony.Enabled = false;
            txtqtymotorolla.Enabled = false;
            txtqtyoneplus.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkapple_CheckedChanged(object sender, EventArgs e)
        {
            if (chkapple.Checked == true)
            {
                txtqtyapple.Enabled = true;
                txtqtyapple.Text = "0";
            }
        }

        private void chksamsung_CheckedChanged(object sender, EventArgs e)
        {
            if (chksamsung.Checked == true)
            {
                txtqtysamsung.Enabled = true;
                txtqtysamsung.Text = "0";
            }
        }

        private void chkhuawei_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhuawei.Checked == true)
            {
                txtqtyhuawei.Enabled = true;
                txtqtyhuawei.Text = "0";
            }
        }

        private void chkvivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkvivo.Checked == true)
            {
                txtqtyvivo.Enabled = true;
                txtqtyvivo.Text = "0";
            }
        }

        private void chksony_CheckedChanged(object sender, EventArgs e)
        {
            if (chksony.Checked == true)
            {
                txtqtysony.Enabled = true;
                txtqtysony.Text = "0";
            }
        }

        private void chkmotorolla_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmotorolla.Checked == true)
            {
                txtqtymotorolla.Enabled = true;
                txtqtymotorolla.Text = "0";
            }
        }

        private void chkoneplus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkoneplus.Checked == true)
            {
                txtqtyoneplus.Enabled = true;
                txtqtyoneplus.Text = "0";
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnplaceorder_Click(object sender, EventArgs e)
        {
            Reciept r = new Reciept();
            if (chkapple.Checked == true)
                WindowsFormsApp2.Program.qtyapple = Convert.ToInt32(txtqtyapple.Text);
            if (chksamsung.Checked == true)
                WindowsFormsApp2.Program.qtysamsung = Convert.ToInt32(txtqtysamsung.Text);
            if (chkhuawei.Checked == true)
                WindowsFormsApp2.Program.qtyhuawei = Convert.ToInt32(txtqtyhuawei.Text);
            if (chkvivo.Checked == true)
                WindowsFormsApp2.Program.qtyvivo = Convert.ToInt32(txtqtyvivo.Text);
            if (chksony.Checked == true)
                WindowsFormsApp2.Program.qtysony = Convert.ToInt32(txtqtysony.Text);
            if (chkmotorolla.Checked == true)
                WindowsFormsApp2.Program.qtymotorolla = Convert.ToInt32(txtqtymotorolla.Text);
            if (chkoneplus.Checked == true)
                WindowsFormsApp2.Program.qtyoneplus = Convert.ToInt32(txtqtyoneplus.Text);
            reciept c = new reciept();
            WindowsFormsApp2.Program.total = c.total(WindowsFormsApp2.Program.qtyapple, WindowsFormsApp2.Program.qtysamsung, WindowsFormsApp2.Program.qtyhuawei, WindowsFormsApp2.Program.qtyvivo, WindowsFormsApp2.Program.qtysony, WindowsFormsApp2.Program.qtymotorolla, WindowsFormsApp2.Program.qtyoneplus, WindowsFormsApp2.Program.apple, WindowsFormsApp2.Program.samsung, WindowsFormsApp2.Program.huawei, WindowsFormsApp2.Program.vivo, WindowsFormsApp2.Program.sony, WindowsFormsApp2.Program.motorolla, WindowsFormsApp2.Program.oneplus);
            txtqtyapple.Enabled = false;
            txtqtysamsung.Enabled = false;
            txtqtyhuawei.Enabled = false;
            txtqtyvivo.Enabled = false;
            txtqtysony.Enabled = false;
            txtqtymotorolla.Enabled = false;
            txtqtyoneplus.Enabled = false;
            r.Show();
            this.Hide();

           
        }

        private void txtqtyapple_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
