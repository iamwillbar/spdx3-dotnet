namespace Spdx3.Core;

/// \ingroup core
/// <summary>
/// 
/// </summary>
public interface IActor
{
    public string? Name { get; set; }
    public IEnumerable<ExternalIdentifier>? ExternalIdentifiers { get; set; }
    public IEnumerable<ExternalReference>? ExternalReferences { get; set; }
}