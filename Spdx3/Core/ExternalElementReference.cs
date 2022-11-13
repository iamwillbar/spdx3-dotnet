namespace Spdx3.Core;

/// \ingroup Core
/// <summary>
/// Represents a reference to an Element outside of the current scope.
/// </summary>
public struct ExternalElementReference
{
    /// <summary>
    /// Provides a hint for where an SpdxDocument containing the Element can be fetched from.
    /// </summary>
    public Uri? LocationHint { get; set; }
    
    /// <summary>
    /// Specifies how to verify the integrity of the SpdxDocument containing the Element.
    /// </summary>
    public IEnumerable<IIntegrityMethod>? VerifiedUsing { get; set; }
}