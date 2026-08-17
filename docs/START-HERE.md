# Start Here

Bu dosya Arabasorgula Mobile specification ve governance belgelerinin
indeksidir.

## Zorunlu okuma sırası

1. Root `AGENTS.md`
2. [Project Specification](PROJECT-SPEC.md)
3. [Architecture](ARCHITECTURE.md)
4. [Development Rules](DEVELOPMENT-RULES.md)
5. Task ile ilgili domain belgeleri
6. [Implementation Status](IMPLEMENTATION-STATUS.md)

## Domain documents

- [Design System](DESIGN-SYSTEM.md): `AS.*` token contract ve resource kuralları
- [Navigation](NAVIGATION.md): Shell authority ve navigation contract
- [Screen Flows](SCREEN-FLOWS.md): planlanan ekran ilişkileri
- [Component Standards](COMPONENT-STANDARDS.md): reusable component sözleşmesi
- [Local Development](LOCAL-DEVELOPMENT.md): private feed, local license,
  restore/build ve fiziksel Android cihaz kurulumu
- [Grial Integration](GRIAL-INTEGRATION.md): compatibility ve G0–G8 planı
- [Grial Usage Rules](GRIAL-USAGE-RULES.md): agent ve source governance
- [Grial Placement](GRIAL-PLACEMENT.md): reference project izolasyonu

Grial task'larında Grial Integration, Grial Usage Rules ve Design System
belgeleri zorunludur.

## Work start

```powershell
git status --short --branch
```

Remote sync gerektiğinde ve task izin verdiğinde `fetch`/`pull` ayrıca yapılır.
Uncommitted user değişiklikleri korunur.

## Work finish

```powershell
dotnet build .\src\ArabaSorgula.Mobile\ArabaSorgula.Mobile.csproj -f net10.0-android -c Debug
git diff --check
git status --short --branch
```

İlgili tests varsa canonical build öncesinde veya sonrasında çalıştırılır.
Commit ve push yalnız açık task/kullanıcı talebiyle yapılır.

## Current stage

Discovery, architecture/governance pack ve Grial G0 bootstrap tamamlanmıştır.
G1 ve product features henüz başlamamıştır. Gerçek durum için
[Implementation Status](IMPLEMENTATION-STATUS.md) esas alınır.
