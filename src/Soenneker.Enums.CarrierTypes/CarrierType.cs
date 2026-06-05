using Soenneker.Gen.EnumValues;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.CarrierTypes;

/// <summary>
/// An enumerator describing carrier types
/// </summary>
[PublicOpenApiObject]
[EnumValue<string>]
public sealed partial class CarrierType
{
    /// <summary>
    /// The fixed line.
    /// </summary>
    public static readonly CarrierType FixedLine = new(nameof(FixedLine));
    /// <summary>
    /// The mobile.
    /// </summary>
    public static readonly CarrierType Mobile = new(nameof(Mobile));
    /// <summary>
    /// The voip.
    /// </summary>
    public static readonly CarrierType Voip = new(nameof(Voip));
    /// <summary>
    /// The fixed line or mobile.
    /// </summary>
    public static readonly CarrierType FixedLineOrMobile = new(nameof(FixedLineOrMobile));
    /// <summary>
    /// The toll free.
    /// </summary>
    public static readonly CarrierType TollFree = new(nameof(TollFree));
    /// <summary>
    /// The premium rate.
    /// </summary>
    public static readonly CarrierType PremiumRate = new(nameof(PremiumRate));
    /// <summary>
    /// The shared cost.
    /// </summary>
    public static readonly CarrierType SharedCost = new(nameof(SharedCost));
    /// <summary>
    /// The personal number.
    /// </summary>
    public static readonly CarrierType PersonalNumber = new(nameof(PersonalNumber));
    /// <summary>
    /// The pager.
    /// </summary>
    public static readonly CarrierType Pager = new(nameof(Pager));
    /// <summary>
    /// The uan.
    /// </summary>
    public static readonly CarrierType Uan = new(nameof(Uan));
    /// <summary>
    /// The voicemail.
    /// </summary>
    public static readonly CarrierType Voicemail = new(nameof(Voicemail));
    /// <summary>
    /// The unknown.
    /// </summary>
    public static readonly CarrierType Unknown = new(nameof(Unknown));
}