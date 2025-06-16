// Random sayı oluşturuyoruz.
using static System.Runtime.InteropServices.JavaScript.JSType;

var rnd  = new Random();
// Random sayılarımızı tutucak listemiz
var randomNumbers = new List<int>();
// Kaç adet sayı üretileceğini belirliyoruz
int total = 10;
Console.WriteLine("*********************************");
for (int i = 0; i < total; i++)
{
    int number = rnd.Next(-500,500);
    randomNumbers.Add(number);
}
Console.WriteLine("----Random Sayılardan Çift Olanlar----");
var evenNumbers = randomNumbers.Where(num  => num % 2 == 0);
foreach (var number in evenNumbers)
{
    Console.WriteLine($"Random Çift Sayı: {number}");
}

Console.WriteLine("*********************************");


Console.WriteLine("----Random Sayılardan Tek olanlar----");

var oddNumber = randomNumbers.Where(num => num % 2 != 0);

foreach (var number in oddNumber)
{
    Console.WriteLine($"Random Tek Sayı: {number}");
}

Console.WriteLine("*********************************");
Console.WriteLine("----Random Sayılardan Negatif olanlar----");

var negativeNumber = randomNumbers.Where(num => num < 0);
foreach (var number in negativeNumber)
{
    Console.WriteLine($"Random Negatif Sayı: {number}");
}

Console.WriteLine("*********************************");
Console.WriteLine("----Random Sayılardan Pozitif olanlar----");

var positiveNumber = randomNumbers.Where(num => num > 0);

foreach (var number in positiveNumber)
{
    Console.WriteLine($"Random Pozitif Sayı: {number}");
}

Console.WriteLine("*********************************");
Console.WriteLine("----Random Sayılardan 15'ten Büyük ve 22'den küçük olanlar----");


// Burda 15 ile 22 arasında sayı biraz zor denk geliyor yukarı daki -500 / +500 aralığını düşürebilir veya burdaki aralığı artırabilirsiniz.
var limitedNumber = randomNumbers.Where(num => num > 15 && num < 22);

foreach (var number in limitedNumber)
{
    Console.WriteLine($"Random Sınırlandırılmış Sayı: {number}");
}

Console.WriteLine("*********************************");
Console.WriteLine("----Random Sayıların Karesi Olanlar---- ");

var squaredNumber = randomNumbers.Where(num => num > -500 && num < 500)
    .Select(num => num * num);

foreach (var number in squaredNumber)
{
    Console.WriteLine($"Random Sayıların Karesi:{number}");
}