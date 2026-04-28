#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace PlayHT
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ListVoicesResponse : global::System.IEquatable<ListVoicesResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::PlayHT.Voice>? ListVoicesResponseVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::PlayHT.Voice>? ListVoicesResponseVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListVoicesResponseVariant1))]
#endif
        public bool IsListVoicesResponseVariant1 => ListVoicesResponseVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PlayHT.ListVoicesResponseVariant2? ListVoicesResponseVariant2 { get; init; }
#else
        public global::PlayHT.ListVoicesResponseVariant2? ListVoicesResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListVoicesResponseVariant2))]
#endif
        public bool IsListVoicesResponseVariant2 => ListVoicesResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListVoicesResponse(global::PlayHT.ListVoicesResponseVariant2 value) => new ListVoicesResponse((global::PlayHT.ListVoicesResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PlayHT.ListVoicesResponseVariant2?(ListVoicesResponse @this) => @this.ListVoicesResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ListVoicesResponse(global::PlayHT.ListVoicesResponseVariant2? value)
        {
            ListVoicesResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListVoicesResponse(
            global::System.Collections.Generic.IList<global::PlayHT.Voice>? listVoicesResponseVariant1,
            global::PlayHT.ListVoicesResponseVariant2? listVoicesResponseVariant2
            )
        {
            ListVoicesResponseVariant1 = listVoicesResponseVariant1;
            ListVoicesResponseVariant2 = listVoicesResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ListVoicesResponseVariant2 as object ??
            ListVoicesResponseVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ListVoicesResponseVariant1?.ToString() ??
            ListVoicesResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsListVoicesResponseVariant1 && !IsListVoicesResponseVariant2 || !IsListVoicesResponseVariant1 && IsListVoicesResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::PlayHT.Voice>?, TResult>? listVoicesResponseVariant1 = null,
            global::System.Func<global::PlayHT.ListVoicesResponseVariant2?, TResult>? listVoicesResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListVoicesResponseVariant1 && listVoicesResponseVariant1 != null)
            {
                return listVoicesResponseVariant1(ListVoicesResponseVariant1!);
            }
            else if (IsListVoicesResponseVariant2 && listVoicesResponseVariant2 != null)
            {
                return listVoicesResponseVariant2(ListVoicesResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::PlayHT.Voice>?>? listVoicesResponseVariant1 = null,
            global::System.Action<global::PlayHT.ListVoicesResponseVariant2?>? listVoicesResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListVoicesResponseVariant1)
            {
                listVoicesResponseVariant1?.Invoke(ListVoicesResponseVariant1!);
            }
            else if (IsListVoicesResponseVariant2)
            {
                listVoicesResponseVariant2?.Invoke(ListVoicesResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ListVoicesResponseVariant1,
                typeof(global::System.Collections.Generic.IList<global::PlayHT.Voice>),
                ListVoicesResponseVariant2,
                typeof(global::PlayHT.ListVoicesResponseVariant2),
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
        public bool Equals(ListVoicesResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::PlayHT.Voice>?>.Default.Equals(ListVoicesResponseVariant1, other.ListVoicesResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::PlayHT.ListVoicesResponseVariant2?>.Default.Equals(ListVoicesResponseVariant2, other.ListVoicesResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ListVoicesResponse obj1, ListVoicesResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListVoicesResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ListVoicesResponse obj1, ListVoicesResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListVoicesResponse o && Equals(o);
        }
    }
}
