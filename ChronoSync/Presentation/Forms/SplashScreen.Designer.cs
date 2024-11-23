namespace ChronoSync.Presentation.Forms
{
    partial class SplashScreen
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
            components = new System.ComponentModel.Container();
            AppName = new Label();
            ChronoSyncProgressBar = new ProgressBar();
            ChronosyncTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // AppName
            // 
            AppName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AppName.AutoSize = true;
            AppName.BackColor = Color.Transparent;
            AppName.Font = new Font("Bell MT", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppName.ForeColor = Color.Transparent;
            AppName.Location = new Point(100, 166);
            AppName.Name = "AppName";
            AppName.Size = new Size(610, 92);
            AppName.TabIndex = 1;
            AppName.Text = "CHRONOSYNC";
            // 
            // ChronoSyncProgressBar
            // 
            ChronoSyncProgressBar.Dock = DockStyle.Bottom;
            ChronoSyncProgressBar.ForeColor = Color.Transparent;
            ChronoSyncProgressBar.Location = new Point(7, 425);
            ChronoSyncProgressBar.Margin = new Padding(20, 3, 20, 3);
            ChronoSyncProgressBar.Name = "ChronoSyncProgressBar";
            ChronoSyncProgressBar.Size = new Size(786, 18);
            ChronoSyncProgressBar.TabIndex = 4;
            // 
            // ChronosyncTimer
            // 
            ChronosyncTimer.Tick += ChronosyncTimer_Tick;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GradientBlueBg;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(ChronoSyncProgressBar);
            Controls.Add(AppName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SplashScreen";
            Padding = new Padding(7);
            StartPosition = FormStartPosition.CenterScreen;
            Load += SplashScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AppName;
        private ProgressBar ChronoSyncProgressBar;
        private System.Windows.Forms.Timer ChronosyncTimer;
    }
}