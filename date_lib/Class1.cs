namespace date_lib
{
    public class Class1
    {
        // Функция для нахождения разницы между двумя датами
        public static TimeSpan GetDateDifference(DateTime startDate, DateTime endDate)
        {
            return endDate - startDate;
        }

        // Функция для определения, является ли год високосным
        public static bool IsLeapYear(int year)
        {
            
                return DateTime.IsLeapYear(year);
           
        }

        // Функция для нахождения времени суток по заданному времени
        public static string GetTimeOfDay(DateTime time)
        {
            if (time.Hour >= 6 && time.Hour < 12)
                return "Утро";
            else if (time.Hour >= 12 && time.Hour < 18)
                return "День";
            else if (time.Hour >= 18 && time.Hour < 24)
                return "Вечер";
            else
                return "Ночь";
        }

        // Функция для форматирования даты и времени
        public static string FormatDateTime(DateTime dateTime, string format)
        {
            return dateTime.ToString(format);
        }
    }
}