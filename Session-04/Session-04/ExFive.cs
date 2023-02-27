using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class ExFive
    {
        
        int seconds = 432141234;

        //Get results
        public string getDates()
        {

            int minutes = seconds / 60;
            int hours = minutes / 60;
            int days = hours / 24;
            int years = days / 365;

            string result = string.Format("{0} second(s) is:\n{1} Minute(s),\n{2} Hour(s),\n{3} Day(s),\n{4} Year(s). ", seconds,minutes, hours, days, years);

            return result;
        }


    }
}
