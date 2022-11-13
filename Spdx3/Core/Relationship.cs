namespace Spdx3.Core;

/// \ingroup Core
/// <summary>
/// 
/// </summary>
public class Relationship : Element
{
    public Relationship(Uri spdxId, CreationInformation creationInfo, Uri fromElement, IEnumerable<Uri>? toElements = null, string? name = null) : base(spdxId, creationInfo, name)
    {
        From = fromElement;
        To = toElements ?? new Uri[] { };
    }
    public Uri From { get; set; }
    public IEnumerable<Uri> To { get; set; }
    public RelationshipType RelationshipType { get; set; }
    public RelationshipCompleteness RelationshipCompleteness { get; set; }

}