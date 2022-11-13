namespace Spdx3.Core;

/// \ingroup Core
/// <summary>
/// 
/// </summary>
public struct ExternalElementReference
{
    public Uri? LocationHint { get; set; }
    public IEnumerable<IIntegrityMethod>? VerifiedUsing { get; set; }
}