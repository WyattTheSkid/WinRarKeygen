using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.IO;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Runtime.InteropServices;
using System.Windows;

namespace WinRarKeygen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class WinAPI
        {
            public
            const int HOR_Positive = 0X1;

            public
            const int HOR_NEGATIVE = 0X2;

            public
            const int VER_POSITIVE = 0X4;

            public
            const int VER_NEGATIVE = 0X8;

            public
            const int CENTER = 0X10;

            public
            const int BLEND = 0X80000;

            public
            const int AW_HIDE = 0X10000;

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlag);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
            watermarkenabled = true;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string RunScript(String script)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipline = runspace.CreatePipeline();
            pipline.Commands.AddScript(script);
            pipline.Commands.Add("Out-String");
            Collection<PSObject> results = pipline.Invoke();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (PSObject pSObject in results)
                stringBuilder.AppendLine(pSObject.ToString());
            return stringBuilder.ToString();

        }

        public string licence1;
        public string licence2;
        public string LyraTag = "LyraKeygen";
        public string AppLocatiom = AppDomain.CurrentDomain.BaseDirectory + "\\winrar-keygen.exe";

        public string outputstring;

        private void btnRun_Click(object sender, EventArgs e)
        {
            licence2 = txtInput2.Text;
            licence1 = txtInput.Text;

            if (watermarkenabled == true)
            {
                outputstring = RunScript(AppLocatiom + " " + "\"" + LyraTag + " " + licence2 + "\"" + " " + "\"" + licence1 + "\"");
            }
            else

            {
                outputstring = RunScript(AppLocatiom + " " + "\"" + licence2 + "\"" + " " + "\"" + licence1 + "\"");
            }
        }



        private void gunaTransfarantPictureBox2_MouseHover(object sender, EventArgs e) { }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/dqvist12");
        }

        private void txtInput2_TextChanged(object sender, EventArgs e) { }

        bool watermarkenabled;

        private int _clicks = 0;
        private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();

        private void WaterMarkLabel_MouseUp(object sender, MouseEventArgs e)
        {
            _timer.Stop();
            _clicks++;

            if (_clicks > 30)
            {
                int clicksleft = 60 - _clicks;
                WaterMarkLabel.Text = "Remove watermark || You are " + clicksleft + " clicks away from removing the watermark";
            }

            if (_clicks > 40)
            {
                WaterMarkLabel.ForeColor = Color.Red;
            }

            if (_clicks == 60)
            {
                WaterMarkLabel.Text = "|| WATERMARK REMOVED ||";
                watermarkenabled = false;
                WaterMarkLabel.ForeColor = Color.Red;
                WaterMarkTimer.Start();
                _clicks = 0;
            }

            if (_clicks < 500000)
            {
                _timer.Interval = 50000;
                _timer.Start();
                _timer.Tick += (s, t) => {
                    _timer.Stop();
                    _clicks = 0;
                };
            }
        }

        private void WaterMarkTimer_Tick_1(object sender, EventArgs e)
        {
            WaterMarkLabel.Hide();
            WinRar_RarLab.Location = new Point(12, 35);
            WaterMarkTimer.Stop();
        }

        private void WinRar_RarLab_Click(object sender, EventArgs e) 
        {
            System.Diagnostics.Process.Start("http://github.com/dqvist12");
        }

        // Animate button

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            CopyRegPicMouseEnter();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            CopyRegPicMouseLeave();
        }

        private void CopyRegPic_MouseEnter(object sender, EventArgs e)
        {
            CopyRegPicMouseEnter();
        }

        private void CopyRegPic_MouseLeave(object sender, EventArgs e)
        {
            CopyRegPicMouseLeave();
        }

        public void CopyRegPicMouseEnter()
        {
            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            Size size = new Size(33, 33);
            CopyRegPic.Size = size;
        }

        public void CopyRegPicMouseLeave()
        {
            label1.Font = new Font("Arial", 11, FontStyle.Bold);
            Size size = new Size(32, 32);
            CopyRegPic.Size = size;
        }

        // activate button animation 

        public void ActivateRegPicMouseEnter()
        {
            label2.Font = new Font("Arial", 12, FontStyle.Bold);
            Size size = new Size(33, 33);
            ActivateRegPic.Size = size;
        }

        public void ActivateRegPicMouseLeave()
        {
            label2.Font = new Font("Arial", 11, FontStyle.Bold);
            Size size = new Size(32, 32);
            ActivateRegPic.Size = size;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            ActivateRegPicMouseEnter();

        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            ActivateRegPicMouseLeave();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            ActivateRegPicMouseEnter();
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            ActivateRegPicMouseLeave();
        }

        private void ActivateRegPic_MouseEnter(object sender, EventArgs e)
        {
            ActivateRegPicMouseEnter();
        }

        private void ActivateRegPic_MouseLeave(object sender, EventArgs e)
        {
            ActivateRegPicMouseLeave();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ActivateWinRar();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ActivateWinRar();
        }

        private void ActivateRegPic_Click(object sender, EventArgs e)
        {
            ActivateWinRar();
        }

        public void ActivateWinRar()
        {
            try
            {
                System.IO.File.WriteAllText(@"C:\Program Files\WinRAR\rarreg.key", outputstring);
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CopyData();
        }

        private void CopyRegPic_Click(object sender, EventArgs e)
        {
            CopyData();
        }

        public void CopyData()
        {
            sendTooutputForm();
        }

        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";

        public void sendTooutputForm()
        {
            SetValueForText1 = outputstring;
            PureOutput PureOutput = new PureOutput();

            if ((Application.OpenForms["PureOutput"] as PureOutput) != null)
            {
                SetValueForText2 = outputstring;
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                WinAPI.AnimateWindow(PureOutput.Handle, 300, WinAPI.BLEND);
                PureOutput.Show();
            }
        }

        private void SendToOutputText_Tick(object sender, EventArgs e)
        {
            SetValueForText2 = outputstring;
        }

        private void txtInput_TextChanged(object sender, EventArgs e) { }

        private void WaterMarkLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void LoadingScreen_Tick(object sender, EventArgs e)
        {

        }
    }
}