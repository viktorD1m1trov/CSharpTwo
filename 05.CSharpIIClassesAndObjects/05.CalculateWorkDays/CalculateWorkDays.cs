//  5.Write a method that calculates the number of workdays between firstDate 
//  and given date, passed as parameter. Consider that workdays are all days 
//  from Monday to Friday except a fixed list of 
//  public holidays specified preliminary as array.

//Calculates number of business days, taking into account:
///  - weekends (Saturdays and Sundays)
///  - oficial holidays - all oficial holidays in the middle of the week and during the weekends
/// <param name="firstDate">First day in the time interval</param>
/// <param name="lastDate">Last day in the time interval</param>
/// <officialHolidays> List of official holidays including weekends</param>
/// <workDaysSaturdays> List of working Saturdays
/// <returns>Number of business days during the 'span'</returns>


using System;

class CalculateWorkDays
{
    // a number of official holidays 
    static readonly string[] officialHolidays ={"01.01.2013","03.03.2013","01.05.2013","02.05.2013","03.05.2013","04.05.2013",
                                     "05.05.2013","06.05.2013","24.05.2013","06.09.2013","22.09.2013","24.12.2013",
                                 "25.12.2013","26.12.2013","31.12.2013"};
    //working Saturdays
    static readonly string[] workDaysSaturday = { "18.05.2013", "14.12.2013" };

    static void Main()
    {
        DateTime today = DateTime.Now;

        Console.Write("Input date: ");
        string dateString = Console.ReadLine();
        DateTime dateInput = DateTime.Parse(dateString);


        if (dateInput.Date < today.Date)
        {
            throw new ArgumentException("Incorrect day " + dateInput);
        }

        int businessDays = CalculateWorkingDays(today, dateInput);
        Console.WriteLine("There ara {2} working days from {0:D} to {1:D}. ", today.Date, dateInput.Date, businessDays);

    }

    public static int CountDays(DateTime startDate, DateTime endDate)
    {
        TimeSpan period = new TimeSpan();
        period = endDate.Date.Subtract(startDate.Date);
        return (int)period.TotalDays + 1;
    }

    public static int CalculateWorkingDays(DateTime firstDate, DateTime lastDate)
    {
        int totalDays = CountDays(firstDate, lastDate);
        int fullWeeksCount = totalDays / 7;
        int businessDays = totalDays;

        // find out if there are weekends during the time exceeding the full weeks
        if (totalDays > fullWeeksCount * 7)
        {
            // we will find if there is 1-day or 2-days weekend
            //in time after subtrcting full weeks

            int firstDayOfInterval = (int)firstDate.DayOfWeek;
            int lastDayOfInterval = (int)lastDate.DayOfWeek;

            if (firstDayOfInterval > lastDayOfInterval)
            {
                lastDayOfInterval += 7;// allways firstDayOfInterval is smaller
            }

            if (firstDayOfInterval <= 6)
            {
                if (lastDayOfInterval >= 7)   //Saturaday and Sunday are in the remaining interval
                {
                    businessDays -= 2;
                }
                else if (lastDayOfInterval == 6)    // only Saturday is in the remaining interval
                {
                    businessDays -= 1;
                }
            }
            else if (firstDayOfInterval <= 7 && lastDayOfInterval >= 7)   //only Sunday is in the remaining interval
            {
                businessDays -= 1;
            }
        }

        // subtract weekends during full weeks time
        businessDays -= 2 * fullWeeksCount;

        //subtract oficial holidays if they are not in the weekends 
        foreach (string holiday in officialHolidays)
        {
            DateTime oficHol = DateTime.Parse(holiday).Date;
            if (oficHol.Date >= firstDate.Date && oficHol.Date <= lastDate.Date &&
                oficHol.DayOfWeek!=DayOfWeek.Sunday && oficHol.DayOfWeek !=DayOfWeek.Saturday)
            {
                businessDays -= 1;
            }
        }

        //add working Saturdays

        foreach (string workSaturday in workDaysSaturday)
        {
            DateTime workDateSat = DateTime.Parse(workSaturday).Date;
            if (workDateSat.Date >= firstDate.Date && workDateSat.Date <= lastDate.Date)
            {
                businessDays += 1;
            }
        }
        return businessDays;
    }

}

