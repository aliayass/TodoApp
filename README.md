# TodoApp

**TodoApp** basit bir görev (Todo) yönetimi uygulamasıdır. Proje, .NET 9 ve ASP.NET Core Razor Pages kullanılarak geliştirilmiştir ve eğitim amaçlı temel ASP.NET Core kavramlarını örneklemektedir.

Kısa açıklama: Razor Pages ile CRUD işlemleri, model binding, form doğrulama, dependency injection ve In-Memory veri saklama yaklaşımlarını içerir.

## Öne Çıkanlar

- Görev oluşturma, listeleme, düzenleme ve silme
- Başlık ve açıklamaya göre arama
- Öncelik ve durum filtreleme
- Bitiş tarihine göre sıralama
- Model doğrulaması: Data Annotations + özel validator (Validators/TodoValidator.cs)
- TempData ile kullanıcı bildirimleri (Başarı/Hata mesajları)
- Create ve Edit sayfalarında ortak Partial View (`_TodoForm.cshtml`)
- In-Memory veri yönetimi (ConcurrentDictionary tabanlı `InMemoryTodoStore`)

## Teknolojiler

- .NET 9 / C#
- ASP.NET Core Razor Pages
- Bootstrap 5
- ConcurrentDictionary (In-Memory store)
- Dependency Injection

## Proje Yapısı (özet)

TodoApp/
├── Models/               # Domain modelleri (Todo, TodoPriority)
├── Pages/                # Razor Pages (Pages/Todos/...)
│   └── Todos/
│       ├── Index.cshtml
│       ├── Create.cshtml
│       ├── Edit.cshtml
│       ├── Delete.cshtml
│       └── _TodoForm.cshtml
├── Services/             # ITodoStore, InMemoryTodoStore
├── Validators/           # Custom validation (TodoValidator.cs)
├── Program.cs
└── TodoApp.slnx

(Not: proje kökünde TodoApp.slnx ve TodoApp.csproj dosyaları bulunmaktadır.)

## Çalıştırma

Geliştirme için iki yaygın yol:

1) Komut satırı (dotnet CLI):

```powershell
dotnet restore
dotnet build
dotnet run --project .\TodoApp.csproj
```

2) Visual Studio:
- Solution dosyasını (TodoApp.slnx) Visual Studio 2022/2026 ile açın.
- Debug (F5) veya Run (Ctrl+F5) ile projeyi başlatın.

Alternatif: Hızlı geliştirme için `dotnet watch run` kullanabilirsiniz.

Uygulama çalıştıktan sonra tarayıcıda terminal/VS tarafından gösterilen `https://localhost:5xxx` adresine gidin.

> Not: Veri depolama In-Memory olduğundan uygulama yeniden başlatıldığında veriler sıfırlanır.

## Geliştirme Notları

- Doğrulama: Model üzerinde Data Annotations kullanılmıştır; ek doğrulama logicleri Validators/TodoValidator.cs içinde yer alır.
- Servisler: `ITodoStore` arayüzü ile veri erişimi soyutlanmıştır; `InMemoryTodoStore` uygulaması uygulamaya DI olarak eklenir.
- Partial View: Create/Edit sayfalarında `_TodoForm.cshtml` kullanılarak form alanları paylaşılmaktadır.

## Roadmap / Yapılacaklar

- [ ] Entity Framework Core ile kalıcı veri katmanı
- [ ] SQLite / SQL Server desteği
- [ ] Pagination
- [ ] ASP.NET Core Identity (kimlik & yetkilendirme)
- [ ] Unit & Integration Tests
- [ ] AJAX ile durum güncelleme (sayfa yenilemeden)

## Katkıda Bulunma

1. Repoyu fork edin
2. Yeni bir branch oluşturun
3. Değişikliklerinizi PR ile gönderin

## Lisans

MIT
