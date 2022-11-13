using Spdx3.Core;

namespace Spdx3.Software;

/// <summary>
/// Represents a potentially distributable piece of software.
/// </summary>
/// <remarks>
///
/// </remarks>
public class Package : Artifact
{
    public Package(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
    public Uri? ContentIdentifier { get; set; }
    public IEnumerable<SoftwarePurpose>? PackagePurposes { get; set; }
    public Uri? DownloadLocation { get; set; }
    public Uri? PackageUrl { get; set; }
    public Uri? HomePage { get; set; }

}