using Intellenum;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.CarrierTypes;

/// <summary>
/// An enumerator describing carrier types
/// </summary>
[PublicOpenApiObject]
[Intellenum<string>]
public sealed partial class CarrierType
{
    public static readonly CarrierType FixedLine = new(nameof(FixedLine));
    public static readonly CarrierType Mobile = new(nameof(Mobile));
    public static readonly CarrierType Voip = new(nameof(Voip));
    public static readonly CarrierType FixedLineOrMobile = new(nameof(FixedLineOrMobile));
    public static readonly CarrierType TollFree = new(nameof(TollFree));
    public static readonly CarrierType PremiumRate = new(nameof(PremiumRate));
    public static readonly CarrierType SharedCost = new(nameof(SharedCost));
    public static readonly CarrierType PersonalNumber = new(nameof(PersonalNumber));
    public static readonly CarrierType Pager = new(nameof(Pager));
    public static readonly CarrierType Uan = new(nameof(Uan));
    public static readonly CarrierType Voicemail = new(nameof(Voicemail));
    public static readonly CarrierType Unknown = new(nameof(Unknown));
}
