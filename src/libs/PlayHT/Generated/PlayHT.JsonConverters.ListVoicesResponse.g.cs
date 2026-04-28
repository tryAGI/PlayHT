#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace PlayHT.JsonConverters
{
    /// <inheritdoc />
    public class ListVoicesResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PlayHT.ListVoicesResponse>
    {
        /// <inheritdoc />
        public override global::PlayHT.ListVoicesResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            var __score1 = 0;
            if (__jsonProps.Contains("voices")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::System.Collections.Generic.IList<global::PlayHT.Voice>? listVoicesResponseVariant1 = default;
            global::PlayHT.ListVoicesResponseVariant2? listVoicesResponseVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::PlayHT.Voice>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::PlayHT.Voice>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::PlayHT.Voice>).Name}");
                        listVoicesResponseVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PlayHT.ListVoicesResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PlayHT.ListVoicesResponseVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PlayHT.ListVoicesResponseVariant2).Name}");
                        listVoicesResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (listVoicesResponseVariant1 == null && listVoicesResponseVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::PlayHT.Voice>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::PlayHT.Voice>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::PlayHT.Voice>).Name}");
                    listVoicesResponseVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PlayHT.ListVoicesResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PlayHT.ListVoicesResponseVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PlayHT.ListVoicesResponseVariant2).Name}");
                    listVoicesResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::PlayHT.ListVoicesResponse(
                listVoicesResponseVariant1,

                listVoicesResponseVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PlayHT.ListVoicesResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsListVoicesResponseVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::PlayHT.Voice>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::PlayHT.Voice>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::PlayHT.Voice>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListVoicesResponseVariant1!, typeInfo);
            }
            else if (value.IsListVoicesResponseVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PlayHT.ListVoicesResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PlayHT.ListVoicesResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PlayHT.ListVoicesResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListVoicesResponseVariant2!, typeInfo);
            }
        }
    }
}