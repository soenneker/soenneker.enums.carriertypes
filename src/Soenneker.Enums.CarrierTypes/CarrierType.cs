using Soenneker.Gen.EnumValues;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.CarrierTypes;

/// <summary>
/// Classifies a telephone number by the network service or carrier category that provides it.
/// </summary>
[PublicOpenApiObject]
[EnumValue<string>]
public sealed partial class CarrierType
{
    /// <summary>
    /// Traditional fixed-location landline service.
    /// </summary>
    public static readonly CarrierType FixedLine = new(nameof(FixedLine));
    /// <summary>
    /// Mobile or cellular telephone service.
    /// </summary>
    public static readonly CarrierType Mobile = new(nameof(Mobile));
    /// <summary>
    /// Voice over IP telephone service.
    /// </summary>
    public static readonly CarrierType Voip = new(nameof(Voip));
    /// <summary>
    /// Number that cannot be distinguished reliably between fixed-line and mobile service.
    /// </summary>
    public static readonly CarrierType FixedLineOrMobile = new(nameof(FixedLineOrMobile));
    /// <summary>
    /// Toll-free service where the recipient generally pays for the call.
    /// </summary>
    public static readonly CarrierType TollFree = new(nameof(TollFree));
    /// <summary>
    /// Premium-rate service that may charge the caller an elevated fee.
    /// </summary>
    public static readonly CarrierType PremiumRate = new(nameof(PremiumRate));
    /// <summary>
    /// Shared-cost service where call charges are divided between caller and recipient.
    /// </summary>
    public static readonly CarrierType SharedCost = new(nameof(SharedCost));
    /// <summary>
    /// Personal numbering service that can route calls to one or more destinations.
    /// </summary>
    public static readonly CarrierType PersonalNumber = new(nameof(PersonalNumber));
    /// <summary>
    /// Paging service number.
    /// </summary>
    public static readonly CarrierType Pager = new(nameof(Pager));
    /// <summary>
    /// Universal access number that routes callers to an organization or service.
    /// </summary>
    public static readonly CarrierType Uan = new(nameof(Uan));
    /// <summary>
    /// Dedicated voicemail or message-deposit service.
    /// </summary>
    public static readonly CarrierType Voicemail = new(nameof(Voicemail));
    /// <summary>
    /// Carrier category could not be determined from available data.
    /// </summary>
    public static readonly CarrierType Unknown = new(nameof(Unknown));
}
