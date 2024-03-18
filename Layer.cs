    
    public class Layer : Writer
    {
        
    int i;
    int j;
    
    
    public void drawLayer()
    

    {
        
            
        Console.Clear();
        
        
        origRow = Console.CursorTop;
        origCol = Console.CursorLeft;
        
        WriteAt("[[|]]",0,2);
        WriteAt("[[|]]",0,3);
        WriteAt("[[|]]",0,4);
        WriteAt("[[|]]",0,4);
        WriteAt("[[|]]",0,5);
        WriteAt("[[|]]",0,6);
        WriteAt("[[|]]",0,7);
        WriteAt("[[|]]",0,8);
        WriteAt("[[|]]",0,9);
        WriteAt("[[|]]",0,10);
        WriteAt("[[|]]",0,11);
        WriteAt("[[|]]",0,12);
        WriteAt("[[|]]",0,13);
        WriteAt("[[|]]",0,14);
        WriteAt("[[|]]",0,15);
        WriteAt("[[|]]",0,16);
        WriteAt("[[|]]",0,17);
        WriteAt("[[|]]",0,18);
        WriteAt("[[|]]",0,19);

        WriteAt("[[|]]",5,19);
        WriteAt("[[|]]",10,19);
        WriteAt("[[|]]",15,19);
        WriteAt("[[|]]",20,19);
        WriteAt("[[|]]",25,19);
        WriteAt("[[|]]",30,19);

        WriteAt("[[|]]",35,2); 
        WriteAt("[[|]]",35,3);
        WriteAt("[[|]]",35,4);
        WriteAt("[[|]]",35,5);
        WriteAt("[[|]]",35,6);
        WriteAt("[[|]]",35,7);
        WriteAt("[[|]]",35,8);
        WriteAt("[[|]]",35,9);
        WriteAt("[[|]]",35,10);
        WriteAt("[[|]]",35,11);
        WriteAt("[[|]]",35,12);
        WriteAt("[[|]]",35,13);
        WriteAt("[[|]]",35,14);
        WriteAt("[[|]]",35,15);
        WriteAt("[[|]]",35,16);
        WriteAt("[[|]]",35,17);
        WriteAt("[[|]]",35,18);
        WriteAt("[[|]]",35,19);
        
        // when I made loop for WriteAt there were only troubles with this code
        //    for (layerVal=2;layerVal<20;layerVal++)
        //    {   
        //        WriteAt("[[|]]",35,layerVal);
        //        WriteAt("[[|]]",0,layerVal);
        //    }
        //    for (layerVal=1;layerVal<7;layerVal++)
        //    {
        //        WriteAt("[[|]]", layerVal * 5, 19);
        //    }
        
        

    }
    


}
