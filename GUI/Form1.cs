using GUI.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        FHome fhome;
        public Form1()
        {
            InitializeComponent();
            fhome = new FHome();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string name = "admin";
            string pass = name;

            if (tbx_pass.Text == pass && txb_name.Text == name)
            {
                MessageBox.Show("ok");
                this.Hide();
                fhome.ShowDialog();
            }
        }
    }
}
