using System.Linq.Expressions;

public class Movers : Bricks
{
    public int [,] gameTable = new int [20,30];
    public int x;
    public int y;
    public void brickMove(int startingJ)
   
    
    {
        Layer updater = new Layer(); 
        j=startingJ;
        
        for(i=0;i<19;i++)
        {
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
        if(i==18)
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
        }
        drawBoard();
        longBrick();
        System.Threading.Thread.Sleep(100);
        Console.Clear();
          
        updater.drawLayer();
        drawBoard();     
        gameMatrixShow();  
    }
           
        
    }
    public void MoveBrickLeft()
    {
        if (j > 5 )
        {
            j--;
        }
    }

    public void MoveBrickRight()
    {
        if (j < 30)
        {
            j++;
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