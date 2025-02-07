namespace Builder_Vs_Factory_Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mickaelBuilderSoup = new BuilderSoupBuilder()
                .AddMushroom(2)
                .AddTomato(1)
                .AddFlavours("Pepper")
                .Build();
            PrintSoup("Mickael Builder Soup", mickaelBuilderSoup);

            var annesBuilderSoup = new BuilderSoupBuilder()
                .AddMushroom(3)
                .AddCarrot(4)
                .AddFlavours("Pepper")
                .AddFlavours("Lemon juice")
                .Build();
            PrintSoup("Annes Builder Soup", annesBuilderSoup);

            var mickaelFactorySoup = new FactorySoup()
                .CreateFactorySoup(2, 0, 1, new List<string> { "Pepper" });
            PrintSoup("Mickael Factory Soup", mickaelFactorySoup);

            var annesFactorySoup = new FactorySoup()
                .CreateFactorySoup(3, 4, 0, new List<string> { "Pepper", "Lemon juice" });
            PrintSoup("Annes Factory Soup", annesFactorySoup);

            Console.ReadKey();
        }

        static void PrintSoup(string soupOwner, object soup)
        {
            var soupType = soup.GetType();
            Console.WriteLine(soupOwner + " include: \n" +
                soupType.GetProperty("MushroomAmount")?.GetValue(soup) + "Mushrooms \n" +
                soupType.GetProperty("CarrotAmount")?.GetValue(soup) + "Carrots \n" +
                soupType.GetProperty("TomatoAmount")?.GetValue(soup) + "Tomatoes \n" +
                string.Join(", ",((List<string>)(soupType.GetProperty("Flavours")?.GetValue(soup))).ToArray())
                +" as flavours \n");
        }
    }
}
