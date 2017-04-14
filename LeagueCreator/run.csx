#load "..\DomainModels\StorageModel.csx"
#load "..\DomainModels\League.csx"

using System.Net;
using System;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log, IAsyncCollector<League> leaguesTable)
{
    var league = await req.Content.ReadAsAsync<League>();
    league.NewId(typeof(League).Name);
    league.Enabled = true;
    
    log.Info($"Creating new leage: {league.Title}");

    await leaguesTable.AddAsync(league);

    return req.CreateResponse(HttpStatusCode.OK);
}