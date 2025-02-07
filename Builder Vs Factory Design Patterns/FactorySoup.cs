namespace Builder_Vs_Factory_Design_Patterns
{
    public class FactorySoup
    {
        public int MushroomAmount { get; set; }
        public int CarrotAmount { get; set; }
        public int TomatoAmount { get; set; }
        public List<string> Flavours { get; set; } = new List<string>();

        public FactorySoup CreateFactorySoup(int mushroomAmount, int carrotAmount, int tomatoAmount, List<string> flavours)
        {
            return new FactorySoup()
            { 
                CarrotAmount = carrotAmount, 
                MushroomAmount = mushroomAmount, 
                TomatoAmount = tomatoAmount, 
                Flavours = flavours };
        }
    }
}
