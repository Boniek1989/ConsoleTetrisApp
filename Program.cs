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
        
        instanceLayer.gameMatrix();
        instanceLayer.drawLayer();
        instanceLayer.gameMatrixShow();
        
        Console.ReadKey();
    }
}



