using System.Net;
using System;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log, IAsyncCollector<League> leaguesTable)
{
    var league = await req.Content.ReadAsAsync<League>();
    league.Id = Guid.NewGuid().ToString();

    log.Info($"Creating new leage: {league.Title}");

    await leaguesTable.AddAsync(league);

    return req.CreateResponse(HttpStatusCode.OK);
}

public class League
{
    public string Id {get;set;}
    public string Title { get; set; }
    public string Location { get; set; }
}