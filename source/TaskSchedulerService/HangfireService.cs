namespace TaskSchedulerService;

public class HangfireService
{
    public HangfireService(AppSettings appSettings)
    {
        appSettings.Jobs.ToList().ForEach(job =>
        {
            if (job.Active)
                RecurringJob.AddOrUpdate(job.Id, () => Execute(job), job.Cron);
            else
                RecurringJob.RemoveIfExists(job.Id);
        });
    }

    [AutomaticRetry(Attempts = 0)]
    public void Execute(Job job) => new HttpClient().Send(new HttpRequestMessage(new HttpMethod(job.Method), job.Url));
}
