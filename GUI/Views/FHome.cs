using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class FHome : Form
    {
        public FHome()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ChildForm(Form child)
        {
            panel1.Controls.Clear();
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel1.Controls.Add(child);
            child.Show();
        }
        private void btn_qlsv_Click(object sender, EventArgs e)
        {
            FQuanLySinhVien child = new FQuanLySinhVien();
            ChildForm(child);
            if (btn_qlsv.Enabled == true)
            {
                btn_qlsv.ForeColor = Color.BlueViolet;

                btn_qlp.ForeColor = Color.Black;
                btn_qlhd.ForeColor = Color.Black;
                btn_bctk.ForeColor = Color.Black;
                btn_qltb.ForeColor = Color.Black;
                btn_qlnv.ForeColor = Color.Black;
            }
        }

        private void btn_qlp_Click(object sender, EventArgs e)
        {
            FQuanLyPhong child = new FQuanLyPhong();
            ChildForm(child);
            if (btn_qlsv.Enabled == true)
            {
                btn_qlp.ForeColor = Color.BlueViolet;

                btn_qlsv.ForeColor = Color.Black;
                btn_qlhd.ForeColor = Color.Black;
                btn_bctk.ForeColor = Color.Black;
                btn_qltb.ForeColor = Color.Black;
                btn_qlnv.ForeColor = Color.Black;
            }
        }

        private void btn_qlhd_Click(object sender, EventArgs e)
        {
            if (btn_qlhd.Enabled == true)
            {
                btn_qlhd.ForeColor = Color.BlueViolet;


                btn_qlsv.ForeColor = Color.Black;
                btn_bctk.ForeColor = Color.Black;
                btn_qlp.ForeColor = Color.Black;

                btn_qltb.ForeColor = Color.Black;
                btn_qlnv.ForeColor = Color.Black;
            }
        }

        private void btn_qltb_Click(object sender, EventArgs e)
        {
            if (btn_qltb.Enabled == true)
            {

                btn_qltb.ForeColor = Color.BlueViolet;



                btn_qlsv.ForeColor = Color.Black;
                btn_bctk.ForeColor = Color.Black;
                btn_qlp.ForeColor = Color.Black;
                btn_qlhd.ForeColor = Color.Black;
                btn_qlnv.ForeColor = Color.Black;
            }
        }

        private void btn_qlnv_Click(object sender, EventArgs e)
        {
            if (btn_qlnv.Enabled == true)
            {
                btn_qlnv.ForeColor = Color.BlueViolet;

                btn_qlsv.ForeColor = Color.Black;
                btn_bctk.ForeColor = Color.Black;
                btn_qlp.ForeColor = Color.Black;
                btn_qltb.ForeColor = Color.Black ;
                btn_qlhd.ForeColor = Color.Black;
            }
        }

        private void btn_bctk_Click(object sender, EventArgs e)
        {
            if (btn_bctk.Enabled == true)
            {
                btn_bctk.ForeColor = Color.BlueViolet;

                btn_qlnv.ForeColor = Color.Black;
                btn_qlsv.ForeColor = Color.Black;
                btn_qlp.ForeColor = Color.Black;
                btn_qltb.ForeColor = Color.Black;
                btn_qlhd.ForeColor = Color.Black;
            }
        }
    }
}
