namespace EWSApi.Services
{
    public interface IReportRegisterService
    {
        Task ReIndexAllReportRegisters(int[]? reportRegisterIds = null);
    }
}
