#r "Microsoft.WindowsAzure.Storage"
#load "..\DomainModels\League.csx"

using Microsoft.WindowsAzure.Storage.Table;

public static void Run(TimerInfo timer, IQueryable<League> leagues, ICollector<League> scrapeQueue, TraceWriter log)
{
    var leaguesToQueue = leagues.Where(l => l.Enabled == true).ToList();
    log.Info($"Queuing {leaguesToQueue.Count} for scraping");


    foreach (var l in leaguesToQueue)
    {
        log.Info($"Adding {l.ShortName} to queue for scraping");
        scrapeQueue.Add(l);
    }
}