using System;
public class TekmiCiftmi 
{
    public string Deger = "";
    public int Sayi;
    
    public void Hesapla()
    {
        Console.WriteLine("Hoşgeldinizz Çıkışlar n den geçerr");
        do
        {
            Console.Write("Sayı Gİriniz:");
            
            Deger = Console.ReadLine();
            if (int.TryParse(Deger, out Sayi)) 
                /* int.TryParse = sayıya çevirmeye çalışır olmazsa sistem hata vermez
                 * int.Parse veya Convert.ToInt32() = kesinlikle gelen sayıyı sayıya çevirmeye çalışır olmazsa sistem hata verir
                 */
            {
                if (Sayi % 2 == 0)
                {
                    Console.WriteLine("Sayı Çifttirr");
                }
                else
                {
                    Console.WriteLine("Sayı Tektirrr");
                }
            }
            else
            {
                if (Deger != "N" && Deger != "n")
                {
                    Console.WriteLine("No No No yapamazsın just sayı lütfen");
                } 
            }
            
            
        } while (Deger != "N" && Deger !="n");
        Console.WriteLine("Hoşçakalıııınnnnn");
        
    }
   
}
public class Program 
    {
        public static void Main()
        {
            TekmiCiftmi kontrolcu = new TekmiCiftmi();//new classdan aldığı bilgileri nesneye çevirir
        kontrolcu.Hesapla();
        }
    }
