using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Globalization;

namespace Mindash.CurrentWeek.Web.Data.DTOS
{
    public class CurrentTimeViewModel
    {
        public CurrentTimeViewModel(int currentWeek, DateTime dateTime)
        {
            CurrentWeek = currentWeek;
            DateTime = dateTime;
        }

        public virtual int CurrentWeek { get; set; }

        public virtual DateTime DateTime { get; set; }

        public string DateString { get => GetDateString(); }

        public string TimeString { get => GetTimeString(); }


        private string GetDateString()
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            return DateTime.ToString(ci.DateTimeFormat.LongDatePattern, ci);
        }

        private string GetTimeString()
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            return DateTime.ToString(ci.DateTimeFormat.LongTimePattern, ci);
        }
    }

    public class LocadingCurrentTimeViewModel : CurrentTimeViewModel
    {
        public LocadingCurrentTimeViewModel() : base(0, DateTime.MinValue)
        {
        }
    }
}
