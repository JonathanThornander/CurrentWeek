using Microsoft.EntityFrameworkCore;
using Mindash.CurrentWeek.Web.Data;
using Mindash.CurrentWeek.Web.Data.DTOS;
using System.Globalization;

namespace Mindash.CurrentWeek.Web.Services
{
    public class CurrentWeekService : ICurrentWeekService
    {
        private static CultureInfo GetCultureInfo()
        {
            var providedCulture = Environment.GetEnvironmentVariable("CULTURE");

            if (string.IsNullOrEmpty(providedCulture))
            {
                return CultureInfo.CurrentCulture;
            }

            try
            {
                return CultureInfo.GetCultureInfo(providedCulture);
            }
            catch
            {
                return CultureInfo.CurrentCulture;
            }

        }

        public CurrentTimeViewModel GetCurrentWeek()
        {
            var culture = GetCultureInfo();
            Calendar cal = culture.Calendar;

            var localNow = DateTime.Now.ToLocalTime();
            var week = cal.GetWeekOfYear(localNow, culture.DateTimeFormat.CalendarWeekRule, DayOfWeek.Monday);

            return new CurrentTimeViewModel(week, localNow, culture); 
        }
    }
}
