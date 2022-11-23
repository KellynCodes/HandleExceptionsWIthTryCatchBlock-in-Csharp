namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "How to handle Exceptions";
            HowToHandleExceptions exceptions = new HowToHandleExceptions();
            exceptions.Return();
        }
    }
}