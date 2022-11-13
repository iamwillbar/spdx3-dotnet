using Spdx3.Core;

namespace Spdx3.Software;

/// \ingroup Software
/// <summary>
/// Represents a portion of a file.
/// </summary>
/// <remarks>
/// The <c>File</c>(s) that a <c>Snippet</c> is contained in can be found
/// by finding <c>Relationship</c> elements with a <c>RelationshipType</c>
/// equal to <c>RelationshipType.Contains</c> and the <c>Snippet</c>'s
/// <c>SpdxId</c> in the <c>To</c> of the <c>Relationship</c>.
/// 
/// If the <c>ByteRange</c> and <c>LineRange</c> are inconsistent with each
/// other, the <c>ByteRange</c> takes precedence.
/// </remarks>
public class Snippet : Artifact
{
    public Snippet(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
    public Uri? ContentIdentifier { get; set; }
    public IEnumerable<SoftwarePurpose>? SnippetPurposes { get; set; }
    public Range? ByteRange { get; set; }
    public Range? LineRange { get; set; }

}