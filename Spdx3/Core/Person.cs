namespace Spdx3.Core;

public class Person : Element, IIdentity, IActor
{
    public Person(Uri spdxId, CreationInformation creationInfo, string? name = null) : base(spdxId, creationInfo, name)
    {
    }
}