
#nullable enable

namespace PlayHT
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsModel
    {
        /// <summary>
        /// 
        /// </summary>
        Play30Mini,
        /// <summary>
        /// 
        /// </summary>
        PlayDialog,
        /// <summary>
        /// 
        /// </summary>
        PlayDialogTurbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsModel value)
        {
            return value switch
            {
                TtsModel.Play30Mini => "Play3.0-mini",
                TtsModel.PlayDialog => "PlayDialog",
                TtsModel.PlayDialogTurbo => "PlayDialog-turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsModel? ToEnum(string value)
        {
            return value switch
            {
                "Play3.0-mini" => TtsModel.Play30Mini,
                "PlayDialog" => TtsModel.PlayDialog,
                "PlayDialog-turbo" => TtsModel.PlayDialogTurbo,
                _ => null,
            };
        }
    }
}