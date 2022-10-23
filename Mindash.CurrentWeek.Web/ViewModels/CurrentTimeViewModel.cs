using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Globalization;

namespace Mindash.CurrentWeek.Web.Data.DTOS
{
    public class CurrentTimeViewModel
    {
        private readonly CultureInfo _cultureInfo;

        public CurrentTimeViewModel(int currentWeek, DateTime dateTime, CultureInfo cultureInfo)
        {
            CurrentWeek = currentWeek;
            DateTime = dateTime;
            _cultureInfo = cultureInfo;
        }

        public virtual int CurrentWeek { get; set; }

        public virtual DateTime DateTime { get; set; }

        public string DateString { get => GetDateString(); }

        public string TimeString { get => GetTimeString(); }


        private string GetDateString()
        {
            return DateTime.ToString(_cultureInfo.DateTimeFormat.LongDatePattern, _cultureInfo);
        }

        private string GetTimeString()
        {
            return DateTime.ToString(_cultureInfo.DateTimeFormat.LongTimePattern, _cultureInfo);
        }
    }

    public class LocadingCurrentTimeViewModel : CurrentTimeViewModel
    {
        public LocadingCurrentTimeViewModel() : base(0, DateTime.MinValue, CultureInfo.CurrentCulture)
        {
        }
    }
}
