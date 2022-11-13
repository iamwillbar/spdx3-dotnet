namespace Spdx3.Core;

/// \ingroup Core
/// <summary>
/// Represents a persisted collection of Elements.
/// </summary>
public class SpdxDocument : Bundle
{
    public SpdxDocument(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
}