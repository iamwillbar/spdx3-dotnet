namespace Spdx3.Core;

public struct ExternalElementReference
{
    public Uri? LocationHint { get; set; }
    public IEnumerable<IIntegrityMethod>? VerifiedUsing { get; set; }
}