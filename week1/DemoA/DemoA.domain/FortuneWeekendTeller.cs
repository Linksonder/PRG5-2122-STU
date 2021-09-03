using System;

namespace DemoA.domain
{
    public class FortuneWeekendTeller
    {
        public IsHetWeekend WeekendChecker()
        {
            if(DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                return IsHetWeekend.Bietje;
            }

            if(DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                return IsHetWeekend.JaHetIsWeekend;
            }

            return IsHetWeekend.NeeNogLangeNieEllende;
        }
    }

    public enum IsHetWeekend
    {
        JaHetIsWeekend, NeeNogLangeNieEllende, Bietje
    }
}
