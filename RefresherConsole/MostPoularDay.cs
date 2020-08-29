using System;
using System.Collections.Generic;
using System.Linq;

namespace RefresherConsole
{
  
    /*

Hi! Before proceeding any further, please enter your name here.

Name: Asim Suvedi


Exercise
--------
You have been tasked with helping a hotel manager find out which day was the most popular (i.e. had the highest occupancy) at the hotel.

You have a record of all stays at the hotel, represented as a list of check-in and check-out dates (both dates are inclusive).

For example, given these check-in and check-out dates:
  Guest 1: 2019-11-16 to 2019-11-20
  Guest 2: 2019-11-18 to 2019-11-20
  Guest 3: 2019-11-19 to 2019-11-22
  
  -- Analysing the dates
  
  
  Guest 1: 2019-11-16 2019-11-17 2019-11-18 2019-11-19 2019-11-20
  Guest 2:                       2019-11-18 2019-11-19 2019-11-20
  Guest 3:                                  2019-11-19 2019-11-20 2019-11-21 2019-11-22
  
  Most popular =  2019-11-19 and  2019-11-20 
  But If there are multiple dates with the same popularity, we are asked choose the earliest one.
    
  
  // so the dates are inclusive..
The most popular date is 2019-11-20 as all three stays include that date.

If there are multiple dates with the same popularity, choose the earliest one.

Another example:
  2019-05-01 to 2019-05-05
  2019-05-03 to 2019-05-08
  2019-05-02 to 2019-05-04
  2019-05-06 to 2019-05-07
  
Two dates (2019-05-03 and 2019-05-04) have the same maximum number of guests (3). We choose the earlier date 2019-05-03 as the answer.

*/


    class HotelManager
    {
        // This method is executed by the environment.
        // You may modify the body of the method but do not change
        // the method signature.
        

        public static DateTime FindMostPopularDay(IList<Stay> stays)
        {
            // Implement your logic here.

            // Might use Dictionary which will hold the date and how many times date occurs


            //if the date is null or blank then return the minimum date

            if (stays == null || stays.Count == 0)
                return DateTime.MinValue;

            //choose the earliest date if there is only one date. 
            if (stays?.Count == 1)
                return stays[0].StartDate;

            Dictionary<DateTime, int> dateFrequency = new Dictionary<DateTime, int>();

            //loop though the stay dates 

            foreach (var stay in stays)
            {

                var currentDate = stay.StartDate;

                // if the current date is less than or equal to the end date, 
                // go through to find the end date

                // might use while loop            
                while (currentDate.Date <= stay.EndDate.Date)
                {
                    // Console.WriteLine($"{currentDate.Date}");
                    if (!dateFrequency.ContainsKey(currentDate.Date))
                    {
                        dateFrequency.Add(currentDate.Date, 0);
                    }

                    dateFrequency[currentDate.Date]++;

                    currentDate = currentDate.AddDays(1);

                }

            }

            return dateFrequency.OrderByDescending(x => x.Value).ThenBy(x => x.Key).First().Key;

        }

        //might want to create a test case here so that we are validating the output

        public static void TestStays(List<Stay> stays, DateTime expectedDate, string testCaseName)
        {
            //get the actual date by calling the actual logic in FindMostPopularDay


            var actualDate = FindMostPopularDay(stays);

            //now if the actual date is not the expected date, then the test case fails

            if (actualDate.Date.ToString("yyyy-MM-dd") != expectedDate.Date.ToString("yyyy-MM-dd"))
                Console.WriteLine($"Failed Test Name: {testCaseName}, Expected: {expectedDate.Date.ToString("yyyy-MM-dd")}, Result: {actualDate.Date.ToString("yyyy-MM-dd")}");
            else
                Console.WriteLine($"Passed Test Name: {testCaseName}, Expected: {expectedDate.Date.ToString("yyyy-MM-dd")}, Result: {actualDate.Date.ToString("yyyy-MM-dd")}");


        }

    }

    public class Stay
    {
        //Need start date and end date variables to hold the dates

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Stay(string startAndEndDates)
        {
            // Parse the start and end dates from the given string.
            // Split the string to get the start date and end date

            var dates = startAndEndDates.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StartDate = DateTime.Parse(dates[0]);
            EndDate = DateTime.Parse(dates[1]);


            // You may assume that the input string is correctly formatted.



        }
    }


}
