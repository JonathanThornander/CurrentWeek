using Microsoft.EntityFrameworkCore;
using Mindash.CurrentWeek.Web.Data;
using Mindash.CurrentWeek.Web.Data.DTOS;
using System.Globalization;

namespace Mindash.CurrentWeek.Web.Services
{
    public class CurrentWeekService : ICurrentWeekService
    {
        public int GetCurrentWeek()
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;

            return cal.GetWeekOfYear(DateTime.Now, dfi.CalendarWeekRule, DayOfWeek.Monday);
        }
    }
}
