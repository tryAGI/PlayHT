
#nullable enable

namespace PlayHT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListVoicesResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        public global::System.Collections.Generic.IList<global::PlayHT.Voice>? Voices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVoicesResponseVariant2" /> class.
        /// </summary>
        /// <param name="voices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVoicesResponseVariant2(
            global::System.Collections.Generic.IList<global::PlayHT.Voice>? voices)
        {
            this.Voices = voices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVoicesResponseVariant2" /> class.
        /// </summary>
        public ListVoicesResponseVariant2()
        {
        }
    }
}