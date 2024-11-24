namespace ChronoSync.Core.Interfaces
{
    public interface IApplicationInfoService
    {
        /// <summary>
        /// Gets the current application version.
        /// </summary>
        /// <returns>The application version as a string.</returns>
        string GetApplicationVersion();
    }
}
