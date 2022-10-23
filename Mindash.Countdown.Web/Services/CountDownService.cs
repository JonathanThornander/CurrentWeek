using Microsoft.EntityFrameworkCore;
using Mindash.CurrentWeek.Web.Data;
using Mindash.CurrentWeek.Web.Data.DTOS;
using System.Globalization;

namespace Mindash.CurrentWeek.Web.Services
{
    public class CurrentWeekService : ICurrentWeekService
    {
        public CurrentTimeViewModel GetCurrentWeek()
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;

            var localNow = DateTime.Now;
            var week = cal.GetWeekOfYear(localNow, dfi.CalendarWeekRule, DayOfWeek.Monday);

            return new CurrentTimeViewModel(week, localNow); 
        }
    }
}
