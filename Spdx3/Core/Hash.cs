namespace Spdx3.Core;

/// \ingroup core
/// <summary>
/// Represents the result of performing a cryptographic hash.
/// </summary>
public struct Hash : IIntegrityMethod
{
    public Hash(HashAlgorithm hashAlgorithm, IEnumerable<byte> hashValue, string? comments = null)
    {
        HashAlgorithm = hashAlgorithm;
        HashValue = hashValue;
        Comments = comments;
    }
    public HashAlgorithm HashAlgorithm { get; set; }
    public IEnumerable<byte> HashValue { get; set; }
    public string? Comments { get; set; }
}