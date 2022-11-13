using Spdx3.Core;

namespace Spdx3.Software;

/// \ingroup Software
/// <summary>
/// Represents an individual file.
/// </summary>
/// <remarks>
/// If a file is copied to multiple locations then there will be a <c>File</c> element
/// for each copy of the file. You can determine if two <c>File</c> elements refer to
/// files with identical content by comparing either the <c>ContentIdentifier</c> or
/// <c>VerifiedUsing</c> values of type <c>Hash</c>.
///
/// The existence of a relationship of type <c>RelationshipType.CopyOf</c> between
/// two files is also indicative of identical content, but this should be verified
/// using one of the other two techniques.
/// </remarks>
public class File : Artifact
{
    public File(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
    public Uri? ContentIdentifier { get; set; }
    public IEnumerable<SoftwarePurpose>? FilePurposes { get; set; }
    public string? ContentType { get; set; }

}
