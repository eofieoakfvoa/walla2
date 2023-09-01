using System.Data;
using System.Diagnostics;
public class TempHighlightText
{
    List<int> Options = new();
    
    int selectedOption = 1;
    public ConsoleKeyInfo getKey()
    {
        ConsoleKeyInfo temp = Console.ReadKey();
        return temp;
    }
    public int TextSelection(string Active, List<int> Options, String ClickAble)
    {
        bool Update = true;
        while (Active == "True")
        {   
        ConsoleKeyInfo temp = getKey();
        if (temp.Key == ConsoleKey.DownArrow) 
        {
            if (selectedOption == 1)
            {
                selectedOption = Options.Count;
                Debug.WriteLine(selectedOption);
            }
            else{
                selectedOption --;
                Debug.WriteLine(selectedOption);
            }
            //Fixa så att t.ex border themes behöver man bara klicka på höger och vänster pilen på att ändra inte klicka på enter knappen först sen pilar
            // if (ClickAble == "False")
            // {
            //         return selectedOption;
            // }
        }
        if (temp.Key == ConsoleKey.UpArrow) 
        {
            if (selectedOption == Options.Count)
            {
                selectedOption = 1;
                Debug.WriteLine(selectedOption);
            }
            else{
                selectedOption ++;
                Debug.WriteLine(selectedOption);
            }
            // if (ClickAble == "False")
            // {
            //         return selectedOption;
            // }
        }
        if (temp.Key == ConsoleKey.C) 
        {
            // if (ClickAble == "True")
            // {
                Active = "False";
                ClickAble = string.Empty;
                return selectedOption;
            // }
        }
        }
    return 0; // borde aldrig hända?
    }
    //Up Down funktion som ändrar Selectedoption??
    //Left to right funktion 
}