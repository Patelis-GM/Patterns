using System;

namespace Patterns.BuilderPattern.BuilderB
{

    public interface IBuilder
    {
        public void SetName();
        public void SetPrice();
        public void SetOnSale();
        public void SetReleaseDate();

        public void Reset();
    }


    public class GamingComputerBuilder : IBuilder
    {

        private Product _product = new Product();

        public void SetName()
        {
            this._product.Name = "Gaming Computer";

        }

        public void SetPrice()
        {
            this._product.Price = 69.69f;
        }

        public void SetOnSale()
        {
            this._product.OnSale = false;
        }

        public void SetReleaseDate()
        {
            this._product.ReleaseDate = DateTime.Now;
        }

        public Product Build()
        {
            Product result = this._product;
            this.Reset();
            return result;
        }

        public void Reset()
        {
            this._product = new Product();
        }

    }


    public class TShirtBuilder : IBuilder
    {

        private Product _product = new Product();

        public void SetName()
        {
            this._product.Name = "Emerson T-Shirt";

        }

        public void SetPrice()
        {
            this._product.Price = 25.50f;
        }

        public void SetOnSale()
        {
            this._product.OnSale = true;
        }

        public void SetReleaseDate()
        {
            this._product.ReleaseDate = DateTime.Now;
        }

        public Product Build()
        {
            Product result = this._product;
            this.Reset();
            return result;
        }

        public void Reset()
        {
            this._product = new Product();
        }

    }


    public class Director
    {

        public Director(IBuilder builder)
        {
            builder.SetName();
            builder.SetPrice();
            builder.SetOnSale();
            builder.SetReleaseDate();
        }

    }
}