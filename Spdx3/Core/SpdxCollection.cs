namespace Spdx3.Core;

/// \ingroup Core
/// <summary>
/// 
/// </summary>
public class SpdxCollection : Element
{
    public Uri? RootElement { get; set; }
    public IEnumerable<Uri>? Elements { get; set; }
    public IDictionary<string, Uri>? Namespaces { get; set; }
    public IDictionary<Uri, ExternalElementReference>? Imports { get; set; }

    public SpdxCollection(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
}