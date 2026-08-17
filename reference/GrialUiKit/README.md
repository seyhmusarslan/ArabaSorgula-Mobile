# Grial UI Kit — Reference Area

Bu klasör satın alınan Grial UI Kit kaynaklarının repository içindeki
yeridir.

## Kopyalama hedefi

Grial'in indirdiğin proje paketini şu klasöre koy:

```text
reference/GrialUiKit/Source/
```

`Source/` içindeki `.sln` ve `.csproj` dosyalarını ana
`ArabaSorgula-Mobile.sln` dosyasına ekleme.

## Build isolation

Ana uygulama build'i:

```bash
dotnet build ../../src/ArabaSorgula.Mobile/ArabaSorgula.Mobile.csproj -f net10.0-android -c Debug
```

Grial source'u build etmez.

## Agent policy

Bu klasör varsayılan olarak read-only reference kabul edilir.
İlk Grial inventory task'ında agent burada arama/okuma yapabilir ancak
dosyaları değiştirmez.
