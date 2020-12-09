using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup su = new Signup();
            su.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LOGIN SUCCESSFUL!!");
            this.Hide();
            Feature fe = new Feature();
            fe.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
