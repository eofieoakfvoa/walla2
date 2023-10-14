using System.Diagnostics;
using System.Reflection.Metadata;

public class Tamagotchi
{
    public string Name;

    //använder _ framför namnet eftersom de är private och jag gör properties av de senare och de blir det lättare att differentiata
    private int _Hunger;
    private int _Boredom;
    private bool isAlive = true;
    private List<string> knownWords = new();
    private List<int> happySprite = new List<int>{ 1, 12 }; 
    private List<int> sadSprite = new List<int>{ 13, 24 }; 
    public List<int> CurrentSprite = new List<int>{ 1, 12 }; 
    public bool hasWords = false;
    Random Generator = new();
    //Gör en property av Hunger och Boredom, när den är en viss mängd så ska sprite bytas, och varje ändring på hunger eller boredome ska ändra hunger och boredom bar
    public int Hunger
    {
        get{ return _Hunger;}
        set
        { 
            _Hunger = value;
            if (_Hunger > 8)
            {
                Debug.WriteLine("HEEHLP");
                
                changeSprite(sadSprite);

            }
            else
            {
                changeSprite(happySprite);
            }
        }
    }

    public int Boredom
    {
        get{ return _Boredom;}
        set
        { 
            _Boredom = value;
            if (_Boredom > 8)
            {
                
                changeSprite(sadSprite);

            }
            else
            {
                changeSprite(happySprite);
            }
        }
    }


    public void Play()
    {
        Boredom--;
    }
    public void Feed()
    {
        Hunger--;
    }
    public string talkBack()
    {
        if (!hasWords)
        {
            if(knownWords.Count == 0)
            {
                return $"{Name}Knows no words";
            }
            hasWords = true;
        }
        int Index = Generator.Next(knownWords.Count);
        return knownWords[Index];
    }
    public bool GetAlive()
    {
        if (_Hunger >= 10 || _Boredom >= 10)
        {
            isAlive = false;
        } 
        return isAlive;
    }
    public void teachWord(string word)
    {
        knownWords.Add(word);
    }
    public void Tick()
    {
        Hunger++;
        Boredom++;
        if (!GetAlive())
        {
            Debug.WriteLine("Dead");
        }
    }
    public void changeSprite(List<int> sprite)
    {
        if (CurrentSprite == sprite)
        {
            return;
        }
        CurrentSprite = sprite;
        tamagotchiManager.renderSprite();
    }
    
}