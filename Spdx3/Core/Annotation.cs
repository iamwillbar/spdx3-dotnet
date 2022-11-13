namespace Spdx3.Core;

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