# Navigation Architecture

## Authority

`AppShell` uygulamanın tek navigation authority'sidir.

- Application root `Shell` olarak kalır.
- `RootFlyoutPage` kullanılmaz.
- Feature kendi root navigation sistemini kuramaz.
- Route ownership AppShell ve ilgili feature tarafından açıkça belgelenir.

## Unauthenticated flow

Splash/startup kararı, onboarding ve authentication ekranları Shell
architecture içinde organize edilir. Exact route names implementation task'ında
belirlenir.

Planlanan alan:

```text
Splash decision
  -> Onboarding / Welcome
  -> Login / Register / Recovery
```

Unauthenticated kullanıcı authenticated Shell içeriğine erişmemelidir. Auth
state'in nasıl persist edileceği backend/auth task'ında belirlenir.

## Authenticated flow

Authenticated ana alanın Shell tab yapısı kullanması planlanır. Aday ana
alanlar:

- Home
- Queries
- History
- Settings veya Profile

Kesin tab sayısı, sırası, labels ve icons: **TODO / HUMAN DECISION**.

Vehicle Valuation ve Expertise Appointment ana tab, nested route veya Home
action olabilir. Kesin information architecture: **TODO / HUMAN DECISION**.

## Feature routes

- Read/detail ekranları Shell route olarak açılır.
- Route parametreleri küçük identifier veya typed navigation contract taşır;
  büyük mutable ViewModel nesneleri global state olarak geçirilmez.
- Route string'leri feature ownership'i belli olacak şekilde merkezi veya
  feature-local constants ile yönetilir.
- Duplicate route registration yapılmaz.

## Transactional modal flow

İptal edilebilir, kendi içinde birden fazla adımı olan işlem gerektiğinde
feature-local modal `NavigationPage` kullanılabilir.

Örnek aday: Expertise Appointment.

Kurallar:

- Shell application authority olmaya devam eder.
- Modal flow açık cancel/complete sonucu üretir.
- Modal kendi bottom tabs/flyout/root sistemini kurmaz.
- Modal kapatıldığında Shell state tutarlı kalır.

## Android back behavior

Öncelik sırası:

1. Açık modal/popup varsa kendi contract'ına göre kapanır.
2. Feature navigation stack detail'dan geriye gider.
3. Tab root'unda back, ürünce onaylanan Shell/Android davranışını izler.
4. Authenticated alandan back ile yanlışlıkla login ekranına dönülmez.

Back interception yalnız ürün gereksinimi varsa yapılır; platform default'u
gereksiz yere override edilmez.

## Deep links and restoration

Future deep-link ve state restoration desteği Shell route contract'ı üzerinde
kurulacaktır. Exact URI ve authorization kuralları henüz doğrulanmamıştır.

## Testing expectations

- Cold start: first run / returning user
- Onboarding complete/incomplete
- Login/register/recovery transitions
- Authenticated tab switching
- Detail push/pop
- Modal cancel/complete
- Android system back
- Process recreation ve invalid route fallback, uygulanınca

