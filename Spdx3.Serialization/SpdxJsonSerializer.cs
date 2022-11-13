using System.Text.Json;
using System.Text.Json.Serialization;
using Spdx3.Core;

namespace Spdx3.Serialization;

public class SpdxJsonSerializer
{
    private readonly JsonSerializerOptions _opts = new()
    {
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
        Converters = { new JsonStringEnumConverter(new ScreamingJsonNamingPolicy(), false) }
    };

    public void Serialize(Element element)
    {
        JsonSerializer.Serialize(Console.OpenStandardOutput(), element, _opts);
    }

    public Element Deserialize()
    {
        throw new NotImplementedException();
    }
}