using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PC_INFO
{
    public partial class MouseForm : Form
    {
        public MouseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl1.Text += SystemInformation.MouseButtons;
            lbl2.Text += SystemInformation.MouseWheelPresent;
            lbl3.Text += SystemInformation.MouseSpeed;
            lbl4.Text += SystemInformation.NativeMouseWheelSupport;
        }
    }
}
