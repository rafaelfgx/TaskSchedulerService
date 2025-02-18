# TaskSchedulerService

[Hangfire](https://www.hangfire.io)

## Run

<details>
<summary>Command Line</summary>

#### Prerequisites

* [.NET SDK](https://dotnet.microsoft.com/download)

#### Steps

1. Open directory **source\TaskSchedulerService** in command line and execute **dotnet run**.
2. Open <https://localhost:5000/hangfire>.

</details>

<details>
<summary>Visual Studio Code</summary>

#### Prerequisites

* [.NET SDK](https://dotnet.microsoft.com/download)
* [Visual Studio Code](https://code.visualstudio.com)
* [C# Extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)

#### Steps

1. Open **source** directory in Visual Studio Code.
2. Press **F5**.

</details>

<details>
<summary>Visual Studio</summary>

#### Prerequisites

* [Visual Studio](https://visualstudio.microsoft.com)

#### Steps

1. Open **source\TaskSchedulerService.sln** in Visual Studio.
2. Set **TaskSchedulerService** as startup project.
3. Press **F5**.

</details>

## Jobs

Configure jobs in **AppSettings.json**.

```json
"Jobs": [
    {
        "Id": "Job",
        "Name": "Job",
        "Url": "https://application.domain.com/job",
        "Method": "POST",
        "Cron": "* * * * *",
        "Active": "true"
    }
]
```

## Cron

[Cron Expression](https://en.wikipedia.org/wiki/Cron)

[Cron Generator](https://crontab.guru)

**Examples**

**At every minute:** * * * * *

**At every hour:** 0 * * * *

**At every day:** 0 0 * * *

**At 00:00 on Sunday:** 0 0 * * 0

**At 00:00 on day-of-month 25:** 0 0 25 * *

**At 00:00 on every day-of-month from 25 through 31:** 0 0 25-31 * *

**At 08:30 on day-of-month 1 in June:** 30 8 1 6 *

**At 12:30 on Sunday and Saturday:** 30 12 * * 0,6

**At 18:20 on day-of-month 5 in every 6th month:** 20 18 5 */6 *

**At 20:00 on day-of-month 1:** 0 20 1 * *

**At 22:00 on every day-of-week from Monday through Friday:** 0 22 * * 1-5

**At every hour from 9 through 18:** 0 9-18 * * *

**At every hour from 12 through 14 on Saturday and Sunday:** 0 12-14 * * 6,0

**At every hour from 9 through 18 on every day-of-week from Monday through Friday:** 0 9-18 * * 1-5

## Best Practices

[Idempotence](https://en.wikipedia.org/wiki/Idempotence)

[Reentrancy](https://en.wikipedia.org/wiki/Reentrancy_(computing))
