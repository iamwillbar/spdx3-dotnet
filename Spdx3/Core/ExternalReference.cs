namespace Spdx3.Core;

/// \ingroup Core
/// <summary>
/// 
/// </summary>
public struct ExternalReference
{
    public ExternalReferenceType ExternalReferenceType { get; set; }
    public Uri Locator { get; set; }
    public string? ContentType { get; set; }
    public string? Comment { get; set; }
}