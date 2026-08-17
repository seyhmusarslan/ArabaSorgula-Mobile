# Design System Contract

## Status

Bu belge resource contract'ını kilitler. G1 kapsamında human-approved marka
renkleri ve light neutral baseline uygulanmıştır. Typography ölçüleri ve dark
theme henüz uygulanmış veya onaylanmış kabul edilmez.

Human-approved brand palette:

```text
Dark:    #8B0E0E
Mid:     #B81414
Primary: #E31D1D
```

## Naming contract

Yeni product kaynakları `AS.*` prefix'i kullanır.

### Colors

```text
AS.Color.Brand.Primary
AS.Color.Brand.Mid
AS.Color.Brand.Dark
AS.Color.Background.Primary
AS.Color.Background.Secondary
AS.Color.Surface.Primary
AS.Color.Surface.Secondary
AS.Color.Text.Primary
AS.Color.Text.Secondary
AS.Color.Text.OnBrand
AS.Color.Border.Default
AS.Color.Border.Subtle
AS.Color.State.Success
AS.Color.State.Warning
AS.Color.State.Error
```

### Spacing

```text
AS.Space.Xs
AS.Space.Sm
AS.Space.Md
AS.Space.Lg
AS.Space.Xl
```

### Typography

```text
AS.Type.Caption
AS.Type.Body
AS.Type.BodyStrong
AS.Type.Title
AS.Type.Headline
AS.Type.FontFamily.Primary
AS.Type.FontFamily.Strong
```

### Radius

```text
AS.Radius.Sm
AS.Radius.Md
AS.Radius.Lg
```

### Icons and controls

```text
AS.Icon.FontFamily
AS.Icon.Size.Sm
AS.Icon.Size.Md
AS.Icon.Size.Lg
AS.Control.Button.Primary
AS.Control.Button.Secondary
AS.Control.Entry.Default
AS.Control.Card.Default
AS.Style.Label.Primary
AS.Style.Label.Secondary
AS.Style.Label.Body
AS.Brush.Brand.VerticalGradient
```

State color values G1 sonunda `NOT CONFIRMED` durumundadır ve production
resource olarak uygulanmamıştır.

Feature-specific kaynaklar `AS.Auth.*`, `AS.Home.*`, `AS.Query.*`,
`AS.History.*`, `AS.Settings.*` ve `AS.Profile.*` ile başlar.

## Semantic rules

- Key görsel değeri değil kullanım amacını anlatır.
- Renk veya ölçü literal'i page XAML içinde tekrarlanmaz.
- Tek seferlik, gerçekten yerel layout değerleri token haline getirilmek
  zorunda değildir; tekrar eden veya semantik değerler token olmalıdır.
- Style, mümkün olduğunda ham renk yerine semantic token tüketir.
- Feature token product token'ını alias edebilir; product token feature'a
  bağımlı olamaz.

## Forbidden new keys

Yeni Arabasorgula code'unda aşağıdaki gibi generic Grial/demo anahtarları
oluşturulmaz:

```text
PrimaryColor
TextColor
BackgroundColor
BaseFontSize
AirSpacing
IconsFontFamily
```

Bu adlar anlam ve ownership belirsizliği, global collision ve AI-agent
tarafından kontrolsüz reuse riski doğurur.

Seçilmiş Grial control generic key bekliyorsa, product token'ını o key'e
çeviren küçük ve açık bir adapter dictionary kullanılabilir. Generic adapter
key product page'lerinde tüketilmez.

## Hardcoded values

- Brand/state renkleri doğrudan page'e yazılmaz.
- Tekrarlanan spacing, radius, typography ve control ölçüleri token/style olur.
- Görsel prototipte geçici değer gerekiyorsa task ve diff içinde açıkça
  belirtilir; foundation contract olarak kabul edilmez.

## Theme modes

Light/dark mode ileride desteklenebilir. Bugün yalnız contract tanımlıdır;
dark mode uygulanmış sayılmaz. Theme seçimi eklenirken aynı semantic key seti
farklı value dictionary'leriyle sağlanmalıdır.

## Accessibility

- Text ve icon contrast doğrulanmalıdır.
- Text scale ve uzun localization değerleri layout'u bozmamalıdır.
- Renk tek durum göstergesi olmamalıdır.
- Tap target ve semantics component standardına uymalıdır.

