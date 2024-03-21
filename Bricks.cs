using System.Runtime.CompilerServices;

public class Bricks : Writer
{
    
    public int i;
    public int j;
    public void lBrick()
{   
        Console.CursorTop = i;
        Console.CursorLeft = j;
      
        WriteAt("X",j,i+1);
        WriteAt("X",j,i);   
        WriteAt("X",j+1,i); 
        WriteAt("X",j+2,i);   
        WriteAt("X",j+3,i);
        WriteAt("X",j+4,i);

}
    public void rotatedLBrick()
    {
                WriteAt("X", j+1, i+2);
                WriteAt("X", j, i+2);  
                WriteAt("X", j, i+1);  
                WriteAt("X", j, i);  
                WriteAt("X", j, i-1); 
                WriteAt("X", j, i-2);
    }
    public void longBrick()
{   
        Console.CursorTop = i;
        Console.CursorLeft = j;
      
        WriteAt("X", j, i);  
        WriteAt("X", j+1, i);  
        WriteAt("X", j+2, i);  
        WriteAt("X", j+3, i); 
        WriteAt("X", j+4, i);
}
    public void rotatedLongBrick()
    {
        WriteAt("X", j, i-2);  
        WriteAt("X", j, i-1);  
        WriteAt("X", j, i);  
        WriteAt("X", j, i+1); 
        WriteAt("X", j, i+2);
    }
}
