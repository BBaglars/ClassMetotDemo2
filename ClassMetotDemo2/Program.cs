using ClassMetotDemo2;

Musteri musteri1 = new Musteri();
musteri1.Id = 1;
musteri1.Name = "Berkay";
musteri1.Surname = "Bağlars";

Musteri musteri2 = new Musteri();
musteri2.Id = 2;
musteri2.Name = "Murat";
musteri2.Surname = "Bağlars";

Musteri musteri3 = new Musteri();
musteri3.Id = 3;
musteri3.Name = "Engin";
musteri3.Surname = "Demiroğ";

MusteriManager musteriManager = new MusteriManager();

musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);
musteriManager.Ekle(musteri3);

musteriManager.Listele(musteri1);
musteriManager.Listele(musteri2);
musteriManager.Listele(musteri3);

musteriManager.Sil(musteri1);