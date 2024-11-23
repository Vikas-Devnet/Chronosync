using ChronoSync.Application.Interfaces;
using ChronoSync.Presentation.Globals;

namespace ChronoSync.Presentation.Forms
{
    public partial class SplashScreen : Form
    {
        private bool isTaskComplete = false;
        private int progress = 0;
        private readonly INetworkService _networkService;
        private readonly IApplicationInfoService _applicationInfoService;

        public SplashScreen(INetworkService networkService, IApplicationInfoService applicationInfoService) // Constructor should be public
        {
            InitializeComponent();
            _networkService = networkService;
            _applicationInfoService = applicationInfoService;
        }

        private async void SplashScreen_Load(object sender, EventArgs e)
        {
            ChronosyncTimer.Start();
            await InitializeAppAsync();
        }
        private async Task InitializeAppAsync()
        {
            try
            {
                AppState.IPAddress = await _networkService.GetPublicIPAddressAsync();
                AppState.AppVersion = _applicationInfoService.GetApplicationVersion();
                ChronoSyncProgressBar.Value = 50;
                await Task.Delay(10000);  // Simulate additional loading tasks
                ChronoSyncProgressBar.Value = 100;
                isTaskComplete = true;
            }
            catch (Exception ex)
            {
                ChronosyncTimer.Stop();
                MessageBox.Show($"An error occurred during initialization: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }

        }


        private void ChronosyncTimer_Tick(object sender, EventArgs e)
        {
            if (!isTaskComplete)
            {
                if (progress < 96)
                {
                    progress += 2;
                    ChronoSyncProgressBar.Value = progress;
                }
                else
                {
                    ChronoSyncProgressBar.Value = 96;
                }
            }
            else
            {
                ChronoSyncProgressBar.Value = 100;
                ChronosyncTimer.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
