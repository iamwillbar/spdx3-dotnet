namespace Spdx3.Core;

/// \ingroup Core
/// <summary>
/// 
/// </summary>
public struct ProfileIdentifier
{
    public static ProfileIdentifier Core = new ProfileIdentifier("core");
    public static ProfileIdentifier Software = new ProfileIdentifier("software");

    // ReSharper disable once MemberCanBePrivate.Global
    public ProfileIdentifier(string name)
    {
        Name = name;
    }
    public string Name { get; private set; }
}