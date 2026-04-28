
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace PlayHT
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::PlayHT.JsonConverters.OutputFormatJsonConverter),

            typeof(global::PlayHT.JsonConverters.OutputFormatNullableJsonConverter),

            typeof(global::PlayHT.JsonConverters.TtsModelJsonConverter),

            typeof(global::PlayHT.JsonConverters.TtsModelNullableJsonConverter),

            typeof(global::PlayHT.JsonConverters.StreamSpeechRequestJsonConverter),

            typeof(global::PlayHT.JsonConverters.ListVoicesResponseJsonConverter),

            typeof(global::PlayHT.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PlayHT.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PlayHT.OutputFormat), TypeInfoPropertyName = "OutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PlayHT.TtsModel), TypeInfoPropertyName = "TtsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PlayHT.CreateSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PlayHT.StreamSpeechRequest), TypeInfoPropertyName = "StreamSpeechRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PlayHT.StreamSpeechRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PlayHT.CreateSpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PlayHT.SpeechJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PlayHT.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PlayHT.ListVoicesResponse), TypeInfoPropertyName = "ListVoicesResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PlayHT.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PlayHT.ListVoicesResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PlayHT.WebSocketAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PlayHT.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PlayHT.Voice>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}