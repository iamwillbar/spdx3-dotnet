namespace Spdx3.Core;

/// \ingroup core
/// <summary>
/// Represents the nature of the connection between one and more Elements. 
/// </summary>
public enum RelationshipType
{
    Other = 0,
    Describes = 1,
    Amends = 2,
    Contains = 3,
    Ancestor = 4,
    DependsOn = 5,
    Variant = 6,
    DependencyManifest = 7,
    Generates = 8,
    DistributionArtifact = 9,
    Example = 10,
    DataFile = 11,
    TestCase = 12,
    Documentation = 13,
    Metafile = 14,
    Test = 15,
    Packages = 16,
    Patch = 17,
    Copy = 18,
    ExpandedFromArchive = 19,
    FileAdded = 20,
    FileDeleted = 21,
    FileModified = 22,
    RequirementFor = 23,
    SpecificationFor = 24
}