namespace ConsoleApplication3
{
    using System;
    class DealingWithTypes
    {
        enum Days { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
        
        public static void Main()
        {
            DateTime currentDay = DateTime.Now;
            String currentDayName = Convert.ToString(currentDay.DayOfWeek);

            getDayTillWeekend(currentDayName);
        }

        public static void getDayTillWeekend(String currentDayName)
        {
            switch (currentDayName)
            {
                case "Monday":
                    Console.WriteLine("The remaining days till weekend - " + (5 - (int)Days.Mon));
                    Console.ReadLine();
                    break;
                case "Tuesday":
                    Console.WriteLine("The remaining days till weekend - " + (5 - (int)Days.Tue));
                    Console.ReadLine();
                    break;
                case "Wednesday":
                    Console.WriteLine("The remaining days till weekend - " + (5 - (int)Days.Wed));
                    Console.ReadLine();
                    break;
                case "Thursday":
                    Console.WriteLine("The remaining days till weekend - " + (5 - (int)Days.Thu));
                    Console.ReadLine();
                    break;
                case "Friday":
                    Console.WriteLine("Thank God it's Friday!");
                    Console.ReadLine();
                    break;
                case "Saturday":
                    Console.WriteLine("Yippee! It's weekend!");
                    Console.ReadLine();
                    break;
                case "Sunday":
                    Console.WriteLine("Yippee! It's weekend!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}    