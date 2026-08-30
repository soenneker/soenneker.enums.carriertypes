[![](https://img.shields.io/nuget/v/soenneker.enums.carriertypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.carriertypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.carriertypes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.carriertypes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.carriertypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.carriertypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.carriertypes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.carriertypes/actions/workflows/codeql.yml)

# Soenneker.Enums.CarrierTypes

A string-backed enum-value type for classifying the service category associated with a telephone number.

## Install

```bash
dotnet add package Soenneker.Enums.CarrierTypes
```

## Usage

```csharp
using Soenneker.Enums.CarrierTypes;

CarrierType type = CarrierType.Mobile;
string wireValue = type.Value; // "Mobile"

if (CarrierType.TryFromValue(input, out CarrierType? parsed))
{
    // parsed is one of the shared static instances
}
```

The available values and their serialized strings are:

- `FixedLine`
- `Mobile`
- `Voip`
- `FixedLineOrMobile`
- `TollFree`
- `PremiumRate`
- `SharedCost`
- `PersonalNumber`
- `Pager`
- `Uan`
- `Voicemail`
- `Unknown`

`System.Text.Json` serializes the type as its string value and deserializes known values back to the corresponding static instance. `FromValue` throws for an unknown value; use `TryFromValue` at external-input boundaries. `FromName` and `TryFromName` are also generated for member-name lookup.

This package classifies a supplied result; it does not inspect phone numbers, query carrier data, or guarantee that a classification remains accurate after number porting. Use `Unknown` when the upstream source cannot determine a category.
