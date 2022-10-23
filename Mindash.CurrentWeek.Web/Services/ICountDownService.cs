using Mindash.CurrentWeek.Web.Data.DTOS;

namespace Mindash.CurrentWeek.Web.Services
{
    public interface ICurrentWeekService
    {
        public CurrentTimeViewModel GetCurrentWeek();
    }
}
