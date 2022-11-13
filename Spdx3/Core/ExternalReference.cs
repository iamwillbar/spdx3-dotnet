namespace Spdx3.Core;

/// \ingroup Core
/// <summary>
/// Represents a pointer to information outside of the SPDX domain related to an Element. 
/// </summary>
public struct ExternalReference
{
    public ExternalReferenceType ExternalReferenceType { get; set; }
    public Uri Locator { get; set; }
    public string? ContentType { get; set; }
    public string? Comment { get; set; }
}