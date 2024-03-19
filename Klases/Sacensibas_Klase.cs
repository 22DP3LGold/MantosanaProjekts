abstract class Sacensibas{

    protected string komandasNosaukums;
    protected string komandasTreneris;
    protected int komandasVecumaGrupa;

    
    public abstract void KomanduInfo();

    public virtual void SacensibuBracket(){
        Console.WriteLine($"Nakamās spēles hokejā un hokejā norisināsies jau drīz!");
    }

}