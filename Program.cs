namespace SingleTonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleTon s1 = SingleTon.getSingleTonInstance();

            SingleTon s2 = SingleTon.getSingleTonInstance();

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
