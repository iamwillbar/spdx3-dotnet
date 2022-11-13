using Spdx3.Core;

namespace Spdx3.Licensing;

/// \defgroup Licensing Licensing
/// \ingroup Licensing
/// <summary>
/// 
/// </summary>
public class LicenseGrant : Extension
{
    public LicenseGrant(string declaredLicense)
    {
        DeclaredLicense = declaredLicense;
    }
    public static Uri ExtensionUri = new Uri("https://spdx.dev/extensions/licensing/license-grant/1.0");
    public string DeclaredLicense { get; set; }
}