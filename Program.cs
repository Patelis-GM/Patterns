using System;
using Patterns.BuilderPattern;
using Patterns.BuilderPattern.BuilderA;
using Patterns.BuilderPattern.BuilderB;
using Patterns.SingletonPattern;
public class Program
{

    public static void BuilderPattern(){
        ProductBuilder productBuilder = new ProductBuilder();
        Patterns.BuilderPattern.Product product1 = productBuilder.SetName("Gaming Computer").SetPrice(69.69f).SetOnSale(false).SetReleaseDate(DateTime.Now).Build();
        Patterns.BuilderPattern.Product product2 = productBuilder.SetName("Emerson T-Shirt").SetPrice(25.50f).SetOnSale(true).SetReleaseDate(DateTime.Now).Build();

        GamingComputerBuilder gamingComputerBuilder = new GamingComputerBuilder();
        Director director1 = new Director(gamingComputerBuilder);

        TShirtBuilder shirtBuilder = new TShirtBuilder();
        Director director2 = new Director(shirtBuilder);

        Patterns.BuilderPattern.Product product3 = gamingComputerBuilder.Build();
        Patterns.BuilderPattern.Product product4 = shirtBuilder.Build();

        Console.WriteLine(product1);
        Console.WriteLine(product2);
        Console.WriteLine(product3);
        Console.WriteLine(product4);
    }


    public static void SingletonPattern(){
        Console.WriteLine(SingletonProduct.GetProduct());
        Console.WriteLine(SingletonProduct.GetProduct());
    }

    public static void Main()
    {

       
        SingletonPattern();


    }


}