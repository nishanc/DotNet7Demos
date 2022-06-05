namespace DotNet7Demos.Demos
{
    public static class MicroAndNanoSeconds
    {
        // Read more - https://github.com/dotnet/runtime/issues/23799
        public static void Demo()
        {
            var dateTime = DateTime.Now;
            var dateTimeOffset = DateTimeOffset.Now;
            var timeSpan = TimeSpan.FromDays(12);
            var timeOnly = TimeOnly.FromDateTime(dateTime);

            Console.WriteLine(dateTime.Microsecond);
            Console.WriteLine(dateTime.Nanosecond);

            Console.WriteLine(dateTimeOffset.Microsecond);
            Console.WriteLine(dateTimeOffset.Nanosecond);

            Console.WriteLine(timeSpan.TotalMicroseconds);
            Console.WriteLine(timeSpan.TotalNanoseconds);

            Console.WriteLine(timeOnly.Microsecond);
            Console.WriteLine(timeOnly.Nanosecond);

            // Github Issue https://github.com/dotnet/runtime/issues/23799
        }
    }
}