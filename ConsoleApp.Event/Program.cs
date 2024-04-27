using System.ComponentModel;

namespace ConsoleApp.Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.PropertyChanged += Person_PropertyChanged;
            person.Name = "Ali";
            person.Name = "Veli";
        }
        private static void Person_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Name")
            {
                Console.WriteLine("Name özelliği değişti.");
            }
        }
    }
}