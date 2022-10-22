using Mindash.Countdown.Web.Data.DTOS;
using Mindash.Countdown.Web.Models;

namespace Mindash.Countdown.Web.Services
{
    public interface ICountDownService
    {
        public Task<Data.DTOS.CountdownEvent?> GetCountDownAsync();

        public Task CreateNew(Data.DTOS.CountdownEvent dateModel);

        public Task<IEnumerable<Data.DTOS.CountdownEvent>> GetAllAsync();

        public Task DeleteByIdAsync(Guid ID);

        public Task Update(Data.DTOS.CountdownEvent dateModel);
    }
}
