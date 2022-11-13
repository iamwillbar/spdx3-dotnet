namespace Spdx3.Core;

public class Organization : Element, IIdentity, IActor
{
    public Organization(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
}