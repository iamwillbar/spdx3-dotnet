namespace Spdx3.Core;

/// \ingroup core
/// <summary>
/// Represents a collection of Elements that have a shared context.
/// </summary>
public class Bundle : SpdxCollection
{
    public Bundle(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
    public string? Context { get; set; }
}
