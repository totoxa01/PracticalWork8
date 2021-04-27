using System;

namespace MyClassLibrary
{
    public class ClassMessage
    {
        public static string MethodGreeting(string name)
        {
            string message = "Здравствуй, " + name + "!";
            return message;
        }
    }
}
