    
    public class Layer : Writer
    {
    int [,] gameTable = new int [20,30];
    int i;
    int j;
    
    
    public void drawLayer()
    

    {
        
        Console.Clear();
        
        
        origRow = Console.CursorTop;
        origCol = Console.CursorLeft;
        
        
            for (layerVal=2;layerVal<20;layerVal++)
            {   
                WriteAt("[[|]]",35,layerVal);
                WriteAt("[[|]]",0,layerVal);
            }
            for (layerVal=1;layerVal<7;layerVal++)
            {
                WriteAt("[[|]]", layerVal * 5, 19);
            }
        
    }
    public void gameMatrix()
    {
        for(int x=0;x<20;x++)
        {
            for(int y=0;y<30;y++)
            {
                gameTable[x,y]=0;
            }
        }
        
        {
            for(int y=0;y<30;y++)
            {
                gameTable[19,y]=1;
            }
        } 
    }
    public void gameMatrixShow()
    {
        for (int x = 0; x < 20; x++)
        {
            Console.CursorLeft = 60;
            Console.CursorTop = x;
                for (int y = 0; y < 30; y++)
                {
                     Console.Write(gameTable[x, y] + " ");
                }
             Console.WriteLine();
        }
    }   
    public void drawBoard()
    {
      
        for(int x=0;x<20;x++)
        {
            for(int y=0;y<30;y++)
            {
                if (gameTable[x,y]==1)
                {
                    WriteAt("X",j+5,i);
                }
            }
        }
    }


}
