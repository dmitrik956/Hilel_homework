namespace VegetableShopApp
{
    public abstract class Product
    {
        public string Name { get; }
        protected double BasePrice { get; }

        public Product(string name, double basePrice)
        {
            Name = name;
            BasePrice = basePrice;
        }

        public abstract double Price { get; }

        public abstract void PrintInfo();
    }

    public class Carrot : Product
    {
        public Carrot(double basePrice) : base("Carrot", basePrice) { }

        public override double Price => BasePrice;

        public override void PrintInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price}");
        }
    }

    public class Potato : Product
    {
        public double Count { get; } 

        public Potato(double basePrice, double count) : base("Potato", basePrice)
        {
            Count = count;
        }

        public override double Price => BasePrice * Count;

        public override void PrintInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: {BasePrice}, Count: {Count}, Total price: {Price}");
        }
    }

    public class Cucumber : Product
    {
        public double Count { get; } 

        public Cucumber(double basePrice, double count) : base("Cucumber", basePrice)
        {
            Count = count;
        }

        public override double Price => BasePrice * Count;

        public override void PrintInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: {BasePrice}, Count: {Count}, Total price: {Price}");
        }
    }
    public class Tomato : Product
    {
        public Tomato(double basePrice) : base("Tomato", basePrice) { }

        public override double Price => BasePrice;

        public override void PrintInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price}");
        }
    }

    public class VegetableShop
    {
        private readonly List<Product> _products = new List<Product>();

        public void AddProducts(List<Product> products)
        {
            _products.AddRange(products);
        }

        public void PrintProductsInfo()
        {
            double totalPrice = 0;

            foreach (var product in _products)
            {
                product.PrintInfo();
                totalPrice += product.Price;
            }

            Console.WriteLine($"Total products price: {totalPrice}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Carrot(15),
                new Potato(20, 4),
                new Cucumber(14, 2),
                new Tomato(18)
            };

            VegetableShop shop = new VegetableShop();
            shop.AddProducts(products);

            shop.PrintProductsInfo();
        }
    }
}
