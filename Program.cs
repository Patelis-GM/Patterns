using System;
using Patterns.BuilderPattern;
using Patterns.BuilderPattern.BuilderA;
using Patterns.BuilderPattern.BuilderB;
public class Program
{

    public static void Main()
    {

        ProductBuilder productBuilder = new ProductBuilder();
        Product product1 = productBuilder.SetName("Gaming Computer").SetPrice(69.69f).SetOnSale(false).SetReleaseDate(DateTime.Now).Build();
        Product product2 = productBuilder.SetName("Emerson T-Shirt").SetPrice(25.50f).SetOnSale(true).SetReleaseDate(DateTime.Now).Build();


        GamingComputerBuilder gamingComputerBuilder = new GamingComputerBuilder();
        Director director1 = new Director(gamingComputerBuilder);

        TShirtBuilder shirtBuilder = new TShirtBuilder();
        Director director2 = new Director(shirtBuilder);

        Product product3 = gamingComputerBuilder.Build();
        Product product4 = shirtBuilder.Build();

        Console.WriteLine(product1);
        Console.WriteLine(product2);
        Console.WriteLine(product3);
        Console.WriteLine(product4);



    }


}