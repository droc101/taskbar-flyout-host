namespace TaskbarFlyoutHost
{
    partial class OneFlyout
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
            this.bottomPanel1 = new AeroSuite.Controls.BottomPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.aeroLinkLabel1 = new AeroSuite.Controls.AeroLinkLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.soundSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeMixerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.networkSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dateAndTimeSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandLink1 = new AeroSuite.Controls.CommandLink();
            this.commandLink2 = new AeroSuite.Controls.CommandLink();
            this.commandLink3 = new AeroSuite.Controls.CommandLink();
            this.label1 = new System.Windows.Forms.Label();
            this.aeroProgressBar1 = new AeroSuite.Controls.AeroProgressBar();
            this.clock1 = new uxlib.Clock();
            this.bottomPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomPanel1
            // 
            this.bottomPanel1.Controls.Add(this.tableLayoutPanel2);
            this.bottomPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel1.Location = new System.Drawing.Point(0, 376);
            this.bottomPanel1.Name = "bottomPanel1";
            this.bottomPanel1.Size = new System.Drawing.Size(413, 40);
            this.bottomPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.aeroLinkLabel1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 40);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // aeroLinkLabel1
            // 
            this.aeroLinkLabel1.AutoSize = true;
            this.aeroLinkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aeroLinkLabel1.Location = new System.Drawing.Point(180, 12);
            this.aeroLinkLabel1.Name = "aeroLinkLabel1";
            this.aeroLinkLabel1.Size = new System.Drawing.Size(53, 16);
            this.aeroLinkLabel1.TabIndex = 0;
            this.aeroLinkLabel1.TabStop = true;
            this.aeroLinkLabel1.Text = "Options";
            this.aeroLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aeroLinkLabel1_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSettingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.soundSettingsToolStripMenuItem,
            this.volumeMixerToolStripMenuItem,
            this.soundsToolStripMenuItem,
            this.toolStripSeparator2,
            this.networkSettingsToolStripMenuItem,
            this.toolStripSeparator3,
            this.dateAndTimeSettingsToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(196, 182);
            // 
            // openSettingsToolStripMenuItem
            // 
            this.openSettingsToolStripMenuItem.Name = "openSettingsToolStripMenuItem";
            this.openSettingsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openSettingsToolStripMenuItem.Text = "Open Settings";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // soundSettingsToolStripMenuItem
            // 
            this.soundSettingsToolStripMenuItem.Name = "soundSettingsToolStripMenuItem";
            this.soundSettingsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.soundSettingsToolStripMenuItem.Text = "Sound Settings";
            // 
            // volumeMixerToolStripMenuItem
            // 
            this.volumeMixerToolStripMenuItem.Name = "volumeMixerToolStripMenuItem";
            this.volumeMixerToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.volumeMixerToolStripMenuItem.Text = "Volume Mixer";
            // 
            // soundsToolStripMenuItem
            // 
            this.soundsToolStripMenuItem.Name = "soundsToolStripMenuItem";
            this.soundsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.soundsToolStripMenuItem.Text = "Sounds";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // networkSettingsToolStripMenuItem
            // 
            this.networkSettingsToolStripMenuItem.Name = "networkSettingsToolStripMenuItem";
            this.networkSettingsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.networkSettingsToolStripMenuItem.Text = "Network Settings";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(192, 6);
            // 
            // dateAndTimeSettingsToolStripMenuItem
            // 
            this.dateAndTimeSettingsToolStripMenuItem.Name = "dateAndTimeSettingsToolStripMenuItem";
            this.dateAndTimeSettingsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.dateAndTimeSettingsToolStripMenuItem.Text = "Date and Time Settings";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(192, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // commandLink1
            // 
            this.commandLink1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandLink1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.commandLink1.Location = new System.Drawing.Point(12, 223);
            this.commandLink1.Name = "commandLink1";
            this.commandLink1.Note = "";
            this.commandLink1.Size = new System.Drawing.Size(389, 45);
            this.commandLink1.TabIndex = 9;
            this.commandLink1.Text = "Volume";
            this.commandLink1.UseVisualStyleBackColor = true;
            this.commandLink1.Click += new System.EventHandler(this.commandLink1_Click);
            // 
            // commandLink2
            // 
            this.commandLink2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandLink2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.commandLink2.Location = new System.Drawing.Point(12, 274);
            this.commandLink2.Name = "commandLink2";
            this.commandLink2.Note = "";
            this.commandLink2.Size = new System.Drawing.Size(389, 45);
            this.commandLink2.TabIndex = 10;
            this.commandLink2.Text = "Network";
            this.commandLink2.UseVisualStyleBackColor = true;
            this.commandLink2.Click += new System.EventHandler(this.commandLink2_Click);
            // 
            // commandLink3
            // 
            this.commandLink3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandLink3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.commandLink3.Location = new System.Drawing.Point(12, 325);
            this.commandLink3.Name = "commandLink3";
            this.commandLink3.Note = "";
            this.commandLink3.Size = new System.Drawing.Size(389, 45);
            this.commandLink3.TabIndex = 11;
            this.commandLink3.Text = "Clock";
            this.commandLink3.UseVisualStyleBackColor = true;
            this.commandLink3.Click += new System.EventHandler(this.commandLink3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "";
            // 
            // aeroProgressBar1
            // 
            this.aeroProgressBar1.Location = new System.Drawing.Point(49, 7);
            this.aeroProgressBar1.Name = "aeroProgressBar1";
            this.aeroProgressBar1.Size = new System.Drawing.Size(352, 23);
            this.aeroProgressBar1.State = AeroSuite.Controls.ProgressBarState.Normal;
            this.aeroProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.aeroProgressBar1.TabIndex = 14;
            // 
            // clock1
            // 
            this.clock1.BackColor = System.Drawing.Color.Transparent;
            this.clock1.DetailColor = System.Drawing.SystemColors.ControlDark;
            this.clock1.Location = new System.Drawing.Point(12, 36);
            this.clock1.Name = "clock1";
            this.clock1.Size = new System.Drawing.Size(389, 181);
            this.clock1.TabIndex = 12;
            this.clock1.UseCustomTime = false;
            // 
            // OneFlyout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 416);
            this.ControlBox = false;
            this.Controls.Add(this.aeroProgressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clock1);
            this.Controls.Add(this.commandLink3);
            this.Controls.Add(this.commandLink2);
            this.Controls.Add(this.commandLink1);
            this.Controls.Add(this.bottomPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OneFlyout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Deactivate += new System.EventHandler(this.OneFlyout_Deactivate);
            this.Load += new System.EventHandler(this.OneFlyout_Load);
            this.bottomPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AeroSuite.Controls.BottomPanel bottomPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem soundSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeMixerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem networkSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem dateAndTimeSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private AeroSuite.Controls.AeroLinkLabel aeroLinkLabel1;
        private AeroSuite.Controls.CommandLink commandLink1;
        private AeroSuite.Controls.CommandLink commandLink2;
        private AeroSuite.Controls.CommandLink commandLink3;
        private uxlib.Clock clock1;
        private System.Windows.Forms.Label label1;
        private AeroSuite.Controls.AeroProgressBar aeroProgressBar1;
    }
}