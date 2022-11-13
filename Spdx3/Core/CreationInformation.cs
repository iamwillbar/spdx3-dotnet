namespace Spdx3.Core;

/// \ingroup Core
/// <summary>
/// 
/// </summary>
public struct CreationInformation
{
    public CreationInformation(IEnumerable<Actor> createdBy, IEnumerable<ProfileIdentifier>? additionalProfiles = null)
    {
        SpecVersion = new Version(3, 0);
        Created = DateTime.Now;
        CreatedBy = createdBy;
        Profiles = (additionalProfiles ?? Array.Empty<ProfileIdentifier>())
            .Prepend(ProfileIdentifier.Core)
            .DistinctBy(p => p.Name)
            .ToArray();
    }
    public Version SpecVersion { get; set; }
    public IEnumerable<ProfileIdentifier> Profiles { get; set; }
    public DateTime Created { get; set; }
    public IEnumerable<Actor> CreatedBy { get; set; }
    public string DataLicense => "CC0";
    public string? Comment { get; set; }
}