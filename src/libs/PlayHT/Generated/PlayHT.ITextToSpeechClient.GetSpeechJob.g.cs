#nullable enable

namespace PlayHT
{
    public partial interface ITextToSpeechClient
    {
        /// <summary>
        /// Get an asynchronous TTS job
        /// </summary>
        /// <param name="asyncTtsJobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PlayHT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PlayHT.SpeechJob> GetSpeechJobAsync(
            string asyncTtsJobId,
            global::PlayHT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}