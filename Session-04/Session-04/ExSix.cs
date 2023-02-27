using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class ExSix
    {

        int seconds = 432141234;

        public string getDates()
        {


            var totalSeconds = TimeSpan.FromSeconds(seconds);


            string result = string.Format("{0} second(s) is/are:\n{1} Minute(s),\n{2} Hour(s),\n{3} Day(s),\n{4} Year(s). ",
                totalSeconds.TotalSeconds, (int) totalSeconds.TotalMinutes, (int)totalSeconds.TotalHours,
                (int)totalSeconds.TotalDays, (int)totalSeconds.TotalDays/365);

         return result;
        }
    }
}
