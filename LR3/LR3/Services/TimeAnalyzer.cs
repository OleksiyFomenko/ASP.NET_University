namespace ASP.NET.services
{
    public class TimeAnalyzer : interfaces.ITimeAnalyzer
    {
        public string GetTimeOfDay(DateTime dateTime)
        {
            int hour = dateTime.Hour;

            if (0 <= hour && hour < 6)
            {
                return "it is night";
            }

            if (6 <= hour && hour < 12)
            {
                return "it is morning";
            }

            if (12 <= hour && hour < 18)
            {
                return "it is daytime";
            }

            if (18 <= hour && hour < 24)
            {
                return "it is evening";
            } 
            
            throw new Exception("Invalid data");
        }

    }
}
