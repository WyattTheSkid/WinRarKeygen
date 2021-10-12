
namespace WinRarKeygen
{
    partial class PureOutput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PureOutput));
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.FocusBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CopyRegPic = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.CopyTimer2 = new System.Windows.Forms.Timer(this.components);
            this.NewOutputString = new System.Windows.Forms.Timer(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.licensing1 = new Guna.UI.Licensing.Licensing();
            this.FocusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CopyRegPic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.White;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.Color.Black;
            this.txtOutput.HideSelection = false;
            this.txtOutput.Location = new System.Drawing.Point(1, 12);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(458, 349);
            this.txtOutput.TabIndex = 25;
            this.txtOutput.Text = "The generated Licence will show here ";
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // FocusBar
            // 
            this.FocusBar.Controls.Add(this.label1);
            this.FocusBar.Controls.Add(this.CopyRegPic);
            this.FocusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FocusBar.Location = new System.Drawing.Point(0, 363);
            this.FocusBar.Name = "FocusBar";
            this.FocusBar.Size = new System.Drawing.Size(459, 54);
            this.FocusBar.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(60)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(180, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Copy Licence Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // CopyRegPic
            // 
            this.CopyRegPic.BackColor = System.Drawing.Color.Transparent;
            this.CopyRegPic.BaseColor = System.Drawing.Color.Black;
            this.CopyRegPic.Image = global::WinRarKeygen.Properties.Resources.Copy_And_Pate_Picture;
            this.CopyRegPic.Location = new System.Drawing.Point(145, 9);
            this.CopyRegPic.Margin = new System.Windows.Forms.Padding(0);
            this.CopyRegPic.Name = "CopyRegPic";
            this.CopyRegPic.Size = new System.Drawing.Size(32, 32);
            this.CopyRegPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CopyRegPic.TabIndex = 34;
            this.CopyRegPic.TabStop = false;
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(60)))), ((int)(((byte)(139)))));
            this.gunaSeparator2.Location = new System.Drawing.Point(-17, 359);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(483, 10);
            this.gunaSeparator2.TabIndex = 35;
            this.gunaSeparator2.Thickness = 2;
            // 
            // CopyTimer2
            // 
            this.CopyTimer2.Interval = 2000;
            this.CopyTimer2.Tick += new System.EventHandler(this.CopyTimer2_Tick);
            // 
            // NewOutputString
            // 
            this.NewOutputString.Enabled = true;
            this.NewOutputString.Interval = 1;
            this.NewOutputString.Tick += new System.EventHandler(this.NewOutputString_Tick);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.FocusBar;
            // 
            // licensing1
            // 
            this.licensing1.BackColor = System.Drawing.Color.White;
            this.licensing1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.licensing1.Location = new System.Drawing.Point(450, 155);
            this.licensing1.MaximumSize = new System.Drawing.Size(348, 485);
            this.licensing1.MinimumSize = new System.Drawing.Size(348, 485);
            this.licensing1.Name = "licensing1";
            this.licensing1.Size = new System.Drawing.Size(348, 485);
            this.licensing1.TabIndex = 36;
            // 
            // PureOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 417);
            this.Controls.Add(this.licensing1);
            this.Controls.Add(this.gunaSeparator2);
            this.Controls.Add(this.FocusBar);
            this.Controls.Add(this.txtOutput);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PureOutput";
            this.Text = "Licence Output";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PureOutput_Load);
            this.FocusBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CopyRegPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Panel FocusBar;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTransfarantPictureBox CopyRegPic;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private System.Windows.Forms.Timer CopyTimer2;
        private System.Windows.Forms.Timer NewOutputString;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.Licensing.Licensing licensing1;
    }
}