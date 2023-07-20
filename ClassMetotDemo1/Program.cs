using System;
using System.Collections.Generic;

public class Musteri
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public override string ToString()
    {
        return $"Id: {Id}\nAdı: {Ad}\nSoyadı: {Soyad}";
    }
}

public class MusteriManager
{
    private List<Musteri> musteriler = new List<Musteri>();

    public void MusteriEkle(Musteri musteri)
    {
        musteriler.Add(musteri);
        Console.WriteLine("Müşteri başarıyla eklendi.");
    }

    public void MusteriListele()
    {
        if (musteriler.Count == 0)
        {
            Console.WriteLine("Listelenecek müşteri bulunmamaktadır.");
        }
        else
        {
            Console.WriteLine("----- Müşteriler -----");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.ToString());
            }
            Console.WriteLine("-----------------------");
        }
    }

    public void MusteriSil(int musteriId)
    {
        var silinecekMusteri = musteriler.Find(m => m.Id == musteriId);
        if (silinecekMusteri != null)
        {
            musteriler.Remove(silinecekMusteri);
            Console.WriteLine("Müşteri başarıyla silindi.");
        }
        else
        {
            Console.WriteLine("Belirtilen Id'ye sahip müşteri bulunamadı.");
        }
    }
}

class Program
{
    static void Main()
    {
        MusteriManager musteriManager = new MusteriManager();

        Musteri musteri1 = new Musteri { Id = 10, Ad = "Yasir Emin", Soyad = "Çiftçi" };
        musteriManager.MusteriEkle(musteri1);

        Musteri musteri2 = new Musteri { Id = 123, Ad = "Zeliha Nur", Soyad = "Ak" };
        musteriManager.MusteriEkle(musteri2);
        musteriManager.MusteriListele();
        musteriManager.MusteriSil(123);
        musteriManager.MusteriListele();
    }
}
