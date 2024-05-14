namespace TaskbarFlyoutHost
{
    partial class Options
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
            this.navigationButton1 = new AeroSuite.Controls.NavigationButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trayVol = new System.Windows.Forms.CheckBox();
            this.trayNetwork = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openIn = new WindowsFormsAero.ComboBox();
            this.animType = new WindowsFormsAero.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.commandLink1 = new AeroSuite.Controls.CommandLink();
            this.commandLink2 = new AeroSuite.Controls.CommandLink();
            this.SuspendLayout();
            // 
            // navigationButton1
            // 
            this.navigationButton1.Location = new System.Drawing.Point(12, 12);
            this.navigationButton1.Name = "navigationButton1";
            this.navigationButton1.Size = new System.Drawing.Size(30, 30);
            this.navigationButton1.TabIndex = 4;
            this.navigationButton1.Text = "navigationButton1";
            this.navigationButton1.Type = AeroSuite.Controls.NavigationButtonType.Back;
            this.navigationButton1.Click += new System.EventHandler(this.navigationButton1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(52, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Animate Transitions";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Options";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trayVol
            // 
            this.trayVol.AutoSize = true;
            this.trayVol.Location = new System.Drawing.Point(52, 288);
            this.trayVol.Name = "trayVol";
            this.trayVol.Size = new System.Drawing.Size(109, 17);
            this.trayVol.TabIndex = 17;
            this.trayVol.Text = "Volume Tray Icon";
            this.trayVol.UseVisualStyleBackColor = true;
            this.trayVol.CheckedChanged += new System.EventHandler(this.trayVol_CheckedChanged);
            // 
            // trayNetwork
            // 
            this.trayNetwork.AutoSize = true;
            this.trayNetwork.Location = new System.Drawing.Point(52, 311);
            this.trayNetwork.Name = "trayNetwork";
            this.trayNetwork.Size = new System.Drawing.Size(114, 17);
            this.trayNetwork.TabIndex = 18;
            this.trayNetwork.Text = "Network Tray Icon";
            this.trayNetwork.UseVisualStyleBackColor = true;
            this.trayNetwork.CheckedChanged += new System.EventHandler(this.trayNetwork_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Settings links should open in:";
            // 
            // openIn
            // 
            this.openIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.openIn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openIn.FormattingEnabled = true;
            this.openIn.Items.AddRange(new object[] {
            "Settings",
            "Control Panel"});
            this.openIn.Location = new System.Drawing.Point(52, 242);
            this.openIn.Name = "openIn";
            this.openIn.Size = new System.Drawing.Size(162, 21);
            this.openIn.TabIndex = 20;
            this.openIn.SelectedIndexChanged += new System.EventHandler(this.openIn_SelectedIndexChanged);
            // 
            // animType
            // 
            this.animType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.animType.FormattingEnabled = true;
            this.animType.Items.AddRange(new object[] {
            "Slide",
            "Fade",
            "Slide and Fade"});
            this.animType.Location = new System.Drawing.Point(53, 114);
            this.animType.Name = "animType";
            this.animType.Size = new System.Drawing.Size(162, 21);
            this.animType.TabIndex = 22;
            this.animType.SelectedIndexChanged += new System.EventHandler(this.animType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Animation Type:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(53, 160);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 17);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "Enable Glass";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Text = "ribbonTab1";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Text = "ribbonTab2";
            // 
            // commandLink1
            // 
            this.commandLink1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.commandLink1.Location = new System.Drawing.Point(52, 416);
            this.commandLink1.Name = "commandLink1";
            this.commandLink1.Note = "";
            this.commandLink1.Size = new System.Drawing.Size(349, 45);
            this.commandLink1.TabIndex = 25;
            this.commandLink1.Text = "Exit App";
            this.commandLink1.UseVisualStyleBackColor = true;
            this.commandLink1.Click += new System.EventHandler(this.commandLink1_Click);
            // 
            // commandLink2
            // 
            this.commandLink2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.commandLink2.Location = new System.Drawing.Point(52, 365);
            this.commandLink2.Name = "commandLink2";
            this.commandLink2.Note = "";
            this.commandLink2.Size = new System.Drawing.Size(349, 45);
            this.commandLink2.TabIndex = 26;
            this.commandLink2.Text = "Restart App";
            this.commandLink2.UseVisualStyleBackColor = true;
            this.commandLink2.Click += new System.EventHandler(this.commandLink2_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 473);
            this.ControlBox = false;
            this.Controls.Add(this.commandLink2);
            this.Controls.Add(this.commandLink1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.animType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.openIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trayNetwork);
            this.Controls.Add(this.trayVol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.navigationButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AeroSuite.Controls.NavigationButton navigationButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox trayVol;
        private System.Windows.Forms.CheckBox trayNetwork;
        private System.Windows.Forms.Label label2;
        private WindowsFormsAero.ComboBox openIn;
        private WindowsFormsAero.ComboBox animType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private AeroSuite.Controls.CommandLink commandLink1;
        private AeroSuite.Controls.CommandLink commandLink2;
    }
}

