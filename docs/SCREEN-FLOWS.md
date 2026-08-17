# Screen Flows

Bu belge onaylı ekran ilişkilerini gösterir. Backend response, validation,
permission zorunluluğu veya ticari branching doğrulanmadıysa tanımlamaz.

## Entry flow

```text
Splash
  -> onboarding state decision
      -> Onboarding
          -> Welcome
      -> Welcome

Welcome
  -> Login
  -> Register
```

Onboarding'in kaç adım olduğu ve skip davranışı: **TODO / HUMAN DECISION**.

## Login and recovery

```text
Login
  -> authenticated main area, on success
  -> Forgot Password
      -> recovery request
      -> Reset Password, only when backend/auth contract supports it
  -> Register
```

Email/phone login yöntemi, token delivery ve reset link/code davranışı henüz
doğrulanmamıştır.

## Registration

```text
Register
  -> Phone Verification
  -> Terms & Privacy acknowledgement, when required
  -> Notification Permission education/request, when approved
  -> authenticated main area
```

Consent ve permission adımlarının kesin sırası/required durumu:
**TODO / HUMAN DECISION + LEGAL/BACKEND CONFIRMATION**.

OS notification permission, kullanıcıya açıklama yapılmadan veya platform API
gereksinimi doğrulanmadan startup'ta otomatik istenmez.

## Authenticated main area

```text
Shell
  -> Home
  -> Queries
  -> History
  -> Settings
      -> Profile
```

Settings ve Profile'ın ayrı tab olup olmayacağı: **TODO / HUMAN DECISION**.

## Query and history

```text
Home or Queries
  -> query input
  -> query result / vehicle detail, when defined
  -> History entry
```

Sorgu türleri, ücretlendirme, quota, result schema ve persistence backend
contract'ı olmadan tanımlanmaz.

## Vehicle valuation

```text
Home / Queries / vehicle context
  -> Vehicle Valuation input
  -> Valuation result
```

Data source, hesaplama, güven aralığı ve result details henüz doğrulanmamıştır.

## Expertise appointment

```text
Home or vehicle context
  -> Expertise Appointment
      -> details
      -> date/time/location selection
      -> review
      -> confirmation or cancel
```

Bu akış feature-local modal NavigationPage adayıdır. V1 map gerektirmez.
Provider, availability ve payment davranışları: **NOT CONFIRMED**.

