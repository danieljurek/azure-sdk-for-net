// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class CustomAnalyzer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tokenizer");
            writer.WriteStringValue(TokenizerName.ToString());
            if (TokenFilters != null && TokenFilters.Any())
            {
                writer.WritePropertyName("tokenFilters");
                writer.WriteStartArray();
                foreach (var item in TokenFilters)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (CharFilters != null && CharFilters.Any())
            {
                writer.WritePropertyName("charFilters");
                writer.WriteStartArray();
                foreach (var item in CharFilters)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static CustomAnalyzer DeserializeCustomAnalyzer(JsonElement element)
        {
            LexicalTokenizerName tokenizer = default;
            IList<TokenFilterName> tokenFilters = default;
            IList<string> charFilters = default;
            string odataType = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tokenizer"))
                {
                    tokenizer = new LexicalTokenizerName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tokenFilters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TokenFilterName> array = new List<TokenFilterName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new TokenFilterName(item.GetString()));
                    }
                    tokenFilters = array;
                    continue;
                }
                if (property.NameEquals("charFilters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    charFilters = array;
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new CustomAnalyzer(odataType, name, tokenizer, tokenFilters, charFilters);
        }
    }
}
