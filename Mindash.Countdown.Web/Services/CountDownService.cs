using Microsoft.EntityFrameworkCore;
using Mindash.Countdown.Web.Data;
using Mindash.Countdown.Web.Data.DTOS;
using Mindash.Countdown.Web.Models;

namespace Mindash.Countdown.Web.Services
{
    public class CountDownService : ICountDownService
    {
        private readonly CountDownDBContext _dbContext;

        public CountDownService(CountDownDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
        }

        public async Task CreateNew(Data.DTOS.CountdownEvent dateModel)
        {
            await _dbContext.CountdownEvents.AddAsync(dateModel);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(Guid id)
        {
            var enity = await _dbContext.CountdownEvents.FindAsync(id) ?? throw new Exception("No event was found");
            _dbContext.CountdownEvents.Remove(enity);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Data.DTOS.CountdownEvent>> GetAllAsync()
        {
            return await _dbContext.CountdownEvents.ToArrayAsync();
        }

        public async Task<Data.DTOS.CountdownEvent?> GetCountDownAsync()
        {
            return await _dbContext.CountdownEvents.OrderBy(date => date.DateTime).FirstOrDefaultAsync();
        }

        public async Task Update(Data.DTOS.CountdownEvent dateModel)
        {
            _dbContext.CountdownEvents.Update(dateModel);
            await _dbContext.SaveChangesAsync();
        }
    }
}
