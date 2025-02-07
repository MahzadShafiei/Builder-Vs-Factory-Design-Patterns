namespace Builder_Vs_Factory_Design_Patterns
{
    public class BuilderSoup
    {
        public int MushroomAmount { get; set; }
        public int CarrotAmount { get; set; }
        public int TomatoAmount { get; set; }
        public List<string> Flavours { get; set; } = new List<string>();
    }

    public class BuilderSoupBuilder 
    {
        private BuilderSoup _builderSoup = new BuilderSoup();

        public BuilderSoupBuilder AddMushroom(int mushroomAmount)
        {
            _builderSoup.MushroomAmount = mushroomAmount;
            return this;
        }

        public BuilderSoupBuilder AddCarrot(int carrotAmount)
        {
            _builderSoup.CarrotAmount = carrotAmount;
            return this;
        }

        public BuilderSoupBuilder AddTomato(int tomatoAmount)
        {
            _builderSoup.TomatoAmount = tomatoAmount;
            return this;
        }

        public BuilderSoupBuilder AddFlavours(string flavours)
        {
            _builderSoup.Flavours.Add(flavours);
            return this;
        }

        public BuilderSoup Build()
        {
            return _builderSoup;
        }
    }
}
