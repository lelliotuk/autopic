namespace image_thingy
{
    partial class Main
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webCamera = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblExposure = new System.Windows.Forms.Label();
            this.trkExposure = new System.Windows.Forms.TrackBar();
            this.chkManual = new System.Windows.Forms.CheckBox();
            this.chkAf = new System.Windows.Forms.CheckBox();
            this.lblIso = new System.Windows.Forms.Label();
            this.trkIso = new System.Windows.Forms.TrackBar();
            this.txtFilePattern = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.trkInterval = new System.Windows.Forms.TrackBar();
            this.lblQuality = new System.Windows.Forms.Label();
            this.btnWebUI = new System.Windows.Forms.Button();
            this.btnSingle = new System.Windows.Forms.Button();
            this.btnVideoFeed = new System.Windows.Forms.Button();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.trkQuality = new System.Windows.Forms.TrackBar();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPortFind = new System.Windows.Forms.TextBox();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkExposure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkIso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.webCamera);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblInterval);
            this.splitContainer1.Panel2.Controls.Add(this.lblExposure);
            this.splitContainer1.Panel2.Controls.Add(this.trkExposure);
            this.splitContainer1.Panel2.Controls.Add(this.chkManual);
            this.splitContainer1.Panel2.Controls.Add(this.chkAf);
            this.splitContainer1.Panel2.Controls.Add(this.lblIso);
            this.splitContainer1.Panel2.Controls.Add(this.trkIso);
            this.splitContainer1.Panel2.Controls.Add(this.txtFilePattern);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtDir);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.btnStartStop);
            this.splitContainer1.Panel2.Controls.Add(this.trkInterval);
            this.splitContainer1.Panel2.Controls.Add(this.lblQuality);
            this.splitContainer1.Panel2.Controls.Add(this.btnWebUI);
            this.splitContainer1.Panel2.Controls.Add(this.btnSingle);
            this.splitContainer1.Panel2.Controls.Add(this.btnVideoFeed);
            this.splitContainer1.Panel2.Controls.Add(this.chkRemember);
            this.splitContainer1.Panel2.Controls.Add(this.trkQuality);
            this.splitContainer1.Panel2.Controls.Add(this.txtPassword);
            this.splitContainer1.Panel2.Controls.Add(this.txtUsername);
            this.splitContainer1.Panel2.Controls.Add(this.txtPortFind);
            this.splitContainer1.Panel2.Controls.Add(this.btnAuto);
            this.splitContainer1.Panel2.Controls.Add(this.btnGo);
            this.splitContainer1.Panel2.Controls.Add(this.txtAddress);
            this.splitContainer1.Size = new System.Drawing.Size(990, 617);
            this.splitContainer1.SplitterDistance = 700;
            this.splitContainer1.TabIndex = 1;
            // 
            // webCamera
            // 
            this.webCamera.AllowExternalDrop = true;
            this.webCamera.CreationProperties = null;
            this.webCamera.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webCamera.Location = new System.Drawing.Point(0, 0);
            this.webCamera.Name = "webCamera";
            this.webCamera.Size = new System.Drawing.Size(700, 617);
            this.webCamera.TabIndex = 4;
            this.webCamera.ZoomFactor = 1D;
            this.webCamera.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.webCamera_CoreWebView2InitializationCompleted);
            this.webCamera.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webCamera_NavigationCompleted);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Enabled = false;
            this.lblInterval.Location = new System.Drawing.Point(7, 435);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(56, 13);
            this.lblInterval.TabIndex = 13;
            this.lblInterval.Text = "Interval 3s";
            // 
            // lblExposure
            // 
            this.lblExposure.AutoSize = true;
            this.lblExposure.Enabled = false;
            this.lblExposure.Location = new System.Drawing.Point(7, 329);
            this.lblExposure.Name = "lblExposure";
            this.lblExposure.Size = new System.Drawing.Size(32, 13);
            this.lblExposure.TabIndex = 24;
            this.lblExposure.Text = "40ms";
            // 
            // trkExposure
            // 
            this.trkExposure.Enabled = false;
            this.trkExposure.Location = new System.Drawing.Point(6, 345);
            this.trkExposure.Maximum = 500;
            this.trkExposure.Minimum = 1;
            this.trkExposure.Name = "trkExposure";
            this.trkExposure.Size = new System.Drawing.Size(259, 45);
            this.trkExposure.SmallChange = 10;
            this.trkExposure.TabIndex = 23;
            this.trkExposure.Value = 40;
            this.trkExposure.Scroll += new System.EventHandler(this.trkExposure_Scroll);
            this.trkExposure.MouseCaptureChanged += new System.EventHandler(this.trkExposure_MouseCaptureChanged);
            // 
            // chkManual
            // 
            this.chkManual.AutoSize = true;
            this.chkManual.Enabled = false;
            this.chkManual.Location = new System.Drawing.Point(10, 255);
            this.chkManual.Name = "chkManual";
            this.chkManual.Size = new System.Drawing.Size(97, 17);
            this.chkManual.TabIndex = 22;
            this.chkManual.Text = "Manual Sensor";
            this.chkManual.UseVisualStyleBackColor = true;
            this.chkManual.CheckedChanged += new System.EventHandler(this.chkManual_CheckedChanged);
            // 
            // chkAf
            // 
            this.chkAf.AutoSize = true;
            this.chkAf.Enabled = false;
            this.chkAf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAf.Location = new System.Drawing.Point(10, 383);
            this.chkAf.Name = "chkAf";
            this.chkAf.Size = new System.Drawing.Size(119, 33);
            this.chkAf.TabIndex = 21;
            this.chkAf.Text = "AF Hold";
            this.chkAf.UseVisualStyleBackColor = true;
            this.chkAf.CheckedChanged += new System.EventHandler(this.chkAf_CheckedChanged);
            // 
            // lblIso
            // 
            this.lblIso.AutoSize = true;
            this.lblIso.Enabled = false;
            this.lblIso.Location = new System.Drawing.Point(7, 278);
            this.lblIso.Name = "lblIso";
            this.lblIso.Size = new System.Drawing.Size(46, 13);
            this.lblIso.TabIndex = 20;
            this.lblIso.Text = "ISO 400";
            // 
            // trkIso
            // 
            this.trkIso.Enabled = false;
            this.trkIso.Location = new System.Drawing.Point(6, 294);
            this.trkIso.Maximum = 6400;
            this.trkIso.Minimum = 100;
            this.trkIso.Name = "trkIso";
            this.trkIso.Size = new System.Drawing.Size(259, 45);
            this.trkIso.SmallChange = 10;
            this.trkIso.TabIndex = 19;
            this.trkIso.Value = 400;
            this.trkIso.Scroll += new System.EventHandler(this.trkIso_Scroll);
            this.trkIso.MouseCaptureChanged += new System.EventHandler(this.trkIso_MouseCaptureChanged);
            // 
            // txtFilePattern
            // 
            this.txtFilePattern.Location = new System.Drawing.Point(102, 528);
            this.txtFilePattern.Name = "txtFilePattern";
            this.txtFilePattern.Size = new System.Drawing.Size(178, 20);
            this.txtFilePattern.TabIndex = 18;
            this.txtFilePattern.Text = "\"photo\" HHmmss f";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Filename Pattern";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(102, 502);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(178, 20);
            this.txtDir.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Capture Directory";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Enabled = false;
            this.btnStartStop.Location = new System.Drawing.Point(9, 556);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(270, 50);
            this.btnStartStop.TabIndex = 14;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // trkInterval
            // 
            this.trkInterval.Location = new System.Drawing.Point(10, 451);
            this.trkInterval.Maximum = 120;
            this.trkInterval.Minimum = 1;
            this.trkInterval.Name = "trkInterval";
            this.trkInterval.Size = new System.Drawing.Size(259, 45);
            this.trkInterval.TabIndex = 12;
            this.trkInterval.Value = 6;
            this.trkInterval.Scroll += new System.EventHandler(this.trackInterval_Scroll);
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Enabled = false;
            this.lblQuality.Location = new System.Drawing.Point(3, 216);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(66, 13);
            this.lblQuality.TabIndex = 10;
            this.lblQuality.Text = "Feed Quality";
            // 
            // btnWebUI
            // 
            this.btnWebUI.Enabled = false;
            this.btnWebUI.Location = new System.Drawing.Point(6, 108);
            this.btnWebUI.Name = "btnWebUI";
            this.btnWebUI.Size = new System.Drawing.Size(136, 32);
            this.btnWebUI.TabIndex = 8;
            this.btnWebUI.Text = "Web UI";
            this.btnWebUI.UseVisualStyleBackColor = true;
            this.btnWebUI.Click += new System.EventHandler(this.btnWebUI_Click);
            // 
            // btnSingle
            // 
            this.btnSingle.Enabled = false;
            this.btnSingle.Location = new System.Drawing.Point(148, 108);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(132, 32);
            this.btnSingle.TabIndex = 8;
            this.btnSingle.Text = "Single Photo";
            this.btnSingle.UseVisualStyleBackColor = true;
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // btnVideoFeed
            // 
            this.btnVideoFeed.Enabled = false;
            this.btnVideoFeed.Location = new System.Drawing.Point(6, 146);
            this.btnVideoFeed.Name = "btnVideoFeed";
            this.btnVideoFeed.Size = new System.Drawing.Size(136, 32);
            this.btnVideoFeed.TabIndex = 8;
            this.btnVideoFeed.Text = "Video Feed";
            this.btnVideoFeed.UseVisualStyleBackColor = true;
            this.btnVideoFeed.Click += new System.EventHandler(this.btnVideoFeed_Click);
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Location = new System.Drawing.Point(6, 85);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(77, 17);
            this.chkRemember.TabIndex = 7;
            this.chkRemember.Text = "Remember";
            this.chkRemember.UseVisualStyleBackColor = true;
            this.chkRemember.CheckedChanged += new System.EventHandler(this.chkSave_CheckedChanged);
            // 
            // trkQuality
            // 
            this.trkQuality.Enabled = false;
            this.trkQuality.Location = new System.Drawing.Point(6, 184);
            this.trkQuality.Maximum = 100;
            this.trkQuality.Minimum = 1;
            this.trkQuality.Name = "trkQuality";
            this.trkQuality.Size = new System.Drawing.Size(259, 45);
            this.trkQuality.TabIndex = 6;
            this.trkQuality.Value = 1;
            this.trkQuality.Scroll += new System.EventHandler(this.trackQuality_Scroll);
            this.trkQuality.MouseCaptureChanged += new System.EventHandler(this.trackQuality_MouseCaptureChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(127, 32);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(153, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Password...";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(6, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(115, 20);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "Username...";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPortFind
            // 
            this.txtPortFind.Location = new System.Drawing.Point(6, 6);
            this.txtPortFind.Name = "txtPortFind";
            this.txtPortFind.Size = new System.Drawing.Size(100, 20);
            this.txtPortFind.TabIndex = 3;
            this.txtPortFind.Text = "8080";
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(112, 4);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(171, 23);
            this.btnAuto.TabIndex = 2;
            this.btnAuto.Text = "Auto find port";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(208, 59);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(72, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(6, 59);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(196, 20);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.Text = "Address...";
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 617);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Main";
            this.Text = "Autopic";
            this.Load += new System.EventHandler(this.Main_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkExposure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkIso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkQuality)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtPortFind;
        private Microsoft.Web.WebView2.WinForms.WebView2 webCamera;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnWebUI;
        private System.Windows.Forms.Button btnSingle;
        private System.Windows.Forms.Button btnVideoFeed;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.TrackBar trkQuality;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.TrackBar trkInterval;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txtFilePattern;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIso;
        private System.Windows.Forms.TrackBar trkIso;
        private System.Windows.Forms.CheckBox chkAf;
        private System.Windows.Forms.CheckBox chkManual;
        private System.Windows.Forms.Label lblExposure;
        private System.Windows.Forms.TrackBar trkExposure;
    }
}

