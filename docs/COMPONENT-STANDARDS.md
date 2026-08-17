# Component Standards

## Scope

Bu belge production reusable component sözleşmesini tanımlar. Aşağıdaki
isimler **CANDIDATE / PLANNED COMPONENTS**'tir; repository'de uygulanmış
oldukları anlamına gelmez.

- `ASIconText`
- `ASIconButton`
- `ASRoundedIcon`
- `ASBadge`
- `ASTag`
- `ASAvatar`
- `ASSearchBar`

## Promotion rule

Bir görsel parça ancak en az iki gerçek kullanım veya açık foundation
gereksinimi olduğunda reusable control'a yükseltilir. Tek feature'a ait parça
önce feature-local kalır.

## Resource contract

- Component yalnız `AS.*` product token'larını public contract olarak tüketir.
- `PrimaryColor`, `AirSpacing`, `IconsFontFamily` gibi generic Grial key'lerini
  expose etmez.
- Grial adapter gerekiyorsa implementation detail olarak component veya küçük
  adapter dictionary içinde tutulur.
- Public property default'ları mümkün olduğunda semantic style/token üzerinden
  gelir.

## Dependency rules

- Gereksiz package dependency alınmaz.
- Standard MAUI yeterliyse third-party control kullanılmaz.
- Grial veya toolkit gereksinimi component documentation'ında belirtilir.
- Bir global handler gerekiyorsa handler type, neden, global etki ve regression
  planı aynı task'ta belgelenir.

## Behavior boundaries

- Component business logic, API call, authentication veya navigation yapmaz.
- State bindable properties/commands/events ile dışarıdan sağlanır.
- Component kendi service locator veya global singleton'ını çağırmaz.
- Async action ownership parent ViewModel/feature'dadır.

## API design

- Bindable property adları MAUI convention'ına uyar.
- Boolean adları `Is*`, commands `*Command`, accessibility değerleri açık
  isimlidir.
- Gereksiz property forwarding yapılmaz.
- Defaults platformlar arasında tutarlı olmalıdır.

## Accessibility

Her interactive component için değerlendirilir:

- `SemanticProperties.Description` veya eşdeğer accessible name
- minimum tap target
- disabled/selected/busy state
- screen reader ordering
- text scaling ve localization
- yalnız renge bağlı olmayan state indicator

## Platform reuse

Component Android ve gelecekte iOS üzerinde çalışabilecek cross-platform MAUI
API'leriyle yazılır. Platform-specific workaround ayrı handler/service içinde
ve açık compile condition ile sınırlandırılır.

## Candidate notes

- `ASIconText`: icon + text presentation; non-interactive default.
- `ASIconButton`: command, disabled ve semantics destekli action.
- `ASRoundedIcon`: dekoratif/action olmayan icon surface.
- `ASBadge`: kısa count/status; uzun text için kullanılmaz.
- `ASTag`: filtre/özellik/durum; selected state erişilebilir olmalıdır.
- `ASAvatar`: fallback, image, initials ve optional status contract'ı.
- `ASSearchBar`: text, search/clear command ve keyboard davranışı.

## Verification

- Isolated render/smoke page veya component test
- Light theme baseline; dark mode yalnız uygulanınca
- Long text ve large font
- Empty/null/disabled/loading states
- Standard MAUI screen regression, handler varsa

