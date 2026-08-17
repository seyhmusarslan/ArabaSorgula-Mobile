# Development Rules

## Required start sequence

Her implementation task:

1. `AGENTS.md` ve yönlendirdiği belgeleri okur.
2. `git status --short --branch` çalıştırır.
3. Task scope, allowed files ve forbidden changes'i belirler.
4. İlgili feature/design/navigation/Grial belgelerini okur.
5. Mevcut source'u tahmin etmeden inceler.

## Implementation discipline

- Minimum, task-scoped değişiklik yapılır.
- Task dışı refactor yapılmaz.
- Yeni framework/layer/project gerçek gereksinim olmadan eklenmez.
- Existing user changes korunur.
- Secret, token, license key ve signing credential yazılmaz.
- `reference/GrialUiKit/` varsayılan olarak read-only'dir.

## Restricted decisions

AI agent açık task/human approval olmadan:

- architecture değiştiremez;
- dependency/package ekleyemez;
- minimum SDK değiştiremez;
- target framework değiştiremez;
- navigation root/authority değiştiremez;
- global handler register edemez;
- platform permission veya API key ekleyemez;
- full Grial theme merge edemez.

## Canonical build

```powershell
dotnet build .\src\ArabaSorgula.Mobile\ArabaSorgula.Mobile.csproj -f net10.0-android -c Debug
```

Reference Grial project canonical build'in parçası değildir. Grial `.sln` veya
`.csproj` dosyaları ana solution/build graph'a eklenmez.

## Required finish sequence

1. İlgili tests mümkünse çalıştırılır.
2. Canonical Android build çalıştırılır.
3. `git diff --check` çalıştırılır.
4. `git diff` scope ve accidental changes için review edilir.
5. `git status --short --branch` çalıştırılır.
6. Final report değişen dosyaları, validation ve kalan riskleri belirtir.

Build başarısızsa task kapsamında olmayan fix yapılmaz; hata ve olası kapsam
raporlanır.

## Documentation

- Architecture kararları code ile aynı task'ta güncel tutulur.
- Status yalnız doğrulanmış implementation'ı COMPLETE gösterir.
- TODO, NOT CONFIRMED ve HUMAN DECISION ifadeleri bilinmeyen alanlarda korunur.
- Implementation yapılmadan yapılmış gibi belge yazılmaz.

## Git safety

- Destructive Git komutları kullanılmaz.
- Unrelated changes commit/revert edilmez.
- Commit/push yalnız task veya kullanıcı açıkça istediğinde yapılır.
- Material delete öncesi target ve izin doğrulanır.

