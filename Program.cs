//1. Doira yuzi va aylana uzunligini hisoblash
Console.WriteLine("1-masala");
Console.Write("Doira uchun radiusni kiriting: ");
double radius = Convert.ToDouble(Console.ReadLine());

// Doira yuzi
double S = Math.PI * Math.Pow(radius, 2);
Console.WriteLine($"Doira yuzi: {S}");

// Aylana uzunligi
double L = 2 * Math.PI * radius;
Console.WriteLine($"Aylana uzunligi: {L}");

//2. Valyuta konvertri
Console.WriteLine("2-masala");
Console.Write("Summa: ");
double summa = Convert.ToDouble(Console.ReadLine());

//valyuta kursi
Console.Write("Valyuta kursini kiriting: ");
double kurs = Convert.ToDouble(Console.ReadLine());

//konvertatsiya
double konvertatsiya = summa * kurs;
Console.WriteLine($"Konvertatsiya: {konvertatsiya}");

//3. Yoshni hisoblash
Console.WriteLine("3-masala");
Console.Write("Foydalanuvchi tug'ilgan yilini kiriting: ");
int x = Convert.ToInt32(Console.ReadLine());

//hisoblash
int joriyYil = DateTime.Today.Year;
int yosh = joriyYil - x;
int kun = yosh * 365;
Console.WriteLine($"Foydalanuvchi yoshi(kunlarda): {kun}");