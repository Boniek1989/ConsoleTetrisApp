using System.Linq.Expressions;
using System.Runtime.CompilerServices;

public class Movers : Bricks
{
    public int [,] gameTable = new int [20,30];
    public int x;
    public int y;
    public byte rotator=1;
    public byte moveBuffor=0; 
    
    public void brickMoveThird(int startingJ)
    {
    Layer updater = new Layer(); 
    j=startingJ;
        
    for(i=0;i<19;i++)
    {
            

    int x=j-5;
    int y=i; 
       
        
        if(rotator%2>0)
        {
            moveBuffor=1;

            if(gameTable[y+2,x]==1||gameTable[y+1,x+1]==1||gameTable[y+1,x+2]==1||gameTable[y+1,x+3]==1||gameTable[y+1,x+4]==1)
            {  
                gameTable[y+1,x]=1;
                gameTable[y,x]=1;
                gameTable[y,x+1]=1;
                gameTable[y,x+2]=1;
                gameTable[y,x+3]=1;
                gameTable[y,x+4]=1;

                break;
            }
            if(i==17)
            {
                gameTable[y+1,x]=1;
                gameTable[y,x]=1;
                gameTable[y,x+1]=1;
                gameTable[y,x+2]=1;
                gameTable[y,x+3]=1;
                gameTable[y,x+4]=1;
                break;
        }    
        lBrick();
        }
        if (rotator%2==0)
        {
            moveBuffor=2;

            if(gameTable[y+3,x]==1)
            {
                gameTable[y-2,x]=1;
                gameTable[y-1,x]=1;
                gameTable[y,x]=1;
                gameTable[y+1,x]=1;
                gameTable[y+2,x]=1;

                break;
            }
            if(i+2==18)
            {   
                gameTable[y+2,x+1]=1;
                gameTable[y-2,x]=1;
                gameTable[y-1,x]=1;
                gameTable[y,x]=1;
                gameTable[y+1,x]=1;
                gameTable[y+2,x]=1; 
                break;
            }
            rotatedLBrick();
        }
        gameMatrixShow();
            drawBoard();
                System.Threading.Thread.Sleep(300);
                    Console.Clear();
                        updater.drawLayer();
             
         
    }  
    }
    public void brickMoveFourth(int startingJ)
   
    
    {   
        Layer updater = new Layer(); 
        j=startingJ;
        
        for(i=0;i<19;i++)
        {
            

        int x=j-5;
        int y=i; 
       
        
        if(rotator%2>0)
        {
            moveBuffor=1;

            if(gameTable[y+1,x]==1||gameTable[y+1,x+1]==1||gameTable[y+1,x+2]==1||gameTable[y+1,x+3]==1||gameTable[y+1,x+4]==1)
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
        longBrick();
        }
        if (rotator%2==0)
        {
            moveBuffor=2;

            if(gameTable[y+3,x]==1)
            {
                WriteAt("X", j, i+2);  
                WriteAt("X", j, i+1);  
                WriteAt("X", j, i);  
                WriteAt("X", j, i-1); 
                WriteAt("X", j, i-2);

                gameTable[y-2,x]=1;
                gameTable[y-1,x]=1;
                gameTable[y,x]=1;
                gameTable[y+1,x]=1;
                gameTable[y+2,x]=1;

                break;
            }
            if(i+2==18)
            {
                WriteAt("X", j, i+2);  
                WriteAt("X", j, i+1);  
                WriteAt("X", j, i);  
                WriteAt("X", j, i-1); 
                WriteAt("X", j, i-2);

                gameTable[y-2,x]=1;
                gameTable[y-1,x]=1;
                gameTable[y,x]=1;
                gameTable[y+1,x]=1;
                gameTable[y+2,x]=1; 
                break;
            }
            rotatedLongBrick();
        }
        gameMatrixShow();
            drawBoard();
                System.Threading.Thread.Sleep(500);
                    Console.Clear();
                        updater.drawLayer();
             
         
    }
           
        
    }
    // better colliders better rotator colliders
    public void MoveBrickLeft()
    {
        switch(moveBuffor)
        {   
        case 1:
            if (j > 5)
            {
                j--;
            } 
        break; 
        case 2:
            {
            if (j > 5) 
            j--;
            }
        break;
        }
    }

    public void MoveBrickRight()
    {
        switch(moveBuffor)
        {   
        case 1:
            if (j < 30)
            {
                j++;
            }
        break; 
        case 2:
            if (j < 34)
            {
                j++;
            }
        break;
        }
    }
    public void rotateBrick()
    {
        switch(moveBuffor)
        {   
        case 1:
            if (j>5 && j<30 )
            {
               
                
                    rotator++;
                
            }
        break; 
        case 2:
            if (j>5 && j<34)
            {
                rotator++;
            }
        break;
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
    Console.CursorTop=0;
    Console.CursorLeft=0;
        for(int x=0;x<20;x++)
        {
            for(int y=0;y<30;y++)
            {
                if (gameTable[x,y]==1)
                {
                    WriteAt("X",y+5,x);
                }
            }
        }
    }
}

