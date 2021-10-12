
namespace WinRarKeygen
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.InfoBoxShowTimer = new System.Windows.Forms.Timer(this.components);
            this.txtInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtInput2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.PictureDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.WinRar_RarLab = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.btnRun = new Guna.UI2.WinForms.Guna2Button();
            this.gunaAnimateWindow1 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.WaterMarkLabel = new System.Windows.Forms.Label();
            this.WaterMarkTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SendToOutputText = new System.Windows.Forms.Timer(this.components);
            this.ActivateRegPic = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.CopyRegPic = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.LoadingScreen = new System.Windows.Forms.Timer(this.components);
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.WinRar_RarLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivateRegPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopyRegPic)).BeginInit();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this;
            // 
            // InfoBoxShowTimer
            // 
            this.InfoBoxShowTimer.Interval = 3500;
            // 
            // txtInput
            // 
            this.txtInput.Animated = true;
            this.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput.DefaultText = "";
            this.txtInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInput.DisabledState.Parent = this.txtInput;
            this.txtInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.txtInput.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtInput.FocusedState.Parent = this.txtInput;
            this.txtInput.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInput.ForeColor = System.Drawing.Color.Black;
            this.txtInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtInput.HoverState.Parent = this.txtInput;
            this.txtInput.Location = new System.Drawing.Point(12, 178);
            this.txtInput.MaxLength = 20;
            this.txtInput.Name = "txtInput";
            this.txtInput.PasswordChar = '\0';
            this.txtInput.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtInput.PlaceholderText = "Custom Description";
            this.txtInput.SelectedText = "";
            this.txtInput.ShadowDecoration.Parent = this.txtInput;
            this.txtInput.ShortcutsEnabled = false;
            this.txtInput.Size = new System.Drawing.Size(250, 28);
            this.txtInput.TabIndex = 17;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtInput2
            // 
            this.txtInput2.Animated = true;
            this.txtInput2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput2.DefaultText = "";
            this.txtInput2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInput2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInput2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInput2.DisabledState.Parent = this.txtInput2;
            this.txtInput2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInput2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.txtInput2.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtInput2.FocusedState.Parent = this.txtInput2;
            this.txtInput2.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtInput2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInput2.ForeColor = System.Drawing.Color.Black;
            this.txtInput2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtInput2.HoverState.Parent = this.txtInput2;
            this.txtInput2.Location = new System.Drawing.Point(12, 144);
            this.txtInput2.MaxLength = 20;
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.PasswordChar = '\0';
            this.txtInput2.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtInput2.PlaceholderText = "Custom Company Licence";
            this.txtInput2.SelectedText = "";
            this.txtInput2.ShadowDecoration.Parent = this.txtInput2;
            this.txtInput2.ShortcutsEnabled = false;
            this.txtInput2.Size = new System.Drawing.Size(250, 28);
            this.txtInput2.TabIndex = 18;
            this.txtInput2.TextChanged += new System.EventHandler(this.txtInput2_TextChanged);
            // 
            // PictureDragControl
            // 
            this.PictureDragControl.TargetControl = this.WinRar_RarLab;
            // 
            // WinRar_RarLab
            // 
            this.WinRar_RarLab.BackColor = System.Drawing.Color.Transparent;
            this.WinRar_RarLab.BaseColor = System.Drawing.Color.Black;
            this.WinRar_RarLab.Image = global::WinRarKeygen.Properties.Resources.Keygen_Logo_DQVIST1;
            this.WinRar_RarLab.Location = new System.Drawing.Point(12, 21);
            this.WinRar_RarLab.Name = "WinRar_RarLab";
            this.WinRar_RarLab.Size = new System.Drawing.Size(250, 71);
            this.WinRar_RarLab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WinRar_RarLab.TabIndex = 6;
            this.WinRar_RarLab.TabStop = false;
            this.WinRar_RarLab.Click += new System.EventHandler(this.WinRar_RarLab_Click);
            // 
            // btnRun
            // 
            this.btnRun.Animated = true;
            this.btnRun.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnRun.BorderThickness = 2;
            this.btnRun.CheckedState.Parent = this.btnRun;
            this.btnRun.CustomImages.Parent = this.btnRun;
            this.btnRun.DisabledState.Parent = this.btnRun;
            this.btnRun.FillColor = System.Drawing.Color.White;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnRun.ForeColor = System.Drawing.Color.Black;
            this.btnRun.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnRun.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(60)))), ((int)(((byte)(139)))));
            this.btnRun.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRun.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRun.HoverState.Parent = this.btnRun;
            this.btnRun.Location = new System.Drawing.Point(282, 144);
            this.btnRun.Name = "btnRun";
            this.btnRun.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(60)))), ((int)(((byte)(139)))));
            this.btnRun.ShadowDecoration.Parent = this.btnRun;
            this.btnRun.Size = new System.Drawing.Size(163, 62);
            this.btnRun.TabIndex = 19;
            this.btnRun.Text = "Generate Licence";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // gunaAnimateWindow1
            // 
            this.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND;
            this.gunaAnimateWindow1.Interval = 100;
            this.gunaAnimateWindow1.TargetControl = this;
            // 
            // WaterMarkLabel
            // 
            this.WaterMarkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.WaterMarkLabel.ForeColor = System.Drawing.Color.Black;
            this.WaterMarkLabel.Location = new System.Drawing.Point(12, 112);
            this.WaterMarkLabel.Name = "WaterMarkLabel";
            this.WaterMarkLabel.Size = new System.Drawing.Size(445, 15);
            this.WaterMarkLabel.TabIndex = 28;
            this.WaterMarkLabel.Text = "Contact me to remove the Licence watermark";
            this.WaterMarkLabel.Click += new System.EventHandler(this.WaterMarkLabel_Click_1);
            this.WaterMarkLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WaterMarkLabel_MouseUp);
            // 
            // WaterMarkTimer
            // 
            this.WaterMarkTimer.Interval = 3000;
            this.WaterMarkTimer.Tick += new System.EventHandler(this.WaterMarkTimer_Tick_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(60)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(53, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Show Licence data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(60)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(297, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Activate WinRar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // SendToOutputText
            // 
            this.SendToOutputText.Enabled = true;
            this.SendToOutputText.Interval = 1;
            this.SendToOutputText.Tick += new System.EventHandler(this.SendToOutputText_Tick);
            // 
            // ActivateRegPic
            // 
            this.ActivateRegPic.BackColor = System.Drawing.Color.Transparent;
            this.ActivateRegPic.BaseColor = System.Drawing.Color.Black;
            this.ActivateRegPic.Image = global::WinRarKeygen.Properties.Resources.Activate_Pictue;
            this.ActivateRegPic.Location = new System.Drawing.Point(259, 264);
            this.ActivateRegPic.Margin = new System.Windows.Forms.Padding(0);
            this.ActivateRegPic.Name = "ActivateRegPic";
            this.ActivateRegPic.Size = new System.Drawing.Size(32, 32);
            this.ActivateRegPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ActivateRegPic.TabIndex = 32;
            this.ActivateRegPic.TabStop = false;
            this.ActivateRegPic.Click += new System.EventHandler(this.ActivateRegPic_Click);
            this.ActivateRegPic.MouseEnter += new System.EventHandler(this.ActivateRegPic_MouseEnter);
            this.ActivateRegPic.MouseLeave += new System.EventHandler(this.ActivateRegPic_MouseLeave);
            // 
            // CopyRegPic
            // 
            this.CopyRegPic.BackColor = System.Drawing.Color.Transparent;
            this.CopyRegPic.BaseColor = System.Drawing.Color.Black;
            this.CopyRegPic.Image = global::WinRarKeygen.Properties.Resources.Copy_And_Pate_Picture;
            this.CopyRegPic.Location = new System.Drawing.Point(18, 264);
            this.CopyRegPic.Margin = new System.Windows.Forms.Padding(0);
            this.CopyRegPic.Name = "CopyRegPic";
            this.CopyRegPic.Size = new System.Drawing.Size(32, 32);
            this.CopyRegPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CopyRegPic.TabIndex = 29;
            this.CopyRegPic.TabStop = false;
            this.CopyRegPic.Click += new System.EventHandler(this.CopyRegPic_Click);
            this.CopyRegPic.MouseEnter += new System.EventHandler(this.CopyRegPic_MouseEnter);
            this.CopyRegPic.MouseLeave += new System.EventHandler(this.CopyRegPic_MouseLeave);
            // 
            // LoadingScreen
            // 
            this.LoadingScreen.Enabled = true;
            this.LoadingScreen.Interval = 1;
            this.LoadingScreen.Tick += new System.EventHandler(this.LoadingScreen_Tick);
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(60)))), ((int)(((byte)(139)))));
            this.gunaSeparator2.Location = new System.Drawing.Point(-19, 239);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(501, 10);
            this.gunaSeparator2.TabIndex = 36;
            this.gunaSeparator2.Thickness = 5;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(60)))), ((int)(((byte)(139)))));
            this.gunaSeparator1.Location = new System.Drawing.Point(-19, 316);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(501, 68);
            this.gunaSeparator1.TabIndex = 37;
            this.gunaSeparator1.Thickness = 300;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 356);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.gunaSeparator2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ActivateRegPic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CopyRegPic);
            this.Controls.Add(this.WaterMarkLabel);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.WinRar_RarLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinRAR - Keygen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WinRar_RarLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivateRegPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopyRegPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl DragControl;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTransfarantPictureBox ActivateRegPic;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTransfarantPictureBox CopyRegPic;
        private System.Windows.Forms.Label WaterMarkLabel;
        private Guna.UI2.WinForms.Guna2Button btnRun;
        private Guna.UI2.WinForms.Guna2TextBox txtInput2;
        private Guna.UI2.WinForms.Guna2TextBox txtInput;
        private Guna.UI.WinForms.GunaTransfarantPictureBox WinRar_RarLab;
        private System.Windows.Forms.Timer InfoBoxShowTimer;
        private Guna.UI.WinForms.GunaDragControl PictureDragControl;
        private Guna.UI.WinForms.GunaAnimateWindow gunaAnimateWindow1;
        private System.Windows.Forms.Timer WaterMarkTimer;
        private System.Windows.Forms.Timer SendToOutputText;
        private System.Windows.Forms.Timer LoadingScreen;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
    }
}

