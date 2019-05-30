namespace Kelvin
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overcastSkype6500KToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daylightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moonlight4000KToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warmWhite3000KToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraWarm2800KToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candleLight1800KToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentKelvin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kOvercastSkypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kDaylightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kMoonlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kWarmWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kExtraWarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kCandleLightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // trackBar1
            //
            this.trackBar1.Location = new System.Drawing.Point(2, 76);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Maximum = 6500;
            this.trackBar1.Minimum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(313, 45);
            this.trackBar1.SmallChange = 35;
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 4500;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            //
            // textBox1
            //
            this.textBox1.AutoSize = true;
            this.textBox1.Location = new System.Drawing.Point(10, 54);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 13);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "1000K";
            //
            // notifyIcon1
            //
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Kelvin";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            //
            // contextMenuStrip1
            //
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.temperaturesToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 92);
            //
            // infoToolStripMenuItem
            //
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            //
            // temperaturesToolStripMenuItem
            //
            this.temperaturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overcastSkype6500KToolStripMenuItem,
            this.daylightToolStripMenuItem,
            this.moonlight4000KToolStripMenuItem,
            this.warmWhite3000KToolStripMenuItem,
            this.extraWarm2800KToolStripMenuItem,
            this.candleLight1800KToolStripMenuItem});
            this.temperaturesToolStripMenuItem.Name = "temperaturesToolStripMenuItem";
            this.temperaturesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.temperaturesToolStripMenuItem.Text = "Temperatures";
            //
            // overcastSkype6500KToolStripMenuItem
            //
            this.overcastSkype6500KToolStripMenuItem.Name = "overcastSkype6500KToolStripMenuItem";
            this.overcastSkype6500KToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.overcastSkype6500KToolStripMenuItem.Tag = "6500";
            this.overcastSkype6500KToolStripMenuItem.Text = "6500K - Overcast Skype";
            this.overcastSkype6500KToolStripMenuItem.Click += new System.EventHandler(this.overcastSkype6500KToolStripMenuItem_Click);
            //
            // daylightToolStripMenuItem
            //
            this.daylightToolStripMenuItem.Name = "daylightToolStripMenuItem";
            this.daylightToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.daylightToolStripMenuItem.Tag = "5000";
            this.daylightToolStripMenuItem.Text = "5000K - Daylight";
            //
            // moonlight4000KToolStripMenuItem
            //
            this.moonlight4000KToolStripMenuItem.Name = "moonlight4000KToolStripMenuItem";
            this.moonlight4000KToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.moonlight4000KToolStripMenuItem.Tag = "4000";
            this.moonlight4000KToolStripMenuItem.Text = "4000K - Moonlight";
            //
            // warmWhite3000KToolStripMenuItem
            //
            this.warmWhite3000KToolStripMenuItem.Name = "warmWhite3000KToolStripMenuItem";
            this.warmWhite3000KToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.warmWhite3000KToolStripMenuItem.Tag = "3000";
            this.warmWhite3000KToolStripMenuItem.Text = "3000K - Warm White";
            //
            // extraWarm2800KToolStripMenuItem
            //
            this.extraWarm2800KToolStripMenuItem.Name = "extraWarm2800KToolStripMenuItem";
            this.extraWarm2800KToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.extraWarm2800KToolStripMenuItem.Tag = "2800";
            this.extraWarm2800KToolStripMenuItem.Text = "2800K - Extra Warm";
            //
            // candleLight1800KToolStripMenuItem
            //
            this.candleLight1800KToolStripMenuItem.Name = "candleLight1800KToolStripMenuItem";
            this.candleLight1800KToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.candleLight1800KToolStripMenuItem.Tag = "1800";
            this.candleLight1800KToolStripMenuItem.Text = "1800K - Candle Light";
            //
            // aboutToolStripMenuItem
            //
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            //
            // exitToolStripMenuItem
            //
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "6500K";
            //
            // lblCurrentKelvin
            //
            this.lblCurrentKelvin.AutoSize = true;
            this.lblCurrentKelvin.Location = new System.Drawing.Point(176, 54);
            this.lblCurrentKelvin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentKelvin.Name = "lblCurrentKelvin";
            this.lblCurrentKelvin.Size = new System.Drawing.Size(38, 13);
            this.lblCurrentKelvin.TabIndex = 4;
            this.lblCurrentKelvin.Text = "4500K";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temperature:";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Brightness:";
            //
            // trackBarBrightness
            //
            this.trackBarBrightness.Location = new System.Drawing.Point(2, 127);
            this.trackBarBrightness.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarBrightness.Maximum = 250;
            this.trackBarBrightness.Minimum = 15;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(313, 45);
            this.trackBarBrightness.TabIndex = 7;
            this.trackBarBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBrightness.Value = 200;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);
            //
            // menuStrip1
            //
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem1,
            this.presetsToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(327, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            //
            // infoToolStripMenuItem1
            //
            this.infoToolStripMenuItem1.Name = "infoToolStripMenuItem1";
            this.infoToolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.infoToolStripMenuItem1.Text = "Hotkeys";
            this.infoToolStripMenuItem1.Click += new System.EventHandler(this.infoToolStripMenuItem1_Click);
            //
            // presetsToolStripMenuItem
            //
            this.presetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kOvercastSkypeToolStripMenuItem,
            this.kDaylightToolStripMenuItem,
            this.kMoonlightToolStripMenuItem,
            this.kWarmWhiteToolStripMenuItem,
            this.kExtraWarmToolStripMenuItem,
            this.kCandleLightToolStripMenuItem});
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            this.presetsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.presetsToolStripMenuItem.Text = "Temperatures";
            //
            // kOvercastSkypeToolStripMenuItem
            //
            this.kOvercastSkypeToolStripMenuItem.Name = "kOvercastSkypeToolStripMenuItem";
            this.kOvercastSkypeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.kOvercastSkypeToolStripMenuItem.Tag = "6500";
            this.kOvercastSkypeToolStripMenuItem.Text = "6500K - Overcast Skype";
            //
            // kDaylightToolStripMenuItem
            //
            this.kDaylightToolStripMenuItem.Name = "kDaylightToolStripMenuItem";
            this.kDaylightToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.kDaylightToolStripMenuItem.Tag = "5000";
            this.kDaylightToolStripMenuItem.Text = "5000K - Daylight";
            //
            // kMoonlightToolStripMenuItem
            //
            this.kMoonlightToolStripMenuItem.Name = "kMoonlightToolStripMenuItem";
            this.kMoonlightToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.kMoonlightToolStripMenuItem.Tag = "4000";
            this.kMoonlightToolStripMenuItem.Text = "4000K - Moonlight";
            //
            // kWarmWhiteToolStripMenuItem
            //
            this.kWarmWhiteToolStripMenuItem.Name = "kWarmWhiteToolStripMenuItem";
            this.kWarmWhiteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.kWarmWhiteToolStripMenuItem.Tag = "3000";
            this.kWarmWhiteToolStripMenuItem.Text = "3000K - Warm White";
            //
            // kExtraWarmToolStripMenuItem
            //
            this.kExtraWarmToolStripMenuItem.Name = "kExtraWarmToolStripMenuItem";
            this.kExtraWarmToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.kExtraWarmToolStripMenuItem.Tag = "2800";
            this.kExtraWarmToolStripMenuItem.Text = "2800K - Extra Warm";
            //
            // kCandleLightToolStripMenuItem
            //
            this.kCandleLightToolStripMenuItem.Name = "kCandleLightToolStripMenuItem";
            this.kCandleLightToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.kCandleLightToolStripMenuItem.Tag = "1800";
            this.kCandleLightToolStripMenuItem.Text = "1800K - Candle Light";
            //
            // aboutToolStripMenuItem1
            //
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 169);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCurrentKelvin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Kelvin";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label textBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentKelvin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperaturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overcastSkype6500KToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daylightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moonlight4000KToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warmWhite3000KToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraWarm2800KToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candleLight1800KToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem presetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kOvercastSkypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kDaylightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kMoonlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kWarmWhiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kExtraWarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kCandleLightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

