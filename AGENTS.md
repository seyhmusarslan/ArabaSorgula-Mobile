# AGENTS.md

Bu repository üzerinde çalışan Codex/Cursor/AI agent için ana kurallar.

## Çalışmaya başlamadan önce

Sırayla oku:

1. `docs/START-HERE.md`
2. `docs/PROJECT-STATUS.md`
3. `docs/GRIAL-PLACEMENT.md`

Daha sonra aktif task sistemi eklendiğinde ilgili task dosyasını da oku.

## Repository sınırları

### Değiştirilebilir

```text
src/
docs/
scripts/
```

### Varsayılan olarak READ ONLY

```text
reference/GrialUiKit/
```

`reference/GrialUiKit/` altında bulunan satın alınmış Grial kaynaklarını
açık task izni olmadan:

- değiştirme,
- silme,
- rename etme,
- package upgrade yapma,
- refactor etme.

Bu alan örnek ve kaynak inceleme alanıdır.

## Build kuralı

Canonical Android build:

```bash
dotnet build src/ArabaSorgula.Mobile/ArabaSorgula.Mobile.csproj -f net10.0-android -c Debug
```

Grial demo `.sln` veya `.csproj` dosyalarını canonical build'e dahil etme.

## Mimari disiplin

- Task dışı refactor yapma.
- Yeni UI framework ekleme.
- Grial demo ekranını production ekranı olarak doğrudan kopyalama.
- Platform-specific handler yazmadan önce mevcut MAUI/Grial çözümünü incele.
- Secret veya signing credential commit etme.
- Build doğrulanmadan task DONE kabul etme.

## Önemli

Repository'nin içindeki bir `.csproj` dosyasının varlığı tek başına onun
build edileceği anlamına gelmez. Ana solution yalnız
`src/ArabaSorgula.Mobile/ArabaSorgula.Mobile.csproj` projesini içermelidir.
