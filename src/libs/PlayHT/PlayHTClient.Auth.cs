namespace PlayHT;

public sealed partial class PlayHTClient
{
    /// <summary>
    /// Creates a new <see cref="PlayHTClient"/> using PlayAI's API key plus user ID headers.
    /// </summary>
    /// <param name="apiKey">PlayAI API key sent as a bearer token.</param>
    /// <param name="userId">PlayAI user ID sent as the <c>X-USER-ID</c> header.</param>
    /// <param name="httpClient">Optional HTTP client.</param>
    /// <param name="baseUri">Optional base URI override.</param>
    /// <param name="disposeHttpClient">Whether to dispose the HTTP client with this client.</param>
    public PlayHTClient(
        string apiKey,
        string userId,
        global::System.Net.Http.HttpClient? httpClient = null,
        global::System.Uri? baseUri = null,
        bool disposeHttpClient = true) : this(
            httpClient,
            baseUri,
            authorizations: null,
            disposeHttpClient: disposeHttpClient)
    {
        apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
        userId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));

        AuthorizeUsingBearer(apiKey);
        AuthorizeUsingApiKeyInHeader(userId);
    }
}
