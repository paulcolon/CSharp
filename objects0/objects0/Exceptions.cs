namespace TreehouseDefense
{
    public class Exceptions
    {
        class TreehouseDefenseException : System.Exception
    }

    public TreehouseDefenseException(string message) : base (message)
    {
    
    }
    

    class OutOfBoundsException : TreehouseDefenseException
{
    public OutOfBoundsException(string message) : base(message)
    {
        
    }
    
}
}