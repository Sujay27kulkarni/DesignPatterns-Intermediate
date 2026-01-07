namespace SimpleFactoryPattern.Abstractions
{
    public abstract class Pizza
    {
        public string Name { get; set; }    
        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
        }

        public void Bake()
        {
            Console.WriteLine($"Baking {Name}");
        }

        public void Cut()
        {
            Console.WriteLine($"Cutting {Name}");
        }

        public void Box()
        {
            Console.WriteLine($"Boxing {Name}");
        }
    }
}
