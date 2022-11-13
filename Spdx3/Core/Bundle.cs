namespace Spdx3.Core;

/// \ingroup Core
/// <summary>
/// 
/// </summary>
public class Bundle : SpdxCollection
{
    public Bundle(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
    public string? Context { get; set; }
}
