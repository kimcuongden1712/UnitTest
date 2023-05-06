using CleverCore.Application.Dapper.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleverCore.Application.Dapper.Interfaces
{
    public interface IReportService
    {
        Task<IEnumerable<RevenueReportViewModel>> GetReportAsync(string fromDate, string toDate);
    }
}