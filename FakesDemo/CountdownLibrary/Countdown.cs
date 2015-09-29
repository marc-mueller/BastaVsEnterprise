using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownLibrary
{
    public class Countdown
    {
        public static TimeSpan Calculate(DateTime targetEventDateTime)
        {
            return targetEventDateTime.ToUniversalTime() - DateTime.UtcNow;
        }
    }
}
