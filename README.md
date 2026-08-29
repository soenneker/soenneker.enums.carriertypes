[![](https://img.shields.io/nuget/v/soenneker.enums.carriertypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.carriertypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.carriertypes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.carriertypes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.carriertypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.carriertypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.carriertypes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.carriertypes/actions/workflows/codeql.yml)

# Soenneker.Enums.CarrierTypes

Classifies a telephone number by the network service or carrier category that provides it.

## Install

```bash
dotnet add package Soenneker.Enums.CarrierTypes
```

## What you get

- `CarrierType` — Classifies a telephone number by the network service or carrier category that provides it.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `CarrierType.FixedLine` | Traditional fixed-location landline service. | Traditional fixed-location landline service. |
| `CarrierType.Mobile` | Mobile or cellular telephone service. | Mobile or cellular telephone service. |
| `CarrierType.FixedLineOrMobile` | Number that cannot be distinguished reliably between fixed-line and mobile service. | Number that cannot be distinguished reliably between fixed-line and mobile service. |
| `CarrierType.PremiumRate` | Premium-rate service that may charge the caller an elevated fee. | Premium-rate service that may charge the caller an elevated fee. |
| `CarrierType.SharedCost` | Shared-cost service where call charges are divided between caller and recipient. | Shared-cost service where call charges are divided between caller and recipient. |
| `CarrierType.PersonalNumber` | Personal numbering service that can route calls to one or more destinations. | Personal numbering service that can route calls to one or more destinations. |
| `CarrierType.Uan` | Universal access number that routes callers to an organization or service. | Universal access number that routes callers to an organization or service. |
| `CarrierType.Voicemail` | Dedicated voicemail or message-deposit service. | Dedicated voicemail or message-deposit service. |
| `CarrierType.Unknown` | Carrier category could not be determined from available data. | Carrier category could not be determined from available data. |
