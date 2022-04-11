
using static System.Numerics.BitOperations;
namespace DotNet6;

public class DotNetPeriodicTimer
{
    public static async Task PrintAsync()
    {
        using var timer = new PeriodicTimer(TimeSpan.FromSeconds(1));
        while (await timer.WaitForNextTickAsync())
        {
            LogEntry? l = Random.Shared.Next(128) is int r && IsPow2(r)
                ? default
                : new(r);

            ProcessLogEntry(l);
        }
    }

    static void ProcessLogEntry(LogEntry? l)
    {
        ArgumentNullException.ThrowIfNull(l, nameof(l));
        WriteLine(l);
    }

    public record class LogEntry(int Value);
}
