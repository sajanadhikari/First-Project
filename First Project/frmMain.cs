using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int width = btn.Size.Width;
            int height = btn.Size.Height;
            int larger = 2;
            btn.Size = new Size(width + larger, height + larger);
            MessageBox.Show("Hello" + " " + txtName.Text + "!");
        }
    }
}
