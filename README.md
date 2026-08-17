# ArabaSorgula Mobile

ArabaSorgula mobil uygulaması için .NET MAUI repository iskeleti.

## Repository yapısı

```text
ArabaSorgula-Mobile/
├── src/
│   └── ArabaSorgula.Mobile/       # Gerçek uygulama
├── reference/
│   └── GrialUiKit/                # Satın alınan Grial kaynakları (referans)
├── docs/                           # Proje hafızası / kurallar
├── scripts/                        # Ortak build yardımcıları
├── AGENTS.md
└── ArabaSorgula-Mobile.sln
```

## Temel kural

`reference/GrialUiKit` ana solution'a eklenmez ve `ProjectReference`
olarak bağlanmaz. Grial kaynakları önce incelenir; gerçek bağımlılıklar
daha sonra bilinçli şekilde `src/ArabaSorgula.Mobile` projesine eklenir.

## Proje belgeleri

Çalışmaya başlamadan önce root `AGENTS.md` ve
[`docs/START-HERE.md`](docs/START-HERE.md) içindeki okuma sırasını izle.
Architecture, design-system, navigation ve Grial governance kararları `docs/`
altındaki final spec pack'te tutulur.

## İlk kurulum

1. Repository'yi clone et.
2. Satın alınan Grial UI Kit proje klasörünü
   `reference/GrialUiKit/Source/` altına kopyala.
3. `AGENTS.md` ve `docs/START-HERE.md` dosyalarını oku.
4. Grial task'ıysa `reference/GrialUiKit/README.md` dosyasını oku.
5. Visual Studio'da `ArabaSorgula-Mobile.sln` dosyasını aç.
6. Android build al.

PowerShell:

```powershell
./scripts/build-android.ps1
```

veya:

```bash
dotnet build src/ArabaSorgula.Mobile/ArabaSorgula.Mobile.csproj -f net10.0-android -c Debug
```

## Not

Bu başlangıç iskeleti Android-first tutulmuştur. iOS hedefi Grial
bağımlılıkları ve proje sürümü doğrulandıktan sonra eklenecektir.
