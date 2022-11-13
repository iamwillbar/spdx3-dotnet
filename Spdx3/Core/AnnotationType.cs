using System.Runtime.Serialization;

namespace Spdx3.Core;

public enum AnnotationType
{
    [EnumMember(Value = "OTHER")]
    Other = 0,
    [EnumMember(Value = "REVIEW")]
    Review = 1
}