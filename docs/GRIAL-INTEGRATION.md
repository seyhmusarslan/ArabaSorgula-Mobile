# Grial Integration Architecture

## Boundary

Reference source:

```text
reference/GrialUiKit/Source/GrialArabasorgula/
```

Bu proje read-only referanstır; production dependency değildir. Production
gerektiğinde `UXDivers.GrialMaui` paketini doğrudan kullanabilir.

## Verified compatibility facts

- Production: `net10.0-android`, `Microsoft.Maui.Controls` `10.0.30`,
  `UXDivers.GrialMaui` `4.4.127`, Android minimum SDK 21.
- Reference: `net10.0-android;net10.0-ios`, MAUI `10.0.30`, Android 28,
  Grial `4.4.127`.
- Grial `4.4.127`, restore sırasında `Microsoft.Maui.Controls >= 10.0.30`
  gerektirdi. Production MAUI human-approved olarak `10.0.30`'a hizalandı.
- G0 kapsamında restore, canonical Android build ve fiziksel Android cihaz
  runtime smoke test'i başarılıdır.
- Android minimum SDK 21, G0 package/license bootstrap için build ve runtime
  açısından doğrulanmıştır.
- Bu sonuç bütün future Grial controls'un API 21 desteğini garanti etmez; her
  seçilmiş component kendi dependency/runtime closure'ında doğrulanır.

## License boundary

- `GrialLicense` içeriği okunmaz, raporlanmaz veya commit mesajına yazılmaz.
- Package kullanımı başlarsa license final production assembly içinde doğru
  resource adıyla embedded olmalıdır.
- Android initialization `MainApplication` içinde, MAUI app kurulmadan önce
  `GrialKit.Init(...)` ile yapılır; bu contract G0'da doğrulanmıştır.
- iOS initialization gelecekte ayrı task'tır.

## Theme and resource boundary

- Grial `MyAppTheme`, diğer full themes ve demo `App.xaml` merge edilmez.
- Arabasorgula `AS.*` semantic token'larının sahibidir.
- Seçilmiş Grial control için yalnız gerekli key'leri bridge eden küçük adapter
  resources oluşturulabilir.

## Handler boundary

Demo global olarak Entry, Editor, Picker, DatePicker, TimePicker,
NavigationPage, Image, Switch ve ScrollView handler'ları register eder; iOS'ta
CollectionView/CarouselView handler'ları da değişir.

Production'a toplu handler registration yasaktır. Her handler için component
dependency, application-wide yan etki ve standard MAUI regression testi
belgelenir.

## Fonts and controls

- Bütün font seti taşınmaz.
- Başlangıç font/icon kararı G2 kapsamındadır.
- Candidate controls dependency closure ve `AS.*` adaptasyonu sonrasında
  production'a alınabilir.
- Demo branding içeren logo/activity indicator production'a alınmaz.

## Navigation difference

Reference demo `FlyoutPage`, `NavigationPage`, modal pages ve Grial TabControl
kullanır. Production navigation authority Shell'dir. `RootFlyoutPage` ve demo
ViewModel navigation yaklaşımı taşınmaz.

## Packages excluded from foundation

- `UXDivers.Popups.Maui`
- `UXDivers.GrialMaui.Maps`
- `Microsoft.Maui.Controls.Compatibility`
- `CommunityToolkit.Maui`, ancak seçilen component gerektirirse eklenebilir

## Integration phases

### G0 — Package/license bootstrap spike

- Goal: Grial package ve Android license initialization minimumunu doğrulamak.
- Allowed: onaylı spike task'ında csproj, MauiProgram ve MainApplication'ın
  minimum değişikliği.
- Forbidden: theme/page/control/demo asset taşıma; min SDK'yi tahminle yükseltme.
- Build checkpoint: canonical Android Debug build ve launch smoke test.
- Exit: exact package sürümü, resource name ve runtime gereksinimi kanıtlanmış.

### G1 — Semantic design tokens

- Goal: `AS.*` resource contract'ını production'da uygulamak.
- Allowed: Arabasorgula-owned resource dictionaries ve mevcut key migration.
- Forbidden: full Grial theme merge ve marka değerlerini tahmin etme.
- Build checkpoint: canonical build ve mevcut ekran visual smoke test.
- Exit: collision olmayan token seti ve ownership doğrulanmış.

### G2 — Typography/icon foundation

- Goal: minimum font ve icon setini seçip register etmek.
- Allowed: yalnız seçilen font asset/alias/style'ları.
- Forbidden: bütün Grial font klasörünü kopyalama.
- Build checkpoint: glyph/font smoke screen ve canonical build.
- Exit: missing glyph yok, alias'lar `AS.*` contract'ına bağlı.

### G3 — Reusable controls

- Goal: ilk product-owned reusable controls'u üretmek.
- Allowed: dependency closure'ı tamamlanmış, `AS.*` tüketen controls.
- Forbidden: business logic, generic Grial key exposure, toplu handler ekleme.
- Build checkpoint: component smoke tests ve standard MAUI regression.
- Exit: accessibility ve platform contract'ı belgelenmiş.

### G4 — Auth visual prototype

- Goal: Login, Register ve Forgot Password production prototipi.
- Allowed: Auth feature pages/ViewModels/routes ve onaylı validators.
- Forbidden: demo service davranışı, demo JSON ve doğrulanmamış backend logic.
- Build checkpoint: auth navigation/back test ve canonical build.
- Exit: dependency closure kapalı, visual/product review tamamlanmış.

### G5 — Shell navigation contract

- Goal: unauthenticated/authenticated route ve bottom-tab sınırını uygulamak.
- Allowed: AppShell routes, auth gate ve gerektiğinde feature-local modal flow.
- Forbidden: ikinci navigation authority ve RootFlyoutPage.
- Build checkpoint: cold start, back, auth transition ve tab smoke tests.
- Exit: route ownership ve state transitions doğrulanmış.

### G6 — Home dashboard

- Goal: demo data olmadan Home information architecture ve visual pattern.
- Allowed: Home feature, product ViewModel/service boundary, selected controls.
- Forbidden: Dashboards.json/JsonHelper/demo Data classes.
- Build checkpoint: load/state/navigation tests ve canonical build.
- Exit: gerçek data contract veya açık fake interface ile bağımsız feature.

### G7 — Settings/profile

- Goal: settings ve profile feature'larını product architecture'a eklemek.
- Allowed: selected patterns ve product-owned controls.
- Forbidden: Social/Settings demo JSON ve demo navigation.
- Build checkpoint: state, back ve accessibility smoke tests.
- Exit: settings/profile ownership ve persistence boundary tanımlı.

### G8 — Optional popup/maps

- Goal: yalnız onaylanmış feature gerektirirse popup veya maps eklemek.
- Allowed: ayrı architecture/implementation task'ında minimum package/setup.
- Forbidden: foundation'a önceden package, permission veya API key eklemek.
- Build checkpoint: platform-specific build/runtime tests.
- Exit: somut feature, permission, key management ve fallback tamamlanmış.
