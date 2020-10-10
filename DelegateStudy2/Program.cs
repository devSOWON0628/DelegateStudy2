using System;

namespace DelegateStudy2
{
    class Program
    {
        public delegate void SendString(string message);

        static void Main(string[] args)
        {
            SendString sayHello, sayGoodbye, multiDelegate;

            sayHello = Hello;
            //sayHello는 Hello 메서드, 
            //sayGoodbye 메서드는 GoodBye메서드를 주는 느낌
            sayGoodbye = GoodBye;

            multiDelegate = sayHello + sayGoodbye;
            multiDelegate("박소원");

            Console.WriteLine();

            multiDelegate = sayGoodbye;
            multiDelegate("박소원");
        }
        public static void Hello(string message)
        {
            Console.WriteLine("안녕하세요 " + message);
        }
        public static void GoodBye(string message)
        {
            Console.WriteLine("안녕히 가세요 " + message);
        }
    }
}
