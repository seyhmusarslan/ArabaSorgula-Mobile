# Grial UI Kit Placement

## Grial nereye konulacak?

Satın aldığın Grial paket/proje içeriğini:

```text
reference/GrialUiKit/Source/
```

altına kopyala.

Örnek:

```text
reference/
└── GrialUiKit/
    ├── README.md
    └── Source/
        ├── GrialSample.sln
        ├── SomeProject.csproj
        ├── Pages/
        ├── Controls/
        └── Resources/
```

## Yapılmayacaklar

Grial demo projesini:

- `ArabaSorgula-Mobile.sln` içine ekleme.
- `ProjectReference` ile ana uygulamaya bağlama.
- `src/ArabaSorgula.Mobile/` altına gömme.
- İlk aşamada package/target framework upgrade etme.

## Neden?

Amaç Grial demo uygulamasını dependency yapmak değil, Grial'in sunduğu
hazır kontrol ve kullanım örneklerini inceleyip Arabasorgula'da gereken
gerçek bağımlılıkları bilinçli şekilde kullanmaktır.

Böylece Grial demo projesi kendi başına build hatası verse bile:

```bash
dotnet build src/ArabaSorgula.Mobile/ArabaSorgula.Mobile.csproj -f net10.0-android
```

komutu onu build etmeye çalışmaz.

## GitHub

Grial lisans koşullarını kontrol et. Kaynakları GitHub'da tutacaksan
repository private olmalıdır ve lisans private source-control kullanımına
izin vermelidir.
