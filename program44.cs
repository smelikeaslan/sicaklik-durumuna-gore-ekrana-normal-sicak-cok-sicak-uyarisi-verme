Console.WriteLine("Sıcaklık değerini giriniz: ");
int sicaklik = Convert.ToInt32(Console.ReadLine());

if (sicaklik >= 10 && sicaklik < 20)

    Console.Write("normal");
else if (sicaklik >= 20 && sicaklik < 30)
    Console.Write("sıcak");

else if (sicaklik >= 30 && sicaklik < 40)
    Console.Write(" çok sıcak");

else
    Console.Write(" 10 ile 40 arasında bir sayı giriniz! ");

Console.ReadKey();
