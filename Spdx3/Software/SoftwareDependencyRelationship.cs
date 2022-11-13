using Spdx3.Core;

namespace Spdx3.Software;

/// \ingroup Software
/// <summary>
/// 
/// </summary>
public class SoftwareDependencyRelationship : Relationship
{
    public SoftwareDependencyRelationship(Uri spdxId, CreationInformation creationInfo, Uri fromElement, IEnumerable<Uri>? toElements = null) : base(spdxId, creationInfo, fromElement, toElements)
    {
        RelationshipType = RelationshipType.DependsOn;
        LinkingMethod = LinkingMethod.Unknown;
        Optionality = Optionality.Required;
        DeliveryMethod = DeliveryMethod.Provided;
        Scope = Scope.Unknown;
        Cardinality = Cardinality.All;
    }
    public LinkingMethod LinkingMethod { get; set; }    
    public Optionality Optionality { get; set; }
    public DeliveryMethod DeliveryMethod { get; set; }
    public Scope Scope { get; set; }
    public Cardinality Cardinality { get; set; }
}

public enum LinkingMethod
{
    Unknown = 0,
    Static = 1,
    Dynamic = 2,
    OutOfProcess = 3,
}

public enum Optionality
{
    Unknown = 0,
    Required = 1,
    Optional = 2,
}

public enum DeliveryMethod
{
    Unknown = 0,
    Provided = 1,
    Acquired = 2,
    Expected = 3,
}

public enum Scope
{
    Unknown = 0,
    Develop = 1,
    Build = 2,
    Test = 3,
    Deploy = 4,
    Run = 5,
    Operate = 6,
    Dispose = 7,
}

public enum Cardinality
{
    Unknown = 0,
    None = 1,
    One = 2,
    Multiple = 3,
    All = 4,
}