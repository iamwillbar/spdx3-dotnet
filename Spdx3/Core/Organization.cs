namespace Spdx3.Core;

/// \ingroup Core
/// <summary>
/// Represents a formal or informal group of people. 
/// </summary>
public class Organization : Element, IIdentity, IActor
{
    public Organization(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
}