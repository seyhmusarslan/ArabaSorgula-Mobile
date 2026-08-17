# Architecture

## Architecture style

Uygulama sade, feature-oriented bir MAUI yapısı kullanır. Yeni class-library
katmanları veya soyutlamalar gerçek ihtiyaç olmadan eklenmez.

Planlanan production organization:

```text
src/ArabaSorgula.Mobile/
├── Features/
│   ├── Auth/
│   ├── Onboarding/
│   ├── Home/
│   ├── Queries/
│   ├── History/
│   ├── Valuation/
│   ├── Expertise/
│   ├── Settings/
│   └── Profile/
├── Controls/
├── Models/
├── Services/
├── Resources/
├── Platforms/
├── App.xaml
├── AppShell.xaml
└── MauiProgram.cs
```

Bu klasörler planlanan yönü gösterir; implementation başlamadan boş klasör
veya placeholder class oluşturulmaz.

## Application startup

- `MauiProgram` application ve onaylı service/dependency registration'larının
  tek composition root'udur.
- `App` application-level resource ve root window kurulumundan sorumludur.
- `AppShell` tek navigation authority'dir.
- Platform startup değişikliği yalnız platform gereksinimi kanıtlandığında
  yapılır.

## Feature organization

Bir feature mümkün olduğunca page, ViewModel, feature-local model ve
template'lerini kendi klasöründe tutar. Birden fazla feature tarafından
gerçekten kullanılan görsel parçalar `Controls/` altına yükseltilebilir.

Shared alanlar, yalnız olası tekrar beklentisiyle oluşturulmaz.

## ViewModels

- ViewModel UI state ve presentation davranışını taşır.
- ViewModel doğrudan page oluşturmaz ve navigation root değiştirmez.
- Navigation, service veya platform davranışı gerektiğinde test edilebilir
  bir boundary üzerinden sağlanır.
- Async operasyonlar hata ve cancellation davranışı açık olan command
  yaklaşımı kullanır; kontrolsüz `async void` yalnız UI event zorunluluğunda
  kullanılabilir.
- Demo JSON loader veya page-name convention production pattern değildir.

## Services and API boundary

- HTTP, authentication, storage, permission ve platform işlemleri page
  code-behind içine gömülmez.
- Interface yalnız gerçek test/substitution sınırı varsa oluşturulur.
- API request/response modelleri UI control modellerinden ayrılır.
- Backend contract doğrulanmadan endpoint, status veya retry kuralı uydurulmaz.
- Secrets, API keys ve signing credentials source control'a yazılmaz.

## Resource ownership

- Product-wide design kaynakları `Resources/` altında `AS.*` contract'ına
  uyar.
- Feature kaynakları `AS.Auth.*`, `AS.Home.*` gibi feature prefix'i kullanır.
- Grial adapter kaynakları küçük, isimlendirilmiş ve seçilen component ile
  sınırlı dictionary'lerde tutulur.
- Full Grial theme dictionary production'a merge edilmez.

## Platform-specific code

- `Platforms/Android/` yalnız Android runtime gereksinimlerini içerir.
- Cross-platform çözülebilen davranış için platform handler yazılmaz.
- Handler ve permission application-wide etki analizi olmadan eklenmez.
- iOS implementation ayrı, açık task gerektirir.

## Dependency changes

Yeni package için task şunları belgelemelidir:

1. Hangi feature veya component gerektiriyor?
2. Standard MAUI alternatifi neden yetersiz?
3. Startup, handler, permission veya resource etkisi nedir?
4. Minimum platform sürümünü etkiliyor mu?
5. Build ve regression checkpoint'i nedir?

## Build boundary

Canonical build yalnız production project'i hedefler:

```powershell
dotnet build .\src\ArabaSorgula.Mobile\ArabaSorgula.Mobile.csproj -f net10.0-android -c Debug
```

`reference/GrialUiKit/` build graph'a dahil edilmez.

