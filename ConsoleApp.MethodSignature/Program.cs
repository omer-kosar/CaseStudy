namespace ConsoleApp.MethodSignature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Show(1, 2);
            Show(3, 4, 5);
        }

        private static void Show(params int[] parameters)
        {
            Console.WriteLine(string.Join(",", parameters));
        }
    }
}