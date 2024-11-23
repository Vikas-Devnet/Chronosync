namespace ChronoSync.Core.Utils
{
    internal class MessageBoxHelper
    {
        public static void MessageBoxError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void MessageBoxWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void MessageBoxSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void MessageBoxNone(string message)
        {
            MessageBox.Show(message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        public static void MessageBoxInformation(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
