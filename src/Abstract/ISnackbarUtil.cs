using System;
using System.Threading.Tasks;

namespace Soenneker.Blazor.Snackbar.Abstract;

/// <summary>
/// Provides utility methods for displaying snackbars with standard and error messages.
/// </summary>
public interface ISnackbarUtil
{
    /// <summary>
    /// Event triggered to display a standard snackbar message.
    /// </summary>
    event Func<string, ValueTask> ShowEvent;

    /// <summary>
    /// Event triggered to display an error snackbar message.
    /// </summary>
    event Func<string, ValueTask> ErrorEvent;

    /// <summary>
    /// Displays a standard snackbar message.
    /// </summary>
    /// <param name="message">The message to be displayed in the snackbar.</param>
    /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
    ValueTask Show(string message);

    /// <summary>
    /// Displays an error snackbar message.
    /// </summary>
    /// <param name="message">The error message to be displayed in the snackbar.</param>
    /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
    ValueTask Error(string message);
}
