#nullable enable

namespace PlayHT
{
    public partial interface ITextToSpeechClient
    {
        /// <summary>
        /// Stream generated speech bytes<br/>
        /// Streams audio bytes from the selected PlayAI model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PlayHT.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamSpeechAsync(

            global::PlayHT.StreamSpeechRequest request,
            global::PlayHT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream generated speech bytes<br/>
        /// Streams audio bytes from the selected PlayAI model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PlayHT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> StreamSpeechAsStreamAsync(

            global::PlayHT.StreamSpeechRequest request,
            global::PlayHT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream generated speech bytes<br/>
        /// Streams audio bytes from the selected PlayAI model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PlayHT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PlayHT.AutoSDKHttpResponse<byte[]>> StreamSpeechAsResponseAsync(

            global::PlayHT.StreamSpeechRequest request,
            global::PlayHT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream generated speech bytes<br/>
        /// Streams audio bytes from the selected PlayAI model.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamSpeechAsync(
            global::PlayHT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}