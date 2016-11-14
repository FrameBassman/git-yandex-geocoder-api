# Yandex Geocoder Api
Repository for realization of yandex geocoder API.

Welcome to this page.
This is source of https://www.nuget.org/packages/Yandex.Api/0.0.2 nuget package.

# How to use
1. Create solution
2. Clone this repository
3. Add project from this repository 'Yandex.Api' as existing project to your solution
4. Add console application project
5. Add reference from your console application project to 'Yandex.Api' project
6. Build
7. ...
8. PROFIT. You can write the following code:
```csharp
var geocodeService = new Yandex.Api.GeocodeService();

var pount = geocodeService.GetPoint("Иваново, улица Тихая, 15");
var address = geocodeService.GetAddress(point);
```
