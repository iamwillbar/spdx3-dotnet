using Spdx3.Core;
using Spdx3.Licensing;
using Spdx3.Serialization;
using Spdx3.Software;
using File = Spdx3.Software.File;

namespace Spdx3.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void CanCreateSbom()
    {
        var actor = new Actor("William Bartholomew",
            ActorType.Person,
            new[]
            {
                new ExternalIdentifier(ExternalIdentifierType.Other, "iamwillbar", "GitHub")
            });
        var creationInfo = new CreationInformation(new [] { actor }, new[] { ProfileIdentifier.Software });
        var contoso = new Organization(new Uri("duns:123456"), creationInfo, "Contoso");

        var myapp = new Package(new Uri("https://spdx.contoso.com/package/myapp/1.0"), creationInfo, "MyApp 1.0")
        {
            ContentIdentifier = new Uri("gitoid:12345"),
            DownloadLocation = new Uri("https://downloads.contoso.com/myapp/1.0"),
            HomePage = new Uri("https://contoso.com/myapp"),
            PackagePurposes = new [] { SoftwarePurpose.Application },
            PackageUrl = new Uri("pkg:npm/@contoso/myapp/1.0.0"),
            OriginatedBy = new[] { contoso },
            Extensions = new Dictionary<Uri, Extension>()
            {
                { LicenseGrant.ExtensionUri, new LicenseGrant("MIT") }
            }
        };

        var myappPack = new File(new Uri("https://spdx.contoso.com/file/12345/1"), creationInfo)
        {
            Name = "./myapp-1.0.tgz",
            ContentIdentifier = myapp.ContentIdentifier,
            ContentType = "application/gzip",
            FilePurposes = new [] { SoftwarePurpose.Archive },
            VerifiedUsing = new IIntegrityMethod[]
            {
                new Hash(HashAlgorithm.Sha256, new byte[] {})
            }
        };

        var myappPackRel = myapp.CreateRelationship(new Uri("https://spdx.contoso.com/rels/myapp/1.0-pack"), RelationshipType.DistributionArtifact,
            new[] { myappPack.SpdxId });
        myappPackRel.RelationshipCompleteness = RelationshipCompleteness.Unknown;

        var runtimeDependencies = new SoftwareDependencyRelationship(new Uri("https://spdx.contoso.com/rels/myapp/1.0-runtimedeps"), creationInfo, myapp.SpdxId)
        {
            Scope = Scope.Run,
            LinkingMethod = LinkingMethod.Dynamic
        };

        var sbom = new Sbom(new Uri("https://spdx.contoso.com/sbom/myapp/1.0/1"), creationInfo, "MyApp 1.0 SBOM")
        {
            Elements = new[] { myapp.SpdxId, myappPack.SpdxId, myappPackRel.SpdxId, runtimeDependencies.SpdxId },
            RootElement = myapp.SpdxId
        };
        
        var serializer = new SpdxJsonSerializer();
        serializer.Serialize(sbom);
        Assert.IsNotNull(sbom);
    }
}