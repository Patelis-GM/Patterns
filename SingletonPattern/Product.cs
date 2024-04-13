using System.Text.Json;
using System;

namespace Patterns.SingletonPattern {

    public class Product {

        public string Name {get; set;} = string.Empty;

        public float Price {get; set;}

        public bool OnSale {get; set;} 

        public DateTime ReleaseDate {get; set;}


        public override string ToString(){
            return JsonSerializer.Serialize(this);
        }

    }

}