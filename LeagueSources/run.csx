using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    var league  = await req.Content.ReadAsAsync<League>();

    log.Info($"Successfully read league data for {league.Title}");

    // Todo - check whether it's a PUT OR POST and update or CREATE the league data

    req.CreateResponse(HttpStatusCode.OK);
}

public class League {
    public string Title {get;set;}
    public string Location {get;set;}
}