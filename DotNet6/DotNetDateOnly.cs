using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6
{
    public class DotNetDateOnly
    {
        public static void Print()
        {
            DateOnly date = DateOnly.MinValue;
            Log(date, nameof(date));

            TimeOnly time = TimeOnly.MinValue;
            Log(time, nameof(time));

            TimeOnly startTime = TimeOnly.Parse("11:00 PM");
            var hoursWorked = 2;
            var endTime = startTime.AddHours(hoursWorked);
            Log(endTime, nameof(endTime));

            var isBetween = TimeOnly.Parse("12:00 AM").IsBetween(startTime, endTime);

            Log(isBetween, nameof(isBetween));

        }

        static void Log<T>(T value, string name = "")
        {
            WriteLine($"{name} {value}");
        }
    }
}
