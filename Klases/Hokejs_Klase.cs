using System;
using System.Collections;
using System.Text.RegularExpressions;

class Hokejs : Sacensibas {
    
    private int komanduSkaits;
    
    private List<Hokejs> komanduSarkasts = new List<Hokejs>();
    private Regex regexCipariem = new Regex(@"^[0-9]{1,3}$");
    private  Regex regexBurtiem = new Regex(@"^[a-zA-ZāēīūōĀĒĪŪŌčģķļņšžČĢĶĻŅŠŽ\.]{3,}$");
    public Hokejs(string komandasNosaukums, int komandasVecumaGrupa, string komandasTreneris) 
{
    this.komandasVecumaGrupa = komandasVecumaGrupa;
    this.komandasNosaukums = komandasNosaukums;
    this.komandasTreneris = komandasTreneris;
   
}

    public Hokejs HokejKomanda(){
        
        Console.WriteLine("Reģistrējat hokeja komandu\n");

        Console.Write("Ievadiet hokeja komandas nosaukumu: ");
        komandasNosaukums = Console.ReadLine();
        while (!regexBurtiem.IsMatch(komandasNosaukums)){
            Console.Write("Ievadītā vērtība nav burti, lūdzu mēģiniet vēlreiz: ");
            komandasNosaukums = Console.ReadLine();
        }
        foreach (Hokejs komanda in komanduSarkasts){
        while (komandasNosaukums== komanda.komandasNosaukums){
            Console.Write("Šāda komanda jau ir pievienota, lūdzu mēģiniet vēlreiz: ");
            komandasNosaukums = Console.ReadLine();
            while (!regexBurtiem.IsMatch(komandasNosaukums)){
                Console.Write("Ievadītā vērtība nav burti, lūdzu mēģiniet vēlreiz: ");
                komandasNosaukums = Console.ReadLine();
            }
        }
        }
        Console.Write("Ievadiet hokeja komandas vecuma grupu: U");
        string SKomandasVecumaGrupa = Console.ReadLine();
        while (!regexCipariem.IsMatch(SKomandasVecumaGrupa)){
            Console.Write("Ievadītā vērtība nav skaitlis, lūdzu mēģiniet vēlreiz: ");
            SKomandasVecumaGrupa = Console.ReadLine();
        }
        komandasVecumaGrupa = Convert.ToInt32(SKomandasVecumaGrupa);
        Console.Write("Ievadiet hokeja komandas treneri: ");
        komandasTreneris = Console.ReadLine();
        while (!regexBurtiem.IsMatch(komandasTreneris)){
            Console.Write("Ievadītā vērtība nav burti, lūdzu mēģiniet vēlreiz: ");
            komandasTreneris = Console.ReadLine();
        }
        Console.WriteLine($"\nHokeja komanda {komandasNosaukums} ir veiksmīgi pievienota!\n");


        Hokejs hokejkomanda = new Hokejs(komandasNosaukums, komandasVecumaGrupa,  komandasTreneris);
        komanduSarkasts.Add(hokejkomanda);

        return hokejkomanda;
    }

    public override void KomanduInfo(){
        int NPK = 0;
        foreach (Hokejs komanda in komanduSarkasts){
            NPK++;
            Console.WriteLine($"{NPK}. Komandas nosaukums: {komanda.komandasNosaukums} | Vecuma grupa: U{komanda.komandasVecumaGrupa} | Treneris: {komanda.komandasTreneris}");
        }

    }

    public override void SacensibuBracket(){
        List<Hokejs> sakartotsLists = komanduSarkasts.OrderBy(o=>o.komandasVecumaGrupa).ToList();
        int karta = 1;
        for (int i = 0; i < sakartotsLists.Count; i++){
            Console.WriteLine($"{karta++}. kārtas spēle: {sakartotsLists[i].komandasNosaukums} (U{sakartotsLists[i].komandasVecumaGrupa}) VS {sakartotsLists[i+1].komandasNosaukums} (U{sakartotsLists[i+1].komandasVecumaGrupa})");
            i++;
        }
    }

    public bool HokejSkaitluParbaude(){
        int hokejKomandas = 0;
        Console.Write("Ievadiet cik hokeja komandas vēlaties pievienot: ");
            string ShokejKomandas = Console.ReadLine();
            while (Convert.ToInt32(ShokejKomandas) % 2 != 0){
                Console.Write("Lūdzu ievadiet pāra skaitli lai komandai būtu pretinieks: ");
                ShokejKomandas = Console.ReadLine();
                while (!regexCipariem.IsMatch(ShokejKomandas)){
                    Console.Write("Ievadītā vērtība nav skaitlis, lūdzu mēģiniet vēlreiz: ");
                    ShokejKomandas = Console.ReadLine();
                }
            }
            hokejKomandas = Convert.ToInt32(ShokejKomandas);
            for (int i = 0; i < hokejKomandas; i++){
                HokejKomanda();
            }
            return true;
    }
    public List<Hokejs> GetKomanduSaraksts()
    {
        return komanduSarkasts;
    }
}