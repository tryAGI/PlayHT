namespace PlayHT.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static PlayHTClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("PLAYHT_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("PLAYHT_API_KEY environment variable is not found.");
        var userId =
            Environment.GetEnvironmentVariable("PLAYHT_USER_ID") is { Length: > 0 } userIdValue
                ? userIdValue
                : throw new AssertInconclusiveException("PLAYHT_USER_ID environment variable is not found.");

        var client = new PlayHTClient(apiKey, userId);
        
        return client;
    }
}
