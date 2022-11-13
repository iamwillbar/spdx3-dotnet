namespace Spdx3.Core;

public struct ExternalReference
{
    public ExternalReferenceType ExternalReferenceType { get; set; }
    public Uri Locator { get; set; }
    public string? ContentType { get; set; }
    public string? Comment { get; set; }
}