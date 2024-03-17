public class Writer
{
protected static int origRow;
    protected static int origCol;
    int bufferHeight = Console.BufferHeight;
    protected static int layerVal; 
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
}