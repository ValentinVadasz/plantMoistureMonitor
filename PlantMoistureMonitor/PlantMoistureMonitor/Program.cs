namespace PlantMoistureMonitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string? name;
            name = GetName();
            WriteName(name);
        }

        static string? GetName()
        {
            Console.WriteLine("Add meg a neved:");

            string? name;
            name = Console.ReadLine();

            return name;
        }

        static void WriteName(string? userName)
        {
            Console.WriteLine("Üdvözöllek, {0}", userName);
        }
    }
}