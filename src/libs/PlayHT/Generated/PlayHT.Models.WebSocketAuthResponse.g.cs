
#nullable enable

namespace PlayHT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSocketAuthResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webSocketUrls")]
        public global::System.Collections.Generic.Dictionary<string, string>? WebSocketUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSocketAuthResponse" /> class.
        /// </summary>
        /// <param name="webSocketUrls"></param>
        /// <param name="expiresAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSocketAuthResponse(
            global::System.Collections.Generic.Dictionary<string, string>? webSocketUrls,
            global::System.DateTime? expiresAt)
        {
            this.WebSocketUrls = webSocketUrls;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSocketAuthResponse" /> class.
        /// </summary>
        public WebSocketAuthResponse()
        {
        }

    }
}