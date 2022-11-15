namespace Spdx3.Core;

/// \ingroup core
/// <summary>
/// Represents the list of Artifacts used to produce another Artifact.
/// </summary>
public class Bom : Bundle
{
    public Bom(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
}