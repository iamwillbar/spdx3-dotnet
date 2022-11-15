namespace Spdx3.Core;

/// \ingroup core
/// <summary>
/// Represents the identity of a process or system.
/// </summary>
public class Tool : Element, IIdentity, IActor
{
    public Tool(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
}