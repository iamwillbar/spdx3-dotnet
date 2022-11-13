namespace Spdx3.Core;

public class Bom : Bundle
{
    public Bom(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
}