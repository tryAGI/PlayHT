#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace PlayHT
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct StreamSpeechRequest : global::System.IEquatable<StreamSpeechRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PlayHT.CreateSpeechRequest? Create { get; init; }
#else
        public global::PlayHT.CreateSpeechRequest? Create { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Create))]
#endif
        public bool IsCreate => Create != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PlayHT.StreamSpeechRequestVariant2? StreamSpeechRequestVariant2 { get; init; }
#else
        public global::PlayHT.StreamSpeechRequestVariant2? StreamSpeechRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamSpeechRequestVariant2))]
#endif
        public bool IsStreamSpeechRequestVariant2 => StreamSpeechRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamSpeechRequest(global::PlayHT.CreateSpeechRequest value) => new StreamSpeechRequest((global::PlayHT.CreateSpeechRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PlayHT.CreateSpeechRequest?(StreamSpeechRequest @this) => @this.Create;

        /// <summary>
        /// 
        /// </summary>
        public StreamSpeechRequest(global::PlayHT.CreateSpeechRequest? value)
        {
            Create = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamSpeechRequest(global::PlayHT.StreamSpeechRequestVariant2 value) => new StreamSpeechRequest((global::PlayHT.StreamSpeechRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PlayHT.StreamSpeechRequestVariant2?(StreamSpeechRequest @this) => @this.StreamSpeechRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StreamSpeechRequest(global::PlayHT.StreamSpeechRequestVariant2? value)
        {
            StreamSpeechRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StreamSpeechRequest(
            global::PlayHT.CreateSpeechRequest? create,
            global::PlayHT.StreamSpeechRequestVariant2? streamSpeechRequestVariant2
            )
        {
            Create = create;
            StreamSpeechRequestVariant2 = streamSpeechRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StreamSpeechRequestVariant2 as object ??
            Create as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Create?.ToString() ??
            StreamSpeechRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreate && IsStreamSpeechRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::PlayHT.CreateSpeechRequest?, TResult>? create = null,
            global::System.Func<global::PlayHT.StreamSpeechRequestVariant2?, TResult>? streamSpeechRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreate && create != null)
            {
                return create(Create!);
            }
            else if (IsStreamSpeechRequestVariant2 && streamSpeechRequestVariant2 != null)
            {
                return streamSpeechRequestVariant2(StreamSpeechRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::PlayHT.CreateSpeechRequest?>? create = null,
            global::System.Action<global::PlayHT.StreamSpeechRequestVariant2?>? streamSpeechRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreate)
            {
                create?.Invoke(Create!);
            }
            else if (IsStreamSpeechRequestVariant2)
            {
                streamSpeechRequestVariant2?.Invoke(StreamSpeechRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Create,
                typeof(global::PlayHT.CreateSpeechRequest),
                StreamSpeechRequestVariant2,
                typeof(global::PlayHT.StreamSpeechRequestVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(StreamSpeechRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::PlayHT.CreateSpeechRequest?>.Default.Equals(Create, other.Create) &&
                global::System.Collections.Generic.EqualityComparer<global::PlayHT.StreamSpeechRequestVariant2?>.Default.Equals(StreamSpeechRequestVariant2, other.StreamSpeechRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StreamSpeechRequest obj1, StreamSpeechRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamSpeechRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StreamSpeechRequest obj1, StreamSpeechRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamSpeechRequest o && Equals(o);
        }
    }
}
