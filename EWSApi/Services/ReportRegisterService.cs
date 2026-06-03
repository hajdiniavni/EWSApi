using EWSApi.Core;
using EWSApi.Utils.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EWSApi.Services
{
    public class ReportRegisterService : IReportRegisterService
    {
        private readonly AppDBContext _appDb;
        private readonly IIndexService indexService;
        private readonly string reportRegisterIndex;

        public ReportRegisterService(AppDBContext appDb, IIndexService indexService, IOptions<ElasticConfiguration> config)
        {
            _appDb = appDb;
            this.indexService = indexService;
            reportRegisterIndex = string.IsNullOrWhiteSpace(config.Value.Index) ? "reportlist_index" : config.Value.Index;
        }

        public async Task ReIndexAllReportRegisters(int[]? reportRegisterIds = null)
        {
            var query = _appDb.ElasticSearchReportList
                .AsNoTracking()
                .AsQueryable();

            if (reportRegisterIds != null && reportRegisterIds.Any())
            {
                query = query.Where(x => reportRegisterIds.Contains(x.ReportRegisterId) && x.IsTB == 0);
            }

            var rows = await query.ToArrayAsync();

            if (!rows.Any())
            {
                return;
            }

            await indexService.IndexData(rows, reportRegisterIndex);
        }
    }
}
