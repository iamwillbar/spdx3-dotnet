using System.Text.Json;

namespace Spdx3.Serialization;

internal class ScreamingJsonNamingPolicy : JsonNamingPolicy
{
    public override string ConvertName(string name)
    {
        return name.ToUpperInvariant();
    }
}