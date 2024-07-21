namespace TaskSchedulerService;

public sealed record AppSettings
{
    public IReadOnlyList<Job> Jobs { get; set; }
}
