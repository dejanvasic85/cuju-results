using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    var league = await req.Content.ReadAsAsync<League>();

    log.Info($"Creating new leage: {league.Title}");

    return req.CreateResponse(HttpStatusCode.OK);
}

public class League
{
    public string Title { get; set; }
    public string Location { get; set; }
}