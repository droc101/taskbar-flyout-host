namespace TaskbarFlyoutHost
{
    partial class Network
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
            this.navigationButton1 = new AeroSuite.Controls.NavigationButton();
            this.type = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bottomPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomPanel1
            // 
            this.bottomPanel1.Controls.Add(this.tableLayoutPanel2);
            this.bottomPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel1.Location = new System.Drawing.Point(0, 253);
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
            this.aeroLinkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aeroLinkLabel1.Location = new System.Drawing.Point(124, 16);
            this.aeroLinkLabel1.Name = "aeroLinkLabel1";
            this.aeroLinkLabel1.Size = new System.Drawing.Size(165, 16);
            this.aeroLinkLabel1.TabIndex = 0;
            this.aeroLinkLabel1.TabStop = true;
            this.aeroLinkLabel1.Text = "Network && Internet Settings";
            this.aeroLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aeroLinkLabel1_LinkClicked);
            // 
            // navigationButton1
            // 
            this.navigationButton1.Location = new System.Drawing.Point(12, 12);
            this.navigationButton1.Name = "navigationButton1";
            this.navigationButton1.Size = new System.Drawing.Size(30, 30);
            this.navigationButton1.TabIndex = 5;
            this.navigationButton1.Text = "navigationButton1";
            this.navigationButton1.Type = AeroSuite.Controls.NavigationButtonType.Back;
            this.navigationButton1.Click += new System.EventHandler(this.navigationButton1_Click_1);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(49, 142);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(49, 21);
            this.type.TabIndex = 12;
            this.type.Text = "Type: ";
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.Location = new System.Drawing.Point(49, 121);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(96, 21);
            this.desc.TabIndex = 13;
            this.desc.Text = "Description: ";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(47, 79);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(96, 30);
            this.name.TabIndex = 14;
            this.name.Text = "Network";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Network";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Network
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 301);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.type);
            this.Controls.Add(this.navigationButton1);
            this.Controls.Add(this.bottomPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Network";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Network_Load);
            this.bottomPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AeroSuite.Controls.BottomPanel bottomPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private AeroSuite.Controls.AeroLinkLabel aeroLinkLabel1;
        private AeroSuite.Controls.NavigationButton navigationButton1;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

