# AGENTS.md

Bu repository üzerinde çalışan Codex/Cursor/AI agent için ana kurallar.

## Çalışmaya başlamadan önce

Sırayla oku:

1. `AGENTS.md`
2. `docs/PROJECT-SPEC.md`
3. `docs/ARCHITECTURE.md`
4. `docs/DEVELOPMENT-RULES.md`
5. task ile ilgili domain belgeleri
6. `docs/IMPLEMENTATION-STATUS.md`

Doküman indeksi için `docs/START-HERE.md` kullanılır.

Task Grial inceleme veya entegrasyonu içeriyorsa ayrıca, implementation
başlamadan önce:

1. `docs/GRIAL-INTEGRATION.md`
2. `docs/GRIAL-USAGE-RULES.md`
3. `docs/DESIGN-SYSTEM.md`

okunur.

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
- Shell dışındaki bir yapıyı application navigation authority yapma.
- Yeni production resource'larında `AS.*` naming contract'ını kullan.
- Platform-specific handler yazmadan önce mevcut MAUI/Grial çözümünü incele.
- Secret veya signing credential commit etme.
- Build doğrulanmadan task DONE kabul etme.

Agent açık task/human approval olmadan dependency, minimum SDK, target
framework, navigation root, global handler veya platform permission
değiştiremez.

## Önemli

Repository'nin içindeki bir `.csproj` dosyasının varlığı tek başına onun
build edileceği anlamına gelmez. Ana solution yalnız
`src/ArabaSorgula.Mobile/ArabaSorgula.Mobile.csproj` projesini içermelidir.
