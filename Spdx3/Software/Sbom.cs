using Spdx3.Core;

namespace Spdx3.Software;

public class Sbom : Bom
{
    public Sbom(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
}