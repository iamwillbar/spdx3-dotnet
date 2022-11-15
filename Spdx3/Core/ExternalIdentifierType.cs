namespace Spdx3.Core;

/// \ingroup core
/// <summary>
/// Represents the scheme or authority that the external identifier belongs to. 
/// </summary>
public enum ExternalIdentifierType
{
    Other = 0,
    Cpe22 = 1,
    Cpe23 = 2,
    Purl = 3,
    Swid = 4,
    Swhid = 5,
    GitOid = 6,
}
