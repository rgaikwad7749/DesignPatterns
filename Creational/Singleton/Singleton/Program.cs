namespace SingleTonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.getSingletonInstance();

            Singleton s2 = Singleton.getSingletonInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
                s1.someLogic().StringSet("key", "valye");

                Console.WriteLine(s2.someLogic().StringGet("key"));

            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

            Console.ReadLine();
        }
    }
}
