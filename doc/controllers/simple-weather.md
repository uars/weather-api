# Simple Weather

```csharp
SimpleWeatherController simpleWeatherController = client.SimpleWeatherController;
```

## Class Name

`SimpleWeatherController`

## Methods

* [Weather by City Name](/doc/controllers/simple-weather.md#weather-by-city-name)
* [Weather by City ID](/doc/controllers/simple-weather.md#weather-by-city-id)


# Weather by City Name

```csharp
WeatherByCityNameAsync(
    Models.TypeWeatherEnum weather,
    string appid,
    string q,
    Models.TypeModeEnum mode,
    Models.TypeUnitsEnum units,
    Models.TypeLanguageEnum lang)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `weather` | [`Models.TypeWeatherEnum`](/doc/models/type-weather-enum.md) | Template, Required | - |
| `appid` | `string` | Query, Required | - |
| `q` | `string` | Query, Required | - |
| `mode` | [`Models.TypeModeEnum`](/doc/models/type-mode-enum.md) | Query, Required | - |
| `units` | [`Models.TypeUnitsEnum`](/doc/models/type-units-enum.md) | Query, Required | - |
| `lang` | [`Models.TypeLanguageEnum`](/doc/models/type-language-enum.md) | Query, Required | - |

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
TypeWeatherEnum weather = TypeWeatherEnum.Weather;
string appid = "67efe337072a2e09c9d9796a16c42af9";
string q = "London";
TypeModeEnum mode = TypeModeEnum.Xml;
TypeUnitsEnum units = TypeUnitsEnum.Imperial;
TypeLanguageEnum lang = TypeLanguageEnum.En;

try
{
    dynamic result = await simpleWeatherController.WeatherByCityNameAsync(weather, appid, q, mode, units, lang);
}
catch (ApiException e){};
```


# Weather by City ID

```csharp
WeatherByCityIDAsync(
    Models.TypeWeatherEnum weather,
    int id,
    string appid,
    Models.TypeModeEnum mode,
    Models.TypeUnitsEnum units,
    Models.TypeLanguageEnum lang)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `weather` | [`Models.TypeWeatherEnum`](/doc/models/type-weather-enum.md) | Template, Required | - |
| `id` | `int` | Query, Required | - |
| `appid` | `string` | Query, Required | - |
| `mode` | [`Models.TypeModeEnum`](/doc/models/type-mode-enum.md) | Query, Required | - |
| `units` | [`Models.TypeUnitsEnum`](/doc/models/type-units-enum.md) | Query, Required | - |
| `lang` | [`Models.TypeLanguageEnum`](/doc/models/type-language-enum.md) | Query, Required | - |

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
TypeWeatherEnum weather = TypeWeatherEnum.Weather;
int id = 2172797;
string appid = "67efe337072a2e09c9d9796a16c42af9";
TypeModeEnum mode = TypeModeEnum.Xml;
TypeUnitsEnum units = TypeUnitsEnum.Imperial;
TypeLanguageEnum lang = TypeLanguageEnum.En;

try
{
    dynamic result = await simpleWeatherController.WeatherByCityIDAsync(weather, id, appid, mode, units, lang);
}
catch (ApiException e){};
```

