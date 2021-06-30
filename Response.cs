using System;
namespace NumberGuesser
{
    public class Response
    {
        public Response(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}