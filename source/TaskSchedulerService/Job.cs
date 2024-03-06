namespace TaskSchedulerService;

public sealed record Job
{
    public string Id { get; set; }

    public string Url { get; set; }

    public string Method { get; set; }

    public string Cron { get; set; }

    public bool Active { get; set; }

    public bool Inactive => !Active;
}
