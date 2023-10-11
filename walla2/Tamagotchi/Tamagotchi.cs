using System.Reflection.Metadata;

public class Tamagotchi
{
    public string Name;

    //Gör en property av Hunger och Boredom, när den är en viss mängd så ska sprite bytas, och varje ändring på hunger eller boredome ska ändra hunger och boredom bar
    private int Hunger;
    private int Boredom;
    private bool isAlive;
    private List<string> knownWords = new();
    private List<int> happySprite = new List<int>{ 1, 12 }; 
    private List<int> sadSprite = new List<int>{ 13, 24 }; 
    
    public void Play()
    {

    }
    public void Feed()
    {

    }
    public void teachWord()
    {

    }
    public void Tick()
    {
        
    }
}