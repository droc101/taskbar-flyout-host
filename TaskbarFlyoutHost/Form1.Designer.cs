namespace TaskbarFlyoutHost
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
            this.button1 = new System.Windows.Forms.Button();
            this.bottomPanel1 = new AeroSuite.Controls.BottomPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.aeroLinkLabel1 = new AeroSuite.Controls.AeroLinkLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.soundSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemSoundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeMixerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.verticalAeroProgressBar1 = new AeroSuite.Controls.VerticalAeroProgressBar();
            this.tbar1 = new TaskbarFlyoutHost.TBAR();
            this.navigationButton1 = new AeroSuite.Controls.NavigationButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bottomPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(171, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bottomPanel1
            // 
            this.bottomPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.bottomPanel1.Controls.Add(this.tableLayoutPanel2);
            this.bottomPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel1.Location = new System.Drawing.Point(0, 372);
            this.bottomPanel1.Name = "bottomPanel1";
            this.bottomPanel1.Size = new System.Drawing.Size(413, 48);
            this.bottomPanel1.TabIndex = 2;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 48);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // aeroLinkLabel1
            // 
            this.aeroLinkLabel1.AutoSize = true;
            this.aeroLinkLabel1.ContextMenuStrip = this.contextMenuStrip1;
            this.aeroLinkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aeroLinkLabel1.Location = new System.Drawing.Point(157, 15);
            this.aeroLinkLabel1.Name = "aeroLinkLabel1";
            this.aeroLinkLabel1.Size = new System.Drawing.Size(98, 18);
            this.aeroLinkLabel1.TabIndex = 0;
            this.aeroLinkLabel1.TabStop = true;
            this.aeroLinkLabel1.Text = "Volume Mixer";
            this.aeroLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aeroLinkLabel1_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundSettingsToolStripMenuItem,
            this.systemSoundsToolStripMenuItem,
            this.volumeMixerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 70);
            // 
            // soundSettingsToolStripMenuItem
            // 
            this.soundSettingsToolStripMenuItem.Name = "soundSettingsToolStripMenuItem";
            this.soundSettingsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.soundSettingsToolStripMenuItem.Text = "Sound Settings";
            this.soundSettingsToolStripMenuItem.Click += new System.EventHandler(this.soundSettingsToolStripMenuItem_Click);
            // 
            // systemSoundsToolStripMenuItem
            // 
            this.systemSoundsToolStripMenuItem.Name = "systemSoundsToolStripMenuItem";
            this.systemSoundsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.systemSoundsToolStripMenuItem.Text = "System Sounds";
            this.systemSoundsToolStripMenuItem.Click += new System.EventHandler(this.systemSoundsToolStripMenuItem_Click);
            // 
            // volumeMixerToolStripMenuItem
            // 
            this.volumeMixerToolStripMenuItem.Name = "volumeMixerToolStripMenuItem";
            this.volumeMixerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.volumeMixerToolStripMenuItem.Text = "Volume Mixer";
            this.volumeMixerToolStripMenuItem.Click += new System.EventHandler(this.volumeMixerToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 52);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 307);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.verticalAeroProgressBar1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbar1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(171, 8);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(50, 245);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // verticalAeroProgressBar1
            // 
            this.verticalAeroProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalAeroProgressBar1.Location = new System.Drawing.Point(3, 3);
            this.verticalAeroProgressBar1.Name = "verticalAeroProgressBar1";
            this.verticalAeroProgressBar1.Size = new System.Drawing.Size(4, 239);
            this.verticalAeroProgressBar1.State = AeroSuite.Controls.ProgressBarState.Normal;
            this.verticalAeroProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.verticalAeroProgressBar1.TabIndex = 4;
            // 
            // tbar1
            // 
            this.tbar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbar1.Location = new System.Drawing.Point(13, 3);
            this.tbar1.Maximum = 100;
            this.tbar1.Name = "tbar1";
            this.tbar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbar1.Size = new System.Drawing.Size(34, 239);
            this.tbar1.TabIndex = 5;
            this.tbar1.TickFrequency = 10;
            this.tbar1.Scroll += new System.EventHandler(this.tbar1_Scroll);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Volume";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 420);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navigationButton1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bottomPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.bottomPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private AeroSuite.Controls.BottomPanel bottomPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private AeroSuite.Controls.AeroLinkLabel aeroLinkLabel1;
        private AeroSuite.Controls.NavigationButton navigationButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem soundSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemSoundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeMixerToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private AeroSuite.Controls.VerticalAeroProgressBar verticalAeroProgressBar1;
        private System.Windows.Forms.Label label1;
        private TBAR tbar1;
    }
}

