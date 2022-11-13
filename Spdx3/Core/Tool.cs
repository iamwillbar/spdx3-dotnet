namespace Spdx3.Core;

/// \ingroup Core
/// <summary>
/// 
/// </summary>
public class Tool : Element, IIdentity, IActor
{
    public Tool(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
}