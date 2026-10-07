TodoApp

.NET 9 ve ASP.NET Core Razor Pages kullanılarak geliştirilmiş, eğitim amaçlı hafif ve pratik bir yapılacaklar (Todo) listesi uygulamasıdır.

Bu proje; Razor Pages mimarisi, Model Binding, Dependency Injection, CRUD işlemleri, Partial View kullanımı ve In-Memory veri yönetimini uygulamalı olarak göstermek amacıyla hazırlanmıştır.

Özellikler

CRUD İşlemleri: Görev oluşturma, listeleme, düzenleme ve silme.

Arama ve Filtreleme: Başlık/açıklama araması, öncelik ve durum (Bekliyor/Tamamlandı) filtreleme.

Sıralama: Bitiş tarihine göre görev sıralama.

Form Doğrulama: Data Annotations ile sunucu taraflı model kontrolü.

Kullanıcı Bildirimleri: TempData destekli durum mesajları.

Yeniden Kullanılabilir Arayüz: Create ve Edit formları için ortak Partial View (_TodoForm.cshtml).

In-Memory Store: Kurulum gerektirmeyen, bellek içi başlangıç verileri.

Teknolojiler

Platform: .NET 9 (C#)

Web Çerçevesi: ASP.NET Core Razor Pages

Arayüz: Bootstrap 5, HTML5, CSS3

Veri Depolama: In-Memory (ConcurrentDictionary)

Proje Yapısı

TodoApp/
│
├── Models/
│   ├── Todo.cs
│   └── TodoPriority.cs
│
├── Pages/
│   └── Todos/
│       ├── Index.cshtml / .cs       # Listeleme, filtreleme ve arama
│       ├── Create.cshtml / .cs      # Yeni görev oluşturma
│       ├── Edit.cshtml / .cs        # Görev düzenleme
│       ├── Delete.cshtml / .cs      # Görev silme onayı
│       └── _TodoForm.cshtml         # Ortak form bileşeni
│
├── Services/
│   ├── ITodoStore.cs                # Depolama arayüzü
│   └── InMemoryTodoStore.cs         # Bellek içi servis implementasyonu
│
├── Program.cs
└── TodoApp.csproj


Öne Çıkan Mimari Yaklaşımlar

Razor Pages & PageModel: UI (.cshtml) ve sunucu mantığı (.cshtml.cs) birbirinden izole edilerek temiz bir sayfa hiyerarşisi sağlandı.

Model Binding: Form alanları [BindProperty] özniteliğiyle doğrudan güçlü tipli modellere bağlanır.

Partial View: Tekrar eden form alanları _TodoForm.cshtml bileşenine taşınarak kod tekrarı önlendi (DRY).

Dependency Injection: Veri erişimi ITodoStore soyutlaması üzerinden enjekte edilerek gevşek bağlılık (loose coupling) sağlandı.

Kurulum ve Çalıştırma

Gereksinimler

.NET 9 SDK

Git

Adımlar

Depoyu klonlayın:

git clone <repository-url>
cd TodoApp


Bağımlılıkları geri yükleyin:

dotnet restore


Uygulamayı çalıştırın:

dotnet run


Terminalde belirtilen adresi tarayıcınızda açın (varsayılan: https://localhost:5001 veya http://localhost:5000).

Not: Veriler bellekte (In-Memory) tutulduğundan, uygulama durdurulduğunda yapılan değişiklikler sıfırlanır ve varsayılan tohum (seed) veriler yeniden yüklenir.

Gelecek Planları (Roadmap)

[ ] Entity Framework Core & SQLite / SQL Server entegrasyonu

[ ] Sayfalama (Pagination) desteği

[ ] AJAX ile sayfa yenilenmeden durum güncelleme

[ ] ASP.NET Core Identity ile kullanıcı yönetimi

[ ] Unit & Integration testleri


Bu proje eğitim ve kişisel gelişim amaçlı hazırlanmıştır.
