using Method__Overloading;

string sayi = "999";
bool sonuc = int.TryParse(sayi, out int outSayi); if (sonuc)
{
    Console.WriteLine("Başarılı!"); Console.WriteLine(outSayi);
}
else
{
}
Console.WriteLine("Başarısız!");
Metotlar instance = new Metotlar();
instance.Topla(4, 5, out int toplamSonucu); Console.WriteLine(toplamSonucu);

//Metot Aşırı Yükleme - Overloading
int ifade = 999;
instance.EkranaYazdir(Convert.ToString(ifade));
instance.EkranaYazdir(ifade);
