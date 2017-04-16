#load "..\DomainModels\League.csx"

#r "Newtonsoft.Json"

using System;
using Newtonsoft.Json;

public static void Run(string leagueJson, TraceWriter log)
{
    var league = JsonConvert.DeserializeObject<League>(leagueJson);
    if (league == null){
        log.Error($"Skipping {leagueJson} as it is not a valid League object. Failed deserialization");
    }
    else
    {
        log.Info($"Fetching data for the league {league.Title}");
    }
}