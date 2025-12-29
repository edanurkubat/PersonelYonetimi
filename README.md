# 👥 Personel Yönetim Sistemi

Marmara Üniversitesi Bilgisayar Programcılığı bölümü, Veri Tabanı Yönetim Sistemleri I dersi kapsamında geliştirilmiş bir masaüstü uygulamasıdır.

## 📋 Proje Hakkında

Bu proje, C# ve SQL Server kullanılarak geliştirilmiş basit ve kullanıcı dostu bir personel yönetim sistemidir. Temel CRUD (Create, Read, Update, Delete) işlemlerini destekler ve departman bazlı personel yönetimi sağlar.

## 🚀 Özellikler

- ✅ Güvenli kullanıcı girişi
- ✅ Departman yönetimi (ekleme, güncelleme)
- ✅ Personel yönetimi (ekleme, silme, güncelleme, listeleme)
- ✅ Gelişmiş arama ve filtreleme
  - İsme göre arama
  - Soyisme göre arama
  - Pozisyona göre filtreleme

## 🛠️ Kullanılan Teknolojiler

- **IDE:** Visual Studio
- **Programlama Dili:** C#
- **Framework:** .NET Framework / .NET Core
- **Veritabanı:** Microsoft SQL Server
- **UI Framework:** Windows Forms

## 📦 Gereksinimler

- Visual Studio 2019 veya üzeri
- .NET Framework 4.7.2 veya üzeri
- SQL Server 2016 veya üzeri

## ⚙️ Kurulum

1. Projeyi klonlayın:
```bash
git clone https://github.com/kullaniciadi/personel-yonetim-sistemi.git
```

2. SQL Server'da veritabanını oluşturun:
   - `database.sql` dosyasını SQL Server Management Studio'da çalıştırın

3. Bağlantı ayarlarını düzenleyin:
   - `App.config` dosyasındaki connection string'i kendi SQL Server bilgilerinize göre güncelleyin

4. Visual Studio'da projeyi açın ve derleyin

5. Uygulamayı çalıştırın

## 🔐 Giriş Bilgileri

Uygulamayı test etmek için aşağıdaki bilgileri kullanabilirsiniz:

- **Kullanıcı Adı:** edanurrkbt
- **Şifre:** edaedaeda

## 📸 Ekran Görüntüleri

### Giriş Ekranı
![giris-ekrani](https://github.com/user-attachments/assets/693c3e59-f138-4a97-a0a2-0f0df05166a0)

### Ana Panel
![ana-sayfa-ekrani](https://github.com/user-attachments/assets/b46cd3c1-785c-4b95-a2ed-5beb965b22e5)
### Personel Listesi
![duzenleme-ekrani](https://github.com/user-attachments/assets/a8201464-06a3-4df9-84fc-d412a64a8145)

## 📚 Veritabanı Yapısı

### Personel Tablosu
| Kolon Adı | Veri Tipi | Açıklama |
|-----------|-----------|----------|
| PersonelID | int | Primary Key |
| Ad | nvarchar(50) | Personel adı |
| Soyad | nvarchar(50) | Personel soyadı |
| Pozisyon | nvarchar(50) | Görev unvanı |
| DepartmanID | int | Foreign Key |

### Departman Tablosu
| Kolon Adı | Veri Tipi | Açıklama |
|-----------|-----------|----------|
| DepartmanID | int | Primary Key |
| DepartmanAdi | nvarchar(100) | Departman adı |

## 🎯 Kullanım

1. Uygulamayı başlatın ve giriş yapın
2. Ana menüden "Departmanlar" sekmesine giderek yeni departman ekleyin
3. "Personeller" sekmesinden yeni personel kaydı oluşturun
4. Arama çubuğunu kullanarak personelleri filtreleyin
5. Tabloda seçim yaparak personel bilgilerini güncelleyin veya silin

## 👨‍💻 Geliştirici

**Eda Nur**
- GitHub: [@edanurkubat](https://github.com/edanurkubat)

## 📝 Lisans

Bu proje eğitim amaçlı geliştirilmiştir.



---

⭐ Projeyi beğendiyseniz yıldız vermeyi unutmayın!



