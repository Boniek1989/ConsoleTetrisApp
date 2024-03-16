using System;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

public class Program
{
    static void Main()
    {
        Layer instanceLayer = new Layer();
        instanceLayer.drawLayer();
        instanceLayer.gameMatrix();

        // Tworzymy nowy wątek do obsługi wejścia z klawiatury
        Thread inputThread = new Thread(() =>
        {
            while (true)
            {
                // Pobieramy naciśnięty klawisz
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                // Sprawdzamy, który klawisz został naciśnięty
                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        instanceLayer.MoveBrickLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        instanceLayer.MoveBrickRight();
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0); // Wyjście z programu
                        break;
                }
            }
        });

        // Uruchamiamy wątek obsługujący wejście z klawiatury
        inputThread.Start();
        
        
                
        while(1<10)
        {
          
            instanceLayer.brickOneMove();
            instanceLayer.drawBoard();

         //Console.CursorLeft=60;
         //Console.CursorTop=0;
         //instanceLayer.gameMatrixShow();
        }

        
    }
    
}

public class Layer

{   int [,] gameTable = new int [20,30];

    
    int bufferHeight = Console.BufferHeight;
    int i;
    int j = 8;
 protected static int origRow;
    protected static int origCol;

    protected static void WriteAt(string s, int x, int y)
    {
    try
        {
        Console.SetCursorPosition(origCol+x, origRow+y);
        Console.Write(s);
        }
    catch (ArgumentOutOfRangeException e)
        {
        Console.Clear();
        Console.WriteLine(e.Message);
        }
    }

    public void drawLayer()
    

    {
        Console.Clear();

        origRow = Console.CursorTop;
        origCol = Console.CursorLeft;

            for (i=2;i<bufferHeight && i<20;i++)
            {   
                WriteAt("[[|]]",35,i);
                WriteAt("[[|]]",0,i);
            }
            for (i=1;i<7;i++)
            {
                WriteAt("[[|]]", i * 5, 19);
            }

            

}

    public void brickOne()
    {
        
        WriteAt("X",j,i);  
        WriteAt("X",j+1,i);  
        WriteAt("X",j+2,i);  
        WriteAt("X",j+3,i); 
        WriteAt("X",j+4,i);  
        WriteAt(" ",j,i-1);  
        WriteAt(" ",j+1,i-1);  
        WriteAt(" ",j+2,i-1);  
        WriteAt(" ",j+3,i-1); 
        WriteAt(" ",j+4,i-1);
             
        
    }
    public void brickOneMove()
   {
        
        for(i=1;i<19;i++) 
        {   
            
            
            brickOne();
            int x=j-5;
            int y=i;
                        
                if(gameTable[y+1,x]==1||gameTable[y+1,x+1]==1||gameTable[y+1,x+2]==1||gameTable[y+1,x+3]==1)
                {
                    WriteAt("X",j,i);   
                    WriteAt("X",j+1,i); 
                    WriteAt("X",j+2,i);   
                    WriteAt("X",j+3,i);
                    WriteAt("X",j+4,i);

                    gameTable[y,x]=1;
                    gameTable[y,x+1]=1;
                    gameTable[y,x+2]=1;
                    gameTable[y,x+3]=1;
                    gameTable[y,x+4]=1;
                    
                break;
                }
            System.Threading.Thread.Sleep(500);
       
         
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
    public void MoveBrickLeft()
    {
        if (j > 5 )
        {
            j--;
            
            
            
            brickOne();
            WriteAt(" ",j,i);  
            WriteAt(" ",j+1,i);  
            WriteAt(" ",j+2,i);  
            WriteAt(" ",j+3,i); 
            WriteAt(" ",j+4,i);
            WriteAt(" ",j+5,i);  
        }
    }

    public void MoveBrickRight()
    {
        if (j < 30)
        {
            j++;
            
            
            
            brickOne();
            WriteAt(" ",j-1,i);  
            WriteAt(" ",j,i);  
            WriteAt(" ",j+1,i);  
            WriteAt(" ",j+2,i);  
            WriteAt(" ",j+3,i); 
            WriteAt(" ",j+4,i);  
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




