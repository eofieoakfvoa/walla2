using System.Diagnostics;
using System.Reflection.Metadata;

public class tamagotchiManager
{

    private List<int> happySprite = new List<int>{ 0, 11 }; 
    private List<int> sadSprite = new List<int>{ 12, 24 }; 
    
    public void initTamagochiScene()
    {
        ConsoleManager.currentScreen = "Tamagochi";
        ConsoleManager.renderSprite(happySprite[0], happySprite[1], 20, 3);
        ConsoleManager.addText(11, new string[]{"Center", "Center"});
        ConsoleManager.addText(12, new string[]{"Center", "Center"});
        ConsoleManager.addText(13, new string[]{"Center", "Center"});
        ConsoleManager.addText(14, new string[]{"Center", "Center"});
        
        ConsoleManager.Update();


        _ = TimerTicks(); //quick fix gjorde _ =, vet inte direkt vad det är men det är en discard variable
    }
    async Task TimerTicks()
    {
        PeriodicTimer Timer = new PeriodicTimer(TimeSpan.FromSeconds(10));
        while (await Timer.WaitForNextTickAsync())
        {
            Debug.WriteLine("hello");
        }
    }
    


}