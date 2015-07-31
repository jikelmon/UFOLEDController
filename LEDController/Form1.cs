using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LEDController;
using UFOLEDController;

namespace LEDController
{
    public partial class Form1 : Form
    {
        private UFOv3 regal;
        private UFOv1 bett;

        public Form1()
        {
            InitializeComponent();
            bett = new UFOv1("Bett", "192.168.0.10");
            regal = new UFOv3("Regal", "192.168.0.21");
        }

        private void cmdOff1_Click(object sender, EventArgs e)
        {
            bett.POWER = Power.Off;
        }

        private void cmdOn2_Click(object sender, EventArgs e)
        {
            regal.POWER = Power.On;
        }

        private void cmdOff2_Click(object sender, EventArgs e)
        {
            regal.POWER = Power.Off;
        }

        private void cmdOn1_Click(object sender, EventArgs e)
        {
            bett.POWER = Power.On;
        }

        private void cmdOnAll_Click(object sender, EventArgs e)
        {
            bett.POWER = Power.On;
            regal.POWER = Power.On;
        }

        private void cmdOffAll_Click(object sender, EventArgs e)
        {
            bett.POWER = Power.Off;
            regal.POWER = Power.Off;
        }

        private void cmdRGB_Click(object sender, EventArgs e)
        {
            bett.SendRGB(255, 0, 0, 100);
            regal.SendRGB(255, 0, 0, 100);
        }

        private void cmdGreen_Click(object sender, EventArgs e)
        {
            bett.SendRGB(0, 255, 0, 100);
            regal.SendRGB(0, 255, 0, 100);
        }

        private void cmdBlue_Click(object sender, EventArgs e)
        {
            bett.SendRGB(0, 0, 255, 100);
            regal.SendRGB(0, 0, 255, 100);
        }

        private void cmdTogglePWR1_Click(object sender, EventArgs e)
        {
            bett.TogglePower();
        }

        private void cmdTogglePWR2_Click(object sender, EventArgs e)
        {
            regal.TogglePower();
        }
    }
}
