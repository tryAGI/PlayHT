
#nullable enable

namespace PlayHT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Voice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public string? Style { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_url")]
        public string? SampleUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="voice1"></param>
        /// <param name="language"></param>
        /// <param name="languageCode"></param>
        /// <param name="gender"></param>
        /// <param name="accent"></param>
        /// <param name="style"></param>
        /// <param name="sampleUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Voice(
            string? id,
            string? name,
            string? voice1,
            string? language,
            string? languageCode,
            string? gender,
            string? accent,
            string? style,
            string? sampleUrl)
        {
            this.Id = id;
            this.Name = name;
            this.Voice1 = voice1;
            this.Language = language;
            this.LanguageCode = languageCode;
            this.Gender = gender;
            this.Accent = accent;
            this.Style = style;
            this.SampleUrl = sampleUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        public Voice()
        {
        }

    }
}