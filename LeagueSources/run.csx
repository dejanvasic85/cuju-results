using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info("C# HTTP trigger function processed a request.");

    // Get request body
    dynamic data = await req.Content.ReadAsAsync<object>();

    // Set name to query string or body data

    // return name == null
    //     ? req.CreateResponse(HttpStatusCode.BadRequest, "Please pass a name on the query string or in the request body")
    //     : req.CreateResponse(HttpStatusCode.OK, "Hello " + name);

    req.CreateResponse(HttpStatusCode.OK);
}