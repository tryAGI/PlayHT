
#nullable enable

namespace PlayHT
{
    public sealed partial class PlayHTClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "X-USER-ID")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::PlayHT.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "UserIdAuth",
                Location = "Header",
                Name = "X-USER-ID",
                Value = apiKey,
            });
        }
    }
}