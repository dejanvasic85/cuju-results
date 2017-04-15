#r "Microsoft.WindowsAzure.Storage"
#load "..\DomainModels\League.csx"

using Microsoft.WindowsAzure.Storage.Table;

public static void Run(TimerInfo timer, IQueryable<League> leagues, TraceWriter log)
{
    var leaguesToQueue = leagues.Where(l => l.Enabled == true).ToList();
    log.Info($"Queuing {leaguesToQueue.Count} for scraping");
    
}