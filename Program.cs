namespace SingleTonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.getSingletoninstance();

            Singleton s2 = Singleton.getSingletoninstance();

            if (s1 == s2)
            {
                Console.WriteLine("singleton works");
                s1.someLogic().StringSet("Key", "Value");

                Console.WriteLine(s2.someLogic().StringGet("key"));
            }
            else
            {

                Console.WriteLine("singleton not works");
            }
            Console.ReadLine();
        }
    }
}
