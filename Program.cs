
class Program
{
    static void Main(string[] args){

        int futbolKomandas = 0;
        int hokejKomandas = 0;
        Futbols futbols = new Futbols("", 0, "");
        Hokejs hokejs = new Hokejs("", 0, "");
        while (true){
        Console.Write("\nIzvēlieties sporta veidu ko apskatīsiet (futbols / hokejs) vai exit: ");
        string izvele = Console.ReadLine();
        switch (izvele){
                case "futbols":
        
                    if (futbolKomandas <= 0){
                        futbols.FutbolSkaitluParbaude();
                        futbolKomandas++;
                }
                Console.WriteLine("Vēlaties pievienot vēl kādu komandu? (jā / nē): ");
                
                izvele = Console.ReadLine();
                if (izvele == "jā" || izvele == "ja" || izvele == "j"){
                    futbols.FutbolSkaitluParbaude();
                    
                }
               
                Console.WriteLine("\nŠeit redzēsiet jūsu pieteiktās futbola komandas sacensībām\n");
                futbols.KomanduInfo();
                Console.WriteLine("\n-------------------------------------------------------------\n");
                Console.WriteLine("\nŠeit redzēsiet komandu nākamos pretiniekus\n");
                futbols.SacensibuBracket();
                break;
                
                
                case "hokejs":
 
                    if (hokejKomandas <= 0){
                        hokejs.HokejSkaitluParbaude();
                        hokejKomandas++;
                }
                Console.WriteLine("Vēlaties pievienot vēl kādu komandu? (jā / nē): ");
                
                izvele = Console.ReadLine();
                if (izvele == "jā" || izvele == "ja" || izvele == "j"){
                    hokejs.HokejSkaitluParbaude();
                    
                }
               
                Console.WriteLine("\nŠeit redzēsiet jūsu pieteiktās hokeja komandas sacensībām\n");
                hokejs.KomanduInfo();
                Console.WriteLine("\n-------------------------------------------------------------\n");
                Console.WriteLine("\nŠeit redzēsiet komandu nākamos pretiniekus\n");
                hokejs.SacensibuBracket();
                Console.WriteLine("\n-------------------------------------------------------------\n");
                break;

                case "exit":
                    Environment.Exit(0);
                    break;
            default:
                
                Console.Write("Ievadītā izvēle nav pieejama, lūdzu mēģiniet vēlreiz! ");
                izvele = Console.ReadLine();
                break;
            
        }
    }
}
}