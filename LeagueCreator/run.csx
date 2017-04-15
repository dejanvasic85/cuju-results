#load "..\DomainModels\League.csx"

using System.Net;
using System;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log, IAsyncCollector<League> leaguesTable)
{
    var league = await req.Content.ReadAsAsync<League>();
    league.PartitionKey = "League";
    league.RowKey = Guid.NewGuid().ToString();
    league.Enabled = true;
    league.CreatedDateUtc = DateTime.UtcNow;
    
    log.Info($"Creating new leage: {league.Title}");

    await leaguesTable.AddAsync(league);

    return req.CreateResponse(HttpStatusCode.OK);
}