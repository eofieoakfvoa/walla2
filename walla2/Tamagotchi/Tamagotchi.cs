using System.Diagnostics;
using System.Reflection.Metadata;

public class Tamagotchi
{
    public string Name;

    //Gör en property av Hunger och Boredom, när den är en viss mängd så ska sprite bytas, och varje ändring på hunger eller boredome ska ändra hunger och boredom bar
    private int _Hunger;
    public int Hunger
    {
        get{ return _Hunger;}
        set
        { 
            _Hunger = value;
            if (_Hunger > 1)
            {
                Debug.WriteLine("HEEHLP");
                changeSprite(sadSprite);
            }
        }
    }
    private int Boredom;
    private bool isAlive;
    private List<string> knownWords = new();
    private List<int> happySprite = new List<int>{ 1, 12 }; 
    private List<int> sadSprite = new List<int>{ 13, 24 }; 
    public List<int> CurrentSprite = new List<int>{ 1, 12 }; 

    public void Play()
    {
        Boredom--;
    }
    public void Feed()
    {
        Hunger--;
    }
    public void teachWord()
    {
        string word;
        string taught = "word";
        word = taught;
    }
    public void Tick()
    {
        
    }
    public void changeSprite(List<int> sprite)
    {
        CurrentSprite = sprite;
        tamagotchiManager.renderSprite();
    }
    
}