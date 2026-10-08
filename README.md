# TodoApp

**TodoApp**, .NET 9 ve ASP.NET Core Razor Pages kullanılarak geliştirilmiş basit ve kullanışlı bir görev yönetimi uygulamasıdır.

Proje; **Razor Pages, CRUD işlemleri, Model Binding, Dependency Injection, Partial View ve form doğrulama** gibi ASP.NET Core konularını uygulamalı olarak geliştirmek amacıyla hazırlanmıştır.

## Özellikler

- Görev oluşturma, listeleme, düzenleme ve silme
- Başlık ve açıklamaya göre arama
- Öncelik ve durum filtreleme
- Bitiş tarihine göre sıralama
- Data Annotations ile form doğrulama
- TempData ile kullanıcı bildirimleri
- Create ve Edit sayfalarında ortak Partial View kullanımı
- In-Memory veri yönetimi

## Teknolojiler

- **.NET 9 / C#**
- **ASP.NET Core Razor Pages**
- **Bootstrap 5**
- **HTML5 / CSS3**
- **ConcurrentDictionary**
- **Dependency Injection**

## Proje Yapısı

```text
TodoApp/
├── Models/
│   ├── Todo.cs
│   └── TodoPriority.cs
│
├── Pages/
│   └── Todos/
│       ├── Index.cshtml
│       ├── Create.cshtml
│       ├── Edit.cshtml
│       ├── Delete.cshtml
│       └── _TodoForm.cshtml
│
├── Services/
│   ├── ITodoStore.cs
│   └── InMemoryTodoStore.cs
│
├── Program.cs
└── TodoApp.csproj
```

## Mimari

Veri erişimi `ITodoStore` interface'i üzerinden sağlanarak **Dependency Injection** kullanılmıştır.

Create ve Edit sayfalarında ortak form alanları `_TodoForm.cshtml` Partial View içerisinde tutulmuş ve kod tekrarının azaltılması hedeflenmiştir.

## Kurulum

```bash
git clone <repository-url>
cd TodoApp
dotnet restore
dotnet run
```

Uygulama çalıştırıldıktan sonra terminalde belirtilen `localhost` adresinden erişilebilir.

> **Not:** Veriler In-Memory olarak tutulmaktadır. Uygulama yeniden başlatıldığında yapılan değişiklikler sıfırlanır.

## Roadmap

- [ ] Entity Framework Core
- [ ] SQLite / SQL Server
- [ ] Pagination
- [ ] ASP.NET Core Identity
- [ ] Unit & Integration Tests
- [ ] AJAX ile sayfa yenilemeden durum güncelleme

## Lisans

MIT
