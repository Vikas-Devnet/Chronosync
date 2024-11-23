namespace ChronoSync.Application.Interfaces
{
    /// <summary>
    /// Gets the current application version.
    /// </summary>
    /// <returns>The application version as a string.</returns>
    public interface IApplicationInfoService  // Make sure this is public
    {
        string GetApplicationVersion();
    }
}
