using System;
using System.Threading.Tasks;
using Soenneker.Blazor.Snackbar.Abstract;

namespace Soenneker.Blazor.Snackbar;

///<inheritdoc cref="ISnackbarUtil"/>
public class SnackbarUtil : ISnackbarUtil
{
    public event Func<string, ValueTask> ShowEvent = null!;
    public event Func<string, ValueTask> ErrorEvent = null!;

    public ValueTask Show(string message)
    {
        return ShowEvent(message);
    }

    public ValueTask Error(string message)
    {
        return ErrorEvent(message);
    }
}