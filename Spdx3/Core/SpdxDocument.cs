namespace Spdx3.Core;

/// \ingroup Core
/// <summary>
/// 
/// </summary>
public class SpdxDocument : Bundle
{
    public SpdxDocument(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
}