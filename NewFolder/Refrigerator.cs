using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.NewFolder
{
    class Refrigerator:ElectricItems
    {
        private int liters;
        private int doors;


        public Refrigerator(string color ="Black", int year = 2022, int liter = 450, int door = 2, int watt = 0) :
             base(liter * 10, 2000 + liter + door*10, liter + 500, color, year)
        {
            setDoors(door);
            setLiter(liter);
            switch (color)
            {
                case "Black":
                    setId(2000 + liter + door * 10 + 1);
                    break;
                case "White":
                    setId(2000 + liter + door * 10 + 2);
                    break;
                case "Grey":
                    setId(2000 + liter + door * 10 + 3);
                    break;
                default:
                    break;
            }
        }

        public int getLiter()
        {
            return this.liters;
        }
        public void setLiter(int newLiter)
        {
            if(newLiter>0)
                this.liters = newLiter;
        }
        public int getDoors()
        {
            return this.doors;
        }
        public void setDoors(int newDoor)
        {
            if(newDoor>0)
                this.doors = newDoor;
        }
        public override string ToString()
        {
            return "Refrigetor" + " price: " + getPrice() + " id: " + getId() + " color: " + getColor() + " watts: " + getWatt() + " year: " + getYearsOfProduction()+" litter: "+getLiter()+ " doors: " + getDoors();
        }

        public void print()
        {
            Console.WriteLine("Details of this refrigerator:\n");
            Console.WriteLine("The price is:" + this.getPrice()+"\n");
            Console.WriteLine("Number of doors is:" + this.getDoors()+"\n");
            Console.WriteLine("The color of refrigerator is:" + this.getColor() + "\n");
            Console.WriteLine("The device consumes " + this.getWatt() + " watts\n");
        }
        public void printId()
        {
            Console.WriteLine("Details of this refrigerator:\n");
            Console.WriteLine("The Id of this item is:" + this.getId() + "\n");
            Console.WriteLine("The price is:" + this.getPrice() + "\n");
            Console.WriteLine("Number of doors is:" + this.getDoors() + "\n");
            Console.WriteLine("The color of refrigerator is:" + this.getColor() + "\n");
            Console.WriteLine("The device consumes " + this.getWatt() + " watts\n");
        }
    }
}
