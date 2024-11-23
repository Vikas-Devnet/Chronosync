using ChronoSync.Core.Utils;
using ChronoSync.Presentation.Globals;

namespace ChronoSync.Presentation.Forms
{
    public partial class ActionPanel : Form
    {
        private Form? activeForm = null;
        public ActionPanel()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            formContainerPanel.Controls.Add(childForm);
            formContainerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ActionPanel_Load(object sender, EventArgs e)
        {
            PublicIP.Text = $"IPv4: {AppState.IPAddress}";
        }
        private void DataSyncBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DataSyncForm());
        }
        private void DataVaultBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DataVaultForm());
        }
        private void DashBoardBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardForm());
        }
        private void MessageBox_Click(object sender, EventArgs e)
        {
            MessageBoxHelper.MessageBoxInformation("Message Box is Under Development");
        }
    }
}
