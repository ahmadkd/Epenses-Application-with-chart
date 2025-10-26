using FinanceApp.Models;

namespace FinanceApp.Data.Service
{
    public interface IexpensesService
    {
        Task<IEnumerable<Expense>> GetAll();
        Task Add(Expense expense);
        IQueryable GetChartData();
    }
}
