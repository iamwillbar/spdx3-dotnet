namespace Spdx3.Core;

public class SpdxDocument : Bundle
{
    public SpdxDocument(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
}