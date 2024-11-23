namespace ChronoSync.Presentation.Forms
{
    partial class ActionPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionPanel));
            panel1 = new Panel();
            panel3 = new Panel();
            DashBoardBtn = new Button();
            DataVaultBtn = new Button();
            DataSyncBtn = new Button();
            PublicIP = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            MessageBox = new PictureBox();
            formContainerPanel = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MessageBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(PublicIP);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 625);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(DashBoardBtn);
            panel3.Controls.Add(DataVaultBtn);
            panel3.Controls.Add(DataSyncBtn);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 475);
            panel3.TabIndex = 3;
            // 
            // DashBoardBtn
            // 
            DashBoardBtn.AutoSize = true;
            DashBoardBtn.BackColor = SystemColors.ControlLightLight;
            DashBoardBtn.Dock = DockStyle.Top;
            DashBoardBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashBoardBtn.Location = new Point(0, 80);
            DashBoardBtn.Name = "DashBoardBtn";
            DashBoardBtn.Padding = new Padding(15, 5, 5, 5);
            DashBoardBtn.Size = new Size(207, 40);
            DashBoardBtn.TabIndex = 2;
            DashBoardBtn.Text = "DASHBOARD";
            DashBoardBtn.TextAlign = ContentAlignment.MiddleLeft;
            DashBoardBtn.UseVisualStyleBackColor = false;
            DashBoardBtn.Click += DashBoardBtn_Click;
            // 
            // DataVaultBtn
            // 
            DataVaultBtn.AutoSize = true;
            DataVaultBtn.BackColor = SystemColors.ControlLightLight;
            DataVaultBtn.Dock = DockStyle.Top;
            DataVaultBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataVaultBtn.Location = new Point(0, 40);
            DataVaultBtn.Name = "DataVaultBtn";
            DataVaultBtn.Padding = new Padding(15, 5, 5, 5);
            DataVaultBtn.Size = new Size(207, 40);
            DataVaultBtn.TabIndex = 1;
            DataVaultBtn.Text = "DATA VAULT";
            DataVaultBtn.TextAlign = ContentAlignment.MiddleLeft;
            DataVaultBtn.UseVisualStyleBackColor = false;
            DataVaultBtn.Click += DataVaultBtn_Click;
            // 
            // DataSyncBtn
            // 
            DataSyncBtn.AutoSize = true;
            DataSyncBtn.BackColor = SystemColors.ControlLightLight;
            DataSyncBtn.Dock = DockStyle.Top;
            DataSyncBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataSyncBtn.Location = new Point(0, 0);
            DataSyncBtn.Name = "DataSyncBtn";
            DataSyncBtn.Padding = new Padding(15, 5, 5, 5);
            DataSyncBtn.Size = new Size(207, 40);
            DataSyncBtn.TabIndex = 0;
            DataSyncBtn.Text = "DATA SYNC";
            DataSyncBtn.TextAlign = ContentAlignment.MiddleLeft;
            DataSyncBtn.UseVisualStyleBackColor = false;
            DataSyncBtn.Click += DataSyncBtn_Click;
            // 
            // PublicIP
            // 
            PublicIP.BackColor = SystemColors.InactiveBorder;
            PublicIP.Dock = DockStyle.Bottom;
            PublicIP.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PublicIP.Location = new Point(0, 594);
            PublicIP.Name = "PublicIP";
            PublicIP.Size = new Size(207, 31);
            PublicIP.TabIndex = 2;
            PublicIP.Text = "IPv4 Address";
            PublicIP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 62);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 30);
            label1.Size = new Size(207, 57);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.ProfileLogo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(MessageBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(207, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1169, 62);
            panel2.TabIndex = 1;
            // 
            // MessageBox
            // 
            MessageBox.BackColor = Color.Transparent;
            MessageBox.BackgroundImage = Properties.Resources.EmptyMessageBox;
            MessageBox.BackgroundImageLayout = ImageLayout.Center;
            MessageBox.Dock = DockStyle.Right;
            MessageBox.Location = new Point(1044, 0);
            MessageBox.Name = "MessageBox";
            MessageBox.Size = new Size(125, 62);
            MessageBox.TabIndex = 0;
            MessageBox.TabStop = false;
            MessageBox.Click += MessageBox_Click;
            // 
            // formContainerPanel
            // 
            formContainerPanel.AutoScroll = true;
            formContainerPanel.Dock = DockStyle.Fill;
            formContainerPanel.Location = new Point(207, 62);
            formContainerPanel.Name = "formContainerPanel";
            formContainerPanel.Size = new Size(1169, 563);
            formContainerPanel.TabIndex = 2;
            // 
            // ActionPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 625);
            Controls.Add(formContainerPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ActionPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChronoSync";
            Load += ActionPanel_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MessageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label PublicIP;
        private Panel panel3;
        private Button DataSyncBtn;
        private Button DataVaultBtn;
        private Panel formContainerPanel;
        private Button DashBoardBtn;
        private PictureBox MessageBox;
        private Label label1;
        private PictureBox pictureBox1;
    }
}