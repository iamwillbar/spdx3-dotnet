namespace Spdx3.Core;

/// \defgroup core Core
/// \ingroup core
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
    /// <summary>
    /// Globally unique identifier for the Element.
    /// </summary>
    /// <remarks>
    /// The SpdxId enables the Element to be referenced from both within the document it is contained, as well as from
    /// other documents.
    ///
    /// The SpdxId MUST be globally unique.
    ///
    /// The authority portion of the URI SHOULD be controlled by the creator of the Element - such as the creator's
    /// domain name to help ensure global uniqueness of the SpdxId.
    ///
    /// The creator SHOULD define and use a consistent structure for the path portion of the URI to avoid any SpdxId
    /// conflicts. Because Element objects are immutable this structure SHOULD support multiple versions of an Element
    /// over time.
    ///
    /// The SpdxId MUST NOT contain a fragment portion.
    ///
    /// One possible structure would be:
    /// `urn:authority/elementType/uniqueEntityAttribute/elementRevision`
    ///
    /// For example, choosing to identify Package elements by their content hash an SpdxId may be:
    /// `urn:contoso.com/package/a0b65939670bc2c010f4d5d6a0b3e4e4590fb92b/1`
    /// </remarks>
    public Uri SpdxId { get; private set; }
    public CreationInformation CreationInfo { get; private set; }
    
    /// <summary>
    /// Single line of text to help a human identify what the Element represents.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Short abstract to help a human understand what the Element represents.
    /// </summary>
    public string? Summary { get; set; }
    /// <summary>
    /// Longer description to provide a human detail about what the Element represents.
    /// </summary>
    public string? Description { get; set; }
    public IEnumerable<IIntegrityMethod>? VerifiedUsing { get; set; }
    public IEnumerable<ExternalReference>? ExternalReferences { get; set; }
    public IEnumerable<ExternalIdentifier>? ExternalIdentifiers { get; set; }
    public Dictionary<Uri, Extension>? Extensions { get; set; }

    /// <summary>
    /// Creates a Relationship with this Element as the From of the Relationship.
    /// </summary>
    /// <param name="spdxId">Globally unique identifier to assign to the Relationship.</param>
    /// <param name="relationshipType">Nature of the Relationship.</param>
    /// <param name="toElements">Globally unique identifiers of the Element related to this Element.</param>
    /// <returns>Relationship</returns>
    public Relationship CreateRelationship(Uri spdxId, RelationshipType relationshipType, IEnumerable<Uri> toElements)
    {
        return new Relationship(spdxId, CreationInfo, SpdxId, toElements);
    }
}