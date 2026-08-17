# START HERE

Bu repository iki farklı bilgisayarda GitHub üzerinden çalışmak için
tasarlanmıştır.

## Her çalışma başlangıcında

```bash
git status
git fetch --all --prune
git pull --rebase
```

Ardından:

1. `AGENTS.md`
2. `docs/PROJECT-STATUS.md`
3. ileride eklenecek aktif task dosyası

okunur.

## Her çalışma sonunda

1. Build/test çalıştır.
2. Proje durumunu güncelle.
3. Commit oluştur.
4. GitHub'a push et.

## Şimdiki aşama

Henüz detaylı tasarım sistemi ve task sistemi kilitlenmedi.

Öncelik:

1. Bu repository iskeletini GitHub'a koymak.
2. Grial kaynaklarını `reference/GrialUiKit/Source/` altına yerleştirmek.
3. Ana Arabasorgula projesinin Android build'ini doğrulamak.
4. Grial inventory çıkarmak.
5. Sonra detaylı `.md` standardını ve task'ları belirlemek.
