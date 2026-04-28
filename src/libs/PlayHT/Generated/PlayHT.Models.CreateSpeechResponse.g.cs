
#nullable enable

namespace PlayHT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpeechResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asyncTtsJobId")]
        public string? AsyncTtsJobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="jobId"></param>
        /// <param name="asyncTtsJobId"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpeechResponse(
            string? id,
            string? jobId,
            string? asyncTtsJobId,
            string? status)
        {
            this.Id = id;
            this.JobId = jobId;
            this.AsyncTtsJobId = asyncTtsJobId;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechResponse" /> class.
        /// </summary>
        public CreateSpeechResponse()
        {
        }
    }
}