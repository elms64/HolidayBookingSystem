namespace ExtensionMethods
{
    public static class DateTimeExtensions
     {
        
         // Method to trim milli second of date so we can comapre the date between the request and the date in the db
        public static DateTime TrimMilliseconds(this DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, 0, dt.Kind);
        }
    }
}