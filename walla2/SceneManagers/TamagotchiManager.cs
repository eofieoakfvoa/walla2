using System.Diagnostics;
using System.Reflection.Metadata;

public static class tamagotchiManager
{

    private static List<int> happySprite = new List<int>{ 0, 11 }; 
    private static List<int> sadSprite = new List<int>{ 12, 24 };
    static Tamagotchi instancetamagotchi = new();
    
    public static void initTamagochiScene()
    {
        ConsoleManager.currentScreen = "Tamagochi";
        //ConsoleManager.renderSprite(happySprite[0], happySprite[1], 20, 3);
        tamagotchiManager.renderSprite();
        ConsoleManager.addText(11, new string[]{"Center", "Center"});
        ConsoleManager.addText(12, new string[]{"Center", "Center"});
        ConsoleManager.addText(13, new string[]{"Center", "Center"});
        ConsoleManager.addText(14, new string[]{"Center", "Center"});
        
        ConsoleManager.Update();


        _ = TimerTicks(); //quick fix gjorde _ =, vet inte direkt vad det är men det är en discard variable
    }
    async static Task TimerTicks()
    {
        PeriodicTimer Timer = new PeriodicTimer(TimeSpan.FromSeconds(10));
        while (await Timer.WaitForNextTickAsync())
        {
            instancetamagotchi.Tick();
        }
    }
    public static void renderSprite()
    {
        Debug.WriteLine(instancetamagotchi.CurrentSprite[0] + instancetamagotchi.CurrentSprite[1]);
        ConsoleManager.renderSprite(instancetamagotchi.CurrentSprite[0], instancetamagotchi.CurrentSprite[1], 20, 3);
        ConsoleManager.Update();
    }
    


}