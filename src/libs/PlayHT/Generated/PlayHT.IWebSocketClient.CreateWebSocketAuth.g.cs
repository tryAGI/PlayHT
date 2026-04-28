#nullable enable

namespace PlayHT
{
    public partial interface IWebSocketClient
    {
        /// <summary>
        /// Create short-lived WebSocket URLs for realtime TTS
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PlayHT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PlayHT.WebSocketAuthResponse> CreateWebSocketAuthAsync(
            global::PlayHT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}