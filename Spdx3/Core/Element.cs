namespace Spdx3.Core;

/// \defgroup Core Core
/// \ingroup Core
/// <summary>
/// 
/// </summary>
public abstract class Element
{
    protected Element(Uri spdxId, CreationInformation creationInfo, string? name = null)
    {
        SpdxId = spdxId;
        CreationInfo = creationInfo;
        Name = name;
    }
    public Uri SpdxId { get; private set; }
    public CreationInformation CreationInfo { get; private set; }
    public string? Name { get; set; }
    public string? Summary { get; set; }
    public string? Description { get; set; }
    public IEnumerable<IIntegrityMethod>? VerifiedUsing { get; set; }
    public IEnumerable<ExternalReference>? ExternalReferences { get; set; }
    public IEnumerable<ExternalIdentifier>? ExternalIdentifiers { get; set; }
    public Dictionary<Uri, Extension>? Extensions { get; set; }

    public Relationship CreateRelationship(Uri spdxId, RelationshipType relationshipType, IEnumerable<Uri> toElements)
    {
        return new Relationship(spdxId, CreationInfo, SpdxId, toElements);
    }
}