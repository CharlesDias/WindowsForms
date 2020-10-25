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
    public partial class Frm_HelloWorld : Form
    {
        public Frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ChangeLabel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_LabelContent.Text) && !string.IsNullOrWhiteSpace(txt_LabelContent.Text))
            {
                lbl_Title.Text = txt_LabelContent.Text;
            }
        }
    }
}
