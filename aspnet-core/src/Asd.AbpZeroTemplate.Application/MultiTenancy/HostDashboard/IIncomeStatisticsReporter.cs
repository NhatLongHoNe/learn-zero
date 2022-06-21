using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Asd.AbpZeroTemplate.MultiTenancy.HostDashboard.Dto;

namespace Asd.AbpZeroTemplate.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}