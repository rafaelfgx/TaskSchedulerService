namespace TaskSchedulerService;

public sealed record Job(string Id, string Url, string Method, string Cron, bool Active);
