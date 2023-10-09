using System.Reflection.Metadata;

public class Tamagotchi
{
    public string Name;
    private int Hunger;
    private int Boredom;
    private bool isAlive;
    private List<string> knownWords = new();
    private List<int> happySprite = new List<int>{ 1, 12 }; 
    private List<int> sadSprite = new List<int>{ 13, 25 }; 
    
    public void tamagotchiManager()
    {
    ConsoleManager.renderSprite(happySprite[0], happySprite[1], 10, 10);
    ConsoleManager.Update();  
    }
    public void Play()
    {

    }
    public void Feed()
    {

    }
    public void teachWord()
    {

    }
    
}