namespace Spdx3.Core;

/// \ingroup Core
/// <summary>
/// Represents a comment or explanation about an Element.
/// </summary>
/// <remarks>
///
/// </remarks>
public class Annotation : Element
{
    public Annotation(Uri spdxId, CreationInformation creationInfo, Uri subject) : base(spdxId, creationInfo)
    {
        Subject = subject;
    }

    public Annotation(Uri spdxId, CreationInformation creationInfo, Element subject) : base(spdxId, creationInfo)
    {
        Subject = subject.SpdxId;
    }
    public Uri Subject { get; set; }
    public string? Statement { get; set; }
    public AnnotationType AnnotationType { get; set; }
    public string? ContentType { get; set; }
}