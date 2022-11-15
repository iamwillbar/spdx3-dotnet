namespace Spdx3.Core;

/// \ingroup core
/// <summary>
/// 
/// </summary>
public abstract class Artifact : Element
{
    protected Artifact(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
    public IEnumerable<IIdentity>? OriginatedBy { get; set; }
}