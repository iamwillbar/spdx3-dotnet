namespace Spdx3.Core;

/// \ingroup core
/// <summary>
/// Represents a natural person.
/// </summary>
public class Person : Element, IIdentity, IActor
{
    public Person(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
}