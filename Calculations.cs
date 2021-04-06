using System;
using System.Collections.Generic;
using System.Text;

namespace WhiteboardEx_SD9
{
    class Calculations
    {
        public static double TimeAngle(int hour, int minute)
        {
            double degree1 = hour * 30;
            double degree2 = minute * 6;

            double hourHandComp = (double)minute / 60;
            degree1 += 30 * hourHandComp;

            double angle = Math.Abs(degree1 - degree2);
            if (angle > 180) angle = 360 - angle;
            return angle;
        }

        public static double FindTimeAngle(string time)
        {
            if (String.IsNullOrEmpty(time) || time.Length > 5) throw new Exception("Incorrect Date Format");
            

            string hourStr = "";
            string minStr = "";
            int ind = 0;

            for (int i = 0; i < time.Length; i++)
            {
                if (time[i] == ':')
                {
                    ind = i + 1;
                    break;
                }
                hourStr += time[i];
            }
            for (int i = ind; i < time.Length; i++)
            {
                minStr += time[i];
            }

            return TimeAngle(Int32.Parse(hourStr), Int32.Parse(minStr));
        }

    }
}
