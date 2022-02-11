namespace Review
{
    class UnitsOfTimeInAYear
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of years to convert to minutes: ");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You have chosen {years} years.");

            int daysInAYear = 365 * years;
            int daysInAWeek = 7;
            int hoursInADay = 24;
            int minutesInAnHour = 60;

            double weeksInAYear = daysInAYear / daysInAWeek;
            int hoursInAWeek = daysInAWeek * hoursInADay;
            int minutesInAWeek = hoursInAWeek * minutesInAnHour;
            double minutesInAYear = minutesInAWeek * weeksInAYear;

            Console.WriteLine($"There are {weeksInAYear} weeks in {daysInAYear} days.\nEach week has {daysInAWeek} days, which is {hoursInAWeek} hours or {minutesInAWeek} minutes.\nUsing these numbers, {years} year(s) has/have {minutesInAYear} minutes.");
        }
    }
}