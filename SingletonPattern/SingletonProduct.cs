using System;
namespace Patterns.SingletonPattern
{

    public class SingletonProduct
    {

        private static Product _product = null!;


        public static Product GetProduct()
        {

            if (SingletonProduct._product == null){
                Console.WriteLine("Will have to create object");
                SingletonProduct._product = new Product()
                {
                    Name = "Singleton Product",
                    Price = 3.14f,
                    OnSale = false,
                    ReleaseDate = DateTime.Now
                };
            }

            else
                Console.WriteLine("Won't have to create object again");



            return SingletonProduct._product;

        }


    }








}