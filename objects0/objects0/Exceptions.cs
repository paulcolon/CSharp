namespace TreehouseDefense
{
    public class Exceptions
    {
        class TreehouseDefenseException : System.Exception 
    }

    public class TreehouseDefenseException(string message) : base (message)
    {
    
    }
    

    public class OutOfBoundsException : TreehouseDefenseException
{
    
    
    public OutOfBoundsException(string message) : base(message)
    {
        
    }
    
}
}