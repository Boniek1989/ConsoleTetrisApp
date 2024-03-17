public class Bricks : Writer
{
    public int i;
    public int j;
    public void longBrick()
    {
        // long brick = 5 pieces straight brick
        //if (rotator%2==0)
        //{
        WriteAt("X",j,i);  
        WriteAt("X",j+1,i);  
        WriteAt("X",j+2,i);  
        WriteAt("X",j+3,i); 
        WriteAt("X",j+4,i);  
       
      // }
       // if (rotator%2>0)
        //{
          //  WriteAt("X",j+2,i-2);  
          //  WriteAt("X",j+2,i-1);  
          //  WriteAt("X",j+2,i);  
          //  WriteAt("X",j+2,i+1); 
          //  WriteAt("X",j+2,i+2);  
        //}            

    }
}