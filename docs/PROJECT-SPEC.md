# ArabaSorgula Mobile Project Specification

## Purpose

ArabaSorgula Mobile, kullanıcıların araçla ilgili sorgu, geçmiş,
değerleme ve ekspertiz işlemlerine mobil cihazdan erişmesini amaçlayan
.NET MAUI uygulamasıdır.

Bu belge ürün sınırını tanımlar; doğrulanmamış backend davranışı, iş kuralı
veya marka değeri tanımlamaz.

## Platform scope

- Mevcut üretim hedefi `net10.0-android`'dir.
- Android minimum sürümü 21 olarak korunur.
- iOS gelecekte desteklenecektir; mevcut implementation Android-first'tür.
- iOS startup, license, orientation ve permission entegrasyonu ayrı task'tır.

## Planned application areas

### Entry and identity

- Splash
- Onboarding
- Welcome
- Login
- Register
- Phone Verification
- Forgot Password
- Reset Password
- Terms & Privacy
- Notification Permission

### Authenticated application

- Home
- Queries
- History
- Vehicle Valuation
- Expertise Appointment
- Settings
- Profile

Ekranların varlığı onaylanmıştır; kesin içerik, backend contract, tab labels,
permission sırası ve ticari kurallar ilgili feature task'larında belirlenir.

## High-level boundaries

- Production source: `src/ArabaSorgula.Mobile/`
- Product documentation: `docs/`
- Build scripts: `scripts/`
- Read-only reference source: `reference/GrialUiKit/Source/`

Yalnız `src/ArabaSorgula.Mobile/ArabaSorgula.Mobile.csproj` canonical
production project'tir. Reference altındaki `.sln` ve `.csproj` dosyaları
production dependency veya ana build girdisi değildir.

## Role of Grial

Grial UI Kit:

- tasarım ve interaction referansı olabilir;
- seçilmiş durumlarda `UXDivers.GrialMaui` NuGet paketi üzerinden doğrudan
  production dependency olabilir;
- dependency closure incelenmeden source taşıma gerekçesi değildir.

Demo project, demo App.xaml, demo navigation root ve bütün demo kaynakları
toplu olarak production'a alınmaz.

## Non-goals

- Grial demo uygulamasını yeniden markalamak
- Grial demo projesine `ProjectReference` vermek
- Doğrulanmamış API veya backend davranışları tasarlamak
- Android-first aşamada iOS entegrasyonu yapmak
- Popup veya maps paketini foundation dependency yapmak
- Gereksiz layer veya project sayısıyla mimariyi büyütmek

## Related documents

- [Architecture](ARCHITECTURE.md)
- [Design System](DESIGN-SYSTEM.md)
- [Navigation](NAVIGATION.md)
- [Screen Flows](SCREEN-FLOWS.md)
- [Grial Integration](GRIAL-INTEGRATION.md)

