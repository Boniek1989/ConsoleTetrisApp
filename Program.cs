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
        Movers brickOne = new Movers();


        Thread inputThread = new Thread(() =>
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        brickOne.MoveBrickLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        brickOne.MoveBrickRight();
                        break;
                    case ConsoleKey.Enter:
                        brickOne.rotateBrick();
                        break;    
                    case ConsoleKey.Escape:
                        Environment.Exit(0); 
                        break;
                }
            }
        });

        inputThread.Start();
        brickOne.gameMatrix();

        brickOne.gameMatrixShow();
       
        instanceLayer.drawLayer();
      
        while(1<10)
        { 
            brickOne.brickMoveThird(18);
            
            brickOne.brickMoveFourth(18);
            
        }   
        
    } 
}



