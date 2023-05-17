using System;

namespace WinFormsApp1.NewFolder
{
  [Serializable]
    public abstract class Item
    {
        private double price;
        private int id;

        protected Item() : this(0,0)
        {
            // Throw an message
        }
        protected Item(double newPrice,int newId)
        {
            this.price = newPrice;
            this.id = newId;
            //Console.WriteLine("set for this item price and id");
        }

        public double getPrice()
        {
            return this.price;
        }
        public int getId()
        {
            return this.id;
        }
        public void setPrice(double newPrice)
        {
            if(newPrice>=0)
                this.price = newPrice;
        }
        public void setId(int newId)
        {
            if(newId >= 0)
                this.id = newId;
        }
    }
}
