
#nullable enable

namespace PlayHT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpeechRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Voice ID or cloned voice manifest URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Voice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PlayHT.JsonConverters.TtsModelJsonConverter))]
        public global::PlayHT.TtsModel? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PlayHT.JsonConverters.OutputFormatJsonConverter))]
        public global::PlayHT.OutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public float? Speed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_engine")]
        public string? VoiceEngine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpeechRequest(
            string text,
            string voice,
            global::PlayHT.TtsModel? model,
            global::PlayHT.OutputFormat? outputFormat,
            float? speed,
            float? temperature,
            string? voiceEngine,
            string? language)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.Model = model;
            this.OutputFormat = outputFormat;
            this.Speed = speed;
            this.Temperature = temperature;
            this.VoiceEngine = voiceEngine;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechRequest" /> class.
        /// </summary>
        public CreateSpeechRequest()
        {
        }
    }
}