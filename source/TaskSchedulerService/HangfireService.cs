namespace TaskSchedulerService;

public class HangfireService
{
    public HangfireService(AppSettings appSettings)
    {
        appSettings.Jobs.Where(job => job.Inactive).ToList().ForEach(job => RecurringJob.RemoveIfExists(job.Id));

        appSettings.Jobs.Where(job => job.Active).ToList().ForEach(job => RecurringJob.AddOrUpdate(job.Id, () => ExecuteAsync(job), job.Cron));
    }

    [AutomaticRetry(Attempts = 0)]
    public Task ExecuteAsync(Job job)
    {
        return new HttpClient().SendAsync(new HttpRequestMessage(new HttpMethod(job.Method), job.Url));
    }
}
