var builder = WebApplication.CreateBuilder();

var appSettings = builder.Configuration.Get<AppSettings>();

builder.Services.AddSingleton(appSettings);
builder.Services.AddResponseCompression();
builder.Services.AddControllers();
builder.Services.AddHangfire(configuration => configuration.UseInMemoryStorage());
builder.Services.AddHangfireServer();

var application = builder.Build();

application.UseDeveloperExceptionPage();
application.UseHsts();
application.UseHttpsRedirection();
application.UseResponseCompression();
application.MapControllers();
application.UseHangfireDashboard();

_ = new HangfireService(appSettings);

application.Run();
