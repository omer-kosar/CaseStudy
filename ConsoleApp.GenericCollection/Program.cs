namespace ConsoleApp.GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomGenericCollection<int> list = new CustomGenericCollection<int>();
            list.Add(1);
            list.Add(2);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            CustomGenericCollection<Person> personList = new CustomGenericCollection<Person>();
            personList.Add(new Person { Name = "Ali" });
            personList.Add(new Person { Name = "Veli" });
            foreach (var item in personList)
            {
                Console.WriteLine(item);
            }
        }
    }
}