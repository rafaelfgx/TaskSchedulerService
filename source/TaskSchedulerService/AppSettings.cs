namespace TaskSchedulerService;

public sealed record AppSettings(IReadOnlyList<Job> Jobs);
