namespace Spdx3.Core;

/// \ingroup core
/// <summary>
/// Represents an entity observed performing an action.
/// </summary>
public struct Actor : IActor
{
    public Actor(string? name = null, ActorType? actorType = null, IEnumerable<ExternalIdentifier>? externalIdentifiers = null)
    {
        Name = name;
        ActorType = actorType ?? ActorType.NoAssertion;
        ExternalIdentifiers = externalIdentifiers;
    }
    public string? Name { get; set; }
    public ActorType ActorType { get; private set; }
    public IEnumerable<ExternalIdentifier>? ExternalIdentifiers { get; set; }
    public IEnumerable<ExternalReference>? ExternalReferences { get; set; }
}
