using System;
using System.Collections;
using System.Text.RegularExpressions;

class Futbols : Sacensibas {
    
    private int komanduSkaits;
    
    public List<Futbols> komanduSarkasts = new List<Futbols>();
    private Regex regexCipariem = new Regex(@"^[0-9]{1,3}$");
    private  Regex regexBurtiem = new Regex(@"^[a-zA-ZāēīūōĀĒĪŪŌčģķļņšžČĢĶĻŅŠŽ\.]{3,}$");
    public Futbols(string komandasNosaukums, int komandasVecumaGrupa, string komandasTreneris) 
{
    this.komandasVecumaGrupa = komandasVecumaGrupa;
    this.komandasNosaukums = komandasNosaukums;
    this.komandasTreneris = komandasTreneris;
   
}

    public Futbols FutbolKomanda(){
        
        Console.WriteLine("Reģistrējat futbola komandu\n");

        Console.Write("Ievadiet Futbola komandas nosaukumu: ");
        komandasNosaukums = Console.ReadLine();
        while (!regexBurtiem.IsMatch(komandasNosaukums)){
            Console.Write("Ievadītā vērtība nav burti, lūdzu mēģiniet vēlreiz: ");
            komandasNosaukums = Console.ReadLine();
        }
        foreach (Futbols komanda in komanduSarkasts){
        while (komandasNosaukums== komanda.komandasNosaukums){
            Console.Write("Šāda komanda jau ir pievienota, lūdzu mēģiniet vēlreiz: ");
            komandasNosaukums = Console.ReadLine();
            while (!regexBurtiem.IsMatch(komandasNosaukums)){
                Console.Write("Ievadītā vērtība nav burti, lūdzu mēģiniet vēlreiz: ");
                komandasNosaukums = Console.ReadLine();
            }
        }
        }
        Console.Write("Ievadiet Futbola komandas vecuma grupu: U");
        string SKomandasVecumaGrupa = Console.ReadLine();
        while (!regexCipariem.IsMatch(SKomandasVecumaGrupa)){
            Console.Write("Ievadītā vērtība nav skaitlis, lūdzu mēģiniet vēlreiz: ");
            SKomandasVecumaGrupa = Console.ReadLine();
        }
        komandasVecumaGrupa = Convert.ToInt32(SKomandasVecumaGrupa);
        Console.Write("Ievadiet Futbola komandas treneri: ");
        komandasTreneris = Console.ReadLine();
        while (!regexBurtiem.IsMatch(komandasTreneris)){
            Console.Write("Ievadītā vērtība nav burti, lūdzu mēģiniet vēlreiz: ");
            komandasTreneris = Console.ReadLine();
        }
        Console.WriteLine($"\nFutbola komanda {komandasNosaukums} ir veiksmīgi pievienota!\n");


        Futbols futbolkomanda = new Futbols(komandasNosaukums, komandasVecumaGrupa,  komandasTreneris);
        komanduSarkasts.Add(futbolkomanda);

        return futbolkomanda;
    }

    public override void KomanduInfo(){
        int NPK = 0;
        foreach (Futbols komanda in komanduSarkasts){
            NPK++;
            Console.WriteLine($"{NPK}. Komandas nosaukums: {komanda.komandasNosaukums} | Vecuma grupa: U{komanda.komandasVecumaGrupa} | Treneris: {komanda.komandasTreneris}");
        }

    }

    public override void SacensibuBracket(){
        List<Futbols> sakartotsLists = komanduSarkasts.OrderBy(o=>o.komandasVecumaGrupa).ToList();
        int karta = 1;
        for (int i = 0; i < sakartotsLists.Count; i++){
            Console.WriteLine($"{karta++}. kārtas spēle: {sakartotsLists[i].komandasNosaukums} (U{sakartotsLists[i].komandasVecumaGrupa}) VS {sakartotsLists[i+1].komandasNosaukums} (U{sakartotsLists[i+1].komandasVecumaGrupa})");
            i++;
        }
    
    }

    public bool FutbolSkaitluParbaude(){
        int futbolKomandas = 0;
        Console.Write("Ievadiet cik futbola komandas vēlaties pievienot: ");
            string SfutbolKomandas = Console.ReadLine();
            while (Convert.ToInt32(SfutbolKomandas) % 2 != 0){
                Console.Write("Lūdzu ievadiet pāra skaitli lai komandai būtu pretinieks: ");
                SfutbolKomandas = Console.ReadLine();
                while (!regexCipariem.IsMatch(SfutbolKomandas)){
                    Console.Write("Ievadītā vērtība nav skaitlis, lūdzu mēģiniet vēlreiz: ");
                    SfutbolKomandas = Console.ReadLine();
                }
            }
            futbolKomandas = Convert.ToInt32(SfutbolKomandas);
            for (int i = 0; i < futbolKomandas; i++){
                FutbolKomanda();
            }
            return true;
    }
    public List<Futbols> GetKomanduSaraksts()
    {
        return komanduSarkasts;
    }
}