# Design System Contract

## Status

Bu belge resource contract'ını kilitler. Gerçek marka renkleri, typography
ölçüleri ve dark theme henüz uygulanmış veya onaylanmış kabul edilmez.

## Naming contract

Yeni product kaynakları `AS.*` prefix'i kullanır.

### Colors

```text
AS.Color.Brand.Primary
AS.Color.Background.Primary
AS.Color.Background.Secondary
AS.Color.Surface.Primary
AS.Color.Text.Primary
AS.Color.Text.Secondary
AS.Color.Border.Default
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
AS.Control.Entry.Default
AS.Control.Card.Default
```

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

