using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Mask : Form
    {
        public Frm_Mask()
        {
            InitializeComponent();
        }

        private void Btn_Time_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;

            Lbl_Content.Text = "";
            Msk_TextBox.Mask = "00:00";
            Lbl_ActiveMask.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";

            Msk_TextBox.Focus();
        }

        private void Btn_CEP_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;

            Lbl_Content.Text = "";
            Msk_TextBox.Mask = "00000-000";
            Lbl_ActiveMask.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";

            Msk_TextBox.Focus();
        }

        private void Btn_Currency_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;

            Lbl_Content.Text = "";
            Msk_TextBox.Mask = "$ 000,000,.00";
            Lbl_ActiveMask.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";

            Msk_TextBox.Focus();
        }

        private void Btn_Date_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;

            Lbl_Content.Text = "";
            Msk_TextBox.Mask = "00/00/0000";
            Lbl_ActiveMask.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";

            Msk_TextBox.Focus();
        }

        private void Btn_Phone_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;

            Lbl_Content.Text = "";
            Msk_TextBox.Mask = "(00) 0000-0000";
            Lbl_ActiveMask.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";

            Msk_TextBox.Focus();
        }

        private void Btn_Password_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = true;

            Lbl_Content.Text = "";
            Msk_TextBox.Mask = "000000";
            Lbl_ActiveMask.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";

            Msk_TextBox.Focus();
        }

        private void Btn_ShowContent_Click(object sender, EventArgs e)
        {
            Lbl_Content.Text = Msk_TextBox.Text;
        }
    }
}
