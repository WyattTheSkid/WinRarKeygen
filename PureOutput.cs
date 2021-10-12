using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRarKeygen
{
    public partial class PureOutput : Form
    {
        public PureOutput()
        {
            InitializeComponent();
        }

        private void PureOutput_Load(object sender, EventArgs e)
        {
            FocusBar.Focus();
            txtOutput.Text = Form1.SetValueForText1;
        }


        public void MouseLeave2()
        {
            label1.Font = new Font("Arial", 11, FontStyle.Bold);
            Size size = new Size(32, 32);
            CopyRegPic.Size = size;
        }

        public void MouseEnter2()
        {
            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            Size size = new Size(33, 33);
            CopyRegPic.Size = size;
        }


        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter2();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave2();
        }





        public void CopyData2()
        {
                System.Windows.Forms.Clipboard.SetText(txtOutput.Text);
                label1.Text = "Copied!";
                CopyTimer2.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CopyData2();
        }

        private void CopyTimer2_Tick(object sender, EventArgs e)
        {
                label1.Text = "Copy Licence Data";
            CopyTimer2.Stop();
        }


        private void NewOutputString_Tick(object sender, EventArgs e)
        {
            txtOutput.Text = Form1.SetValueForText2;
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
