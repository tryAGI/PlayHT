
#nullable enable

namespace PlayHT
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Flac,
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Ogg,
        /// <summary>
        /// 
        /// </summary>
        Pcm,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFormat value)
        {
            return value switch
            {
                OutputFormat.Flac => "flac",
                OutputFormat.Mp3 => "mp3",
                OutputFormat.Ogg => "ogg",
                OutputFormat.Pcm => "pcm",
                OutputFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "flac" => OutputFormat.Flac,
                "mp3" => OutputFormat.Mp3,
                "ogg" => OutputFormat.Ogg,
                "pcm" => OutputFormat.Pcm,
                "wav" => OutputFormat.Wav,
                _ => null,
            };
        }
    }
}