using System.Reflection.Metadata;

public class tamagotchiManager
{

    private List<int> happySprite = new List<int>{ 0, 11 }; 
    private List<int> sadSprite = new List<int>{ 12, 24 }; 
    
    public void initTamagochiScene()
    {
        ConsoleManager.hardClear();
        ConsoleManager.currentScreen = "Tamagochi";
        ConsoleManager.renderSprite(happySprite[0], happySprite[1], 10, 10);
        ConsoleManager.Update();  



    }
    
    


}