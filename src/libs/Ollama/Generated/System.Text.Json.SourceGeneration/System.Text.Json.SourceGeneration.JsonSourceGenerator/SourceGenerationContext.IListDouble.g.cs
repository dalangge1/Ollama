﻿// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace Ollama
{
    internal sealed partial class SourceGenerationContext
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<double>>? _IListDouble;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<double>> IListDouble
        {
            get => _IListDouble ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<double>>)Options.GetTypeInfo(typeof(global::System.Collections.Generic.IList<double>));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<double>> Create_IListDouble(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::System.Collections.Generic.IList<double>>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<double>> jsonTypeInfo))
            {
                var info = new global::System.Text.Json.Serialization.Metadata.JsonCollectionInfoValues<global::System.Collections.Generic.IList<double>>
                {
                    ObjectCreator = null,
                    SerializeHandler = IListDoubleSerializeHandler
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateIListInfo<global::System.Collections.Generic.IList<double>, double>(options, info);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }

        // Intentionally not a static method because we create a delegate to it. Invoking delegates to instance
        // methods is almost as fast as virtual calls. Static methods need to go through a shuffle thunk.
        private void IListDoubleSerializeHandler(global::System.Text.Json.Utf8JsonWriter writer, global::System.Collections.Generic.IList<double>? value)
        {
            if (value == null)
            {
                writer.WriteNullValue();
                return;
            }
            
            writer.WriteStartArray();

            for (int i = 0; i < value.Count; i++)
            {
                writer.WriteNumberValue(value[i]);
            }

            writer.WriteEndArray();
        }
    }
}