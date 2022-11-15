namespace Spdx3.Core;

/// \ingroup core
/// <summary>
/// Represents an identifier from outside of the SPDX domain for an Element.
/// </summary>
public struct ExternalIdentifier
{
    public ExternalIdentifier(ExternalIdentifierType externalIdentifierType, string identifier, string? comment = null)
    {
        ExternalIdentifierType = externalIdentifierType;
        Identifier = identifier;
        Comment = comment;

    }
    public string Identifier { get; set; }
    public ExternalIdentifierType ExternalIdentifierType { get; set; }
    public string? Comment { get; set; }
}