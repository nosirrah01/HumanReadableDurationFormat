using System.Collections.Generic;

namespace HumanReadableDurationFormat
{
    public class HumanTimeFormat
    {
        public static string formatDuration(int seconds)
        {
            string duration = string.Empty;
            List<string> nonzeroTimes = new List<string>();

            string formatedYears = "year";
            int yearsLeft = seconds / 31536000;
            if (yearsLeft != 1)
            {
                formatedYears += "s";
            }
            if (yearsLeft > 0)
            {
                nonzeroTimes.Add(yearsLeft + " " + formatedYears);
            }

            string formatedDays = "day";
            int daysLeft = (seconds - (yearsLeft * 31536000)) / 86400;
            if (daysLeft != 1)
            {
                formatedDays += "s";
            }
            if (daysLeft > 0)
            {
                nonzeroTimes.Add(daysLeft + " " + formatedDays);
            }

            string formatedHours = "hour";
            int hoursLeft = (seconds - (yearsLeft * 31536000) - (daysLeft * 86400)) / 3600;
            if (hoursLeft != 1)
            {
                formatedHours += "s";
            }
            if (hoursLeft > 0)
            {
                nonzeroTimes.Add(hoursLeft + " " + formatedHours);
            }

            string formatedMinutes = "minute";
            int minutesLeft = (seconds - (yearsLeft * 31536000) - (daysLeft * 86400) - (hoursLeft * 3600)) / 60;
            if (minutesLeft != 1)
            {
                formatedMinutes += "s";
            }
            if (minutesLeft > 0)
            {
                nonzeroTimes.Add(minutesLeft + " " + formatedMinutes);
            }

            string formatedSeconds = "second";
            int secondsLeft = seconds - (yearsLeft * 31536000) - (daysLeft * 86400) - (hoursLeft * 3600) - (minutesLeft * 60);
            if (secondsLeft != 1)
            {
                formatedSeconds += "s";
            }
            if (secondsLeft > 0)
            {
                nonzeroTimes.Add(secondsLeft+ " " +formatedSeconds);
            }


            if (nonzeroTimes.Count == 0)
            {
                duration = "now";
            } 
            else if (nonzeroTimes.Count == 1)
            {
                duration = nonzeroTimes[0];
            }
            else
            {
                foreach(string time in nonzeroTimes)
                {
                    duration += time+", ";
                }
                duration = duration.Substring(0,duration.Length-2);

                int lastCommaIndex = duration.LastIndexOf(',');
                duration = duration.Remove(lastCommaIndex, 1).Insert(lastCommaIndex, " and");
            }
            return duration;
        }
    }
}
