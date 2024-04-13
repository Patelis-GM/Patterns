using System;

namespace Patterns.BuilderPattern.BuilderA
{

    public class ProductBuilder
    {

        private Product _product = new Product();

        public ProductBuilder SetName(string name)
        {
            this._product.Name = name;
            return this;
        }

        public ProductBuilder SetPrice(float price)
        {
            this._product.Price = price;
            return this;
        }

        public ProductBuilder SetOnSale(bool onSale)
        {
            this._product.OnSale = onSale;
            return this;
        }

        public ProductBuilder SetReleaseDate(DateTime releaseDate)
        {
            this._product.ReleaseDate = releaseDate;
            return this;
        }

        public Product Build()
        {
            Product result = this._product;
            this.Reset();
            return result;
        }

        public ProductBuilder Reset()
        {
            this._product = new Product();
            return this;
        }
    }

}