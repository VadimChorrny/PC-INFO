using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PC_INFO
{
    public partial class DevicesForm : Form
    {
        public DevicesForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PCForm pc = new PCForm();
            pc.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MonitorForm mf = new MonitorForm();
            mf.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MouseForm mf = new MouseForm();
            mf.ShowDialog();
        }
    }
}
