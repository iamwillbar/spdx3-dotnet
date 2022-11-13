using System.Runtime.Serialization;

namespace Spdx3.Core;

/// \ingroup Core
/// <summary>
/// 
/// </summary>
public enum AnnotationType
{
    [EnumMember(Value = "OTHER")]
    Other = 0,
    [EnumMember(Value = "REVIEW")]
    Review = 1
}