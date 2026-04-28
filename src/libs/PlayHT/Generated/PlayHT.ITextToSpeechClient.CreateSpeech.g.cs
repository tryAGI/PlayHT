#nullable enable

namespace PlayHT
{
    public partial interface ITextToSpeechClient
    {
        /// <summary>
        /// Create an asynchronous text-to-speech job<br/>
        /// Returns a job ID that can be polled with `GET /api/v1/tts/{asyncTtsJobId}`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PlayHT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PlayHT.CreateSpeechResponse> CreateSpeechAsync(

            global::PlayHT.CreateSpeechRequest request,
            global::PlayHT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an asynchronous text-to-speech job<br/>
        /// Returns a job ID that can be polled with `GET /api/v1/tts/{asyncTtsJobId}`.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="voice">
        /// Voice ID or cloned voice manifest URL.
        /// </param>
        /// <param name="model"></param>
        /// <param name="outputFormat"></param>
        /// <param name="speed"></param>
        /// <param name="temperature"></param>
        /// <param name="voiceEngine"></param>
        /// <param name="language"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PlayHT.CreateSpeechResponse> CreateSpeechAsync(
            string text,
            string voice,
            global::PlayHT.TtsModel? model = default,
            global::PlayHT.OutputFormat? outputFormat = default,
            float? speed = default,
            float? temperature = default,
            string? voiceEngine = default,
            string? language = default,
            global::PlayHT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}