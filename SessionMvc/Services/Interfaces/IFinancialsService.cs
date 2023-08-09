using SessionMvc.Models;

namespace SessionMvc.Services.Interfaces
{
    public interface IFinancialsService
    {
        decimal GetTotalSold();
        FinancialStats GetStats();
    }
}
