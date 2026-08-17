# Grial Usage Rules

## Default policy

`reference/GrialUiKit/` **READ-ONLY BY DEFAULT** alanıdır.

Agent source'u okuyabilir ve analiz edebilir. Task açıkça izin vermedikçe hiçbir
dosyayı modify, move, rename veya delete edemez; package upgrade/refactor da
yapamaz.

## Production dependency rule

Grial demo `.csproj` dosyasına `ProjectReference` verilmez ve demo project ana
solution'a eklenmez. Gerekirse onaylı `UXDivers.GrialMaui` package doğrudan
production project'e eklenir.

## Dependency closure requirement

Bir Grial page/control/pattern taşınmadan veya yeniden uygulanmadan önce şu
closure kaydedilir:

1. XAML ve code-behind
2. Styles ve resource keys
3. Local controls/templates
4. Converters/behaviors
5. Fonts/images
6. NuGet packages
7. Handlers/startup
8. Platform permissions/configuration
9. Demo data/navigation bağı

Closure kapanmadan implementation başlamaz.

## Forbidden reasoning

Hiçbir agent yalnız “Grial'de böyle yapılmış” gerekçesiyle:

- package ekleyemez;
- handler register edemez;
- full theme merge edemez;
- navigation root değiştiremez;
- platform permission, manifest key veya API key ekleyemez;
- Android minimum SDK veya target framework değiştiremez.

Her değişiklik product gereksinimi ve production source üzerinde bağımsız
kanıt gerektirir.

## Theme and assets

- Demo App.xaml veya full theme dictionary alınmaz.
- Yeni product resources `AS.*` kullanır.
- Kullanılmayan font/image/theme taşınmaz.
- Grial app icon, splash, brand logo ve branded activity indicator alınmaz.

## Navigation

- Shell tek navigation authority'dir.
- `RootFlyoutPage` ve demo main menu taşınmaz.
- Demo ViewModel'in doğrudan page oluşturması production pattern değildir.

## License safety

- `GrialLicense` içeriği okunmaz, loglanmaz, raporlanmaz veya kopyalanmaz.
- License key/token hiçbir prompt, diff, commit veya issue'ya yazılmaz.
- Yalnız dosyanın resource/startup mekanizması teknik olarak incelenebilir.

## Production boundary

Şunlar production'a taşınmaz:

- `SamplesCatalog`, DemoApp root/menu/flyout ve `DEMO_APP`
- embedded sample JSON, `JsonHelper`, demo Data classes
- demo Resx içeriği
- sample maps key ve kullanılmayan location permissions
- kullanılmayan themes, fonts ve images
- demo ViewModel navigation architecture
- bütün demo project veya klasörlerinin toplu kopyası

## Required validation

Grial ile ilgili her implementation task canonical Android build almalı ve
eklediği global resource/handler davranışı için standard MAUI regression
kontrolü raporlamalıdır.

