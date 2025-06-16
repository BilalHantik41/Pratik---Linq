# Rastgele Sayı Üreteci ve Analiz Uygulaması

Bu C# konsol uygulaması, belirli bir aralıkta rastgele tam sayılar üreterek bunları farklı kategorilere ayırır. Ayrıca her sayının karesini hesaplar. Kategoriler şunlardır:

* Çift sayılar
* Tek sayılar
* Negatif sayılar
* Pozitif sayılar
* 15 ile 22 (15 ve 22 hariç) arasındaki sayılar
* Tüm üretilen sayıların kareleri

## Özellikler

* Belirtilen aralıkta (varsayılan: -500 ile 500) istenen sayıda rastgele tam sayı üretme.
* Aşağıdaki kategorilere göre filtreleme ve görüntüleme:

  * Çift sayılar
  * Tek sayılar
  * Negatif sayılar
  * Pozitif sayılar
  * 15’ten büyük ve 22’den küçük sayılar
* Her üretilen sayının karesini hesaplama ve gösterme.
* Konsol çıktısında net başlıklarla okunması kolay yapı.

## Gereksinimler

* [.NET SDK](https://dotnet.microsoft.com/download) (sürüm 6.0 veya üzeri)
* C# desteği olan bir kod editörü veya IDE (örn. Visual Studio, Visual Studio Code)

## Başlarken

1. **Depoyu klonlayın**

   ```bash
   git clone <depo-url>
   cd <depo-dizini>
   ```

2. **Projeyi açın**

   * Visual Studio’da: `.sln` dosyasını açın.
   * Visual Studio Code’da: `.csproj` dosyasının bulunduğu klasörü açın.

3. **Projeyi derleyin**

   ```bash
   dotnet build
   ```

4. **Uygulamayı çalıştırın**

   ```bash
   dotnet run
   ```

   Program şunları yapacak:

   * 10 rastgele sayı üretecek (varsayılan aralık: -500 ila 500).
   * Kategorilere göre filtreleyip sonuçları ekranda gösterecek.

## Özelleştirme

* Üretilen sayı adedini değiştirmek için `Program.cs` içinde `total` değişkenini düzenleyin:

  ```csharp
  int total = 10; // Üretilmesini istediğiniz rastgele sayı adedi
  ```

* Rastgele değer aralığını ayarlamak için:

  ```csharp
  rnd.Next(-500, 500); // Min ve max değerleri değiştirin
  ```

* Filtre aralığını (örn. 15–22) değiştirmek için LINQ `Where` ifadesini güncelleyin:

  ```csharp
  var limitedNumber = randomNumbers.Where(num => num > 15 && num < 22);
  ```

## Kod Parçacığı

```csharp
// Rastgele sayı üretimi
var rnd = new Random();
var randomNumbers = new List<int>();
int total = 10;

for (int i = 0; i < total; i++)
{
    int number = rnd.Next(-500, 500);
    randomNumbers.Add(number);
}

// Örnek: Çift sayıları filtreleme
var evenNumbers = randomNumbers.Where(num => num % 2 == 0);

// Örnek: Kareleri hesaplama
var squaredNumbers = randomNumbers.Select(num => num * num);
```

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. İhtiyacınıza göre kullanabilir ve değiştirebilirsiniz.
