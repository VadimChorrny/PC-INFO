using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_INFO
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DevicesForm devices = new DevicesForm();
            devices.Show();
        }



        //label1.Text = SystemInformation.UserName;
        //label2.Text = Environment.MachineName;
        //   label3.Text += Environment.Version;

        // 
        // Monitor count
        // Mouse buttons
        // Mouse Speed
        // MouseWheelScrolDelta
        // Network
        // Power status
    }
}
