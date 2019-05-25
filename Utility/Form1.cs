using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StatusBateria();
        }

        private void StatusBateria()
        {
            PowerStatus status = SystemInformation.PowerStatus;
            txtChargeStatus.Text = status.BatteryChargeStatus.ToString();
            if (status.BatteryFullLifetime == -1)
                txtFullLifetime.Text = "Unknown";
            else
                txtFullLifetime.Text =
                    status.BatteryFullLifetime.ToString();
            txtCharge.Text = status.BatteryLifePercent.ToString("P0");
            if (status.BatteryLifeRemaining == -1)
                txtLifeRemaining.Text = "Unknown";
            else
                txtLifeRemaining.Text =
                    status.BatteryLifeRemaining.ToString();
            txtLineStatus.Text = status.PowerLineStatus.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatusBateria();
        }
    }
}
