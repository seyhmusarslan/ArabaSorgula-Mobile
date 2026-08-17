# Local Development Setup

Bu belge yeni bilgisayar veya temiz clone sonrasında gerekli local-only
kurulumu açıklar. Credential, token veya license içeriği repository'ye
yazılmaz.

## Canonical project

```text
src/ArabaSorgula.Mobile/ArabaSorgula.Mobile.csproj
```

Reference altındaki Grial demo project canonical restore/build girdisi değildir.

## Private Grial NuGet source

`UXDivers.GrialMaui` private NuGet source gerektirir. Doğrulanmış source:

```text
Name: Grial
URL:  https://nuget.uxdivers.com/grial
```

Mevcut machine/user sources:

```powershell
dotnet nuget list source
```

Yeni bilgisayarda source ve credential kullanıcı/makine düzeyinde yeniden
configure edilmelidir. Username, password veya credential token repository
`NuGet.config` dosyasına yazılmaz ve commit edilmez. Yetkilendirme yöntemi
Grial hesabının güncel provisioning talimatına göre developer tarafından
yapılır.

## Local Grial license

Her developer machine'de production application identity ile uyumlu local
license şu konuma provision edilmelidir:

```text
src/ArabaSorgula.Mobile/GrialLicense
```

License GitHub'dan gelmez. Repository ignore contract'ı:

```text
**/GrialLicense
```

İçeriği görüntülemeden safety doğrulaması:

```powershell
git check-ignore -v .\src\ArabaSorgula.Mobile\GrialLicense
git ls-files -- .\src\ArabaSorgula.Mobile\GrialLicense
```

İkinci komut hiçbir tracked file döndürmemelidir.

## Restore and build

Local feed credential ve license hazırlandıktan sonra:

```powershell
dotnet restore .\src\ArabaSorgula.Mobile\ArabaSorgula.Mobile.csproj
dotnet build .\src\ArabaSorgula.Mobile\ArabaSorgula.Mobile.csproj -f net10.0-android -c Debug
```

## Physical Android device

USB debugging açık cihazı doğrula:

```powershell
adb devices
```

Tek uygun Android cihaz bağlıyken repository root'tan çalıştır:

```powershell
dotnet run --project .\src\ArabaSorgula.Mobile\ArabaSorgula.Mobile.csproj -f net10.0-android -c Debug
```

Birden fazla device/emulator görünüyorsa hedef seçimi local .NET Android SDK
ve adb tooling kurulumuna göre açıkça yapılmalıdır; developer-specific absolute
SDK yolları veya device serial değerleri repository'ye yazılmaz.

Runtime smoke test'te uygulamanın kurulması, process'in başlaması, startup veya
Grial license hatası olmaması ve mevcut root page'in açılması doğrulanır.

## Safety reminders

- License, NuGet credential, API key ve signing material commit edilmez.
- `reference/GrialUiKit/` read-only kalır.
- Maps, Popups, Compatibility veya CommunityToolkit local setup için gerekmez.
- Canonical target `net10.0-android`; Android minimum SDK 21'dir.

