﻿// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace Ollama
{
    internal sealed partial class SourceGenerationContext
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ollama.GenerateChatCompletionResponseDoneReason?>? _NullableGenerateChatCompletionResponseDoneReason;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ollama.GenerateChatCompletionResponseDoneReason?> NullableGenerateChatCompletionResponseDoneReason
        {
            get => _NullableGenerateChatCompletionResponseDoneReason ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ollama.GenerateChatCompletionResponseDoneReason?>)Options.GetTypeInfo(typeof(global::Ollama.GenerateChatCompletionResponseDoneReason?));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ollama.GenerateChatCompletionResponseDoneReason?> Create_NullableGenerateChatCompletionResponseDoneReason(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::Ollama.GenerateChatCompletionResponseDoneReason?>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ollama.GenerateChatCompletionResponseDoneReason?> jsonTypeInfo))
            {
                global::System.Text.Json.Serialization.JsonConverter converter = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.GetNullableConverter<global::Ollama.GenerateChatCompletionResponseDoneReason>(options);
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateValueInfo<global::Ollama.GenerateChatCompletionResponseDoneReason?>(options, converter);
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }
    }
}