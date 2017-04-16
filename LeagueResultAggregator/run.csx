#load "..\DomainModels\League.csx"

using System;

public static void Run(string leagueJson, TraceWriter log)
{
    
    

    log.Info($"C# Queue trigger function processed: {leagueJson}");
}